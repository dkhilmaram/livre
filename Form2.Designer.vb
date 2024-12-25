<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Listisbn = New ListBox()
        Listtitre = New ListBox()
        Listauteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(347, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 1
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(590, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "auteur"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(188, 351)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(436, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 4
        Button2.Text = "ajouter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Listisbn
        ' 
        Listisbn.FormattingEnabled = True
        Listisbn.Location = New Point(79, 150)
        Listisbn.Name = "Listisbn"
        Listisbn.Size = New Size(150, 104)
        Listisbn.TabIndex = 5
        ' 
        ' Listtitre
        ' 
        Listtitre.FormattingEnabled = True
        Listtitre.Location = New Point(306, 150)
        Listtitre.Name = "Listtitre"
        Listtitre.Size = New Size(150, 104)
        Listtitre.TabIndex = 6
        ' 
        ' Listauteur
        ' 
        Listauteur.FormattingEnabled = True
        Listauteur.Location = New Point(542, 150)
        Listauteur.Name = "Listauteur"
        Listauteur.Size = New Size(150, 104)
        Listauteur.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Listauteur)
        Controls.Add(Listtitre)
        Controls.Add(Listisbn)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Listisbn As ListBox
    Friend WithEvents Listtitre As ListBox
    Friend WithEvents Listauteur As ListBox
End Class
