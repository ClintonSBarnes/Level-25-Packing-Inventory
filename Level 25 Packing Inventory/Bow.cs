using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Bow : InventoryItems
    {
        public int bowCount;

        public Bow() : base(1f, 4f)
        {
        }
    }
}
