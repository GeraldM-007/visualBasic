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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txbAge = New System.Windows.Forms.TextBox()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.lblAv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(231, 183)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(94, 25)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Enter  Age"
        '
        'txbAge
        '
        Me.txbAge.Location = New System.Drawing.Point(350, 183)
        Me.txbAge.Name = "txbAge"
        Me.txbAge.Size = New System.Drawing.Size(261, 31)
        Me.txbAge.TabIndex = 1
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(426, 275)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(112, 34)
        Me.Btnadd.TabIndex = 2
        Me.Btnadd.Text = "Add Age"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'lbldisplay
        '
        Me.lbldisplay.AutoSize = True
        Me.lbldisplay.Location = New System.Drawing.Point(231, 343)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(236, 25)
        Me.lbldisplay.TabIndex = 3
        Me.lbldisplay.Text = "Displays the number of age "
        '
        'lblAv
        '
        Me.lblAv.AutoSize = True
        Me.lblAv.Location = New System.Drawing.Point(231, 403)
        Me.lblAv.Name = "lblAv"
        Me.lblAv.Size = New System.Drawing.Size(145, 25)
        Me.lblAv.TabIndex = 4
        Me.lblAv.Text = "Displays average"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.lblAv)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.txbAge)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents txbAge As TextBox
    Friend WithEvents Btnadd As Button
    Friend WithEvents lbldisplay As Label
    Friend WithEvents lblAv As Label
End Class
