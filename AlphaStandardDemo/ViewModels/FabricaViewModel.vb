Imports System.Drawing
Imports AlphaLib.Abstracts
Imports AlphaLib.Messenger
Imports AlphaLib.Models

Namespace ViewModel
  Public Class FabricaViewModel
    Inherits LinhaMontagemActionsHandler

    Public Sub New(carroRepository As GenericRepository(Of Carro))
      MyBase.New(carroRepository)

      DeliveredCarsList = New List(Of Carro)
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

    Public Overrides Sub CreateCar(car As Carro)
      CurrentCar = car
    End Sub

    Public Overrides Sub ChangeColor(color As String)
      CurrentCar.Cor = color
    End Sub

    Public Overrides Sub ChangeBrand(brand As String)
      CurrentCar.Marca = brand
    End Sub

    Public Overrides Sub ChangeModel(model As String)
      CurrentCar.Marca = model
    End Sub

    Public Overrides Sub ChangeYear(year As Integer)
      CurrentCar.Ano = year
    End Sub

    Public Overrides Sub YieldCar(car As Carro)
      CurrentCar = New Carro()
      DeliveredCarsList.Add(car)
    End Sub

    Public Overrides Sub CloseForm(mensagem As MensagemTeste)
      AlphaMessenger.Instance.Publish(mensagem)
    End Sub
  End Class
End Namespace
