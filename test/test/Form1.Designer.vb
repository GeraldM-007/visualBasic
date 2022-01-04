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
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.LabelTest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonTest
        '
        Me.ButtonTest.Location = New System.Drawing.Point(283, 288)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(112, 34)
        Me.ButtonTest.TabIndex = 0
        Me.ButtonTest.Text = "Click Here!"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'LabelTest
        '
        Me.LabelTest.AutoSize = True
        Me.LabelTest.Location = New System.Drawing.Point(283, 117)
        Me.LabelTest.Name = "LabelTest"
        Me.LabelTest.Size = New System.Drawing.Size(230, 25)
        Me.LabelTest.TabIndex = 1
        Me.LabelTest.Text = "The display will appear here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 450)
        Me.Controls.Add(Me.LabelTest)
        Me.Controls.Add(Me.ButtonTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonTest As Button
    Friend WithEvents LabelTest As Label
End Class
