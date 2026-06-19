using System;
using Locacao.Classes;
using Microsoft.Data.Sqlite;
using SystemyLocacao.Data;

namespace SystemyLocacao.Repositorios
{
    public class UsuarioRepository
    {
        /// <summary>
        /// Busca um usuário no banco de dados pelo Login e mapeia o Papel corretamente.
        /// </summary>
        public Usuario? BuscarPorLogin(string login)
        {
            using (var conexao = new SqliteConnection(BancoDeDados.StringConexao))
            {
                conexao.Open();

                string query = "SELECT Id, Nome, Login, SenhaHash, PapelId FROM Usuarios WHERE Login = @Login LIMIT 1";

                using (var comando = new SqliteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Login", login);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id        = Convert.ToInt32(reader["Id"]);
                            usuario.Nome = reader["Nome"].ToString()!;
                            usuario.Login = reader["Login"].ToString()!;
                            usuario.SenhaHash = reader["SenhaHash"].ToString()!;

                            // Converte o PapelId numérico do banco para o enum Papel correto.
                            // Sem isso todo usuário logava como Visualizador independente do cadastro.
                            usuario.Papel = (Papel)Convert.ToInt32(reader["PapelId"]);

                            return usuario;
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Insere um novo usuário no banco. Chamado pelo UsuarioService após o hash da senha.
        /// </summary>
        public void Inserir(Usuario usuario)
        {
            using (var conexao = new SqliteConnection(BancoDeDados.StringConexao))
            {
                conexao.Open();

                string query = @"
                    INSERT INTO Usuarios (Nome, Login, SenhaHash, PapelId)
                    VALUES (@Nome, @Login, @SenhaHash, @PapelId)";

                using (var comando = new SqliteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome",      usuario.Nome);
                    comando.Parameters.AddWithValue("@Login",     usuario.Login);
                    comando.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    // Converte o enum Papel de volta para o inteiro que o banco espera
                    comando.Parameters.AddWithValue("@PapelId",   (int)usuario.Papel);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
