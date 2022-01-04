<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtboxf = New System.Windows.Forms.TextBox()
        Me.TextBoxl = New System.Windows.Forms.TextBox()
        Me.lblf = New System.Windows.Forms.Label()
        Me.lbll = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxf
        '
        Me.txtboxf.Location = New System.Drawing.Point(297, 153)
        Me.txtboxf.Name = "txtboxf"
        Me.txtboxf.Size = New System.Drawing.Size(310, 31)
        Me.txtboxf.TabIndex = 0
        '
        'TextBoxl
        '
        Me.TextBoxl.Location = New System.Drawing.Point(297, 247)
        Me.TextBoxl.Name = "TextBoxl"
        Me.TextBoxl.Size = New System.Drawing.Size(310, 31)
        Me.TextBoxl.TabIndex = 1
        '
        'lblf
        '
        Me.lblf.AutoSize = True
        Me.lblf.Location = New System.Drawing.Point(174, 142)
        Me.lblf.Name = "lblf"
        Me.lblf.Size = New System.Drawing.Size(89, 25)
        Me.lblf.TabIndex = 2
        Me.lblf.Text = "Firstname"
        '
        'lbll
        '
        Me.lbll.AutoSize = True
        Me.lbll.Location = New System.Drawing.Point(191, 247)
        Me.lbll.Name = "lbll"
        Me.lbll.Size = New System.Drawing.Size(87, 25)
        Me.lbll.TabIndex = 3
        Me.lbll.Text = "Lastname"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbll)
        Me.Controls.Add(Me.lblf)
        Me.Controls.Add(Me.TextBoxl)
        Me.Controls.Add(Me.txtboxf)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxf As TextBox
    Friend WithEvents TextBoxl As TextBox
    Friend WithEvents lblf As Label
    Friend WithEvents lbll As Label
End Class
