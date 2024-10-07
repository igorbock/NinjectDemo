Imports AlphaLib.Abstracts
Imports AlphaLib.Messenger
Imports AlphaLib.Models
Imports AlphaStandardDemo.ViewModel

Public Class DemoFabrica
  Private ReadOnly Property _viewModel As LinhaMontagemActionsHandler

  Public Sub New(viewModel As LinhaMontagemActionsHandler)
    InitializeComponent()

    _viewModel = viewModel

    DataGridView.DataBindings.Add("DataSource", _viewModel, NameOf(_viewModel.ListTypeT), True, DataSourceUpdateMode.OnPropertyChanged)
    ComboBoxCor.DataBindings.Add("DataSource", _viewModel, NameOf(_viewModel.Cores), True, DataSourceUpdateMode.OnPropertyChanged)
    IdNumericUpDown.DataBindings.Add("Value", _viewModel, "CurrentItem.Id", True, DataSourceUpdateMode.OnPropertyChanged)
    MarcaTextBox.DataBindings.Add("Text", _viewModel, "CurrentItem.Marca", True, DataSourceUpdateMode.OnPropertyChanged)
    ModeloTextBox.DataBindings.Add("Text", _viewModel, "CurrentItem.Modelo", True, DataSourceUpdateMode.OnPropertyChanged)
    ComboBoxCor.DataBindings.Add("SelectedValue", _viewModel, "CurrentItem.Cor", True, DataSourceUpdateMode.OnPropertyChanged)
    AnoNumericUpDown.DataBindings.Add("Value", _viewModel, "CurrentItem.Ano", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonNovo.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonNewEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonEditar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonUpdateEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonExcluir.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonDeleteEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonFechar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCloseEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonSalvar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonSaveEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonCancelar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCancelEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    MarcaTextBox.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ModeloTextBox.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ComboBoxCor.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    AnoNumericUpDown.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler Load, Sub() _viewModel.LoadCommand.Execute(Nothing)
    AddHandler ButtonNovo.Click, Sub() _viewModel.CreateCommand.Execute(Nothing)
    AddHandler ButtonEditar.Click, Sub() _viewModel.UpdateCommand.Execute(Nothing)
    AddHandler ButtonExcluir.Click, Sub() _viewModel.DeleteCommand.Execute(Nothing)
    AddHandler ButtonFechar.Click, Sub() Close()
    AddHandler ButtonSalvar.Click, Sub() _viewModel.SaveCommand.Execute(Nothing)
    AddHandler ButtonCancelar.Click, Sub() _viewModel.CancelCommand.Execute(Nothing)
    AddHandler DataGridView.CellClick, Sub(sender, e) CellClick(e, DataGridView)
    AddHandler _viewModel.ErrorOcurred, Sub(sender, e) MessageBox.Show(e.GetException().Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    AddHandler FormClosed, Sub() _viewModel.CloseFormCommand.Execute(New MensagemTeste With {.Titulo = "Teste", .Texto = "Primeira comunicação de mensageria entre ViewModels."})
  End Sub

  Private Sub CellClick(e As DataGridViewCellEventArgs, grid As DataGridView)
    If e.RowIndex >= 0 Then
      Dim linhaSelecionada As DataGridViewRow = grid.Rows(e.RowIndex)
      Dim typeTInstance As Carro = linhaSelecionada.DataBoundItem
      _viewModel.CurrentItem = typeTInstance
    End If
  End Sub
End Class