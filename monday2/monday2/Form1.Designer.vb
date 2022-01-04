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
        Me.buttonclicked = New System.Windows.Forms.Button()
        Me.Buttonforclicking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonclicked
        '
        Me.buttonclicked.Location = New System.Drawing.Point(355, 257)
        Me.buttonclicked.Name = "buttonclicked"
        Me.buttonclicked.Size = New System.Drawing.Size(112, 34)
        Me.buttonclicked.TabIndex = 0
        Me.buttonclicked.Text = "Click here!"
        Me.buttonclicked.UseVisualStyleBackColor = True
        '
        'Buttonforclicking
        '
        Me.Buttonforclicking.Location = New System.Drawing.Point(390, 133)
        Me.Buttonforclicking.Name = "Buttonforclicking"
        Me.Buttonforclicking.Size = New System.Drawing.Size(112, 34)
        Me.Buttonforclicking.TabIndex = 1
        Me.Buttonforclicking.Text = "click me!"
        Me.Buttonforclicking.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonforclicking)
        Me.Controls.Add(Me.buttonclicked)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonclicked As Button
    Friend WithEvents Buttonforclicking As Button
End Class
