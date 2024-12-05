Public Class pizza
    Private Sub lst_demande_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_demande.SelectedIndexChanged

    End Sub

    Private Sub btn_affiche_Click(sender As Object, e As EventArgs) Handles btn_affiche.Click
        Dim taille = lst_demande.SelectedItem.ToString()
        Dim ingredient As String = ""
        If rd_fine.Checked Then
            ingredient = " Croute Fine"
        ElseIf rd_classique.Checked Then
            ingredient = "Croute classique"
        ElseIf rd_épaise.Checked Then
            ingredient = "Croute Epaise"
        End If
        Dim ingrSupp As String = ""
        If Chk_ch.Checked Then
            ingrSupp = ingrSupp + "Champignon"
        ElseIf Chk_ol.Checked Then
            ingrSupp = ingrSupp + "Olives"
        ElseIf Chk_po.Checked Then
            ingrSupp = ingrSupp + "poivrons"
        ElseIf Chk_fr.Checked Then
            ingrSupp = ingrSupp + "Fromage supplimentaire"
        End If
        Dim msg As String = "taille:    " + taille + " type de croute :   " + ingredient + "   ingredient suplémentaire:   " + ingrSupp
        MessageBox.Show(msg)
    End Sub

    Private Sub pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
