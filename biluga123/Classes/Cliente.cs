using System;

namespace Locacao.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Contato { get; set; }
    }
}
