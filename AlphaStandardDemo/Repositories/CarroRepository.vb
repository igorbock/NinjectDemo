Imports AlphaLib.Abstracts
Imports AlphaStandardDemo.Context
Imports AlphaLib.Models
Imports Microsoft.EntityFrameworkCore

Namespace Repositories
  Public Class CarroRepository
    Inherits GenericRepository(Of Carro)

    Public Sub New(context As DemoDbContext, connection As String)
      MyBase.New(context, connection)

      _dbContext.Set(Of Carro).Load()
    End Sub
  End Class
End Namespace
