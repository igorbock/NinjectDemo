Imports AlphaLib.Interfaces

Public Class HomePage

  Private ReadOnly Property _navigator As INavigator

  Public Sub New(navigator As INavigator)
    InitializeComponent()

    _navigator = navigator

    AddHandler ButtonCarro.Click, Sub() _navigator.ShowPage("Exemplo")
    AddHandler ButtonSafra.Click, Sub() _navigator.ShowPage("frmCadastro_Safra")
  End Sub
End Class