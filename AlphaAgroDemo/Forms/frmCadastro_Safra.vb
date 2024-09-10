Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Models

Public Class frmCadastro_Safra
  Private ReadOnly Property _viewModel As GenericViewModel(Of Safra)

  Public Sub New(viewModel As GenericViewModel(Of Safra))
    InitializeComponent()

    _viewModel = viewModel

    DataGridView.DataBindings.Add("DataSource", _viewModel, NameOf(_viewModel.ListTypeT), True, DataSourceUpdateMode.OnPropertyChanged)
    TextBoxId.DataBindings.Add("Text", _viewModel, "CurrentItem.Id", True, DataSourceUpdateMode.OnPropertyChanged)
    TextBoxDescricao.DataBindings.Add("Text", _viewModel, "CurrentItem.Descricao", True, DataSourceUpdateMode.OnPropertyChanged)
    CheckBoxInativo.DataBindings.Add("Checked", _viewModel, "CurrentItem.Inativo", True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerInicial.DataBindings.Add("Value", _viewModel, "CurrentItem.DataInicial", True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerFinal.DataBindings.Add("Value", _viewModel, "CurrentItem.DataFinal", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonNovo.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonNewEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonEditar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonUpdateEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonExcluir.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonDeleteEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonFechar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCloseEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonSalvar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonSaveEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonCancelar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCancelEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    TextBoxDescricao.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    CheckBoxInativo.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerInicial.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerFinal.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ControlsEnabled), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler Load, Sub() _viewModel.LoadCommand.Execute(Nothing)
    AddHandler ButtonNovo.Click, Sub() _viewModel.CreateCommand.Execute(Nothing)
    AddHandler ButtonEditar.Click, Sub() _viewModel.UpdateCommand.Execute(Nothing)
    AddHandler ButtonExcluir.Click, Sub() _viewModel.DeleteCommand.Execute(Nothing)
    AddHandler ButtonFechar.Click, Sub() Close()
    AddHandler ButtonSalvar.Click, Sub() _viewModel.SaveCommand.Execute(Nothing)
    AddHandler ButtonCancelar.Click, Sub() _viewModel.CancelCommand.Execute(Nothing)
    AddHandler DataGridView.CellClick, Sub(sender, e) CellClick(e, DataGridView)
    AddHandler _viewModel.ErrorOcurred, Sub(sender, e) MessageBox.Show(e.GetException().Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub CellClick(e As DataGridViewCellEventArgs, grid As DataGridView)
    If e.RowIndex >= 0 Then
      Dim linhaSelecionada As DataGridViewRow = grid.Rows(e.RowIndex)
      Dim typeTInstance As Safra = linhaSelecionada.DataBoundItem
      _viewModel.CurrentItem = typeTInstance
    End If
  End Sub
End Class