<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher
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
        Btn1 = New Button()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(321, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(550, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' Btn1
        ' 
        Btn1.Location = New Point(321, 335)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(94, 29)
        Btn1.TabIndex = 3
        Btn1.Text = "afficher"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(104, 133)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 104)
        lst_isbn.TabIndex = 4
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(284, 133)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(150, 104)
        lst_titre.TabIndex = 5
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(541, 133)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(150, 104)
        lst_auteur.TabIndex = 6
        ' 
        ' frm_afficher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Btn1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_afficher"
        Text = "frm_afficher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents lst_isbn As ListBox
End Class
