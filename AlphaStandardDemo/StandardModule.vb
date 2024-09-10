Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Context
Imports AlphaStandardDemo.Interfaces
Imports AlphaStandardDemo.Models
Imports AlphaStandardDemo.Repositories
Imports AlphaStandardDemo.Services
Imports AlphaStandardDemo.ViewModel
Imports Ninject.Modules

Public Class StandardModule
  Inherits NinjectModule

  Private ReadOnly Property _sqlConnection As String = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;"

  Public Overrides Sub Load()
    Bind(Of IFabrica).To(Of LinhaMontagem)()
    Bind(Of GenericViewModel(Of Carro)).To(Of CarroViewModel)()
    Bind(Of GenericViewModel(Of Safra)).To(Of SafraViewModel)()

    Bind(Of GenericRepository(Of Carro)).To(Of CarroRepository)().WithConstructorArgument("connection", _sqlConnection)
    Bind(Of GenericRepository(Of Safra)).To(Of SafraRepository)().WithConstructorArgument("connection", _sqlConnection)

    Bind(Of DemoDbContext).ToSelf()
  End Sub
End Class
