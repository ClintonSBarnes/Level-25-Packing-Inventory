using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Arrow : InventoryItems
    {
        public int arrowCount;

        public Arrow() : base(.1f, .05f)
        {
        }
    }
}