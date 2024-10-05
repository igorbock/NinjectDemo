Imports System.Reflection
Imports AlphaAgroDemo
Imports AlphaLib.Interfaces
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

    For Each asb As Assembly In AppDomain.CurrentDomain.GetAssemblies()
      Try
        For Each type As Type In asb.GetTypes()
          If GetType(Form).IsAssignableFrom(type) AndAlso type.Name = pageName Then
            Dim form As Form = CType(_kernel.Get(type), Form)
            If form IsNot Nothing Then Return form
          End If
        Next
      Catch ex As ReflectionTypeLoadException
        MessageBox.Show($"Erro ao carregar tipos do assembly {asb.FullName}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    Next

    Throw New Exception("Formulário não encontrado.")
  End Function
End Class
