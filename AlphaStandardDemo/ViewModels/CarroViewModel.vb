Imports System.Drawing
Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Models

Namespace ViewModel
  Public Class CarroViewModel
    Inherits GenericViewModel(Of Carro)

    Private _cores As List(Of Cor)
    Public Property Cores() As List(Of Cor)
      Get
        Return _cores
      End Get
      Set(value As List(Of Cor))
        _cores = value
      End Set
    End Property

    Public Sub New(repository As GenericRepository(Of Carro))
      MyBase.New(repository)
    End Sub

    Protected Overrides Sub Load()
      MyBase.Load()

      Cores = New List(Of Cor) From {
      New Cor With {.Nome = "Vermelho", .Valor = Color.Red.Name},
      New Cor With {.Nome = "Azul", .Valor = Color.Blue.Name},
      New Cor With {.Nome = "Verde", .Valor = Color.Green.Name},
      New Cor With {.Nome = "Laranja", .Valor = Color.Orange.Name},
      New Cor With {.Nome = "Preto", .Valor = Color.Black.Name}
    }
    End Sub
  End Class
End Namespace
