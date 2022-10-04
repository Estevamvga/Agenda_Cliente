<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog))
        Me.btn_cor_Form = New System.Windows.Forms.Button()
        Me.txtEmpresaC = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btn_CorLabel = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'btn_cor_Form
        '
        Me.btn_cor_Form.Location = New System.Drawing.Point(19, 18)
        Me.btn_cor_Form.Name = "btn_cor_Form"
        Me.btn_cor_Form.Size = New System.Drawing.Size(75, 23)
        Me.btn_cor_Form.TabIndex = 0
        Me.btn_cor_Form.Text = "Cor Label"
        Me.btn_cor_Form.UseVisualStyleBackColor = True
        '
        'txtEmpresaC
        '
        Me.txtEmpresaC.AutoSize = True
        Me.txtEmpresaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaC.Location = New System.Drawing.Point(132, 24)
        Me.txtEmpresaC.Name = "txtEmpresaC"
        Me.txtEmpresaC.Size = New System.Drawing.Size(128, 17)
        Me.txtEmpresaC.TabIndex = 1
        Me.txtEmpresaC.Text = "Empresa Control"
        '
        'btn_CorLabel
        '
        Me.btn_CorLabel.Location = New System.Drawing.Point(19, 47)
        Me.btn_CorLabel.Name = "btn_CorLabel"
        Me.btn_CorLabel.Size = New System.Drawing.Size(75, 23)
        Me.btn_CorLabel.TabIndex = 2
        Me.btn_CorLabel.Text = "Cor Form"
        Me.btn_CorLabel.UseVisualStyleBackColor = True
        '
        'Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 78)
        Me.Controls.Add(Me.btn_CorLabel)
        Me.Controls.Add(Me.txtEmpresaC)
        Me.Controls.Add(Me.btn_cor_Form)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cor_Form As Button
    Friend WithEvents txtEmpresaC As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btn_CorLabel As Button
    Friend WithEvents FontDialog1 As FontDialog
End Class
