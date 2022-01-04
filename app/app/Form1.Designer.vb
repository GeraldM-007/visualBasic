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
        Me.clickbutton = New System.Windows.Forms.Button()
        Me.titlelabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clickbutton
        '
        Me.clickbutton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clickbutton.Location = New System.Drawing.Point(272, 433)
        Me.clickbutton.Name = "clickbutton"
        Me.clickbutton.Size = New System.Drawing.Size(547, 77)
        Me.clickbutton.TabIndex = 0
        Me.clickbutton.Text = "Click Here To Enter Specifications"
        Me.clickbutton.UseVisualStyleBackColor = True
        '
        'titlelabel1
        '
        Me.titlelabel1.AutoSize = True
        Me.titlelabel1.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titlelabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.titlelabel1.Location = New System.Drawing.Point(154, 89)
        Me.titlelabel1.Name = "titlelabel1"
        Me.titlelabel1.Size = New System.Drawing.Size(942, 34)
        Me.titlelabel1.TabIndex = 1
        Me.titlelabel1.Text = "WELCOME  TO  CUSTOM  KITCHENS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 671)
        Me.Controls.Add(Me.titlelabel1)
        Me.Controls.Add(Me.clickbutton)
        Me.Name = "Form1"
        Me.Text = "HOME  PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clickbutton As Button
    Friend WithEvents titlelabel1 As Label
End Class
