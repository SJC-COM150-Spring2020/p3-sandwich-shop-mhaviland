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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkCofee = New System.Windows.Forms.CheckBox()
        Me.chkTea = New System.Windows.Forms.CheckBox()
        Me.chkHotChoc = New System.Windows.Forms.CheckBox()
        Me.chkMilk = New System.Windows.Forms.CheckBox()
        Me.chkJuice = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkVeggies = New System.Windows.Forms.CheckBox()
        Me.radScrambled = New System.Windows.Forms.RadioButton()
        Me.radOverEasy = New System.Windows.Forms.RadioButton()
        Me.radSunny = New System.Windows.Forms.RadioButton()
        Me.radPoached = New System.Windows.Forms.RadioButton()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.grpEggs = New System.Windows.Forms.GroupBox()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grpDrinks.SuspendLayout()
        Me.grpEggs.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DarkRed
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSubmit.Location = New System.Drawing.Point(1050, 224)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(158, 81)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit Order Here!"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'chkCofee
        '
        Me.chkCofee.AutoSize = True
        Me.chkCofee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCofee.Location = New System.Drawing.Point(13, 204)
        Me.chkCofee.Name = "chkCofee"
        Me.chkCofee.Size = New System.Drawing.Size(94, 29)
        Me.chkCofee.TabIndex = 3
        Me.chkCofee.Text = "Coffee"
        Me.chkCofee.UseVisualStyleBackColor = True
        '
        'chkTea
        '
        Me.chkTea.AutoSize = True
        Me.chkTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTea.Location = New System.Drawing.Point(13, 170)
        Me.chkTea.Name = "chkTea"
        Me.chkTea.Size = New System.Drawing.Size(68, 29)
        Me.chkTea.TabIndex = 4
        Me.chkTea.Text = "Tea"
        Me.chkTea.UseVisualStyleBackColor = True
        '
        'chkHotChoc
        '
        Me.chkHotChoc.AutoSize = True
        Me.chkHotChoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHotChoc.Location = New System.Drawing.Point(13, 135)
        Me.chkHotChoc.Name = "chkHotChoc"
        Me.chkHotChoc.Size = New System.Drawing.Size(167, 29)
        Me.chkHotChoc.TabIndex = 5
        Me.chkHotChoc.Text = "Hot Chocolate"
        Me.chkHotChoc.UseVisualStyleBackColor = True
        '
        'chkMilk
        '
        Me.chkMilk.AutoSize = True
        Me.chkMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMilk.Location = New System.Drawing.Point(13, 65)
        Me.chkMilk.Name = "chkMilk"
        Me.chkMilk.Size = New System.Drawing.Size(70, 29)
        Me.chkMilk.TabIndex = 6
        Me.chkMilk.Text = "Milk"
        Me.chkMilk.UseVisualStyleBackColor = True
        '
        'chkJuice
        '
        Me.chkJuice.AutoSize = True
        Me.chkJuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJuice.Location = New System.Drawing.Point(13, 100)
        Me.chkJuice.Name = "chkJuice"
        Me.chkJuice.Size = New System.Drawing.Size(82, 29)
        Me.chkJuice.TabIndex = 7
        Me.chkJuice.Text = "Juice"
        Me.chkJuice.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.Location = New System.Drawing.Point(6, 116)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(105, 29)
        Me.chkCheese.TabIndex = 8
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.Location = New System.Drawing.Point(6, 71)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(75, 29)
        Me.chkHam.TabIndex = 9
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBacon.Location = New System.Drawing.Point(203, 72)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(92, 29)
        Me.chkBacon.TabIndex = 10
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSausage.Location = New System.Drawing.Point(203, 116)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(116, 29)
        Me.chkSausage.TabIndex = 11
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkVeggies
        '
        Me.chkVeggies.AutoSize = True
        Me.chkVeggies.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVeggies.Location = New System.Drawing.Point(6, 156)
        Me.chkVeggies.Name = "chkVeggies"
        Me.chkVeggies.Size = New System.Drawing.Size(109, 29)
        Me.chkVeggies.TabIndex = 12
        Me.chkVeggies.Text = "Veggies"
        Me.chkVeggies.UseVisualStyleBackColor = True
        '
        'radScrambled
        '
        Me.radScrambled.AutoSize = True
        Me.radScrambled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radScrambled.Location = New System.Drawing.Point(17, 71)
        Me.radScrambled.Name = "radScrambled"
        Me.radScrambled.Size = New System.Drawing.Size(132, 29)
        Me.radScrambled.TabIndex = 13
        Me.radScrambled.TabStop = True
        Me.radScrambled.Text = "Scrambled"
        Me.radScrambled.UseVisualStyleBackColor = True
        '
        'radOverEasy
        '
        Me.radOverEasy.AutoSize = True
        Me.radOverEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOverEasy.Location = New System.Drawing.Point(17, 141)
        Me.radOverEasy.Name = "radOverEasy"
        Me.radOverEasy.Size = New System.Drawing.Size(130, 29)
        Me.radOverEasy.TabIndex = 14
        Me.radOverEasy.TabStop = True
        Me.radOverEasy.Text = "Over Easy"
        Me.radOverEasy.UseVisualStyleBackColor = True
        '
        'radSunny
        '
        Me.radSunny.AutoSize = True
        Me.radSunny.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSunny.Location = New System.Drawing.Point(17, 106)
        Me.radSunny.Name = "radSunny"
        Me.radSunny.Size = New System.Drawing.Size(173, 29)
        Me.radSunny.TabIndex = 15
        Me.radSunny.TabStop = True
        Me.radSunny.Text = "Sunny Side Up"
        Me.radSunny.UseVisualStyleBackColor = True
        '
        'radPoached
        '
        Me.radPoached.AutoSize = True
        Me.radPoached.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPoached.Location = New System.Drawing.Point(17, 176)
        Me.radPoached.Name = "radPoached"
        Me.radPoached.Size = New System.Drawing.Size(115, 29)
        Me.radPoached.TabIndex = 16
        Me.radPoached.TabStop = True
        Me.radPoached.Text = "Poached"
        Me.radPoached.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.BackColor = System.Drawing.Color.Salmon
        Me.grpDrinks.Controls.Add(Me.chkMilk)
        Me.grpDrinks.Controls.Add(Me.chkJuice)
        Me.grpDrinks.Controls.Add(Me.chkHotChoc)
        Me.grpDrinks.Controls.Add(Me.chkTea)
        Me.grpDrinks.Controls.Add(Me.chkCofee)
        Me.grpDrinks.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDrinks.Location = New System.Drawing.Point(77, 92)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(248, 286)
        Me.grpDrinks.TabIndex = 20
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Drinks"
        '
        'grpEggs
        '
        Me.grpEggs.BackColor = System.Drawing.Color.Violet
        Me.grpEggs.Controls.Add(Me.radScrambled)
        Me.grpEggs.Controls.Add(Me.radOverEasy)
        Me.grpEggs.Controls.Add(Me.radPoached)
        Me.grpEggs.Controls.Add(Me.radSunny)
        Me.grpEggs.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEggs.Location = New System.Drawing.Point(352, 92)
        Me.grpEggs.Name = "grpEggs"
        Me.grpEggs.Size = New System.Drawing.Size(280, 286)
        Me.grpEggs.TabIndex = 21
        Me.grpEggs.TabStop = False
        Me.grpEggs.Text = "Eggs"
        '
        'grpExtras
        '
        Me.grpExtras.BackColor = System.Drawing.Color.DarkTurquoise
        Me.grpExtras.Controls.Add(Me.chkHam)
        Me.grpExtras.Controls.Add(Me.chkBacon)
        Me.grpExtras.Controls.Add(Me.chkCheese)
        Me.grpExtras.Controls.Add(Me.chkVeggies)
        Me.grpExtras.Controls.Add(Me.chkSausage)
        Me.grpExtras.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtras.Location = New System.Drawing.Point(672, 92)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(336, 286)
        Me.grpExtras.TabIndex = 22
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Chartreuse
        Me.btnClear.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(926, 443)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 46)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1073, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 43)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 28
        Me.lstOut.Location = New System.Drawing.Point(429, 401)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(391, 228)
        Me.lstOut.TabIndex = 25
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkRed
        Me.lblWelcome.Location = New System.Drawing.Point(323, 42)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(536, 45)
        Me.lblWelcome.TabIndex = 26
        Me.lblWelcome.Text = "Welcome to the Egg Sandwich Shop!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1014, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 410)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 152)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1227, 652)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpEggs)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpEggs.ResumeLayout(False)
        Me.grpEggs.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents chkCofee As CheckBox
    Friend WithEvents chkTea As CheckBox
    Friend WithEvents chkHotChoc As CheckBox
    Friend WithEvents chkMilk As CheckBox
    Friend WithEvents chkJuice As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkVeggies As CheckBox
    Friend WithEvents radScrambled As RadioButton
    Friend WithEvents radOverEasy As RadioButton
    Friend WithEvents radSunny As RadioButton
    Friend WithEvents radPoached As RadioButton
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents grpEggs As GroupBox
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
