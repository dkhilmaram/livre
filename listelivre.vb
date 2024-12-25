Public Class listelivre
    Private Sub listelivre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherLivre(lst_isbn, lst_titre, lst_auteur)
    End Sub

    Private Sub btn_affiche_Click(sender As Object, e As EventArgs) Handles btn_affiche.Click
        Form4.Show()
    End Sub
End Class