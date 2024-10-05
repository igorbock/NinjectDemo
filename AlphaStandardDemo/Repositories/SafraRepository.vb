Imports System.Data
Imports AlphaLib.Abstracts
Imports AlphaStandardDemo.Context
Imports AlphaLib.Models

Namespace Repositories
  Public Class SafraRepository
    Inherits GenericRepository(Of Safra)

    Public Sub New(context As DemoDbContext, connection As String)
      MyBase.New(context, connection)
    End Sub

    Public Overrides Sub Create(entity As Safra)
      ExecuteNonQuery($"INSERT INTO cadastros.safras (""Descricao"", ""Inativo"", ""DataInicial"", ""DataFinal"") VALUES ('{entity.Descricao}', {entity.Inativo.ToString()}, '{entity.DataInicial}', '{entity.DataFinal}');")
    End Sub

    Public Overrides Sub Update(entity As Safra)
      ExecuteNonQuery($"UPDATE cadastros.safras SET ""Id""={entity.Id}, ""Descricao""='{entity.Descricao}', ""Inativo""={entity.Inativo.ToString()}, ""DataInicial""='{entity.DataInicial}', ""DataFinal""='{entity.DataFinal}';")
    End Sub

    Public Overrides Sub Delete(id As Integer)
      ExecuteNonQuery($"DELETE FROM cadastros.safras WHERE ""Id""={id}")
    End Sub

    Public Overrides Function GetAll() As ComponentModel.BindingList(Of Safra)
      Dim safras As New ComponentModel.BindingList(Of Safra)
      Dim query As String = "SELECT * FROM cadastros.safras;"
      Using dt As IDataReader = ExecuteDR(query)
        While dt.Read()
          safras.Add(New Safra With {.Id = dt!Id, .Descricao = dt!Descricao, .Inativo = dt!Inativo, .DataInicial = dt!DataInicial, .DataFinal = dt!DataFinal})
        End While
      End Using
      Return safras
    End Function

    Public Overrides Function GetById(id As Integer) As Safra
      Dim safra As New Safra
      Dim query As String = $"SELECT * FROM cadastros.safras WHERE ""Id""={id};"
      Using dt As IDataReader = ExecuteDR(query)
        While dt.Read()
          safra = New Safra With {.Id = dt!Id, .Descricao = dt!Descricao, .Inativo = dt!Inativo, .DataInicial = dt!DataInicial, .DataFinal = dt!DataFinal}
        End While
      End Using
      Return safra
    End Function
  End Class
End Namespace
