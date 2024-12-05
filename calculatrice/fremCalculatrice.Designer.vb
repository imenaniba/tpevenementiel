<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fremCalculatrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fremCalculatrice))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        btn_plus = New Button()
        btn_div = New Button()
        btn_mult = New Button()
        btn_minus = New Button()
        btn_egal = New Button()
        btn_res = New Button()
        lbl_res = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Location = New Point(97, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 34)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaption
        Label2.Location = New Point(97, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 34)
        Label2.TabIndex = 1
        Label2.Text = "B"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaption
        Label3.Location = New Point(123, 359)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 34)
        Label3.TabIndex = 2
        Label3.Text = "RESULTAT"
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(151, 36)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 4
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(151, 91)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(125, 27)
        txt_B.TabIndex = 5
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = SystemColors.HotTrack
        btn_plus.ForeColor = SystemColors.ControlLightLight
        btn_plus.Location = New Point(151, 161)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(85, 62)
        btn_plus.TabIndex = 7
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_div
        ' 
        btn_div.BackColor = SystemColors.HotTrack
        btn_div.ForeColor = SystemColors.ControlLightLight
        btn_div.Location = New Point(563, 161)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(88, 62)
        btn_div.TabIndex = 8
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = SystemColors.HotTrack
        btn_mult.ForeColor = SystemColors.ControlLightLight
        btn_mult.Location = New Point(425, 161)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(94, 62)
        btn_mult.TabIndex = 9
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_minus
        ' 
        btn_minus.BackColor = SystemColors.HotTrack
        btn_minus.ForeColor = SystemColors.ControlLightLight
        btn_minus.Location = New Point(289, 161)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(76, 62)
        btn_minus.TabIndex = 10
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = False
        ' 
        ' btn_egal
        ' 
        btn_egal.BackColor = SystemColors.HotTrack
        btn_egal.ForeColor = SystemColors.ControlLightLight
        btn_egal.Location = New Point(151, 281)
        btn_egal.Name = "btn_egal"
        btn_egal.Size = New Size(85, 58)
        btn_egal.TabIndex = 11
        btn_egal.Text = "="
        btn_egal.UseVisualStyleBackColor = False
        ' 
        ' btn_res
        ' 
        btn_res.BackColor = SystemColors.HotTrack
        btn_res.ForeColor = SystemColors.ControlLightLight
        btn_res.Location = New Point(519, 283)
        btn_res.Name = "btn_res"
        btn_res.Size = New Size(79, 56)
        btn_res.TabIndex = 12
        btn_res.Text = "RESET"
        btn_res.UseVisualStyleBackColor = False
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Location = New Point(360, 367)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(18, 20)
        lbl_res.TabIndex = 13
        lbl_res.Text = "..."
        ' 
        ' fremCalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_res)
        Controls.Add(btn_res)
        Controls.Add(btn_egal)
        Controls.Add(btn_minus)
        Controls.Add(btn_mult)
        Controls.Add(btn_div)
        Controls.Add(btn_plus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaption
        Name = "fremCalculatrice"
        Text = "fremCalculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_egal As Button
    Friend WithEvents btn_res As Button
    Friend WithEvents lbl_res As Label

End Class
