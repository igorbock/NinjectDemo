using AlphaLib.Extensions;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.ComponentModel;
using System.Data;

namespace AlphaLib.Abstracts
{
    public abstract class GenericRepository<TypeT> where TypeT : class
    {
        protected DbContext _dbContext { get; private set; }
        protected NpgsqlConnection _npgsqlConnection { get; private set; }
        protected string _connectionString { get; private set; }

        public GenericRepository(DbContext dbContext, string connection)
        {
            _dbContext = dbContext;
            _npgsqlConnection = new NpgsqlConnection(connection);
            _connectionString = connection;
        }

        public virtual void Create(TypeT entity) => _dbContext.Add(entity);
        public virtual BindingList<TypeT> GetAll() => _dbContext.Set<TypeT>().ToBindingList();
        public virtual TypeT GetById(int id) => _dbContext.Set<TypeT>().Find(id);
        public virtual void Update(TypeT entity) => _dbContext.Entry(entity).State = EntityState.Modified;
        public virtual void Delete(int id) => _dbContext.Remove(GetById(id));
        public virtual void SaveChanges() => _dbContext.SaveChanges();

        protected void ExecuteNonQuery(string query)
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            try
            {
                connection = new NpgsqlConnection(_connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção conforme necessário
            }
            finally
            {
                if (transaction != null && transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                {
                    transaction.Rollback();
                    transaction.Dispose();
                }
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
        }

        protected IDataReader ExecuteDR(string query)
        {
            IDbConnection connection = null;
            IDbDataAdapter dataAdapter = null;
            DataTable dataTable = null;

            try
            {
                connection = _npgsqlConnection;
                dataAdapter = new NpgsqlDataAdapter();

                // Gerar o DataSet
                DataSet dataSet = new DataSet();

                // Abrir a conexão
                connection.Open();

                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Clear();
                    command.CommandType = CommandType.Text;
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataSet);
                }

                // Se for PG passar os nomes das colunas para maiúsculas
                for (int j = 0; j < dataSet.Tables.Count; j++)
                {
                    for (int i = 0; i < dataSet.Tables[j].Columns.Count; i++)
                    {
                        dataSet.Tables[j].Columns[i].ColumnName = dataSet.Tables[j].Columns[i].ColumnName.ToUpper();
                    }
                }

                // Converter o DataTable em DataReader
                dataTable = dataSet.Tables[0];
                return dataTable.CreateDataReader();
            }
            catch (Exception ex)
            {
                // Tratar a exceção conforme necessário
            }
            finally
            {
                // Liberar recursos
                if (dataTable != null)
                {
                    dataTable.Dispose();
                }

                // Liberar o dataAdapter diretamente
                if (dataAdapter is NpgsqlDataAdapter npgsqlDataAdapter)
                {
                    npgsqlDataAdapter.Dispose();
                }

                // Liberar a conexão
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Dispose();
                }
            }

            // Se algo falhar, retornar um DataReader vazio
            return (new DataTable()).CreateDataReader();
        }
    }
}
