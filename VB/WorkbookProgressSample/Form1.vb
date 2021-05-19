Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace WorkbookProgressSample
	Partial Public Class Form1
		Inherits Form

		Private cancellationSource As CancellationTokenSource

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Async Sub RunCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRunCancel.Click
			If Not Me.btnRunCancel.IsHandleCreated Then Return

			If cancellationSource IsNot Nothing Then
				cancellationSource.Cancel()
			Else
				progressBarLoad.Value = 0
				progressBarExport.Value = 0
				btnRunCancel.Text = "Cancel"
				cancellationSource = New CancellationTokenSource()
				Try
					Using workbook As New Workbook()
						Await workbook.LoadDocumentAsync("Document.xlsx", cancellationSource.Token, New Progress(Of Integer)(Sub(progress)
							progressBarLoad.Value = progress
							progressBarLoad.Refresh()
						End Sub))
						Await workbook.ExportToPdfAsync("Result.pdf", cancellationSource.Token, New Progress(Of Integer)(Sub(progress)
							progressBarExport.Value = progress
							progressBarExport.Refresh()
						End Sub))
					End Using
				Catch e1 As OperationCanceledException
					progressBarLoad.Value = 0
					progressBarExport.Value = 0
				Finally
					cancellationSource.Dispose()
					cancellationSource = Nothing
					btnRunCancel.Text = "Run"
				End Try
			End If
		End Sub

		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
			cancellationSource?.Cancel()
		End Sub
	End Class
End Namespace
