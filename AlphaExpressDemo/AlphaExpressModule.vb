Imports AlphaAgroDemo
Imports Ninject.Modules

Public Class AlphaExpressModule
  Inherits NinjectModule

  Public Overrides Sub Load()
    Bind(Of Exemplo).ToSelf()
  End Sub
End Class
