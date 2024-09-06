Imports AlphaAgroDemo
Imports AlphaStandardDemo
Imports Ninject

Public Module Program
  Private kernel As IKernel

  <STAThread()>
  Sub Main()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)

    kernel = New StandardKernel(New AlphaExpressModule(), New StandardModule())

    Application.Run(kernel.Get(Of Exemplo))
  End Sub
End Module
