Imports AlphaStandardDemo.Models

Namespace Interfaces
  Public Interface IFabrica
    Property Carro As Carro
    Property Entregues As Integer
    Property ListaCarrosEntregues As List(Of String)
    Sub CriarCarro()
    Sub PintarCarro(color As Drawing.Color)
    Sub MudarMarca(marca As String)
    Sub MudarModelo(modelo As String)
    Sub MudarAno(ano As Integer)
    Sub EntregarCarro()
  End Interface
End Namespace
