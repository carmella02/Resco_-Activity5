<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtfirstnum = New TextBox()
        lblfisrtnum = New Label()
        txtsecondnum = New TextBox()
        lblsecondnum = New Label()
        lblresult = New Label()
        btndivide = New Button()
        SuspendLayout()
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(81, 87)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 0
        ' 
        ' lblfisrtnum
        ' 
        lblfisrtnum.AutoSize = True
        lblfisrtnum.Location = New Point(96, 69)
        lblfisrtnum.Name = "lblfisrtnum"
        lblfisrtnum.Size = New Size(76, 15)
        lblfisrtnum.TabIndex = 1
        lblfisrtnum.Text = "First Number"
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(81, 153)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(100, 23)
        txtsecondnum.TabIndex = 0
        ' 
        ' lblsecondnum
        ' 
        lblsecondnum.AutoSize = True
        lblsecondnum.Location = New Point(88, 135)
        lblsecondnum.Name = "lblsecondnum"
        lblsecondnum.Size = New Size(93, 15)
        lblsecondnum.TabIndex = 1
        lblsecondnum.Text = "Secong Number"
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(109, 277)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(36, 15)
        lblresult.TabIndex = 2
        lblresult.Text = "result"
        ' 
        ' btndivide
        ' 
        btndivide.Location = New Point(96, 211)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(75, 23)
        btndivide.TabIndex = 3
        btndivide.Text = "Divide"
        btndivide.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btndivide)
        Controls.Add(lblresult)
        Controls.Add(lblsecondnum)
        Controls.Add(txtsecondnum)
        Controls.Add(lblfisrtnum)
        Controls.Add(txtfirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents lblfisrtnum As Label
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents lblsecondnum As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents btndivide As Button
End Class
