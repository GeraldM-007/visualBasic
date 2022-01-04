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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Buttonclick = New System.Windows.Forms.Button()
        Me.TextBoxg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(208, 156)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "empty"
        '
        'Buttonclick
        '
        Me.Buttonclick.Location = New System.Drawing.Point(168, 204)
        Me.Buttonclick.Name = "Buttonclick"
        Me.Buttonclick.Size = New System.Drawing.Size(138, 96)
        Me.Buttonclick.TabIndex = 1
        Me.Buttonclick.Text = "SHOW "
        Me.Buttonclick.UseVisualStyleBackColor = True
        '
        'TextBoxg
        '
        Me.TextBoxg.Location = New System.Drawing.Point(144, 52)
        Me.TextBoxg.Multiline = True
        Me.TextBoxg.Name = "TextBoxg"
        Me.TextBoxg.Size = New System.Drawing.Size(233, 86)
        Me.TextBoxg.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxg)
        Me.Controls.Add(Me.Buttonclick)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Buttonclick As Button
    Friend WithEvents TextBoxg As Windows.Forms.TextBox
End Class
