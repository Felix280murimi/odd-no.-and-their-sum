<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnSumDisp = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.ListBoxOddNumbers = New System.Windows.Forms.ListBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(155, 305)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 23)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnSumDisp
        '
        Me.btnSumDisp.Location = New System.Drawing.Point(231, 344)
        Me.btnSumDisp.Name = "btnSumDisp"
        Me.btnSumDisp.Size = New System.Drawing.Size(256, 23)
        Me.btnSumDisp.TabIndex = 0
        Me.btnSumDisp.Text = "Display Odd Numbers And Their Sum"
        Me.btnSumDisp.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(495, 305)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'ListBoxOddNumbers
        '
        Me.ListBoxOddNumbers.FormattingEnabled = True
        Me.ListBoxOddNumbers.ItemHeight = 16
        Me.ListBoxOddNumbers.Location = New System.Drawing.Point(145, 12)
        Me.ListBoxOddNumbers.Name = "ListBoxOddNumbers"
        Me.ListBoxOddNumbers.Size = New System.Drawing.Size(456, 260)
        Me.ListBoxOddNumbers.TabIndex = 1
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(328, 255)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 17)
        Me.lblResults.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.ListBoxOddNumbers)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSumDisp)
        Me.Controls.Add(Me.btnSum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSum As Button
    Friend WithEvents btnSumDisp As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents ListBoxOddNumbers As ListBox
    Friend WithEvents lblResults As Label
End Class
