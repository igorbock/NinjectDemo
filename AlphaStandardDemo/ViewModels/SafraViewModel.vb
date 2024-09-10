﻿Imports AlphaStandardDemo.Abstracts
Imports AlphaStandardDemo.Models

Namespace ViewModel
  Public Class SafraViewModel
    Inherits GenericViewModel(Of Safra)

    Public Sub New(repository As GenericRepository(Of Safra))
      MyBase.New(repository)
    End Sub
  End Class
End Namespace
