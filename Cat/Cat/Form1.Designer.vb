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
        Me.titlelbl = New System.Windows.Forms.Label()
        Me.ntrnlbl = New System.Windows.Forms.Label()
        Me.Adultslbl = New System.Windows.Forms.Label()
        Me.childrenlbl = New System.Windows.Forms.Label()
        Me.adslbl = New System.Windows.Forms.Label()
        Me.totallbl = New System.Windows.Forms.Label()
        Me.childrencbo = New System.Windows.Forms.ComboBox()
        Me.nutritioncbo = New System.Windows.Forms.ComboBox()
        Me.adultscbo = New System.Windows.Forms.ComboBox()
        Me.additioncbo = New System.Windows.Forms.ComboBox()
        Me.purchasebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.titlelbl.ForeColor = System.Drawing.Color.Red
        Me.titlelbl.Location = New System.Drawing.Point(407, 74)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(286, 38)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "GOURMET  EXPRESS"
        '
        'ntrnlbl
        '
        Me.ntrnlbl.AutoSize = True
        Me.ntrnlbl.Location = New System.Drawing.Point(123, 399)
        Me.ntrnlbl.Name = "ntrnlbl"
        Me.ntrnlbl.Size = New System.Drawing.Size(242, 25)
        Me.ntrnlbl.TabIndex = 1
        Me.ntrnlbl.Text = "Choose Type Of Nutrion Plan"
        '
        'Adultslbl
        '
        Me.Adultslbl.AutoSize = True
        Me.Adultslbl.Location = New System.Drawing.Point(123, 296)
        Me.Adultslbl.Name = "Adultslbl"
        Me.Adultslbl.Size = New System.Drawing.Size(302, 25)
        Me.Adultslbl.TabIndex = 2
        Me.Adultslbl.Text = "Choose Number Of Adults To be fed"
        '
        'childrenlbl
        '
        Me.childrenlbl.AutoSize = True
        Me.childrenlbl.Location = New System.Drawing.Point(123, 203)
        Me.childrenlbl.Name = "childrenlbl"
        Me.childrenlbl.Size = New System.Drawing.Size(319, 25)
        Me.childrenlbl.TabIndex = 3
        Me.childrenlbl.Text = "Choose Number Of Children To be Fed"
        '
        'adslbl
        '
        Me.adslbl.AutoSize = True
        Me.adslbl.Location = New System.Drawing.Point(123, 521)
        Me.adslbl.Name = "adslbl"
        Me.adslbl.Size = New System.Drawing.Size(255, 25)
        Me.adslbl.TabIndex = 4
        Me.adslbl.Text = "Choose Any Addition Services "
        '
        'totallbl
        '
        Me.totallbl.AutoSize = True
        Me.totallbl.Location = New System.Drawing.Point(178, 684)
        Me.totallbl.Name = "totallbl"
        Me.totallbl.Size = New System.Drawing.Size(0, 25)
        Me.totallbl.TabIndex = 5
        '
        'childrencbo
        '
        Me.childrencbo.FormattingEnabled = True
        Me.childrencbo.Items.AddRange(New Object() {" 1", " 2", " 3", " 4"})
        Me.childrencbo.Location = New System.Drawing.Point(497, 203)
        Me.childrencbo.Name = "childrencbo"
        Me.childrencbo.Size = New System.Drawing.Size(406, 33)
        Me.childrencbo.TabIndex = 6
        '
        'nutritioncbo
        '
        Me.nutritioncbo.FormattingEnabled = True
        Me.nutritioncbo.Items.AddRange(New Object() {" Regular healthy eating plan", " Weightlifter eating plan", " Endurance trainer eating plan", " Glute free healthy eating plan", " Gluten free weightlifter eating plan", " Gluten free endurance trainer eating plan", " Vegetarian healthy eating plan", " Vegetarian weightlifter eating plan", " Vegetarian endurance trainer eating plan"})
        Me.nutritioncbo.Location = New System.Drawing.Point(497, 399)
        Me.nutritioncbo.Name = "nutritioncbo"
        Me.nutritioncbo.Size = New System.Drawing.Size(413, 33)
        Me.nutritioncbo.TabIndex = 7
        '
        'adultscbo
        '
        Me.adultscbo.FormattingEnabled = True
        Me.adultscbo.Items.AddRange(New Object() {" 1", " 2", " 3", " 4"})
        Me.adultscbo.Location = New System.Drawing.Point(497, 296)
        Me.adultscbo.Name = "adultscbo"
        Me.adultscbo.Size = New System.Drawing.Size(413, 33)
        Me.adultscbo.TabIndex = 9
        '
        'additioncbo
        '
        Me.additioncbo.FormattingEnabled = True
        Me.additioncbo.Items.AddRange(New Object() {"Muscle building fitness plan", " Endurance building fitness plan", " Balanced fitness plan"})
        Me.additioncbo.Location = New System.Drawing.Point(497, 502)
        Me.additioncbo.Name = "additioncbo"
        Me.additioncbo.Size = New System.Drawing.Size(413, 33)
        Me.additioncbo.TabIndex = 10
        '
        'purchasebtn
        '
        Me.purchasebtn.Location = New System.Drawing.Point(604, 665)
        Me.purchasebtn.Name = "purchasebtn"
        Me.purchasebtn.Size = New System.Drawing.Size(172, 62)
        Me.purchasebtn.TabIndex = 11
        Me.purchasebtn.Text = "PURCHASE"
        Me.purchasebtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 815)
        Me.Controls.Add(Me.purchasebtn)
        Me.Controls.Add(Me.additioncbo)
        Me.Controls.Add(Me.adultscbo)
        Me.Controls.Add(Me.nutritioncbo)
        Me.Controls.Add(Me.childrencbo)
        Me.Controls.Add(Me.totallbl)
        Me.Controls.Add(Me.adslbl)
        Me.Controls.Add(Me.childrenlbl)
        Me.Controls.Add(Me.Adultslbl)
        Me.Controls.Add(Me.ntrnlbl)
        Me.Controls.Add(Me.titlelbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents ntrnlbl As Label
    Friend WithEvents Adultslbl As Label
    Friend WithEvents childrenlbl As Label
    Friend WithEvents adslbl As Label
    Friend WithEvents totallbl As Label
    Friend WithEvents childrencbo As ComboBox
    Friend WithEvents nutritioncbo As ComboBox
    Friend WithEvents adultscbo As ComboBox
    Friend WithEvents additioncbo As ComboBox
    Friend WithEvents purchasebtn As Button
End Class
