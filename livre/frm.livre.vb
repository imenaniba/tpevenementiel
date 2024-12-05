Public Class form1
    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As livre
        l.ISBN = txt_isbn.Text
        l.titre = txt_titre.Text
        l.auteur = txt_auteur.Text

        If AjouterLivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        frm_afficher.Show()
    End Sub
End Class
