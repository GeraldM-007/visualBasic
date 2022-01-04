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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Adlbl = New System.Windows.Forms.Label()
        Me.hslbl = New System.Windows.Forms.Label()
        Me.srtlbl = New System.Windows.Forms.Label()
        Me.lbltwn = New System.Windows.Forms.Label()
        Me.lblpostcode = New System.Windows.Forms.Label()
        Me.hsntxb = New System.Windows.Forms.TextBox()
        Me.srtntxb = New System.Windows.Forms.TextBox()
        Me.twntxb = New System.Windows.Forms.TextBox()
        Me.pstctxb = New System.Windows.Forms.TextBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(262, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GOURMET EXPRESS"
        '
        'Adlbl
        '
        Me.Adlbl.AutoSize = True
        Me.Adlbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Adlbl.Location = New System.Drawing.Point(214, 142)
        Me.Adlbl.Name = "Adlbl"
        Me.Adlbl.Size = New System.Drawing.Size(258, 32)
        Me.Adlbl.TabIndex = 1
        Me.Adlbl.Text = "Enter Address Details"
        '
        'hslbl
        '
        Me.hslbl.AutoSize = True
        Me.hslbl.Location = New System.Drawing.Point(230, 230)
        Me.hslbl.Name = "hslbl"
        Me.hslbl.Size = New System.Drawing.Size(133, 25)
        Me.hslbl.TabIndex = 2
        Me.hslbl.Text = "House Number"
        '
        'srtlbl
        '
        Me.srtlbl.AutoSize = True
        Me.srtlbl.Location = New System.Drawing.Point(230, 306)
        Me.srtlbl.Name = "srtlbl"
        Me.srtlbl.Size = New System.Drawing.Size(109, 25)
        Me.srtlbl.TabIndex = 3
        Me.srtlbl.Text = "Street Name"
        '
        'lbltwn
        '
        Me.lbltwn.AutoSize = True
        Me.lbltwn.Location = New System.Drawing.Point(230, 395)
        Me.lbltwn.Name = "lbltwn"
        Me.lbltwn.Size = New System.Drawing.Size(58, 25)
        Me.lbltwn.TabIndex = 4
        Me.lbltwn.Text = "Town "
        '
        'lblpostcode
        '
        Me.lblpostcode.AutoSize = True
        Me.lblpostcode.Location = New System.Drawing.Point(230, 483)
        Me.lblpostcode.Name = "lblpostcode"
        Me.lblpostcode.Size = New System.Drawing.Size(88, 25)
        Me.lblpostcode.TabIndex = 5
        Me.lblpostcode.Text = "PostCode"
        '
        'hsntxb
        '
        Me.hsntxb.Location = New System.Drawing.Point(409, 230)
        Me.hsntxb.Name = "hsntxb"
        Me.hsntxb.Size = New System.Drawing.Size(215, 31)
        Me.hsntxb.TabIndex = 6
        '
        'srtntxb
        '
        Me.srtntxb.Location = New System.Drawing.Point(409, 306)
        Me.srtntxb.Name = "srtntxb"
        Me.srtntxb.Size = New System.Drawing.Size(215, 31)
        Me.srtntxb.TabIndex = 7
        '
        'twntxb
        '
        Me.twntxb.Location = New System.Drawing.Point(409, 389)
        Me.twntxb.Name = "twntxb"
        Me.twntxb.Size = New System.Drawing.Size(215, 31)
        Me.twntxb.TabIndex = 8
        '
        'pstctxb
        '
        Me.pstctxb.Location = New System.Drawing.Point(409, 483)
        Me.pstctxb.Name = "pstctxb"
        Me.pstctxb.Size = New System.Drawing.Size(215, 31)
        Me.pstctxb.TabIndex = 9
        '
        'backbtn
        '
        Me.backbtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backbtn.Location = New System.Drawing.Point(433, 587)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(142, 52)
        Me.backbtn.TabIndex = 10
        Me.backbtn.Text = "BACK"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(433, 541)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 25)
        Me.lblDisplay.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 668)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.pstctxb)
        Me.Controls.Add(Me.twntxb)
        Me.Controls.Add(Me.srtntxb)
        Me.Controls.Add(Me.hsntxb)
        Me.Controls.Add(Me.lblpostcode)
        Me.Controls.Add(Me.lbltwn)
        Me.Controls.Add(Me.srtlbl)
        Me.Controls.Add(Me.hslbl)
        Me.Controls.Add(Me.Adlbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Adlbl As Label
    Friend WithEvents hslbl As Label
    Friend WithEvents srtlbl As Label
    Friend WithEvents lbltwn As Label
    Friend WithEvents lblpostcode As Label
    Friend WithEvents hsntxb As TextBox
    Friend WithEvents srtntxb As TextBox
    Friend WithEvents twntxb As TextBox
    Friend WithEvents pstctxb As TextBox
    Friend WithEvents backbtn As Button
    Friend WithEvents lblDisplay As Label
End Class
