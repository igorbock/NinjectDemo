Imports AlphaStandardDemo.Interfaces

Namespace Models
  Public Class Carro
    Implements IEntity

    Public Property Id As Integer Implements IEntity.Id
    Public Property Marca As String
    Public Property Modelo As String
    Public Property Cor As Drawing.Color
    Public Property Ano As Integer
    Public Overrides Function ToString() As String
      Return $"{Marca} - {Modelo} - {Ano} - {Cor.Name}"
    End Function
  End Class
End Namespace
