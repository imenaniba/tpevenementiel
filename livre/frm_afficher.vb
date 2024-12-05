Public Class frm_afficher
    Private Sub frm_afficher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher_Livre(lst_ISBN, lst_titre, lst_auteur)
    End Sub

    Private Sub lst_isbn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_isbn.SelectedIndexChanged

    End Sub
End Class