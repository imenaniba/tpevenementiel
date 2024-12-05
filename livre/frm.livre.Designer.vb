<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        lbl_isbn = New Label()
        lbl_titre = New Label()
        lbl_auteur = New Label()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        txt_isbn = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_isbn
        ' 
        lbl_isbn.AutoSize = True
        lbl_isbn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lbl_isbn.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        lbl_isbn.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lbl_isbn.Location = New Point(107, 120)
        lbl_isbn.Name = "lbl_isbn"
        lbl_isbn.Size = New Size(63, 28)
        lbl_isbn.TabIndex = 0
        lbl_isbn.Text = "ISBN:"
        ' 
        ' lbl_titre
        ' 
        lbl_titre.AutoSize = True
        lbl_titre.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lbl_titre.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        lbl_titre.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lbl_titre.Location = New Point(107, 203)
        lbl_titre.Name = "lbl_titre"
        lbl_titre.Size = New Size(56, 28)
        lbl_titre.TabIndex = 1
        lbl_titre.Text = "Titre"
        ' 
        ' lbl_auteur
        ' 
        lbl_auteur.AutoSize = True
        lbl_auteur.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lbl_auteur.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        lbl_auteur.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lbl_auteur.Location = New Point(107, 268)
        lbl_auteur.Name = "lbl_auteur"
        lbl_auteur.Size = New Size(81, 28)
        lbl_auteur.TabIndex = 2
        lbl_auteur.Text = "Auteur:"
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btn_ajouter.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btn_ajouter.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_ajouter.Location = New Point(195, 350)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(133, 45)
        btn_ajouter.TabIndex = 3
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = False
        ' 
        ' btn_afficher
        ' 
        btn_afficher.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btn_afficher.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btn_afficher.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_afficher.Location = New Point(380, 350)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(133, 45)
        btn_afficher.TabIndex = 4
        btn_afficher.Text = "afficher"
        btn_afficher.UseVisualStyleBackColor = False
        ' 
        ' txt_isbn
        ' 
        txt_isbn.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txt_isbn.Location = New Point(203, 120)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(125, 27)
        txt_isbn.TabIndex = 5
        ' 
        ' txt_titre
        ' 
        txt_titre.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txt_titre.Location = New Point(203, 200)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 6
        ' 
        ' txt_auteur
        ' 
        txt_auteur.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txt_auteur.Location = New Point(203, 265)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 7
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSlateBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(lbl_auteur)
        Controls.Add(lbl_titre)
        Controls.Add(lbl_isbn)
        Name = "form1"
        Text = "livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_isbn As Label
    Friend WithEvents lbl_titre As Label
    Friend WithEvents lbl_auteur As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox

End Class
