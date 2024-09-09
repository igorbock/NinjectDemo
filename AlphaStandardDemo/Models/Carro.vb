Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports AlphaStandardDemo.Interfaces

Namespace Models
  <Table("carros", Schema:="cadastros")>
  Public Class Carro
    Implements IEntity

    <Key>
    Public Property Id As Integer Implements IEntity.Id
    Public Property Marca As String
    Public Property Modelo As String
    Public Property Cor As String
    Public Property Ano As Integer

    Public Overrides Function ToString() As String
      Return $"{Marca} - {Modelo} - {Ano} - {Cor}"
    End Function
  End Class
End Namespace
