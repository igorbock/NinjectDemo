Imports System.ComponentModel
Imports AlphaStandardDemo.Context
Imports AlphaStandardDemo.Interfaces

Namespace Abstracts
  Public MustInherit Class GenericRepository(Of TypeT As IEntity)

    Protected ReadOnly Property _dbContext As DemoDbContext

    Public Sub New(context As DemoDbContext)
      _dbContext = context
    End Sub

    Public MustOverride Sub Create(entity As TypeT)
    Public MustOverride Function GetAll() As BindingList(Of TypeT)
    Public MustOverride Function GetById(id As Integer) As TypeT
    Public MustOverride Sub Update(entity As TypeT)
    Public MustOverride Sub Delete(id As Integer)
    Public Overridable Sub SaveChanges()
      _dbContext.SaveChanges()
    End Sub
  End Class
End Namespace
