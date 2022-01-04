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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAv = New System.Windows.Forms.Label()
        Me.lblsmallest = New System.Windows.Forms.Label()
        Me.lblnumber = New System.Windows.Forms.Label()
        Me.lbllargest = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(402, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 31)
        Me.TextBox1.TabIndex = 0
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(253, 100)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(91, 25)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Enter age "
        '
        'lblAv
        '
        Me.lblAv.AutoSize = True
        Me.lblAv.Location = New System.Drawing.Point(253, 263)
        Me.lblAv.Name = "lblAv"
        Me.lblAv.Size = New System.Drawing.Size(63, 25)
        Me.lblAv.TabIndex = 2
        Me.lblAv.Text = "Label1"
        '
        'lblsmallest
        '
        Me.lblsmallest.AutoSize = True
        Me.lblsmallest.Location = New System.Drawing.Point(263, 336)
        Me.lblsmallest.Name = "lblsmallest"
        Me.lblsmallest.Size = New System.Drawing.Size(63, 25)
        Me.lblsmallest.TabIndex = 3
        Me.lblsmallest.Text = "Label1"
        '
        'lblnumber
        '
        Me.lblnumber.AutoSize = True
        Me.lblnumber.Location = New System.Drawing.Point(522, 263)
        Me.lblnumber.Name = "lblnumber"
        Me.lblnumber.Size = New System.Drawing.Size(63, 25)
        Me.lblnumber.TabIndex = 4
        Me.lblnumber.Text = "Label1"
        '
        'lbllargest
        '
        Me.lbllargest.AutoSize = True
        Me.lbllargest.Location = New System.Drawing.Point(522, 336)
        Me.lbllargest.Name = "lbllargest"
        Me.lbllargest.Size = New System.Drawing.Size(63, 25)
        Me.lbllargest.TabIndex = 5
        Me.lbllargest.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbllargest)
        Me.Controls.Add(Me.lblnumber)
        Me.Controls.Add(Me.lblsmallest)
        Me.Controls.Add(Me.lblAv)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAv As Label
    Friend WithEvents lblsmallest As Label
    Friend WithEvents lblnumber As Label
    Friend WithEvents lbllargest As Label
    Friend WithEvents Button1 As Button
End Class
