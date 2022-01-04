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
        Me.btnloggin = New System.Windows.Forms.Button()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnloggin
        '
        Me.btnloggin.Location = New System.Drawing.Point(142, 332)
        Me.btnloggin.Name = "btnloggin"
        Me.btnloggin.Size = New System.Drawing.Size(223, 62)
        Me.btnloggin.TabIndex = 0
        Me.btnloggin.Text = "Submit"
        Me.btnloggin.UseVisualStyleBackColor = True
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(142, 91)
        Me.tb.Multiline = True
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(244, 52)
        Me.tb.TabIndex = 2
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(142, 227)
        Me.tb2.Multiline = True
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(244, 46)
        Me.tb2.TabIndex = 3
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(142, 45)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(104, 25)
        Me.lb1.TabIndex = 4
        Me.lb1.Text = "Enter Name"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Location = New System.Drawing.Point(142, 180)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(145, 25)
        Me.lb2.TabIndex = 5
        Me.lb2.Text = "Enter ID Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.btnloggin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnloggin As Button
    Friend WithEvents tb As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
End Class
