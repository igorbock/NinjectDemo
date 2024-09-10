Imports AlphaStandardDemo.Interfaces
Imports AlphaStandardDemo.Models

Public Class Exemplo
  Private ReadOnly Property _fabrica As IFabrica

  Private _cores As List(Of Cor)
  Public Property Cores() As List(Of Cor)
    Get
      Return _cores
    End Get
    Set(value As List(Of Cor))
      _cores = value
    End Set
  End Property

  Public Sub New(fabrica As IFabrica)
    InitializeComponent()

    _fabrica = fabrica

    Cores = New List(Of Cor) From {
      New Cor With {.Nome = "Vermelho", .Valor = Color.Red.Name},
      New Cor With {.Nome = "Azul", .Valor = Color.Blue.Name},
      New Cor With {.Nome = "Verde", .Valor = Color.Green.Name},
      New Cor With {.Nome = "Laranja", .Valor = Color.Orange.Name},
      New Cor With {.Nome = "Preto", .Valor = Color.Black.Name}
    }

    ComboBoxCores.DataSource = Cores
  End Sub

  Private Sub ButtonCriarCarro_Click(sender As Object, e As EventArgs) Handles ButtonCriarCarro.Click
    Try
      _fabrica.CriarCarro()

      LabelMarca.Text = $"Marca: {_fabrica.Carro.Marca}"
      LabelModelo.Text = $"Modelo: {_fabrica.Carro.Modelo}"
      ColorPanel.BackColor = Color.FromName(_fabrica.Carro.Cor)
      LabelAno.Text = $"Ano: {_fabrica.Carro.Ano}"

      ComboBoxCores.SelectedValue = _fabrica.Carro.Cor
      TextBoxMarca.Text = _fabrica.Carro.Marca
      TextBoxModelo.Text = _fabrica.Carro.Modelo
      NumericAno.Value = _fabrica.Carro.Ano
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub ButtonPintarCarro_Click(sender As Object, e As EventArgs) Handles ButtonPintarCarro.Click
    _fabrica.Carro.Cor = ComboBoxCores.SelectedValue
    ColorPanel.BackColor = ComboBoxCores.SelectedValue
  End Sub

  Private Sub ButtonAlterar_Click(sender As Object, e As EventArgs) Handles ButtonAlterar.Click
    Try
      If String.IsNullOrEmpty(TextBoxMarca.Text) Then Throw New Exception("Preencha a Marca")
      If String.IsNullOrEmpty(TextBoxModelo.Text) Then Throw New Exception("Preencha o Modelo")

      _fabrica.Carro.Marca = TextBoxMarca.Text
      _fabrica.Carro.Modelo = TextBoxModelo.Text
      _fabrica.Carro.Ano = NumericAno.Value

      LabelMarca.Text = $"Marca: {_fabrica.Carro.Marca}"
      LabelModelo.Text = $"Modelo: {_fabrica.Carro.Modelo}"
      LabelAno.Text = $"Ano: {_fabrica.Carro.Ano}"
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub ButtonEntregar_Click(sender As Object, e As EventArgs) Handles ButtonEntregar.Click
    Try
      LabelMarca.Text = $"Marca"
      LabelModelo.Text = $"Modelo"
      LabelAno.Text = $"Ano"

      LabelCarrosEntregues.Text = $"Carros entregues: {_fabrica.Entregues}"
      _fabrica.ListaCarrosEntregues.Add(_fabrica.Carro.ToString())
      LabelCarros.Text = String.Join($"{Environment.NewLine}", _fabrica.ListaCarrosEntregues)

      _fabrica.EntregarCarro()
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub
End Class