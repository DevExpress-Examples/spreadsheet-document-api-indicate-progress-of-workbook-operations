using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace WorkbookProgressSample {
    public partial class Form1 : Form {
        CancellationTokenSource cancellationSource;

        public Form1() {
            InitializeComponent();
        }

        private async void RunCancel_Click(object sender, EventArgs e) {
            if (cancellationSource != null) {
                cancellationSource.Cancel();
            }
            else {
                progressBarLoad.Value = 0;
                progressBarExport.Value = 0;
                btnRunCancel.Text = "Cancel";
                cancellationSource = new CancellationTokenSource();
                try {
                    using (Workbook workbook = new Workbook()) {
                        await workbook.LoadDocumentAsync("Document.xlsx",
                            cancellationSource.Token,
                            new Progress<int>((progress) => {
                                progressBarLoad.Value = progress;
                                progressBarLoad.Refresh();
                            }));
                        await workbook.ExportToPdfAsync("Result.pdf",
                            cancellationSource.Token,
                            new Progress<int>((progress) => {
                                progressBarExport.Value = progress;
                                progressBarExport.Refresh();
                            }));
                    }
                }
                catch (OperationCanceledException) {
                    progressBarLoad.Value = 0;
                    progressBarExport.Value = 0;
                }
                finally {
                    cancellationSource.Dispose();
                    cancellationSource = null;
                    btnRunCancel.Text = "Run";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            cancellationSource?.Cancel();
        }
    }
}
