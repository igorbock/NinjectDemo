Imports System.Drawing
Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Models

Namespace ViewModel
  Public Class FabricaViewModel
    Inherits LinhaMontagemViewModel

    Public Sub New()
      DeliveredCarsList = New List(Of Carro)
    End Sub

    Public Overrides Sub CreateCar(car As Carro)
      CurrentCar = car
    End Sub

    Public Overrides Sub ChangeColor(color As Color)
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
  End Class
End Namespace
