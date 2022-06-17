using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Sword : InventoryItems
    {
        public int swordCount;
        public Sword() : base(5f, 3f)
        {
        }
    }
}
