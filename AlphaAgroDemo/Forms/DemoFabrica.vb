Imports AlphaStandardDemo.Abstracts

Public Class DemoFabrica
  Private ReadOnly Property _viewModel As LinhaMontagemViewModel

  Public Sub New(viewModel As LinhaMontagemViewModel)
    InitializeComponent()

    _viewModel = viewModel

    ButtonNovo.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonNewEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonEditar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonUpdateEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonExcluir.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonDeleteEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonFechar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCloseEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonSalvar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonSaveEnabled), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonCancelar.DataBindings.Add("Enabled", _viewModel, NameOf(_viewModel.ButtonCancelEnabled), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler ButtonNovo.Click, Sub() _viewModel.CreateCarCommand.Execute(_viewModel.CurrentCar)
  End Sub
End Class