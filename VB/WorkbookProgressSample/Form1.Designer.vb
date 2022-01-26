Namespace WorkbookProgressSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkbookProgressSample.Form1))
            Me.label1 = New System.Windows.Forms.Label()
            Me.progressBarLoad = New System.Windows.Forms.ProgressBar()
            Me.label2 = New System.Windows.Forms.Label()
            Me.progressBarExport = New System.Windows.Forms.ProgressBar()
            Me.btnRunCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(20, 16)
            Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(113, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Loading a workbook..."
            ' 
            ' progressBarLoad
            ' 
            Me.progressBarLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.progressBarLoad.Location = New System.Drawing.Point(22, 41)
            Me.progressBarLoad.Margin = New System.Windows.Forms.Padding(2)
            Me.progressBarLoad.Name = "progressBarLoad"
            Me.progressBarLoad.Size = New System.Drawing.Size(380, 19)
            Me.progressBarLoad.TabIndex = 1
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(20, 84)
            Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Exporting to PDF..."
            ' 
            ' progressBarExport
            ' 
            Me.progressBarExport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.progressBarExport.Location = New System.Drawing.Point(22, 109)
            Me.progressBarExport.Margin = New System.Windows.Forms.Padding(2)
            Me.progressBarExport.Name = "progressBarExport"
            Me.progressBarExport.Size = New System.Drawing.Size(380, 19)
            Me.progressBarExport.TabIndex = 3
            ' 
            ' btnRunCancel
            ' 
            Me.btnRunCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnRunCancel.Location = New System.Drawing.Point(314, 162)
            Me.btnRunCancel.Margin = New System.Windows.Forms.Padding(2)
            Me.btnRunCancel.Name = "btnRunCancel"
            Me.btnRunCancel.Size = New System.Drawing.Size(89, 28)
            Me.btnRunCancel.TabIndex = 4
            Me.btnRunCancel.Text = "Run"
            Me.btnRunCancel.UseVisualStyleBackColor = True
            AddHandler Me.btnRunCancel.Click, New System.EventHandler(AddressOf Me.RunCancel_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(430, 222)
            Me.Controls.Add(Me.btnRunCancel)
            Me.Controls.Add(Me.progressBarExport)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.progressBarLoad)
            Me.Controls.Add(Me.label1)
            Me.Icon = CType((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Progress Dialog"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.Form1_FormClosing)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private label1 As System.Windows.Forms.Label

        Private progressBarLoad As System.Windows.Forms.ProgressBar

        Private label2 As System.Windows.Forms.Label

        Private progressBarExport As System.Windows.Forms.ProgressBar

        Private btnRunCancel As System.Windows.Forms.Button
    End Class
End Namespace
