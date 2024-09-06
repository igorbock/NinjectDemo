Imports AlphaStandardDemo.Interfaces
Imports AlphaStandardDemo.Models

Namespace Services
  Public Class LinhaMontagem
    Implements IFabrica

    Private Property _carro As Carro
    Public Property Carro As Carro Implements IFabrica.Carro
      Get
        Return _carro
      End Get
      Set(value As Carro)
        _carro = value
      End Set
    End Property
    Private Property _entregues As Integer
    Public Property Entregues As Integer Implements IFabrica.Entregues
      Get
        Return _entregues
      End Get
      Set(value As Integer)
        _entregues = value
      End Set
    End Property
    Private Property _listaCarrosEntregues As List(Of String)
    Public Property ListaCarrosEntregues As List(Of String) Implements IFabrica.ListaCarrosEntregues
      Get
        Return _listaCarrosEntregues
      End Get
      Set(value As List(Of String))
        _listaCarrosEntregues = value
      End Set
    End Property

    Public Sub New()
      Entregues = 0
      ListaCarrosEntregues = New List(Of String)
    End Sub

    Public Sub CriarCarro() Implements IFabrica.CriarCarro
      Carro = New Carro() With {.Marca = "Genérica", .Ano = 2024, .Modelo = "Novo", .Cor = Drawing.Color.Blue}
    End Sub

    Public Sub PintarCarro(color As Drawing.Color) Implements IFabrica.PintarCarro
      Carro.Cor = color
    End Sub

    Public Sub MudarMarca(marca As String) Implements IFabrica.MudarMarca
      Carro.Marca = marca
    End Sub

    Public Sub MudarModelo(modelo As String) Implements IFabrica.MudarModelo
      Carro.Modelo = modelo
    End Sub

    Public Sub MudarAno(ano As Integer) Implements IFabrica.MudarAno
      Carro.Ano = ano
    End Sub

    Public Sub EntregarCarro() Implements IFabrica.EntregarCarro
      Carro = Nothing
      Entregues += 1
    End Sub
  End Class
End Namespace
