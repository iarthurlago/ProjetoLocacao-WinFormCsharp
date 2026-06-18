using System;
using Microsoft.Data.Sqlite;

namespace SystemyLocacao.Data
{
    public static class BancoDeDados
    {
        // Define o nome do arquivo do banco de dados que será criado na pasta do seu projeto
        private const string NomeBanco = "LocacaoBanco.db";

        // String de conexão necessária para o SQLite encontrar o arquivo (com Chaves Estrangeiras ativas)
        public static string StringConexao => $"Data Source={NomeBanco};Foreign Keys=True;";

        /// <summary>
        /// Inicializa o banco de dados, cria todas as tabelas necessárias 
        /// e insere os papéis padrão do sistema.
        /// </summary>
        public static void InicializarBanco()
        {
            using (var conexao = new SqliteConnection(StringConexao))
            {
                conexao.Open();

                // 1. Script para criação de todas as tabelas do sistema
                string queryTabelas = @"
                    -- Tabela de Papéis (Roles)
                    CREATE TABLE IF NOT EXISTS Papeis (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL UNIQUE
                    );

                    -- Tabela de Usuários com vínculo ao Papel
                    CREATE TABLE IF NOT EXISTS Usuarios (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Login TEXT NOT NULL UNIQUE,
                        SenhaHash TEXT NOT NULL,
                        PapelId INTEGER NOT NULL,
                        FOREIGN KEY (PapelId) REFERENCES Papeis(Id)
                    );

                    -- Mantendo as tabelas anteriores do seu sistema
                    CREATE TABLE IF NOT EXISTS Clientes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Contato TEXT NOT NULL
                    );

                    -- MELHORIA AQUI: Nomes de colunas padronizados (sem o 'I' no final)
                    CREATE TABLE IF NOT EXISTS Itens (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Valor REAL NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Locacoes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ClienteId INTEGER NOT NULL,
                        ItemId INTEGER NOT NULL,
                        DataRetirada TEXT NOT NULL,
                        DataPrevistaDevolucao TEXT NOT NULL,
                        DataDevolucao TEXT,
                        Ativa INTEGER NOT NULL DEFAULT 1,
                        FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
                        FOREIGN KEY (ItemId) REFERENCES Itens(Id)
                    );
                ";

                using (var comando = new SqliteCommand(queryTabelas, conexao))
                {
                    comando.ExecuteNonQuery();
                }

                // 2. Alimenta a tabela de papéis com os dados iniciais obrigatórios
                PopularPapeisPadrao(conexao);
            }
        }

        /// <summary>
        /// Garante que os papéis Administrador, Visualizador e Operador existam no banco.
        /// </summary>
        private static void PopularPapeisPadrao(SqliteConnection conexao)
        {
            string queryPapeis = @"
                INSERT OR IGNORE INTO Papeis (Nome) VALUES ('Administrador');
                INSERT OR IGNORE INTO Papeis (Nome) VALUES ('Visualizador');
                INSERT OR IGNORE INTO Papeis (Nome) VALUES ('Operador');
            ";

            using (var comando = new SqliteCommand(queryPapeis, conexao))
            {
                comando.ExecuteNonQuery();
            }
        }
    }
}