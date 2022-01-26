<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/368902367/21.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T999600)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WorkbookProgressSample/Form1.cs) (VB: [Form1.vb](./VB/WorkbookProgressSample/Form1.vb))

<!-- default file list end -->

# Spreadsheet Document API - Indicate Progress of Workbook Operations

This example demonstrates how to create a simple progress dialog that indicates the progress of load and PDF export operations. 

![Progress Dialog for Workbook Operations](./images/workbook-progress-dialog.png)

The [Workbook.LoadDocumentAsync](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.LoadDocumentAsync.overloads) and [Workbook.ExportToPdfAsync](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.ExportToPdfAsync.overloads) methods accept a [Progress&lt;T&gt;](https://docs.microsoft.com/en-US/dotnet/api/system.progress-1) instance as a parameter to report progress information. Pass a [CancellationToken](https://docs.microsoft.com/en-US/dotnet/api/system.threading.cancellationtoken) object to these methods to cancel operations when a user clicks **Cancel** or closes the form.
