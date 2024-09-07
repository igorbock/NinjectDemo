Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.IO
Imports AlphaStandardDemo.Interfaces

Namespace Abstracts
  Public MustInherit Class GenericViewModel(Of TypeT As IEntity)
    Implements INotifyPropertyChanged

    Private ReadOnly Property _repository As GenericRepository(Of TypeT)

    Private _currentItem As TypeT
    Public Property CurrentItem() As TypeT
      Get
        Return _currentItem
      End Get
      Set(value As TypeT)
        _currentItem = value
        OnPropertyChanged(NameOf(CurrentItem))
      End Set
    End Property
    Private _listTypeT As ObservableCollection(Of TypeT)
    Public Property ListTypeT() As ObservableCollection(Of TypeT)
      Get
        Return _listTypeT
      End Get
      Set(value As ObservableCollection(Of TypeT))
        _listTypeT = value
        OnPropertyChanged(NameOf(ListTypeT))
      End Set
    End Property

    Public Sub New(repository As GenericRepository(Of TypeT))
      _repository = repository

      CurrentItem = Activator.CreateInstance(Of TypeT)
      ListTypeT = Activator.CreateInstance(Of ObservableCollection(Of TypeT))
    End Sub

    Protected Overridable Sub Load()
      Try
        CurrentItem = Activator.CreateInstance(Of TypeT)
        ListTypeT = _repository.GetAll()
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Save()
      Try
        If CurrentItem.Id = 0 Then
          _repository.Create(_currentItem)
        Else
          _repository.Update(_currentItem)
        End If

        _repository.SaveChanges()

        ListTypeT = _repository.GetAll()
        CurrentItem = ListTypeT.Last()
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Create()
      Try
        CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub

    Protected Overridable Sub Cancel()
      Try
        If CurrentItem.Id = 0 Then CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Update()
      Try
        If CurrentItem Is Nothing OrElse CurrentItem.Id = 0 Then Throw New Exception("Selecione um registro")

        CurrentItem = _repository.GetById(_currentItem.Id)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Delete()
      Try
        If CurrentItem.Id = 0 Then Throw New Exception("Selecione um registro")

        _repository.Delete(_currentItem.Id)
        _repository.SaveChanges()

        ListTypeT = _repository.GetAll()
        CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub

    Public Event ErrorOcurred As EventHandler(Of ErrorEventArgs)
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnErrorOcurred(exception As Exception)
      RaiseEvent ErrorOcurred(Me, New ErrorEventArgs(exception))
    End Sub
    Protected Sub OnPropertyChanged(propertyName As String)
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
  End Class
End Namespace
