using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;

namespace SystemyLocacao.Classes
{
    public class Locacao
    {
        
        public int id { get; set; }
        public Cliente? ClienteLocacao { get; set; }
        public Item? ItemLocacao { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public bool Ativa => DataDevolucao == null;

        public decimal CalcularValorTotal()
        {
            // Garante que não vai quebrar se tentarem calcular sem um item selecionado
            if (ItemLocacao == null) return 0;

            TimeSpan diferenca = DataPrevistaDevolucao.Date - DataRetirada.Date;
            int dias = diferenca.Days;

            if (dias <= 0) dias = 1;

            // Como usamos decimal no Service, garantimos a conversão aqui se necessário
            return (decimal)ItemLocacao.ValueI * dias;
        }
    }
}