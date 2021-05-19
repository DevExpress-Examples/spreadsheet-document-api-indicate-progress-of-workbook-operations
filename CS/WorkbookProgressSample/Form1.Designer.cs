
namespace WorkbookProgressSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.btnRunCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading a workbook...";
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoad.Location = new System.Drawing.Point(22, 41);
            this.progressBarLoad.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(380, 19);
            this.progressBarLoad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exporting to PDF...";
            // 
            // progressBarExport
            // 
            this.progressBarExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarExport.Location = new System.Drawing.Point(22, 109);
            this.progressBarExport.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(380, 19);
            this.progressBarExport.TabIndex = 3;
            // 
            // btnRunCancel
            // 
            this.btnRunCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCancel.Location = new System.Drawing.Point(314, 162);
            this.btnRunCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunCancel.Name = "btnRunCancel";
            this.btnRunCancel.Size = new System.Drawing.Size(89, 28);
            this.btnRunCancel.TabIndex = 4;
            this.btnRunCancel.Text = "Run";
            this.btnRunCancel.UseVisualStyleBackColor = true;
            this.btnRunCancel.Click += new System.EventHandler(this.RunCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 222);
            this.Controls.Add(this.btnRunCancel);
            this.Controls.Add(this.progressBarExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.Button btnRunCancel;
    }
}

