<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pizza))
        rd_fine = New RadioButton()
        rd_classique = New RadioButton()
        rd_épaise = New RadioButton()
        Chk_ch = New CheckBox()
        Chk_po = New CheckBox()
        Chk_ol = New CheckBox()
        Chk_fr = New CheckBox()
        btn_affiche = New Button()
        lst_demande = New ComboBox()
        SuspendLayout()
        ' 
        ' rd_fine
        ' 
        rd_fine.AutoSize = True
        rd_fine.FlatStyle = FlatStyle.Flat
        rd_fine.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rd_fine.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        rd_fine.Location = New Point(86, 107)
        rd_fine.Name = "rd_fine"
        rd_fine.Size = New Size(133, 32)
        rd_fine.TabIndex = 0
        rd_fine.TabStop = True
        rd_fine.Text = "croute fine"
        rd_fine.UseVisualStyleBackColor = True
        ' 
        ' rd_classique
        ' 
        rd_classique.AutoSize = True
        rd_classique.FlatStyle = FlatStyle.Flat
        rd_classique.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rd_classique.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        rd_classique.Location = New Point(306, 107)
        rd_classique.Name = "rd_classique"
        rd_classique.Size = New Size(182, 32)
        rd_classique.TabIndex = 1
        rd_classique.TabStop = True
        rd_classique.Text = "croute classique"
        rd_classique.UseVisualStyleBackColor = True
        ' 
        ' rd_épaise
        ' 
        rd_épaise.AutoSize = True
        rd_épaise.FlatStyle = FlatStyle.Flat
        rd_épaise.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rd_épaise.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        rd_épaise.Location = New Point(570, 107)
        rd_épaise.Name = "rd_épaise"
        rd_épaise.Size = New Size(156, 32)
        rd_épaise.TabIndex = 2
        rd_épaise.TabStop = True
        rd_épaise.Text = "croute épaise"
        rd_épaise.UseVisualStyleBackColor = True
        ' 
        ' Chk_ch
        ' 
        Chk_ch.AutoSize = True
        Chk_ch.FlatStyle = FlatStyle.Flat
        Chk_ch.Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Chk_ch.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Chk_ch.Location = New Point(86, 173)
        Chk_ch.Name = "Chk_ch"
        Chk_ch.Size = New Size(157, 26)
        Chk_ch.TabIndex = 3
        Chk_ch.Text = "champignion"
        Chk_ch.UseVisualStyleBackColor = True
        ' 
        ' Chk_po
        ' 
        Chk_po.AutoSize = True
        Chk_po.FlatStyle = FlatStyle.Flat
        Chk_po.Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Chk_po.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Chk_po.Location = New Point(86, 278)
        Chk_po.Name = "Chk_po"
        Chk_po.Size = New Size(115, 26)
        Chk_po.TabIndex = 4
        Chk_po.Text = "poissons"
        Chk_po.UseVisualStyleBackColor = True
        ' 
        ' Chk_ol
        ' 
        Chk_ol.AutoSize = True
        Chk_ol.FlatStyle = FlatStyle.Flat
        Chk_ol.Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Chk_ol.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Chk_ol.Location = New Point(86, 226)
        Chk_ol.Name = "Chk_ol"
        Chk_ol.Size = New Size(92, 26)
        Chk_ol.TabIndex = 5
        Chk_ol.Text = "olives"
        Chk_ol.UseVisualStyleBackColor = True
        ' 
        ' Chk_fr
        ' 
        Chk_fr.AutoSize = True
        Chk_fr.FlatStyle = FlatStyle.Flat
        Chk_fr.Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Chk_fr.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Chk_fr.Location = New Point(86, 336)
        Chk_fr.Name = "Chk_fr"
        Chk_fr.Size = New Size(286, 26)
        Chk_fr.TabIndex = 6
        Chk_fr.Text = "fromage supplimentaire"
        Chk_fr.UseVisualStyleBackColor = True
        ' 
        ' btn_affiche
        ' 
        btn_affiche.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btn_affiche.FlatStyle = FlatStyle.Flat
        btn_affiche.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_affiche.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btn_affiche.Location = New Point(306, 381)
        btn_affiche.Name = "btn_affiche"
        btn_affiche.Size = New Size(251, 34)
        btn_affiche.TabIndex = 7
        btn_affiche.Text = "afficher la commande"
        btn_affiche.UseVisualStyleBackColor = False
        ' 
        ' lst_demande
        ' 
        lst_demande.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lst_demande.FormattingEnabled = True
        lst_demande.Items.AddRange(New Object() {"petite", "moyenne ", "grande"})
        lst_demande.Location = New Point(306, 27)
        lst_demande.Name = "lst_demande"
        lst_demande.Size = New Size(151, 28)
        lst_demande.TabIndex = 8
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(lst_demande)
        Controls.Add(btn_affiche)
        Controls.Add(Chk_fr)
        Controls.Add(Chk_ol)
        Controls.Add(Chk_po)
        Controls.Add(Chk_ch)
        Controls.Add(rd_épaise)
        Controls.Add(rd_classique)
        Controls.Add(rd_fine)
        Name = "pizza"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rd_fine As RadioButton
    Friend WithEvents rd_classique As RadioButton
    Friend WithEvents rd_épaise As RadioButton
    Friend WithEvents Chk_ch As CheckBox
    Friend WithEvents Chk_po As CheckBox
    Friend WithEvents Chk_ol As CheckBox
    Friend WithEvents Chk_fr As CheckBox
    Friend WithEvents btn_affiche As Button
    Friend WithEvents lst_demande As ComboBox

End Class
