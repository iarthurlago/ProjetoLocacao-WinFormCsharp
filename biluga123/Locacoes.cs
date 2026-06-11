using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Locacao
{
    public class Locacao
    {
        internal required Cliente ClienteLocacao { get; set; }

        public Item ItemLocacao { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; } // Nullable: se for null, significa que ainda não foi devolvido (Ativa)

        // Propriedade que nos diz se a locação está ativa
        public bool Ativa => DataDevolucao == null;

        // Requisito: O sistema calcula o valor total com base nos dias e no valor diário do item
        public decimal CalcularValorTotal()
        {
            TimeSpan diferenca = DataPrevistaDevolucao.Date - DataRetirada.Date;
            int dias = diferenca.Days;

            if (dias <= 0) dias = 1; // Garante pelo menos 1 diária se pegar e devolver no mesmo dia

            return ItemLocacao.ValueI * dias;
        }
    }
}