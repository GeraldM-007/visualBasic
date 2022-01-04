<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Txt1
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
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Txb1 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(63, 125)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(173, 25)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "Number of Students"
        '
        'Txb1
        '
        Me.Txb1.Location = New System.Drawing.Point(260, 125)
        Me.Txb1.Name = "Txb1"
        Me.Txb1.Size = New System.Drawing.Size(150, 31)
        Me.Txb1.TabIndex = 2
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(228, 243)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(112, 34)
        Me.Btn1.TabIndex = 3
        Me.Btn1.Text = "Get room"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txb1)
        Me.Controls.Add(Me.Lbl2)
        Me.Name = "Txt1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Txb1 As TextBox
    Friend WithEvents Btn1 As Button
End Class
