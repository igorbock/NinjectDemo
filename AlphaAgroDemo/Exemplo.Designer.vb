<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exemplo
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.ButtonCriarCarro = New System.Windows.Forms.Button()
        Me.ButtonPintarCarro = New System.Windows.Forms.Button()
        Me.ComboBoxCores = New System.Windows.Forms.ComboBox()
        Me.LabelMarca = New System.Windows.Forms.Label()
        Me.LabelModelo = New System.Windows.Forms.Label()
        Me.ColorPanel = New System.Windows.Forms.Panel()
        Me.LabelAno = New System.Windows.Forms.Label()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.NumericAno = New System.Windows.Forms.NumericUpDown()
        Me.ButtonAlterar = New System.Windows.Forms.Button()
        Me.ButtonEntregar = New System.Windows.Forms.Button()
        Me.LabelCarrosEntregues = New System.Windows.Forms.Label()
        Me.LabelCarros = New System.Windows.Forms.Label()
        CType(Me.NumericAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCriarCarro
        '
        Me.ButtonCriarCarro.Location = New System.Drawing.Point(12, 12)
        Me.ButtonCriarCarro.Name = "ButtonCriarCarro"
        Me.ButtonCriarCarro.Size = New System.Drawing.Size(121, 23)
        Me.ButtonCriarCarro.TabIndex = 0
        Me.ButtonCriarCarro.Text = "Criar Carro"
        Me.ButtonCriarCarro.UseVisualStyleBackColor = True
        '
        'ButtonPintarCarro
        '
        Me.ButtonPintarCarro.Location = New System.Drawing.Point(12, 135)
        Me.ButtonPintarCarro.Name = "ButtonPintarCarro"
        Me.ButtonPintarCarro.Size = New System.Drawing.Size(121, 23)
        Me.ButtonPintarCarro.TabIndex = 1
        Me.ButtonPintarCarro.Text = "Pintar Carro"
        Me.ButtonPintarCarro.UseVisualStyleBackColor = True
        '
        'ComboBoxCores
        '
        Me.ComboBoxCores.DisplayMember = "Nome"
        Me.ComboBoxCores.FormattingEnabled = True
        Me.ComboBoxCores.Location = New System.Drawing.Point(12, 108)
        Me.ComboBoxCores.Name = "ComboBoxCores"
        Me.ComboBoxCores.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCores.TabIndex = 2
        Me.ComboBoxCores.ValueMember = "Valor"
        '
        'LabelMarca
        '
        Me.LabelMarca.AutoSize = True
        Me.LabelMarca.Location = New System.Drawing.Point(237, 22)
        Me.LabelMarca.Name = "LabelMarca"
        Me.LabelMarca.Size = New System.Drawing.Size(37, 13)
        Me.LabelMarca.TabIndex = 3
        Me.LabelMarca.Text = "Marca"
        '
        'LabelModelo
        '
        Me.LabelModelo.AutoSize = True
        Me.LabelModelo.Location = New System.Drawing.Point(237, 45)
        Me.LabelModelo.Name = "LabelModelo"
        Me.LabelModelo.Size = New System.Drawing.Size(42, 13)
        Me.LabelModelo.TabIndex = 4
        Me.LabelModelo.Text = "Modelo"
        '
        'ColorPanel
        '
        Me.ColorPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ColorPanel.Location = New System.Drawing.Point(240, 61)
        Me.ColorPanel.Name = "ColorPanel"
        Me.ColorPanel.Size = New System.Drawing.Size(76, 33)
        Me.ColorPanel.TabIndex = 5
        '
        'LabelAno
        '
        Me.LabelAno.AutoSize = True
        Me.LabelAno.Location = New System.Drawing.Point(237, 97)
        Me.LabelAno.Name = "LabelAno"
        Me.LabelAno.Size = New System.Drawing.Size(26, 13)
        Me.LabelAno.TabIndex = 6
        Me.LabelAno.Text = "Ano"
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(12, 183)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxMarca.TabIndex = 7
        Me.TextBoxMarca.Text = "Marca"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(12, 209)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxModelo.TabIndex = 8
        Me.TextBoxModelo.Text = "Modelo"
        '
        'NumericAno
        '
        Me.NumericAno.Location = New System.Drawing.Point(12, 235)
        Me.NumericAno.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumericAno.Name = "NumericAno"
        Me.NumericAno.Size = New System.Drawing.Size(121, 20)
        Me.NumericAno.TabIndex = 9
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.Location = New System.Drawing.Point(12, 261)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(121, 23)
        Me.ButtonAlterar.TabIndex = 10
        Me.ButtonAlterar.Text = "Alterar"
        Me.ButtonAlterar.UseVisualStyleBackColor = True
        '
        'ButtonEntregar
        '
        Me.ButtonEntregar.Location = New System.Drawing.Point(240, 135)
        Me.ButtonEntregar.Name = "ButtonEntregar"
        Me.ButtonEntregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEntregar.TabIndex = 11
        Me.ButtonEntregar.Text = "Entregar"
        Me.ButtonEntregar.UseVisualStyleBackColor = True
        '
        'LabelCarrosEntregues
        '
        Me.LabelCarrosEntregues.AutoSize = True
        Me.LabelCarrosEntregues.Location = New System.Drawing.Point(421, 34)
        Me.LabelCarrosEntregues.Name = "LabelCarrosEntregues"
        Me.LabelCarrosEntregues.Size = New System.Drawing.Size(88, 13)
        Me.LabelCarrosEntregues.TabIndex = 12
        Me.LabelCarrosEntregues.Text = "Carros Entregues"
        '
        'LabelCarros
        '
        Me.LabelCarros.AutoSize = True
        Me.LabelCarros.Location = New System.Drawing.Point(421, 61)
        Me.LabelCarros.Name = "LabelCarros"
        Me.LabelCarros.Size = New System.Drawing.Size(37, 13)
        Me.LabelCarros.TabIndex = 13
        Me.LabelCarros.Text = "Carros"
        '
        'Exemplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelCarros)
        Me.Controls.Add(Me.LabelCarrosEntregues)
        Me.Controls.Add(Me.ButtonEntregar)
        Me.Controls.Add(Me.ButtonAlterar)
        Me.Controls.Add(Me.NumericAno)
        Me.Controls.Add(Me.TextBoxModelo)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.LabelAno)
        Me.Controls.Add(Me.ColorPanel)
        Me.Controls.Add(Me.LabelModelo)
        Me.Controls.Add(Me.LabelMarca)
        Me.Controls.Add(Me.ComboBoxCores)
        Me.Controls.Add(Me.ButtonPintarCarro)
        Me.Controls.Add(Me.ButtonCriarCarro)
        Me.Name = "Exemplo"
        Me.Text = "Exemplo"
        CType(Me.NumericAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCriarCarro As Button
    Friend WithEvents ButtonPintarCarro As Button
    Friend WithEvents ComboBoxCores As ComboBox
    Friend WithEvents LabelMarca As Label
    Friend WithEvents LabelModelo As Label
    Friend WithEvents ColorPanel As Panel
    Friend WithEvents LabelAno As Label
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents TextBoxModelo As TextBox
    Friend WithEvents NumericAno As NumericUpDown
    Friend WithEvents ButtonAlterar As Button
    Friend WithEvents ButtonEntregar As Button
    Friend WithEvents LabelCarrosEntregues As Label
    Friend WithEvents LabelCarros As Label
End Class
