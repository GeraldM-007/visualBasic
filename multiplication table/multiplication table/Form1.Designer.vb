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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb4 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(248, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MULTIPLICATION TABLE"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb2.Location = New System.Drawing.Point(100, 121)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(136, 30)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = "Enter factor"
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb3.Location = New System.Drawing.Point(100, 168)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(243, 30)
        Me.lb3.TabIndex = 2
        Me.lb3.Text = "Enter the first number"
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb4.Location = New System.Drawing.Point(100, 226)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(202, 30)
        Me.lb4.TabIndex = 3
        Me.lb4.Text = "Enter last Number"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(396, 120)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(150, 31)
        Me.tb1.TabIndex = 4
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(396, 169)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(150, 31)
        Me.tb2.TabIndex = 5
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(396, 225)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(150, 31)
        Me.tb3.TabIndex = 6
        '
        'lb1
        '
        Me.lb1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb1.FormattingEnabled = True
        Me.lb1.ItemHeight = 30
        Me.lb1.Location = New System.Drawing.Point(577, 95)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(196, 304)
        Me.lb1.TabIndex = 7
        '
        'bt1
        '
        Me.bt1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bt1.Location = New System.Drawing.Point(128, 301)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(112, 34)
        Me.bt1.TabIndex = 8
        Me.bt1.Text = "START"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(396, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "REFRESH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bt3.Location = New System.Drawing.Point(259, 424)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(112, 34)
        Me.bt3.TabIndex = 10
        Me.bt3.Text = "EXIT"
        Me.bt3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 648)
        Me.Controls.Add(Me.bt3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.lb4)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lb4 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents lb1 As ListBox
    Friend WithEvents bt1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt3 As Button
End Class
