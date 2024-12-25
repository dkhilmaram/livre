<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listelivre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        btn_affiche = New Button()
        Btn_ajouter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(128, 173)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 104)
        lst_isbn.TabIndex = 0
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(325, 173)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(150, 104)
        lst_titre.TabIndex = 1
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(519, 173)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(150, 104)
        lst_auteur.TabIndex = 2
        ' 
        ' btn_affiche
        ' 
        btn_affiche.Location = New Point(229, 352)
        btn_affiche.Name = "btn_affiche"
        btn_affiche.Size = New Size(94, 29)
        btn_affiche.TabIndex = 3
        btn_affiche.Text = "afficher"
        btn_affiche.UseVisualStyleBackColor = True
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.Location = New Point(419, 352)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(94, 29)
        Btn_ajouter.TabIndex = 4
        Btn_ajouter.Text = "ajouter"
        Btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 20)
        Label1.TabIndex = 5
        Label1.Text = "isbn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(373, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 6
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(581, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 7
        Label3.Text = "auteur"
        ' 
        ' listelivre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btn_ajouter)
        Controls.Add(btn_affiche)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Name = "listelivre"
        Text = "listelivre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents btn_affiche As Button
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
