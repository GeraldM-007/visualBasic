<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.titlelbl4 = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.psndetailsbtn = New System.Windows.Forms.Button()
        Me.prvsbtn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelbl4
        '
        Me.titlelbl4.AutoSize = True
        Me.titlelbl4.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titlelbl4.ForeColor = System.Drawing.Color.DarkRed
        Me.titlelbl4.Location = New System.Drawing.Point(528, 66)
        Me.titlelbl4.Name = "titlelbl4"
        Me.titlelbl4.Size = New System.Drawing.Size(546, 34)
        Me.titlelbl4.TabIndex = 0
        Me.titlelbl4.Text = "CUSTOM KITCHENS"
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Location = New System.Drawing.Point(364, 280)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(146, 25)
        Me.pricelbl.TabIndex = 1
        Me.pricelbl.Text = "The Total price is:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "price should be displayed here and it should not be editable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'psndetailsbtn
        '
        Me.psndetailsbtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.psndetailsbtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.psndetailsbtn.Location = New System.Drawing.Point(1096, 665)
        Me.psndetailsbtn.Name = "psndetailsbtn"
        Me.psndetailsbtn.Size = New System.Drawing.Size(407, 79)
        Me.psndetailsbtn.TabIndex = 3
        Me.psndetailsbtn.Text = " Enter Personal details"
        Me.psndetailsbtn.UseVisualStyleBackColor = True
        '
        'prvsbtn3
        '
        Me.prvsbtn3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prvsbtn3.ForeColor = System.Drawing.Color.DarkGreen
        Me.prvsbtn3.Location = New System.Drawing.Point(127, 665)
        Me.prvsbtn3.Name = "prvsbtn3"
        Me.prvsbtn3.Size = New System.Drawing.Size(189, 79)
        Me.prvsbtn3.TabIndex = 4
        Me.prvsbtn3.Text = "PREVIOUS PAGE "
        Me.prvsbtn3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1691, 931)
        Me.Controls.Add(Me.prvsbtn3)
        Me.Controls.Add(Me.psndetailsbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pricelbl)
        Me.Controls.Add(Me.titlelbl4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form4"
        Me.Text = "PRICE DISPLAY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl4 As Label
    Friend WithEvents pricelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents psndetailsbtn As Button
    Friend WithEvents prvsbtn3 As Button
End Class
