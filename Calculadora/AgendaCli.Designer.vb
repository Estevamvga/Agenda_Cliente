<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgendaCli
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaCli))
        Me.txt_NomeC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_TelCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TelResidencial = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.cmb_Sexo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_Referencias = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_Cadastro = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Nascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_Responsavel = New System.Windows.Forms.Label()
        Me.dvg_GridViewContatos = New System.Windows.Forms.DataGridView()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vReferencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelResponsavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.btn_incluir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_QtdRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtConsulta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvg_GridViewContatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_NomeC
        '
        Me.txt_NomeC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NomeC.Enabled = False
        Me.txt_NomeC.Location = New System.Drawing.Point(152, 24)
        Me.txt_NomeC.Name = "txt_NomeC"
        Me.txt_NomeC.Size = New System.Drawing.Size(301, 20)
        Me.txt_NomeC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(53, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nome Completo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_TelCelular)
        Me.GroupBox1.Controls.Add(Me.txt_TelResidencial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_Email)
        Me.GroupBox1.Controls.Add(Me.cmb_Sexo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_Referencias)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_Cadastro)
        Me.GroupBox1.Controls.Add(Me.dtp_Nascimento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_Responsavel)
        Me.GroupBox1.Controls.Add(Me.txt_NomeC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações para Cadastro"
        '
        'txt_TelCelular
        '
        Me.txt_TelCelular.Enabled = False
        Me.txt_TelCelular.Location = New System.Drawing.Point(349, 50)
        Me.txt_TelCelular.Mask = "00-9999-9999"
        Me.txt_TelCelular.Name = "txt_TelCelular"
        Me.txt_TelCelular.Size = New System.Drawing.Size(105, 20)
        Me.txt_TelCelular.TabIndex = 3
        '
        'txt_TelResidencial
        '
        Me.txt_TelResidencial.Enabled = False
        Me.txt_TelResidencial.Location = New System.Drawing.Point(152, 50)
        Me.txt_TelResidencial.Mask = "00-9999-9999"
        Me.txt_TelResidencial.Name = "txt_TelResidencial"
        Me.txt_TelResidencial.Size = New System.Drawing.Size(105, 20)
        Me.txt_TelResidencial.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "E-mail "
        '
        'txt_Email
        '
        Me.txt_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Email.Enabled = False
        Me.txt_Email.Location = New System.Drawing.Point(152, 129)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(301, 20)
        Me.txt_Email.TabIndex = 8
        '
        'cmb_Sexo
        '
        Me.cmb_Sexo.Enabled = False
        Me.cmb_Sexo.FormattingEnabled = True
        Me.cmb_Sexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmb_Sexo.Location = New System.Drawing.Point(348, 102)
        Me.cmb_Sexo.Name = "cmb_Sexo"
        Me.cmb_Sexo.Size = New System.Drawing.Size(105, 21)
        Me.cmb_Sexo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sexo"
        '
        'cmb_Referencias
        '
        Me.cmb_Referencias.Enabled = False
        Me.cmb_Referencias.FormattingEnabled = True
        Me.cmb_Referencias.Items.AddRange(New Object() {"FÁMILIA", "AMIGOS", "FACULDADE", "OUTROS"})
        Me.cmb_Referencias.Location = New System.Drawing.Point(152, 102)
        Me.cmb_Referencias.Name = "cmb_Referencias"
        Me.cmb_Referencias.Size = New System.Drawing.Size(105, 21)
        Me.cmb_Referencias.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Referencias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Data Cadatro"
        '
        'dtp_Cadastro
        '
        Me.dtp_Cadastro.Enabled = False
        Me.dtp_Cadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Cadastro.Location = New System.Drawing.Point(349, 76)
        Me.dtp_Cadastro.Name = "dtp_Cadastro"
        Me.dtp_Cadastro.Size = New System.Drawing.Size(105, 20)
        Me.dtp_Cadastro.TabIndex = 5
        '
        'dtp_Nascimento
        '
        Me.dtp_Nascimento.Enabled = False
        Me.dtp_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Nascimento.Location = New System.Drawing.Point(152, 76)
        Me.dtp_Nascimento.MinDate = New Date(1910, 1, 25, 23, 59, 59, 0)
        Me.dtp_Nascimento.Name = "dtp_Nascimento"
        Me.dtp_Nascimento.Size = New System.Drawing.Size(105, 20)
        Me.dtp_Nascimento.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data Nasc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tel. Celular"
        '
        'dtp_Responsavel
        '
        Me.dtp_Responsavel.AutoSize = True
        Me.dtp_Responsavel.Location = New System.Drawing.Point(53, 57)
        Me.dtp_Responsavel.Name = "dtp_Responsavel"
        Me.dtp_Responsavel.Size = New System.Drawing.Size(83, 13)
        Me.dtp_Responsavel.TabIndex = 8
        Me.dtp_Responsavel.Text = "Tel. Residencial"
        '
        'dvg_GridViewContatos
        '
        Me.dvg_GridViewContatos.AllowUserToAddRows = False
        Me.dvg_GridViewContatos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dvg_GridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_GridViewContatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOME, Me.vSexo, Me.vReferencias, Me.TelResponsavel})
        Me.dvg_GridViewContatos.GridColor = System.Drawing.SystemColors.Highlight
        Me.dvg_GridViewContatos.Location = New System.Drawing.Point(14, 23)
        Me.dvg_GridViewContatos.MultiSelect = False
        Me.dvg_GridViewContatos.Name = "dvg_GridViewContatos"
        Me.dvg_GridViewContatos.RowHeadersWidth = 20
        Me.dvg_GridViewContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_GridViewContatos.Size = New System.Drawing.Size(464, 155)
        Me.dvg_GridViewContatos.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dvg_GridViewContatos, "Informações de consulta")
        '
        'NOME
        '
        Me.NOME.HeaderText = "Nome"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        Me.NOME.ToolTipText = "Nome do Cliente"
        Me.NOME.Width = 200
        '
        'vSexo
        '
        Me.vSexo.HeaderText = "Sexo"
        Me.vSexo.Name = "vSexo"
        Me.vSexo.ReadOnly = True
        Me.vSexo.ToolTipText = "Sexo"
        Me.vSexo.Width = 40
        '
        'vReferencias
        '
        Me.vReferencias.HeaderText = "Referências"
        Me.vReferencias.Name = "vReferencias"
        Me.vReferencias.ReadOnly = True
        Me.vReferencias.ToolTipText = "Referências do Cliente"
        '
        'TelResponsavel
        '
        Me.TelResponsavel.HeaderText = "Telefone"
        Me.TelResponsavel.Name = "TelResponsavel"
        Me.TelResponsavel.ReadOnly = True
        Me.TelResponsavel.ToolTipText = "Telefone fixo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dvg_GridViewContatos)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 192)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultar informação "
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Image = Global.Estudo_2022.My.Resources.Resources.CancelAg_48
        Me.btn_cancel.Location = New System.Drawing.Point(374, 20)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(62, 59)
        Me.btn_cancel.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btn_cancel, "Cancelar")
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.FlatAppearance.BorderSize = 0
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Image = Global.Estudo_2022.My.Resources.Resources.Save_481
        Me.btn_salvar.Location = New System.Drawing.Point(306, 20)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(62, 59)
        Me.btn_salvar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btn_salvar, "Salvar")
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Image = Global.Estudo_2022.My.Resources.Resources.Delete_icon_48
        Me.btn_delete.Location = New System.Drawing.Point(238, 20)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(62, 59)
        Me.btn_delete.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_delete, "Deletar")
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.FlatAppearance.BorderSize = 0
        Me.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterar.Image = Global.Estudo_2022.My.Resources.Resources.Altera_date_48
        Me.btn_alterar.Location = New System.Drawing.Point(170, 20)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(62, 59)
        Me.btn_alterar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_alterar, "Alterar")
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_incluir
        '
        Me.btn_incluir.AccessibleDescription = ""
        Me.btn_incluir.AccessibleName = ""
        Me.btn_incluir.FlatAppearance.BorderSize = 0
        Me.btn_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_incluir.Image = Global.Estudo_2022.My.Resources.Resources.schedule_add_48
        Me.btn_incluir.Location = New System.Drawing.Point(102, 20)
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.Size = New System.Drawing.Size(62, 59)
        Me.btn_incluir.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_incluir, "Incluir")
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_QtdRegistros})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(517, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_QtdRegistros
        '
        Me.lbl_QtdRegistros.Name = "lbl_QtdRegistros"
        Me.lbl_QtdRegistros.Size = New System.Drawing.Size(136, 17)
        Me.lbl_QtdRegistros.Text = "Quantidade de registros:"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(12, 17)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(492, 70)
        Me.Guna2GradientPanel1.TabIndex = 16
        '
        'txtConsulta
        '
        Me.txtConsulta.BorderRadius = 10
        Me.txtConsulta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConsulta.DefaultText = ""
        Me.txtConsulta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConsulta.DisabledState.Parent = Me.txtConsulta
        Me.txtConsulta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConsulta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConsulta.FocusedState.Parent = Me.txtConsulta
        Me.txtConsulta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConsulta.HoverState.Parent = Me.txtConsulta
        Me.txtConsulta.Location = New System.Drawing.Point(12, 98)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConsulta.PlaceholderText = "Digite o nome da consulta"
        Me.txtConsulta.SelectedText = ""
        Me.txtConsulta.ShadowDecoration.Parent = Me.txtConsulta
        Me.txtConsulta.Size = New System.Drawing.Size(492, 29)
        Me.txtConsulta.TabIndex = 0
        '
        'AgendaCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 551)
        Me.Controls.Add(Me.txtConsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.btn_incluir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AgendaCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda do Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvg_GridViewContatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_incluir As Button
    Friend WithEvents btn_alterar As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_NomeC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_Cadastro As DateTimePicker
    Friend WithEvents dtp_Nascimento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_Responsavel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents cmb_Sexo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_Referencias As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dvg_GridViewContatos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents vSexo As DataGridViewTextBoxColumn
    Friend WithEvents vReferencias As DataGridViewTextBoxColumn
    Friend WithEvents TelResponsavel As DataGridViewTextBoxColumn
    Friend WithEvents txt_TelResidencial As MaskedTextBox
    Friend WithEvents txt_TelCelular As MaskedTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_QtdRegistros As ToolStripStatusLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtConsulta As Guna.UI2.WinForms.Guna2TextBox
End Class
