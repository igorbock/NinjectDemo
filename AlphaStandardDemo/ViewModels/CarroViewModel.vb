Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Models

Namespace ViewModel
  Public Class CarroViewModel
    Inherits GenericViewModel(Of Carro)

    Public Sub New(repository As GenericRepository(Of Carro))
      MyBase.New(repository)
    End Sub
  End Class
End Namespace
