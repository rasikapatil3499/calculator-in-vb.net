Public Class Form1
    Dim fnum As Decimal
    Dim snum As Decimal
    Dim opr As Integer
    Dim opr_selector As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

 
    Private Sub zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zero.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub one_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub four_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles four.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub three_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles three.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub two_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub five_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles five.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub six_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles six.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub seven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seven.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub eight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eight.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub nine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nine.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub addition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addition.Click
        fnum = TextBox1.Text
        TextBox1.Text = 0
        opr_selector = True
        opr = 1 ' = +
    End Sub

    Private Sub subtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtraction.Click
        fnum = TextBox1.Text
        TextBox1.Text = 0
        opr_selector = True
        opr = 2 ' = -
    End Sub

    Private Sub multiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplication.Click
        fnum = TextBox1.Text
        TextBox1.Text = 0
        opr_selector = True
        opr = 3 ' = *
    End Sub

    Private Sub divide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divide.Click
        fnum = TextBox1.Text
        TextBox1.Text = 0
        opr_selector = True
        opr = 4 ' = /
    End Sub

    Private Sub equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal.Click
        If opr_selector = True Then
            snum = TextBox1.Text
            If opr = 1 Then
                TextBox1.Text = fnum + snum
            ElseIf opr = 2 Then
                TextBox1.Text = fnum - snum
            ElseIf opr = 3 Then
                TextBox1.Text = fnum * snum
            Else
                If snum = 0 Then
                    TextBox1.Text = "error!"
                Else
                    TextBox1.Text = fnum / snum
            End If
        End If
            opr_selector = False
        End If
    End Sub

    Private Sub dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "."
        Else
            TextBox1.Text = "."
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        TextBox1.Text=""
    End Sub
End Class
