<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Txt_isbn = New TextBox()
        Txt_auteur = New TextBox()
        txt_titre = New TextBox()
        Btn_afficher = New Button()
        Btn_ajouter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Location = New Point(200, 88)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.Size = New Size(125, 27)
        Txt_isbn.TabIndex = 0
        ' 
        ' Txt_auteur
        ' 
        Txt_auteur.Location = New Point(200, 222)
        Txt_auteur.Name = "Txt_auteur"
        Txt_auteur.Size = New Size(125, 27)
        Txt_auteur.TabIndex = 1
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(200, 154)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 2
        ' 
        ' Btn_afficher
        ' 
        Btn_afficher.Location = New Point(371, 125)
        Btn_afficher.Name = "Btn_afficher"
        Btn_afficher.Size = New Size(94, 29)
        Btn_afficher.TabIndex = 3
        Btn_afficher.Text = "afficher"
        Btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.Location = New Point(371, 199)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(94, 29)
        Btn_ajouter.TabIndex = 4
        Btn_ajouter.Text = "ajouter"
        Btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 20)
        Label1.TabIndex = 5
        Label1.Text = "isbn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 6
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 7
        Label3.Text = "auteur"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btn_ajouter)
        Controls.Add(Btn_afficher)
        Controls.Add(txt_titre)
        Controls.Add(Txt_auteur)
        Controls.Add(Txt_isbn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_auteur As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents Btn_afficher As Button
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
