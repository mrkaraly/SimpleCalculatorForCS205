Public Class MCalculator
    Public FNumber As Integer
    Public SNumber As Integer
    Public OP As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If C_Display.Text Is "" Then
            MsgBox("There's nothing to Backspace it", MsgBoxStyle.Information, "Go Back")
        Else
            C_Display.Text = C_Display.Text.Remove(C_Display.Text.Length - 1)
        End If
    End Sub
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "0"
            FNumber = 0
        ElseIf C_Display.Text IsNot "" And C_Display.Text Is "0" And OP Is Nothing Then
            C_Display.Text = "0"
            FNumber = 0
        ElseIf C_Display.Text IsNot "" And C_Display.Text IsNot "0" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "0"
            FNumber = Convert.ToInt32(FNumber.ToString + "0")
            MsgBox(SNumber)
        ElseIf C_Display.Text IsNot "" And C_Display.Text IsNot "0" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "0"
            SNumber = Convert.ToInt32(SNumber.ToString + "0")
            MsgBox(SNumber)
        Else
            C_Display.Text = C_Display.Text + " " + "0"
            SNumber = 0
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "1"
            FNumber = 1
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "1"
            FNumber = Convert.ToInt32(FNumber.ToString + "1")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "1"
            SNumber = Convert.ToInt32(SNumber.ToString + "1")
        Else
            C_Display.Text = C_Display.Text + " " + "1"
            SNumber = 1

        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "2"
            FNumber = 2
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "2"
            FNumber = Convert.ToInt32(FNumber.ToString + "2")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "2"
            SNumber = Convert.ToInt32(SNumber.ToString + "2")
        Else
            C_Display.Text = C_Display.Text + " " + "2"
            SNumber = 2
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "3"
            FNumber = 3
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "3"
            FNumber = Convert.ToInt32(FNumber.ToString + "3")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "3"
            SNumber = Convert.ToInt32(SNumber.ToString + "3")
        Else
            C_Display.Text = C_Display.Text + " " + "3"
            SNumber = 3
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "4"
            FNumber = 4
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "4"
            FNumber = Convert.ToInt32(FNumber.ToString + "4")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "4"
            SNumber = Convert.ToInt32(SNumber.ToString + "4")
        Else
            C_Display.Text = C_Display.Text + " " + "4"
            SNumber = 4
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "5"
            FNumber = 5
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "5"
            FNumber = Convert.ToInt32(FNumber.ToString + "5")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "5"
            SNumber = Convert.ToInt32(SNumber.ToString + "5")
        Else
            C_Display.Text = C_Display.Text + " " + "5"
            SNumber = 5
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "6"
            FNumber = 6
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "6"
            FNumber = Convert.ToInt32(FNumber.ToString + "6")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "6"
            SNumber = Convert.ToInt32(SNumber.ToString + "6")
        Else
            C_Display.Text = C_Display.Text + " " + "6"
            SNumber = 6
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "7"
            FNumber = 7
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "7"
            FNumber = Convert.ToInt32(FNumber.ToString + "7")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "7"
            SNumber = Convert.ToInt32(SNumber.ToString + "7")
        Else
            C_Display.Text = C_Display.Text + " " + "7"
            SNumber = 7
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "8"
            FNumber = 8
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "8"
            FNumber = Convert.ToInt32(FNumber.ToString + "8")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "8"
            SNumber = Convert.ToInt32(SNumber.ToString + "8")
        Else
            C_Display.Text = C_Display.Text + " " + "8"
            SNumber = 8
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If C_Display.Text Is "" Then
            C_Display.Text = "9"
            FNumber = 9
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + "9"
            FNumber = Convert.ToInt32(FNumber.ToString + "9")
        ElseIf C_Display.Text IsNot "" And OP IsNot Nothing Then
            C_Display.Text = C_Display.Text + "9"
            SNumber = Convert.ToInt32(SNumber.ToString + "9")
        Else
            C_Display.Text = C_Display.Text + " " + "9"
            SNumber = 9
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If C_Display.Text Is "" Then
            MsgBox("Choose A Number First", MsgBoxStyle.Question, "Where's the Number?")
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + " " + "+ "
            OP = "+"
        Else
            C_Display.Text = C_Display.Text + " " + "+ "
            OP = "+"
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If C_Display.Text Is "" Then
            MsgBox("Choose A Number First", MsgBoxStyle.Question, "Where's the Number?")
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + " " + "- "
            OP = "-"
        Else
            C_Display.Text = C_Display.Text + " " + "- "
            OP = "-"
        End If
    End Sub


    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        If C_Display.Text Is "" Then
            MsgBox("Choose A Number First", MsgBoxStyle.Question, "Where's the Number?")
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + " " + "* "
            OP = "*"
        Else
            C_Display.Text = C_Display.Text + " " + "* "
            OP = "*"
        End If
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        If C_Display.Text Is "" Then
            MsgBox("Choose A Number First", MsgBoxStyle.Question, "Where's the Number?")
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + " " + "/ "
            OP = "/"
        Else
            C_Display.Text = C_Display.Text + " " + "/ "
            OP = "/"
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If C_Display.Text Is "" Then
            MsgBox("Choose A Number First", MsgBoxStyle.Question, "Where's the Number?")
        ElseIf C_Display.Text IsNot "" And OP Is Nothing Then
            C_Display.Text = C_Display.Text + " " + "MOD "
            OP = "MOD"
        Else
            C_Display.Text = C_Display.Text + " " + "MOD "
            OP = "MOD"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        MsgBox("We will leave it for another project Hehehe")
    End Sub
    Private Sub bntEqual_Click(sender As Object, e As EventArgs) Handles bntEqual.Click
        Dim result As Integer
        Select Case OP
            Case "+"
                result = FNumber + SNumber
                C_Display.Text = C_Display.Text + " = " & Environment.NewLine & result
            Case "-"
                result = FNumber - SNumber
                C_Display.Text = C_Display.Text + " = " & Environment.NewLine & result
            Case "*"
                result = FNumber * SNumber
                C_Display.Text = C_Display.Text + " = " & Environment.NewLine & result
            Case "/"
                result = FNumber / SNumber
                C_Display.Text = C_Display.Text + " = " & Environment.NewLine & result
            Case "MOD"
                result = FNumber Mod SNumber
                C_Display.Text = C_Display.Text + " = " & Environment.NewLine & result
            Case Else
                MsgBox("How i'm going to calculate an empty thing?!", MsgBoxStyle.Critical, "Please choose a number!")
        End Select
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        C_Display.Text = ""
        FNumber = 0
        OP = Nothing
        SNumber = 0
    End Sub
End Class