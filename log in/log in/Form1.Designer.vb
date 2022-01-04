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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txb1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(292, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Log in Details"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(135, 160)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(104, 25)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "USERNAME"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(135, 218)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(108, 25)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "PASSWORD"
        '
        'txb1
        '
        Me.txb1.Location = New System.Drawing.Point(292, 154)
        Me.txb1.Name = "txb1"
        Me.txb1.Size = New System.Drawing.Size(150, 31)
        Me.txb1.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(292, 218)
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2.Size = New System.Drawing.Size(150, 31)
        Me.txt2.TabIndex = 4
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(292, 316)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(112, 34)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txb1)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txb1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btnlogin As Button
End Class
