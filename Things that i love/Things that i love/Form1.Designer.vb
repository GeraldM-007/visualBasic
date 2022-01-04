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
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(105, 106)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(77, 29)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "food"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(105, 161)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(72, 29)
        Me.chk2.TabIndex = 1
        Me.chk2.Text = "Cars"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(105, 210)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(92, 29)
        Me.chk4.TabIndex = 3
        Me.chk4.Text = "Novels"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(105, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Things that I love"
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(258, 447)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(112, 34)
        Me.bt1.TabIndex = 8
        Me.bt1.Text = "OK"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 523)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk4)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt1 As Button
End Class
