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
        Me.titlelabel2 = New System.Windows.Forms.Label()
        Me.lengthlabel = New System.Windows.Forms.Label()
        Me.widthlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lengthtxb = New System.Windows.Forms.TextBox()
        Me.widthtxb = New System.Windows.Forms.TextBox()
        Me.budgettxb = New System.Windows.Forms.TextBox()
        Me.nextbtn1 = New System.Windows.Forms.Button()
        Me.prvspagebtn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelabel2
        '
        Me.titlelabel2.AutoSize = True
        Me.titlelabel2.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titlelabel2.ForeColor = System.Drawing.Color.DarkRed
        Me.titlelabel2.Location = New System.Drawing.Point(277, 89)
        Me.titlelabel2.Name = "titlelabel2"
        Me.titlelabel2.Size = New System.Drawing.Size(554, 34)
        Me.titlelabel2.TabIndex = 0
        Me.titlelabel2.Text = "CUSTOM  KITCHENS"
        '
        'lengthlabel
        '
        Me.lengthlabel.AutoSize = True
        Me.lengthlabel.Location = New System.Drawing.Point(277, 260)
        Me.lengthlabel.Name = "lengthlabel"
        Me.lengthlabel.Size = New System.Drawing.Size(115, 25)
        Me.lengthlabel.TabIndex = 1
        Me.lengthlabel.Text = "Enter Length:"
        '
        'widthlabel
        '
        Me.widthlabel.AutoSize = True
        Me.widthlabel.Location = New System.Drawing.Point(277, 353)
        Me.widthlabel.Name = "widthlabel"
        Me.widthlabel.Size = New System.Drawing.Size(109, 25)
        Me.widthlabel.TabIndex = 2
        Me.widthlabel.Text = "Enter Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter Maximum Budget:"
        '
        'lengthtxb
        '
        Me.lengthtxb.Location = New System.Drawing.Point(398, 260)
        Me.lengthtxb.Name = "lengthtxb"
        Me.lengthtxb.Size = New System.Drawing.Size(330, 31)
        Me.lengthtxb.TabIndex = 4
        '
        'widthtxb
        '
        Me.widthtxb.Location = New System.Drawing.Point(398, 350)
        Me.widthtxb.Name = "widthtxb"
        Me.widthtxb.Size = New System.Drawing.Size(330, 31)
        Me.widthtxb.TabIndex = 5
        '
        'budgettxb
        '
        Me.budgettxb.Location = New System.Drawing.Point(485, 449)
        Me.budgettxb.Name = "budgettxb"
        Me.budgettxb.Size = New System.Drawing.Size(330, 31)
        Me.budgettxb.TabIndex = 6
        '
        'nextbtn1
        '
        Me.nextbtn1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nextbtn1.Location = New System.Drawing.Point(828, 593)
        Me.nextbtn1.Name = "nextbtn1"
        Me.nextbtn1.Size = New System.Drawing.Size(203, 62)
        Me.nextbtn1.TabIndex = 7
        Me.nextbtn1.Text = "NEXT"
        Me.nextbtn1.UseVisualStyleBackColor = True
        '
        'prvspagebtn1
        '
        Me.prvspagebtn1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prvspagebtn1.Location = New System.Drawing.Point(362, 593)
        Me.prvspagebtn1.Name = "prvspagebtn1"
        Me.prvspagebtn1.Size = New System.Drawing.Size(203, 62)
        Me.prvspagebtn1.TabIndex = 8
        Me.prvspagebtn1.Text = "PREVOIUS  PAGE"
        Me.prvspagebtn1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1189, 738)
        Me.Controls.Add(Me.prvspagebtn1)
        Me.Controls.Add(Me.nextbtn1)
        Me.Controls.Add(Me.budgettxb)
        Me.Controls.Add(Me.widthtxb)
        Me.Controls.Add(Me.lengthtxb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.widthlabel)
        Me.Controls.Add(Me.lengthlabel)
        Me.Controls.Add(Me.titlelabel2)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelabel2 As Label
    Friend WithEvents lengthlabel As Label
    Friend WithEvents widthlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lengthtxb As TextBox
    Friend WithEvents widthtxb As TextBox
    Friend WithEvents budgettxb As TextBox
    Friend WithEvents nextbtn1 As Button
    Friend WithEvents prvspagebtn1 As Button
End Class
