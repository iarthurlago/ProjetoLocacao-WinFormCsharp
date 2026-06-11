using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao
{

    internal class Cliente
    {
        public required string Name { get; set; } 
        public required string Contact { get; set; }
        

        public void CadastrarCliente(List<Cliente> ClienteList)     
        {
            ClienteList.Add(this);
        }


    }
}
