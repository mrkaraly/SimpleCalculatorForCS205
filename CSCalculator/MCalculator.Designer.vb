<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCalculator
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
        Me.C_Display = New System.Windows.Forms.TextBox()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnDivi = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.bntEqual = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'C_Display
        '
        Me.C_Display.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_Display.Location = New System.Drawing.Point(13, 13)
        Me.C_Display.Multiline = True
        Me.C_Display.Name = "C_Display"
        Me.C_Display.Size = New System.Drawing.Size(654, 237)
        Me.C_Display.TabIndex = 0
        '
        'btnSeven
        '
        Me.btnSeven.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(13, 256)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(133, 119)
        Me.btnSeven.TabIndex = 1
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnEight.Location = New System.Drawing.Point(152, 256)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(133, 119)
        Me.btnEight.TabIndex = 2
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnNine.Location = New System.Drawing.Point(291, 256)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(133, 119)
        Me.btnNine.TabIndex = 3
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnSix.Location = New System.Drawing.Point(291, 381)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(133, 119)
        Me.btnSix.TabIndex = 6
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnFive.Location = New System.Drawing.Point(152, 381)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(133, 119)
        Me.btnFive.TabIndex = 5
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnFour.Location = New System.Drawing.Point(13, 381)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(133, 119)
        Me.btnFour.TabIndex = 4
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnThree.Location = New System.Drawing.Point(290, 506)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(133, 119)
        Me.btnThree.TabIndex = 9
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnTwo.Location = New System.Drawing.Point(151, 506)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(133, 119)
        Me.btnTwo.TabIndex = 8
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnOne.Location = New System.Drawing.Point(12, 506)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(133, 119)
        Me.btnOne.TabIndex = 7
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(481, 453)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(77, 66)
        Me.btnMinus.TabIndex = 10
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(564, 381)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(77, 66)
        Me.btnPlus.TabIndex = 11
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnDivi
        '
        Me.btnDivi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivi.Location = New System.Drawing.Point(564, 525)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(77, 66)
        Me.btnDivi.TabIndex = 12
        Me.btnDivi.Text = "/"
        Me.btnDivi.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.Location = New System.Drawing.Point(564, 453)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(77, 66)
        Me.btnMult.TabIndex = 13
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(481, 525)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(77, 66)
        Me.btnMod.TabIndex = 14
        Me.btnMod.Text = "%"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'bntEqual
        '
        Me.bntEqual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntEqual.Location = New System.Drawing.Point(481, 597)
        Me.bntEqual.Name = "bntEqual"
        Me.bntEqual.Size = New System.Drawing.Size(160, 66)
        Me.bntEqual.TabIndex = 15
        Me.bntEqual.Text = "="
        Me.bntEqual.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnDot.Location = New System.Drawing.Point(290, 631)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(133, 119)
        Me.btnDot.TabIndex = 17
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.btnZero.Location = New System.Drawing.Point(13, 631)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(271, 119)
        Me.btnZero.TabIndex = 16
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(481, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 119)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Backspace"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(481, 381)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(77, 66)
        Me.Clear.TabIndex = 19
        Me.Clear.Text = "C"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'MCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 765)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.bntEqual)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnDivi)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.C_Display)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MCalculator"
        Me.Text = "MCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C_Display As TextBox
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnDivi As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents bntEqual As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Clear As Button
End Class
