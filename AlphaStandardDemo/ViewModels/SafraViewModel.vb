Imports AlphaLib.Abstracts
Imports AlphaLib.Messenger
Imports AlphaLib.Models

Namespace ViewModel
  Public Class SafraViewModel
    Inherits GenericViewModel(Of Safra)

    Public Sub New(repository As GenericRepository(Of Safra))
      MyBase.New(repository)

      AlphaMessenger.Instance.Subscribe(Of MensagemTeste)(AddressOf ReceberMensagem)
    End Sub

    Private _mensagem As String
    Public Property Mensagem() As String
      Get
        Return _mensagem
      End Get
      Set(value As String)
        _mensagem = value
        OnPropertyChanged(NameOf(Mensagem))
      End Set
    End Property

    Private Sub ReceberMensagem(mensagem As MensagemTeste)
      Me.Mensagem = $"{mensagem.Titulo} - {mensagem.Texto}"
    End Sub
  End Class
End Namespace
