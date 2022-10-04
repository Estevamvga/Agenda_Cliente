<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendasPrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendasPrd))
        Me.txtCodprod = New System.Windows.Forms.Label()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtValorDesconto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalLiquido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodprod
        '
        Me.txtCodprod.AutoSize = True
        Me.txtCodprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodprod.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCodprod.Location = New System.Drawing.Point(9, 76)
        Me.txtCodprod.Name = "txtCodprod"
        Me.txtCodprod.Size = New System.Drawing.Size(97, 13)
        Me.txtCodprod.TabIndex = 3
        Me.txtCodprod.Text = "Código do produto:"
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodProduto.Location = New System.Drawing.Point(126, 73)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(297, 20)
        Me.txtCodProduto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(9, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Descrição do produto:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtValorTotal.Location = New System.Drawing.Point(327, 232)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(96, 20)
        Me.txtValorTotal.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(243, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Valor bruto R$:"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 121)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(411, 93)
        Me.ListBox1.TabIndex = 9
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtValorDesconto.Location = New System.Drawing.Point(327, 258)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(96, 20)
        Me.txtValorDesconto.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(243, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descontos:"
        '
        'txtTotalLiquido
        '
        Me.txtTotalLiquido.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalLiquido.Location = New System.Drawing.Point(327, 284)
        Me.txtTotalLiquido.Name = "txtTotalLiquido"
        Me.txtTotalLiquido.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalLiquido.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(243, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Valor Total R$:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(78, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "PDV integrado"
        '
        'btn_help
        '
        Me.btn_help.FlatAppearance.BorderSize = 0
        Me.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_help.Image = Global.Estudo_2022.My.Resources.Resources.Help_48
        Me.btn_help.Location = New System.Drawing.Point(361, 5)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(62, 59)
        Me.btn_help.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btn_help, "Em Desenvolvimento")
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.FlatAppearance.BorderSize = 0
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Image = Global.Estudo_2022.My.Resources.Resources.Clear_48
        Me.btn_limpar.Location = New System.Drawing.Point(293, 5)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(62, 59)
        Me.btn_limpar.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btn_limpar, "Limpar")
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Image = Global.Estudo_2022.My.Resources.Resources.Voltar_48
        Me.btn_voltar.Location = New System.Drawing.Point(225, 5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(62, 59)
        Me.btn_voltar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btn_voltar, "Voltar")
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Estudo_2022.My.Resources.Resources.cash
        Me.PictureBox4.Location = New System.Drawing.Point(152, 236)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'VendasPrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 321)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalLiquido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValorDesconto)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.txtCodprod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendasPrd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissor de Vendas"
        Me.TopMost = True
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodprod As Label
    Friend WithEvents txtCodProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtValorDesconto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalLiquido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_help As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
