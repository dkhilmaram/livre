Public Class Form1
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        If String.IsNullOrWhiteSpace(Txt_isbn.Text) And String.IsNullOrWhiteSpace(txt_titre.Text) And String.IsNullOrWhiteSpace(Txt_auteur.Text) Then
            MessageBox.Show("Veuillez remplir les champs.")

        End If
        Dim l As Livre
        l.ISBN = Txt_isbn.Text
        l.Titre = txt_titre.Text
        l.Auteur = Txt_auteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succès")
            Txt_isbn.Clear()
            txt_titre.Clear()
            Txt_auteur.Clear()
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles Btn_afficher.Click
        listelivre.Show()

    End Sub
End Class
