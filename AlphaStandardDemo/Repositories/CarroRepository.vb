Imports System.ComponentModel
Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Context
Imports AlphaStandardDemo.Models
Imports Microsoft.EntityFrameworkCore

Namespace Repositories
  Public Class CarroRepository
    Inherits GenericRepository(Of Carro)

    Public Sub New(context As DemoDbContext)
      MyBase.New(context)

      _dbContext.Carros.Load()
    End Sub

    Public Overrides Sub Create(entity As Carro)
      _dbContext.Carros.Add(entity)
    End Sub

    Public Overrides Sub Update(entity As Carro)
      _dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified
    End Sub

    Public Overrides Sub Delete(id As Integer)
      _dbContext.Carros.Remove(GetById(id))
    End Sub

    Public Overrides Function GetAll() As BindingList(Of Carro)
      Return _dbContext.Carros.Local.ToBindingList()
    End Function

    Public Overrides Function GetById(id As Integer) As Carro
      Return _dbContext.Carros.Find(id)
    End Function
  End Class
End Namespace
