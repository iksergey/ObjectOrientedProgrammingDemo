using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex023_Inheritance.Items
{
    abstract class Item 
    {
        public Item(string itemName)
        {
            this.itemName = itemName;
        }
        protected string itemName;

        public string ItemName => itemName;
    }

}
