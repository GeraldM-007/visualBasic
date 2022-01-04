<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.cstmnamelbl = New System.Windows.Forms.Label()
        Me.totallbl = New System.Windows.Forms.Label()
        Me.namedspllbl = New System.Windows.Forms.Label()
        Me.costdsplylbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(364, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOM KITCHENS"
        '
        'cstmnamelbl
        '
        Me.cstmnamelbl.AutoSize = True
        Me.cstmnamelbl.Location = New System.Drawing.Point(364, 234)
        Me.cstmnamelbl.Name = "cstmnamelbl"
        Me.cstmnamelbl.Size = New System.Drawing.Size(149, 25)
        Me.cstmnamelbl.TabIndex = 1
        Me.cstmnamelbl.Text = "Customers Name"
        '
        'totallbl
        '
        Me.totallbl.AutoSize = True
        Me.totallbl.Location = New System.Drawing.Point(364, 362)
        Me.totallbl.Name = "totallbl"
        Me.totallbl.Size = New System.Drawing.Size(190, 25)
        Me.totallbl.TabIndex = 2
        Me.totallbl.Text = "Total Cost Of Purchase"
        '
        'namedspllbl
        '
        Me.namedspllbl.AutoSize = True
        Me.namedspllbl.Location = New System.Drawing.Point(364, 285)
        Me.namedspllbl.Name = "namedspllbl"
        Me.namedspllbl.Size = New System.Drawing.Size(0, 25)
        Me.namedspllbl.TabIndex = 3
        '
        'costdsplylbl
        '
        Me.costdsplylbl.AutoSize = True
        Me.costdsplylbl.Location = New System.Drawing.Point(364, 434)
        Me.costdsplylbl.Name = "costdsplylbl"
        Me.costdsplylbl.Size = New System.Drawing.Size(0, 25)
        Me.costdsplylbl.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(364, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 82)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PREVIOUS PAGE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 745)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.costdsplylbl)
        Me.Controls.Add(Me.namedspllbl)
        Me.Controls.Add(Me.totallbl)
        Me.Controls.Add(Me.cstmnamelbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "RECEIPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cstmnamelbl As Label
    Friend WithEvents totallbl As Label
    Friend WithEvents namedspllbl As Label
    Friend WithEvents costdsplylbl As Label
    Friend WithEvents Button1 As Button
End Class
