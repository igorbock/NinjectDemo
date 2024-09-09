Imports System.ComponentModel
Imports System.Windows.Input
Imports AlphaStandardDemo.Classes
Imports AlphaStandardDemo.Models

Namespace Abstracts
  Public MustInherit Class LinhaMontagemViewModel
    Implements INotifyPropertyChanged

    Private _currentCar As Carro
    Public Property CurrentCar() As Carro
      Get
        Return _currentCar
      End Get
      Set(value As Carro)
        _currentCar = value
        OnPropertyChanged(NameOf(Carro))
      End Set
    End Property
    Private _deliveredCars As Integer
    Public Property DeliveredCars() As Integer
      Get
        Return _deliveredCars
      End Get
      Set(value As Integer)
        _deliveredCars = value
        OnPropertyChanged(NameOf(DeliveredCars))
      End Set
    End Property
    Private _deliveredCarsList As List(Of Carro)
    Public Property DeliveredCarsList() As List(Of Carro)
      Get
        Return _deliveredCarsList
      End Get
      Set(value As List(Of Carro))
        _deliveredCarsList = value
        OnPropertyChanged(NameOf(DeliveredCarsList))
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

    Public Sub New()
      ReadMode()
    End Sub

    Public MustOverride Sub CreateCar(car As Carro)
    Public MustOverride Sub ChangeColor(color As String)
    Public MustOverride Sub ChangeBrand(brand As String)
    Public MustOverride Sub ChangeModel(model As String)
    Public MustOverride Sub ChangeYear(year As Integer)
    Public MustOverride Sub YieldCar(car As Carro)

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

    Public ReadOnly Property CreateCarCommand As ICommand
      Get
        Return New RelayCommand(Sub(car) CreateCar(car))
      End Get
    End Property
    Public ReadOnly Property ChangeColorCommand As ICommand
      Get
        Return New RelayCommand(Sub(color) ChangeColor(color))
      End Get
    End Property
    Public ReadOnly Property ChangeBrandCommand As ICommand
      Get
        Return New RelayCommand(Sub(brand) ChangeBrand(brand))
      End Get
    End Property
    Public ReadOnly Property ChangeModelCommand As ICommand
      Get
        Return New RelayCommand(Sub(model) ChangeModel(model))
      End Get
    End Property
    Public ReadOnly Property YieldCarCommand As ICommand
      Get
        Return New RelayCommand(Sub(car) YieldCar(car))
      End Get
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As String)
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
  End Class
End Namespace
