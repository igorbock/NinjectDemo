Imports AlphaLib.Models
Imports Microsoft.EntityFrameworkCore

Namespace Context
  Public Class DemoDbContext
    Inherits DbContext

    Public Sub New()

    End Sub

    Public Sub New(options As DbContextOptions(Of DemoDbContext))
      MyBase.New(options)
    End Sub

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
      MyBase.OnConfiguring(optionsBuilder)

      optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;")
    End Sub

    Public Property Carros() As DbSet(Of Carro)
  End Class
End Namespace
