Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports AlphaStandardDemo.Interfaces

Namespace Models
  <Table("safras", Schema:="cadastros")>
  Public Class Safra
    Implements IEntity

    <Key>
    Public Property Id As Integer Implements IEntity.Id

    <StringLength(100)>
    Public Property Descricao As String
    Public Property Inativo As Boolean?
    Public Property DataInicial As Date?
    Public Property DataFinal As Date?
  End Class
End Namespace
