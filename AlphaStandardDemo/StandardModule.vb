Imports AlphaStandardDemo.Interfaces
Imports AlphaStandardDemo.Services
Imports Ninject.Modules

Public Class StandardModule
  Inherits NinjectModule

  Public Overrides Sub Load()
    Bind(Of IFabrica).To(Of LinhaMontagem)()
  End Sub
End Class
