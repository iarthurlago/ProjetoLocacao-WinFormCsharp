using System;
using Microsoft.Data.Sqlite;
using Locacao.Classes;
using SystemyLocacao.Data;

namespace SystemyLocacao.Repositorios
{
    public class ClienteRepository
    {
        /// <summary>
        /// Insere um novo cliente na tabela Clientes do banco de dados.
        /// </summary>
        public void Inserir(Cliente cliente)
        {
            using (var conexao = new SqliteConnection(BancoDeDados.StringConexao))
            {
                conexao.Open();

                string query = "INSERT INTO Clientes (Nome, Contato) VALUES (@Nome, @Contato)";

                using (var comando = new SqliteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome",    cliente.Nome);
                    comando.Parameters.AddWithValue("@Contato", cliente.Contato);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
