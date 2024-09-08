<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoFabrica
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
        Me.components = New System.ComponentModel.Container()
        Dim AnoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.CarroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IdNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.LabelCor = New System.Windows.Forms.Label()
        Me.ComboBoxCor = New System.Windows.Forms.ComboBox()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        AnoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CorDataGridViewTextBoxColumn, Me.AnoDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.CarroBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(30, 195)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.Size = New System.Drawing.Size(550, 150)
        Me.DataGridView.TabIndex = 0
        '
        'CarroBindingSource
        '
        Me.CarroBindingSource.DataSource = GetType(AlphaStandardDemo.Models.Carro)
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'CorDataGridViewTextBoxColumn
        '
        Me.CorDataGridViewTextBoxColumn.DataPropertyName = "Cor"
        Me.CorDataGridViewTextBoxColumn.HeaderText = "Cor"
        Me.CorDataGridViewTextBoxColumn.Name = "CorDataGridViewTextBoxColumn"
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Ano"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(40, 30)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 1
        AnoLabel.Text = "Ano:"
        '
        'AnoNumericUpDown
        '
        Me.AnoNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CarroBindingSource, "Ano", True))
        Me.AnoNumericUpDown.Location = New System.Drawing.Point(91, 30)
        Me.AnoNumericUpDown.Name = "AnoNumericUpDown"
        Me.AnoNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AnoNumericUpDown.TabIndex = 2
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(40, 56)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 3
        IdLabel.Text = "Id:"
        '
        'IdNumericUpDown
        '
        Me.IdNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CarroBindingSource, "Id", True))
        Me.IdNumericUpDown.Location = New System.Drawing.Point(91, 56)
        Me.IdNumericUpDown.Name = "IdNumericUpDown"
        Me.IdNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.IdNumericUpDown.TabIndex = 4
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(40, 85)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 5
        MarcaLabel.Text = "Marca:"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarroBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(91, 82)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(120, 20)
        Me.MarcaTextBox.TabIndex = 6
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(40, 111)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(45, 13)
        ModeloLabel.TabIndex = 7
        ModeloLabel.Text = "Modelo:"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarroBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(91, 108)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ModeloTextBox.TabIndex = 8
        '
        'LabelCor
        '
        Me.LabelCor.AutoSize = True
        Me.LabelCor.Location = New System.Drawing.Point(40, 137)
        Me.LabelCor.Name = "LabelCor"
        Me.LabelCor.Size = New System.Drawing.Size(26, 13)
        Me.LabelCor.TabIndex = 10
        Me.LabelCor.Text = "Cor:"
        '
        'ComboBoxCor
        '
        Me.ComboBoxCor.FormattingEnabled = True
        Me.ComboBoxCor.Location = New System.Drawing.Point(91, 134)
        Me.ComboBoxCor.Name = "ComboBoxCor"
        Me.ComboBoxCor.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCor.TabIndex = 11
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(30, 351)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNovo.TabIndex = 12
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(111, 351)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 13
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.Location = New System.Drawing.Point(192, 351)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExcluir.TabIndex = 14
        Me.ButtonExcluir.Text = "Excluir"
        Me.ButtonExcluir.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(435, 351)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 15
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Location = New System.Drawing.Point(354, 351)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalvar.TabIndex = 16
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(273, 351)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFechar.TabIndex = 17
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'DemoFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonExcluir)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.ComboBoxCor)
        Me.Controls.Add(Me.LabelCor)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(Me.AnoNumericUpDown)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdNumericUpDown)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "DemoFabrica"
        Me.Text = "DemoFabrica"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarroBindingSource As BindingSource
    Friend WithEvents AnoNumericUpDown As NumericUpDown
    Friend WithEvents IdNumericUpDown As NumericUpDown
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents LabelCor As Label
    Friend WithEvents ComboBoxCor As ComboBox
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonExcluir As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonFechar As Button
End Class
