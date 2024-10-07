<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro_Safra
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colDataInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxDescricao = New System.Windows.Forms.TextBox()
        Me.DateTimePickerInicial = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFinal = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxInativo = New System.Windows.Forms.CheckBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.LabelDecricao = New System.Windows.Forms.Label()
        Me.LabelDataInicial = New System.Windows.Forms.Label()
        Me.LabelDataFinal = New System.Windows.Forms.Label()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.LabelTesteDeMensageria = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDescricao, Me.colInativo, Me.colDataInicial, Me.colDataFinal})
        Me.DataGridView.Location = New System.Drawing.Point(12, 178)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(624, 201)
        Me.DataGridView.TabIndex = 0
        '
        'colId
        '
        Me.colId.DataPropertyName = "Id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colDescricao
        '
        Me.colDescricao.DataPropertyName = "Descricao"
        Me.colDescricao.HeaderText = "Descrição"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.ReadOnly = True
        '
        'colInativo
        '
        Me.colInativo.DataPropertyName = "Inativo"
        Me.colInativo.HeaderText = "Inativo"
        Me.colInativo.Name = "colInativo"
        Me.colInativo.ReadOnly = True
        Me.colInativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colInativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colDataInicial
        '
        Me.colDataInicial.DataPropertyName = "DataInicial"
        Me.colDataInicial.HeaderText = "Data Inicial"
        Me.colDataInicial.Name = "colDataInicial"
        Me.colDataInicial.ReadOnly = True
        '
        'colDataFinal
        '
        Me.colDataFinal.DataPropertyName = "DataFinal"
        Me.colDataFinal.HeaderText = "Data Final"
        Me.colDataFinal.Name = "colDataFinal"
        Me.colDataFinal.ReadOnly = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Location = New System.Drawing.Point(87, 12)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxId.TabIndex = 1
        '
        'TextBoxDescricao
        '
        Me.TextBoxDescricao.Location = New System.Drawing.Point(87, 38)
        Me.TextBoxDescricao.Name = "TextBoxDescricao"
        Me.TextBoxDescricao.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxDescricao.TabIndex = 2
        '
        'DateTimePickerInicial
        '
        Me.DateTimePickerInicial.Location = New System.Drawing.Point(87, 87)
        Me.DateTimePickerInicial.Name = "DateTimePickerInicial"
        Me.DateTimePickerInicial.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerInicial.TabIndex = 3
        '
        'DateTimePickerFinal
        '
        Me.DateTimePickerFinal.Location = New System.Drawing.Point(87, 113)
        Me.DateTimePickerFinal.Name = "DateTimePickerFinal"
        Me.DateTimePickerFinal.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerFinal.TabIndex = 4
        '
        'CheckBoxInativo
        '
        Me.CheckBoxInativo.AutoSize = True
        Me.CheckBoxInativo.Location = New System.Drawing.Point(87, 64)
        Me.CheckBoxInativo.Name = "CheckBoxInativo"
        Me.CheckBoxInativo.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxInativo.TabIndex = 5
        Me.CheckBoxInativo.Text = "Inativo"
        Me.CheckBoxInativo.UseVisualStyleBackColor = True
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(21, 15)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(16, 13)
        Me.LabelId.TabIndex = 6
        Me.LabelId.Text = "Id"
        '
        'LabelDecricao
        '
        Me.LabelDecricao.AutoSize = True
        Me.LabelDecricao.Location = New System.Drawing.Point(21, 41)
        Me.LabelDecricao.Name = "LabelDecricao"
        Me.LabelDecricao.Size = New System.Drawing.Size(50, 13)
        Me.LabelDecricao.TabIndex = 7
        Me.LabelDecricao.Text = "Decrição"
        '
        'LabelDataInicial
        '
        Me.LabelDataInicial.AutoSize = True
        Me.LabelDataInicial.Location = New System.Drawing.Point(21, 87)
        Me.LabelDataInicial.Name = "LabelDataInicial"
        Me.LabelDataInicial.Size = New System.Drawing.Size(60, 13)
        Me.LabelDataInicial.TabIndex = 8
        Me.LabelDataInicial.Text = "Data Inicial"
        '
        'LabelDataFinal
        '
        Me.LabelDataFinal.AutoSize = True
        Me.LabelDataFinal.Location = New System.Drawing.Point(21, 119)
        Me.LabelDataFinal.Name = "LabelDataFinal"
        Me.LabelDataFinal.Size = New System.Drawing.Size(55, 13)
        Me.LabelDataFinal.TabIndex = 9
        Me.LabelDataFinal.Text = "Data Final"
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(12, 149)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNovo.TabIndex = 10
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(93, 149)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 11
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.Location = New System.Drawing.Point(174, 149)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExcluir.TabIndex = 12
        Me.ButtonExcluir.Text = "Excluir"
        Me.ButtonExcluir.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(255, 149)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFechar.TabIndex = 13
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Location = New System.Drawing.Point(336, 149)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalvar.TabIndex = 14
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(417, 149)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 15
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'LabelTesteDeMensageria
        '
        Me.LabelTesteDeMensageria.AutoSize = True
        Me.LabelTesteDeMensageria.Location = New System.Drawing.Point(385, 15)
        Me.LabelTesteDeMensageria.Name = "LabelTesteDeMensageria"
        Me.LabelTesteDeMensageria.Size = New System.Drawing.Size(107, 13)
        Me.LabelTesteDeMensageria.TabIndex = 16
        Me.LabelTesteDeMensageria.Text = "Teste de Mensageria"
        '
        'frmCadastro_Safra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 388)
        Me.Controls.Add(Me.LabelTesteDeMensageria)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonExcluir)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.LabelDataFinal)
        Me.Controls.Add(Me.LabelDataInicial)
        Me.Controls.Add(Me.LabelDecricao)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.CheckBoxInativo)
        Me.Controls.Add(Me.DateTimePickerFinal)
        Me.Controls.Add(Me.DateTimePickerInicial)
        Me.Controls.Add(Me.TextBoxDescricao)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "frmCadastro_Safra"
        Me.Text = "frmCadastro_Safra"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxDescricao As TextBox
    Friend WithEvents DateTimePickerInicial As DateTimePicker
    Friend WithEvents DateTimePickerFinal As DateTimePicker
    Friend WithEvents CheckBoxInativo As CheckBox
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelDecricao As Label
    Friend WithEvents LabelDataInicial As Label
    Friend WithEvents LabelDataFinal As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colDescricao As DataGridViewTextBoxColumn
    Friend WithEvents colInativo As DataGridViewCheckBoxColumn
    Friend WithEvents colDataInicial As DataGridViewTextBoxColumn
    Friend WithEvents colDataFinal As DataGridViewTextBoxColumn
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonExcluir As Button
    Friend WithEvents ButtonFechar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents LabelTesteDeMensageria As Label
End Class
