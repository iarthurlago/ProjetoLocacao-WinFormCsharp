using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string SenhaHash { get; set; }
        public Papel Papel { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string login, string senhaHash, Papel papel)
        {
            Id = id;
            Nome = nome;
            Login = login;
            SenhaHash = senhaHash;
            Papel = papel;
        }
    }
}
