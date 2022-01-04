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
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cboHDD = New System.Windows.Forms.ComboBox()
        Me.cbomem = New System.Windows.Forms.ComboBox()
        Me.cboOS = New System.Windows.Forms.ComboBox()
        Me.cboGraphics = New System.Windows.Forms.ComboBox()
        Me.cbomonitor = New System.Windows.Forms.ComboBox()
        Me.Lblcpu = New System.Windows.Forms.Label()
        Me.Lblmem = New System.Windows.Forms.Label()
        Me.LblHDD = New System.Windows.Forms.Label()
        Me.LblOS = New System.Windows.Forms.Label()
        Me.LblGraphics = New System.Windows.Forms.Label()
        Me.Lblmonitor = New System.Windows.Forms.Label()
        Me.lblperipherals = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'cmb1
        '
        Me.cmb1.AutoCompleteCustomSource.AddRange(New String() {"Intel Pentium G4 - 400", "Intel i3 6100", "Intel core i5 4430", "Intel i7 4790", "AMD A6 7400", "AMD FX 8530"})
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Intel Pentium G4400", "Intel i3 6100", "Intel core i5 4430"})
        Me.cmb1.Location = New System.Drawing.Point(510, 56)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(278, 33)
        Me.cmb1.TabIndex = 0
        '
        'cboHDD
        '
        Me.cboHDD.AutoCompleteCustomSource.AddRange(New String() {"256 HDD", "500 HDD", "1 TB", "256 SSD", "500 SSD", "1 TB SSD "})
        Me.cboHDD.FormattingEnabled = True
        Me.cboHDD.Items.AddRange(New Object() {"1 TB", "2 TB", "4 TB", "6 TB", "8 TB"})
        Me.cboHDD.Location = New System.Drawing.Point(512, 181)
        Me.cboHDD.Name = "cboHDD"
        Me.cboHDD.Size = New System.Drawing.Size(276, 33)
        Me.cboHDD.TabIndex = 1
        '
        'cbomem
        '
        Me.cbomem.AutoCompleteCustomSource.AddRange(New String() {"4 GB", "8 GB", "16 GB"})
        Me.cbomem.FormattingEnabled = True
        Me.cbomem.Items.AddRange(New Object() {"2GB DDR3 1333MHz", "4 GB RAM DDR4 2000MHz", "4 GB RAM DDR4 3000MHz", "8 GB RAM DDR4 3400MHz"})
        Me.cbomem.Location = New System.Drawing.Point(512, 118)
        Me.cbomem.Name = "cbomem"
        Me.cbomem.Size = New System.Drawing.Size(276, 33)
        Me.cbomem.TabIndex = 2
        '
        'cboOS
        '
        Me.cboOS.AutoCompleteCustomSource.AddRange(New String() {"Windows OS", "linux OS ", "IOS"})
        Me.cboOS.FormattingEnabled = True
        Me.cboOS.Items.AddRange(New Object() {"None", "Microsoft Windows 10", "Microsoft Windows 8.1", "Microsoft Windows 7", "Ubuntu 16.04 LTS"})
        Me.cboOS.Location = New System.Drawing.Point(512, 253)
        Me.cboOS.Name = "cboOS"
        Me.cboOS.Size = New System.Drawing.Size(276, 33)
        Me.cboOS.TabIndex = 3
        '
        'cboGraphics
        '
        Me.cboGraphics.AutoCompleteCustomSource.AddRange(New String() {"NVIDIA Graphics ", "AMD Ryzen Graphics", "Intel HD Graphics"})
        Me.cboGraphics.FormattingEnabled = True
        Me.cboGraphics.Items.AddRange(New Object() {"Saphire HD 6450", "Gigabyte Radeon RX 460", "NVIDIA Quadro K620"})
        Me.cboGraphics.Location = New System.Drawing.Point(512, 330)
        Me.cboGraphics.Name = "cboGraphics"
        Me.cboGraphics.Size = New System.Drawing.Size(276, 33)
        Me.cboGraphics.TabIndex = 4
        '
        'cbomonitor
        '
        Me.cbomonitor.AutoCompleteCustomSource.AddRange(New String() {"MAC monitor", "Dell monitor", "HP monitor", "LG monitor"})
        Me.cbomonitor.FormattingEnabled = True
        Me.cbomonitor.Items.AddRange(New Object() {"17'' 1080HP", "19'' 1080HP", "23'' Full HD", "24'' Full HD", "27'' Full HD"})
        Me.cbomonitor.Location = New System.Drawing.Point(512, 424)
        Me.cbomonitor.Name = "cbomonitor"
        Me.cbomonitor.Size = New System.Drawing.Size(276, 33)
        Me.cbomonitor.TabIndex = 5
        '
        'Lblcpu
        '
        Me.Lblcpu.AutoSize = True
        Me.Lblcpu.Location = New System.Drawing.Point(407, 64)
        Me.Lblcpu.Name = "Lblcpu"
        Me.Lblcpu.Size = New System.Drawing.Size(45, 25)
        Me.Lblcpu.TabIndex = 6
        Me.Lblcpu.Text = "CPU"
        '
        'Lblmem
        '
        Me.Lblmem.AutoSize = True
        Me.Lblmem.Location = New System.Drawing.Point(407, 118)
        Me.Lblmem.Name = "Lblmem"
        Me.Lblmem.Size = New System.Drawing.Size(79, 25)
        Me.Lblmem.TabIndex = 7
        Me.Lblmem.Text = "Memory"
        '
        'LblHDD
        '
        Me.LblHDD.AutoSize = True
        Me.LblHDD.Location = New System.Drawing.Point(407, 189)
        Me.LblHDD.Name = "LblHDD"
        Me.LblHDD.Size = New System.Drawing.Size(83, 25)
        Me.LblHDD.TabIndex = 8
        Me.LblHDD.Text = "Harddisk"
        '
        'LblOS
        '
        Me.LblOS.AutoSize = True
        Me.LblOS.Location = New System.Drawing.Point(407, 261)
        Me.LblOS.Name = "LblOS"
        Me.LblOS.Size = New System.Drawing.Size(36, 25)
        Me.LblOS.TabIndex = 9
        Me.LblOS.Text = "OS"
        '
        'LblGraphics
        '
        Me.LblGraphics.AutoSize = True
        Me.LblGraphics.Location = New System.Drawing.Point(407, 338)
        Me.LblGraphics.Name = "LblGraphics"
        Me.LblGraphics.Size = New System.Drawing.Size(80, 25)
        Me.LblGraphics.TabIndex = 10
        Me.LblGraphics.Text = "Graphics"
        '
        'Lblmonitor
        '
        Me.Lblmonitor.AutoSize = True
        Me.Lblmonitor.Location = New System.Drawing.Point(407, 432)
        Me.Lblmonitor.Name = "Lblmonitor"
        Me.Lblmonitor.Size = New System.Drawing.Size(76, 25)
        Me.Lblmonitor.TabIndex = 11
        Me.Lblmonitor.Text = "Monitor"
        '
        'lblperipherals
        '
        Me.lblperipherals.AutoSize = True
        Me.lblperipherals.Location = New System.Drawing.Point(407, 500)
        Me.lblperipherals.Name = "lblperipherals"
        Me.lblperipherals.Size = New System.Drawing.Size(97, 25)
        Me.lblperipherals.TabIndex = 12
        Me.lblperipherals.Text = "Peripherals"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 678)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label8"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(32, 148)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox6.TabIndex = 14
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(351, 713)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(112, 34)
        Me.BtnSubmit.TabIndex = 15
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Portable External HDD 1TB ", "DVD Drive", "Inkjet Printer", "Scanner ", "Card Reader"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(512, 500)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(276, 144)
        Me.CheckedListBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1771, 759)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblperipherals)
        Me.Controls.Add(Me.Lblmonitor)
        Me.Controls.Add(Me.LblGraphics)
        Me.Controls.Add(Me.LblOS)
        Me.Controls.Add(Me.LblHDD)
        Me.Controls.Add(Me.Lblmem)
        Me.Controls.Add(Me.Lblcpu)
        Me.Controls.Add(Me.cbomonitor)
        Me.Controls.Add(Me.cboGraphics)
        Me.Controls.Add(Me.cboOS)
        Me.Controls.Add(Me.cbomem)
        Me.Controls.Add(Me.cboHDD)
        Me.Controls.Add(Me.cmb1)
        Me.Name = "Form1"
        Me.Text = "Shonki Computers Inc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cboHDD As ComboBox
    Friend WithEvents cbomem As ComboBox
    Friend WithEvents cboOS As ComboBox
    Friend WithEvents cboGraphics As ComboBox
    Friend WithEvents cbomonitor As ComboBox
    Friend WithEvents Lblcpu As Label
    Friend WithEvents Lblmem As Label
    Friend WithEvents LblHDD As Label
    Friend WithEvents LblOS As Label
    Friend WithEvents LblGraphics As Label
    Friend WithEvents Lblmonitor As Label
    Friend WithEvents lblperipherals As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
