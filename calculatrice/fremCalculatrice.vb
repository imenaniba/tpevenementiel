Public Class fremCalculatrice
    Dim op As Char
    Private Sub fremCalculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "-"
    End Sub
    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub btn_egal_Click(sender As Object, e As EventArgs) Handles btn_egal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim test = True
            Dim res As Double
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" Then
                res = a / b
                test = False
            Else
                MessageBox.Show("veuillez verifier si b!=0 et que x avez choisit l'operation")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + " " + op + " " + b.ToString + " = " + res.ToString
            End If
        Else
            MessageBox.Show(" A et B devoint etre des entiers")
        End If
    End Sub
End Class