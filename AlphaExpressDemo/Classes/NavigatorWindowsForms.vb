Imports System.Reflection
Imports AlphaAgroDemo
Imports AlphaStandardDemo.Interfaces
Imports Ninject

Public Class NavigatorWindowsForms
  Implements INavigator

  Private ReadOnly Property _kernel As IKernel

  Public Sub New(kernel As IKernel)
    _kernel = kernel
  End Sub

  Public Sub ShowPage(pageName As String) Implements INavigator.ShowPage
    Try
      Dim form As Form = GetOpenedOrCreatePage(pageName)
      form.Show()
      form.BringToFront()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function GetOpenedOrCreatePage(pageName As String) As Form
    For i As Integer = 0 To Application.OpenForms.Count - 1
      Dim form As Form = Application.OpenForms.Item(i)
      If form Is Nothing OrElse form.Name <> pageName Then Continue For
      Return form
    Next

    Dim formName As String = $"AlphaAgroDemo.{pageName}"
    Dim formType As Type = Assembly.GetAssembly(GetType(Exemplo)).GetType(formName)
    If formType IsNot Nothing Then
      Dim windowsForm As Form = _kernel.Get(formType)
      If windowsForm IsNot Nothing Then
        Return windowsForm
      Else
        Throw New Exception("Formulário não encontrado.")
      End If
    Else
      Throw New Exception("Formulário não encontrado.")
    End If
  End Function
End Class
