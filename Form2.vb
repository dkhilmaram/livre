Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ajoute_Click(sender As Object, e As EventArgs)
        Dim l As Livre
        l.ISBN = TAB_isbn.Text
        l.ISBN = TAB_titre.Text
        l.ISBN = TAB_auteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else
            MessageBox.Show("la bibliotheque est saruree!!")
        End If

    End Sub

    Private Sub affiche_Click(sender As Object, e As EventArgs)
        Dim displayForm As New Form2() ' Replace with the name of the form you want to display
        displayForm.Show()
    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listisbn.SelectedIndexChanged

    End Sub
End Class
