<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
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
        Me.titlelabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelabel1
        '
        Me.titlelabel1.AutoSize = True
        Me.titlelabel1.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titlelabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.titlelabel1.Location = New System.Drawing.Point(105, 53)
        Me.titlelabel1.Name = "titlelabel1"
        Me.titlelabel1.Size = New System.Drawing.Size(918, 34)
        Me.titlelabel1.TabIndex = 0
        Me.titlelabel1.Text = "WELCOME TO KITCHEN CUSTOMS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(280, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(550, 72)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click Here To Enter Specifications"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 668)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.titlelabel1)
        Me.Name = "homepage"
        Me.Text = "HOME PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelabel1 As Label
    Friend WithEvents Button1 As Button
End Class
