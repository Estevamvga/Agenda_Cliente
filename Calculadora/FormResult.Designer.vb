<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formResult
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
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nota1 = New System.Windows.Forms.TextBox()
        Me.txt_nota2 = New System.Windows.Forms.TextBox()
        Me.txt_nota3 = New System.Windows.Forms.TextBox()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(88, 40)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(232, 20)
        Me.txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nota 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nota 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nota 3"
        '
        'txt_nota1
        '
        Me.txt_nota1.Location = New System.Drawing.Point(88, 66)
        Me.txt_nota1.Name = "txt_nota1"
        Me.txt_nota1.Size = New System.Drawing.Size(89, 20)
        Me.txt_nota1.TabIndex = 2
        '
        'txt_nota2
        '
        Me.txt_nota2.Location = New System.Drawing.Point(88, 92)
        Me.txt_nota2.Name = "txt_nota2"
        Me.txt_nota2.Size = New System.Drawing.Size(89, 20)
        Me.txt_nota2.TabIndex = 3
        '
        'txt_nota3
        '
        Me.txt_nota3.Location = New System.Drawing.Point(88, 118)
        Me.txt_nota3.Name = "txt_nota3"
        Me.txt_nota3.Size = New System.Drawing.Size(89, 20)
        Me.txt_nota3.TabIndex = 4
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(51, 166)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(58, 23)
        Me.btn_gravar.TabIndex = 5
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Location = New System.Drawing.Point(115, 166)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(116, 23)
        Me.btn_finalizar.TabIndex = 6
        Me.btn_finalizar.Text = "Finalizar Digitação"
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(237, 166)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(58, 23)
        Me.btn_voltar.TabIndex = 7
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 148)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora de resultados"
        '
        'formResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 203)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.txt_nota3)
        Me.Controls.Add(Me.txt_nota2)
        Me.Controls.Add(Me.txt_nota1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora grava resultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nota1 As TextBox
    Friend WithEvents txt_nota2 As TextBox
    Friend WithEvents txt_nota3 As TextBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
