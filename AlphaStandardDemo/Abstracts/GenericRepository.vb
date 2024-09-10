Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports AlphaStandardDemo.Context
Imports AlphaStandardDemo.Interfaces
Imports Npgsql

Namespace Abstracts
  Public MustInherit Class GenericRepository(Of TypeT As IEntity)

    Protected ReadOnly Property _dbContext As DemoDbContext
    Protected ReadOnly Property _npgsqlConnection As NpgsqlConnection
    Protected ReadOnly Property _connectionString As String

    'Construtor para testes unitários com Moq
    Public Sub New()
    End Sub

    Public Sub New(context As DemoDbContext, connection As String)
      _dbContext = context
      _npgsqlConnection = New NpgsqlConnection(connection)
      _connectionString = connection
    End Sub

    Public MustOverride Sub Create(entity As TypeT)
    Public MustOverride Function GetAll() As BindingList(Of TypeT)
    Public MustOverride Function GetById(id As Integer) As TypeT
    Public MustOverride Sub Update(entity As TypeT)
    Public MustOverride Sub Delete(id As Integer)
    Public Overridable Sub SaveChanges()
      _dbContext.SaveChanges()
    End Sub

    Protected Sub ExecuteNonQuery(query As String)
      Dim connection As IDbConnection = Nothing
      Dim transaction As IDbTransaction = Nothing
      Try
        connection = New NpgsqlConnection(_connectionString) '_npgsqlConnection
        connection.Open()
        transaction = connection.BeginTransaction()
        Using command As IDbCommand = connection.CreateCommand()
          command.CommandText = query
          command.CommandType = CommandType.Text
          command.Transaction = transaction
          command.ExecuteNonQuery()
          transaction.Commit()
        End Using
      Catch ex As Exception

      Finally
        If transaction IsNot Nothing AndAlso transaction.Connection IsNot Nothing AndAlso transaction.Connection.State = ConnectionState.Open Then
          transaction.Rollback()
          transaction.Dispose()
        End If
        If connection IsNot Nothing Then
          If connection.State = ConnectionState.Open Then connection.Close()
          connection.Dispose()
        End If
      End Try
    End Sub
    Protected Function ExecuteDR(query As String) As IDataReader
      Dim connection As IDbConnection = Nothing
      Dim dataAdapter As IDbDataAdapter = Nothing
      Dim dataTable As DataTable = Nothing
      Try
        connection = _npgsqlConnection
        dataAdapter = New NpgsqlDataAdapter()
        ' Gerar o dataSet
        Dim dataSet As New DataSet()
        ' Abrir a conexão
        connection.Open()
        Using command As IDbCommand = connection.CreateCommand()
          command.CommandText = query
          command.Parameters.Clear()
          command.CommandType = CommandType.Text
          dataAdapter.SelectCommand = command
          dataAdapter.Fill(dataSet)
        End Using
        ' Se for PG passar os nomes das colunas para maiúsculas
        For j As Integer = 0 To dataSet.Tables.Count - 1
          For i As Integer = 0 To dataSet.Tables(j).Columns.Count - 1
            dataSet.Tables(j).Columns(i).ColumnName = dataSet.Tables(j).Columns(i).ColumnName.ToUpper()
          Next
        Next
        ' Converter o DataTable em DataReader
        dataTable = dataSet.Tables(0)
        Return dataTable.CreateDataReader()
      Catch ex As Exception
      Finally
        'Liberar recursos
        If dataTable IsNot Nothing Then
          dataTable.Dispose()
        End If
        'Liberar o dataAdapter diretamente
        If TypeOf dataAdapter Is NpgsqlDataAdapter Then
          DirectCast(dataAdapter, NpgsqlDataAdapter).Dispose()
        ElseIf TypeOf dataAdapter Is NpgsqlDataAdapter Then
          DirectCast(dataAdapter, NpgsqlDataAdapter).Dispose()
        End If
        'Liberar a conexão
        If connection IsNot Nothing Then
          If connection.State = ConnectionState.Open Then
            connection.Close()
          End If
          connection.Dispose()
        End If
      End Try
      ' Se algo falhar, retornar um DataReader vazio
      Return (New DataTable()).CreateDataReader()
    End Function
  End Class
End Namespace
