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
        Me.Buttongreetings = New System.Windows.Forms.Button()
        Me.buttonvariable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Buttongreetings
        '
        Me.Buttongreetings.Location = New System.Drawing.Point(240, 260)
        Me.Buttongreetings.Name = "Buttongreetings"
        Me.Buttongreetings.Size = New System.Drawing.Size(112, 34)
        Me.Buttongreetings.TabIndex = 0
        Me.Buttongreetings.Text = "Click here!"
        Me.Buttongreetings.UseVisualStyleBackColor = True
        '
        'buttonvariable
        '
        Me.buttonvariable.Location = New System.Drawing.Point(534, 260)
        Me.buttonvariable.Name = "buttonvariable"
        Me.buttonvariable.Size = New System.Drawing.Size(112, 34)
        Me.buttonvariable.TabIndex = 2
        Me.buttonvariable.Text = "Variables"
        Me.buttonvariable.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonvariable)
        Me.Controls.Add(Me.Buttongreetings)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Buttongreetings As Button
    Friend WithEvents buttonvariable As Button
End Class
