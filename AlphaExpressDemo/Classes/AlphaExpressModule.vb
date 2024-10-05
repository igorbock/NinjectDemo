Imports AlphaAgroDemo
Imports AlphaLib.Interfaces
Imports Ninject.Modules

Public Class AlphaExpressModule
  Inherits NinjectModule

  Public Overrides Sub Load()
    Bind(Of Exemplo).ToSelf()
    Bind(Of DemoFabrica).ToSelf()
    Bind(Of frmCadastro_Safra).ToSelf()
    Bind(Of HomePage).ToSelf()

    Bind(Of INavigator).To(Of NavigatorWindowsForms).InSingletonScope()
  End Sub
End Class
