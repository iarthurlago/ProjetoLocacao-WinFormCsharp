using System;
using Microsoft.Data.Sqlite;
using SystemyLocacao.Data;

// Alias resolve o conflito CS0118: "Locacao" é namespace E nome de classe ao mesmo tempo.
// EntidadeLocacao aponta direto para a classe, evitando ambiguidade com o namespace.
using EntidadeLocacao = SystemyLocacao.Classes.Locacao;

namespace SystemyLocacao.Repositorios
{
    public class LocacaoRepository
    {
        public void Inserir(EntidadeLocacao locacao)
        {
            using (var conexao = new SqliteConnection(BancoDeDados.StringConexao))
            {
                conexao.Open();

                string query = @"
                    INSERT INTO Locacoes (ClienteId, ItemId, DataRetirada, DataPrevistaDevolucao, Ativa) 
                    VALUES (@ClienteId, @ItemId, @DataRetirada, @DataPrevistaDevolucao, 1)";

                using (var comando = new SqliteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ClienteId", locacao.ClienteLocacao!.Id);
                    comando.Parameters.AddWithValue("@ItemId",                locacao.ItemLocacao!.Id);
                    comando.Parameters.AddWithValue("@DataRetirada",          locacao.DataRetirada.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@DataPrevistaDevolucao", locacao.DataPrevistaDevolucao.ToString("yyyy-MM-dd"));

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
