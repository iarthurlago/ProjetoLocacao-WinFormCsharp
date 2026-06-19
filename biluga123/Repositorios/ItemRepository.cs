using System;
using Microsoft.Data.Sqlite;
using Locacao.Classes;
using SystemyLocacao.Data;

namespace SystemyLocacao.Repositorios
{
    public class ItemRepository
    {
        public void Inserir(Item item)
        {
            using (var conexao = new SqliteConnection(BancoDeDados.StringConexao))
            {
                conexao.Open();

                string query = @"
                    INSERT INTO Itens (Nome, Valor) 
                    VALUES (@Nome, @Valor)";

                using (var comando = new SqliteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome",  item.NameI);
                    comando.Parameters.AddWithValue("@Valor", item.ValueI);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
