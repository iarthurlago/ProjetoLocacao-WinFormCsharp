using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao
{
    internal class Item
    {
        public required string NameI { get; set; }
        public required string ValueI { get; set; }


        public void CadastrarItem(List<Item> ItemList)
        {
            ItemList.Add(this);
        }
    }
}
