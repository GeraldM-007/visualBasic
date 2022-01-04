<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class specificationsform
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
        Me.labelwidth = New System.Windows.Forms.Label()
        Me.budgetlabel = New System.Windows.Forms.Label()
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
        Me.titlelabel2.Location = New System.Drawing.Point(291, 63)
        Me.titlelabel2.Name = "titlelabel2"
        Me.titlelabel2.Size = New System.Drawing.Size(562, 34)
        Me.titlelabel2.TabIndex = 0
        Me.titlelabel2.Text = "CUSTOM   KITCHENS"
        '
        'lengthlabel
        '
        Me.lengthlabel.AutoSize = True
        Me.lengthlabel.Location = New System.Drawing.Point(264, 207)
        Me.lengthlabel.Name = "lengthlabel"
        Me.lengthlabel.Size = New System.Drawing.Size(111, 25)
        Me.lengthlabel.TabIndex = 1
        Me.lengthlabel.Text = "Enter Length"
        '
        'labelwidth
        '
        Me.labelwidth.AutoSize = True
        Me.labelwidth.Location = New System.Drawing.Point(264, 277)
        Me.labelwidth.Name = "labelwidth"
        Me.labelwidth.Size = New System.Drawing.Size(105, 25)
        Me.labelwidth.TabIndex = 2
        Me.labelwidth.Text = "Enter Width"
        '
        'budgetlabel
        '
        Me.budgetlabel.AutoSize = True
        Me.budgetlabel.Location = New System.Drawing.Point(264, 347)
        Me.budgetlabel.Name = "budgetlabel"
        Me.budgetlabel.Size = New System.Drawing.Size(192, 25)
        Me.budgetlabel.TabIndex = 3
        Me.budgetlabel.Text = "Enter Maximun Budget"
        '
        'lengthtxb
        '
        Me.lengthtxb.Location = New System.Drawing.Point(381, 207)
        Me.lengthtxb.Name = "lengthtxb"
        Me.lengthtxb.Size = New System.Drawing.Size(264, 31)
        Me.lengthtxb.TabIndex = 4
        '
        'widthtxb
        '
        Me.widthtxb.Location = New System.Drawing.Point(381, 271)
        Me.widthtxb.Name = "widthtxb"
        Me.widthtxb.Size = New System.Drawing.Size(264, 31)
        Me.widthtxb.TabIndex = 5
        '
        'budgettxb
        '
        Me.budgettxb.Location = New System.Drawing.Point(462, 347)
        Me.budgettxb.Name = "budgettxb"
        Me.budgettxb.Size = New System.Drawing.Size(261, 31)
        Me.budgettxb.TabIndex = 6
        '
        'nextbtn1
        '
        Me.nextbtn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nextbtn1.Location = New System.Drawing.Point(732, 502)
        Me.nextbtn1.Name = "nextbtn1"
        Me.nextbtn1.Size = New System.Drawing.Size(281, 54)
        Me.nextbtn1.TabIndex = 7
        Me.nextbtn1.Text = "NEXT"
        Me.nextbtn1.UseVisualStyleBackColor = True
        '
        'prvspagebtn1
        '
        Me.prvspagebtn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.prvspagebtn1.Location = New System.Drawing.Point(291, 502)
        Me.prvspagebtn1.Name = "prvspagebtn1"
        Me.prvspagebtn1.Size = New System.Drawing.Size(281, 54)
        Me.prvspagebtn1.TabIndex = 8
        Me.prvspagebtn1.Text = "PREVIOUS PAGE"
        Me.prvspagebtn1.UseVisualStyleBackColor = True
        '
        'specificationsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 643)
        Me.Controls.Add(Me.prvspagebtn1)
        Me.Controls.Add(Me.nextbtn1)
        Me.Controls.Add(Me.budgettxb)
        Me.Controls.Add(Me.widthtxb)
        Me.Controls.Add(Me.lengthtxb)
        Me.Controls.Add(Me.budgetlabel)
        Me.Controls.Add(Me.labelwidth)
        Me.Controls.Add(Me.lengthlabel)
        Me.Controls.Add(Me.titlelabel2)
        Me.Name = "specificationsform"
        Me.Text = "SPECIFICATIONS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelabel2 As Label
    Friend WithEvents lengthlabel As Label
    Friend WithEvents labelwidth As Label
    Friend WithEvents budgetlabel As Label
    Friend WithEvents lengthtxb As TextBox
    Friend WithEvents widthtxb As TextBox
    Friend WithEvents budgettxb As TextBox
    Friend WithEvents nextbtn1 As Button
    Friend WithEvents prvspagebtn1 As Button
End Class
