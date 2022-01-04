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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Txb1 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(138, 88)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(172, 25)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Number of students"
        '
        'Txb1
        '
        Me.Txb1.Location = New System.Drawing.Point(359, 88)
        Me.Txb1.Name = "Txb1"
        Me.Txb1.Size = New System.Drawing.Size(150, 31)
        Me.Txb1.TabIndex = 1
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(292, 190)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(112, 34)
        Me.Btn1.TabIndex = 2
        Me.Btn1.Text = "Get room"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txb1)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Txb1 As TextBox
    Friend WithEvents Btn1 As Button
End Class
