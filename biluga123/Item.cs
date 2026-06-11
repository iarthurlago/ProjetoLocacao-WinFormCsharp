using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao
{
    public class Item
    {
        public required string NameI { get; set; }
        public required long ValueI { get; set; }


        public void CadastrarItem(List<Item> ItemList)
        {
            ItemList.Add(this);
        }
    }
}
