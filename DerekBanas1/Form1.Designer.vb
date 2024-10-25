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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.txtAddValue1 = New System.Windows.Forms.TextBox()
        Me.txtAddValue2 = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswear = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(56, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 22)
        Me.txtName.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(59, 109)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(195, 34)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(501, 109)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(281, 109)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(195, 34)
        Me.btnMessage.TabIndex = 5
        Me.btnMessage.Text = "&Message"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'txtAddValue1
        '
        Me.txtAddValue1.Location = New System.Drawing.Point(59, 205)
        Me.txtAddValue1.Name = "txtAddValue1"
        Me.txtAddValue1.Size = New System.Drawing.Size(69, 22)
        Me.txtAddValue1.TabIndex = 6
        '
        'txtAddValue2
        '
        Me.txtAddValue2.Location = New System.Drawing.Point(210, 205)
        Me.txtAddValue2.Name = "txtAddValue2"
        Me.txtAddValue2.Size = New System.Drawing.Size(69, 22)
        Me.txtAddValue2.TabIndex = 7
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(143, 201)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(43, 30)
        Me.btnSum.TabIndex = 8
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(299, 205)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(14, 16)
        Me.lblAddEqual.TabIndex = 9
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswear
        '
        Me.txtSumAnswear.Location = New System.Drawing.Point(331, 202)
        Me.txtSumAnswear.Name = "txtSumAnswear"
        Me.txtSumAnswear.Size = New System.Drawing.Size(69, 28)
        Me.txtSumAnswear.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSumAnswear)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtAddValue2)
        Me.Controls.Add(Me.txtAddValue1)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents txtAddValue1 As TextBox
    Friend WithEvents txtAddValue2 As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswear As TextBox
End Class
