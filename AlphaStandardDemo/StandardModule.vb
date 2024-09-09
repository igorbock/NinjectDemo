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

  Public Overrides Sub Load()
    Bind(Of IFabrica).To(Of LinhaMontagem)()
    Bind(Of GenericViewModel(Of Carro)).To(Of CarroViewModel)()

    Bind(Of GenericRepository(Of Carro)).To(Of CarroRepository)()

    Bind(Of DemoDbContext).ToSelf()
  End Sub
End Class
