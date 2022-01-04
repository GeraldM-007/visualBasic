<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepageform
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
        Me.titlelabel = New System.Windows.Forms.Label()
        Me.clickbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelabel
        '
        Me.titlelabel.AutoSize = True
        Me.titlelabel.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.titlelabel.Location = New System.Drawing.Point(103, 64)
        Me.titlelabel.Name = "titlelabel"
        Me.titlelabel.Size = New System.Drawing.Size(944, 34)
        Me.titlelabel.TabIndex = 0
        Me.titlelabel.Text = "WELCOME TO CUSTOM KITCHENS"
        '
        'clickbutton
        '
        Me.clickbutton.Location = New System.Drawing.Point(299, 364)
        Me.clickbutton.Name = "clickbutton"
        Me.clickbutton.Size = New System.Drawing.Size(422, 86)
        Me.clickbutton.TabIndex = 1
        Me.clickbutton.Text = "Click To Enter Specifications"
        Me.clickbutton.UseVisualStyleBackColor = True
        '
        'Homepageform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 540)
        Me.Controls.Add(Me.clickbutton)
        Me.Controls.Add(Me.titlelabel)
        Me.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Homepageform"
        Me.Text = "HOME PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelabel As Label
    Friend WithEvents clickbutton As Button
End Class
