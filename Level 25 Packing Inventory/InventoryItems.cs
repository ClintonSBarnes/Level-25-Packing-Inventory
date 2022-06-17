using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    public class InventoryItems
    {
        public float _weight;
        public float _volume;

        public InventoryItems(float weight, float volume)
        {
            _weight = weight;
            _volume = volume;
        }
    }
}
