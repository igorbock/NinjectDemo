Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Input
Imports AlphaStandardDemo.Classes
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
    Private _listTypeT As BindingList(Of TypeT)
    Public Property ListTypeT() As BindingList(Of TypeT)
      Get
        Return _listTypeT
      End Get
      Set(value As BindingList(Of TypeT))
        _listTypeT = value
        OnPropertyChanged(NameOf(ListTypeT))
      End Set
    End Property
    Private _buttonNewEnabled As Boolean
    Public Property ButtonNewEnabled() As Boolean
      Get
        Return _buttonNewEnabled
      End Get
      Set(value As Boolean)
        _buttonNewEnabled = value
        OnPropertyChanged(NameOf(ButtonNewEnabled))
      End Set
    End Property
    Private _buttonUpdateEnabled As Boolean
    Public Property ButtonUpdateEnabled() As Boolean
      Get
        Return _buttonUpdateEnabled
      End Get
      Set(value As Boolean)
        _buttonUpdateEnabled = value
        OnPropertyChanged(NameOf(ButtonUpdateEnabled))
      End Set
    End Property
    Private _buttonDeleteEnabled As Boolean
    Public Property ButtonDeleteEnabled() As Boolean
      Get
        Return _buttonDeleteEnabled
      End Get
      Set(value As Boolean)
        _buttonDeleteEnabled = value
        OnPropertyChanged(NameOf(ButtonDeleteEnabled))
      End Set
    End Property
    Private _buttonCloseEnabled As Boolean
    Public Property ButtonCloseEnabled() As Boolean
      Get
        Return _buttonCloseEnabled
      End Get
      Set(value As Boolean)
        _buttonCloseEnabled = value
        OnPropertyChanged(NameOf(ButtonCloseEnabled))
      End Set
    End Property
    Private _buttonSaveEnabled As Boolean
    Public Property ButtonSaveEnabled() As Boolean
      Get
        Return _buttonSaveEnabled
      End Get
      Set(value As Boolean)
        _buttonSaveEnabled = value
        OnPropertyChanged(NameOf(ButtonSaveEnabled))
      End Set
    End Property
    Private _buttonCancelEnabled As Boolean
    Public Property ButtonCancelEnabled() As Boolean
      Get
        Return _buttonCancelEnabled
      End Get
      Set(value As Boolean)
        _buttonCancelEnabled = value
        OnPropertyChanged(NameOf(ButtonCancelEnabled))
      End Set
    End Property
    Private _controlsEnabled As Boolean
    Public Property ControlsEnabled() As Boolean
      Get
        Return _controlsEnabled
      End Get
      Set(value As Boolean)
        _controlsEnabled = value
        OnPropertyChanged(NameOf(ControlsEnabled))
      End Set
    End Property

    Public Sub New(repository As GenericRepository(Of TypeT))
      _repository = repository

      CurrentItem = Activator.CreateInstance(Of TypeT)
      ListTypeT = Activator.CreateInstance(Of BindingList(Of TypeT))
    End Sub

    Protected Overridable Sub Load()
      Try
        ReadMode()
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
        ReadMode()

        ListTypeT = _repository.GetAll()
        CurrentItem = ListTypeT.Last()
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Create()
      Try
        EditMode()
        CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub

    Protected Overridable Sub Cancel()
      Try
        ReadMode()
        If CurrentItem.Id = 0 Then CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub Update()
      Try
        If CurrentItem Is Nothing OrElse CurrentItem.Id = 0 Then Throw New Exception("Selecione um registro")

        CurrentItem = _repository.GetById(_currentItem.Id)
        EditMode()
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

    Public ReadOnly Property LoadCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Load)
      End Get
    End Property
    Public ReadOnly Property SaveCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Save)
      End Get
    End Property
    Public ReadOnly Property CreateCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Create)
      End Get
    End Property
    Public ReadOnly Property CancelCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Cancel)
      End Get
    End Property
    Public ReadOnly Property UpdateCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Update)
      End Get
    End Property
    Public ReadOnly Property DeleteCommand As ICommand
      Get
        Return New RelayCommand(AddressOf Delete)
      End Get
    End Property

    Public Event ErrorOcurred As EventHandler(Of ErrorEventArgs)
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnErrorOcurred(exception As Exception)
      RaiseEvent ErrorOcurred(Me, New ErrorEventArgs(exception))
    End Sub
    Protected Sub OnPropertyChanged(propertyName As String)
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Overridable Sub EditMode()
      ButtonNewEnabled = False
      ButtonUpdateEnabled = False
      ButtonDeleteEnabled = False
      ButtonCloseEnabled = False
      ButtonSaveEnabled = True
      ButtonCancelEnabled = True
      ControlsEnabled = True
    End Sub
    Public Overridable Sub ReadMode()
      ButtonNewEnabled = True
      ButtonUpdateEnabled = True
      ButtonDeleteEnabled = True
      ButtonCloseEnabled = True
      ButtonSaveEnabled = False
      ButtonCancelEnabled = False
      ControlsEnabled = False
    End Sub
  End Class
End Namespace
