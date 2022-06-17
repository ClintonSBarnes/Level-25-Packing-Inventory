using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Pack
    {
        new float itemLimit;
        new float itemCount;
        new float weightLimit;
        new float weightCount;
        new float volumeLimit;
        new float volumeCount;
        new int arrowCount = 0;
        new int ropeCount = 0;
        new int waterCount = 0;
        new int foodCount = 0;
        new int swordCount = 0;


        public Pack()
        {
            itemLimit = 30f;
            itemCount = 0f;
            weightLimit = 15f;
            weightCount = 0f;
            volumeLimit = 12f;
            volumeCount = 0f;
        }

        public void PackStatus()
        {
            Console.Clear();
            Console.WriteLine($"" +
                $"\nCurrent pack:" +
                $"\nItem Count: {itemCount}/{itemLimit}\n{arrowCount} Arrows, {ropeCount} Ropes, {waterCount} Water, {foodCount} Food, {swordCount} Swords." +
                $"\nWeight: {weightCount}/{weightLimit}" +
                $"\nVolume: {volumeCount}/{volumeLimit}");


        }

        public bool AddOrRemove(string selection, InventoryItems item)
        {
            if (selection == "A")
            {
                if (itemCount == 30f)
                {
                    Console.WriteLine("Your pack is already full.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    return false;
                }
                else if (weightCount + item._weight > weightLimit)
                {
                    Console.WriteLine("That item will excede your pack's weight limit.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    return false;
                }
                else if (volumeCount + item._volume > volumeLimit)
                {
                    Console.WriteLine("That item will excede your pack's volume limit.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    return false;
                }
                else
                    Console.WriteLine("The item has been added to your pack.");
                weightCount += item._weight;
                itemCount += 1;
                volumeCount += item._volume;
                if (item is Arrow)
                {
                    arrowCount++;
                }
                else if (item is Rope)
                {
                    ropeCount++;
                }
                else if (item is Water)
                {
                    waterCount++;
                }
                else if (item is Food)
                {
                    foodCount++;
                }
                else if (item is Sword)
                {
                    swordCount++;
                }

                PackStatus();
                Console.Write("Press any key to continue.");
                Console.ReadKey();
            }
            else if (selection == "R")
            {
                if (item is Arrow && arrowCount > 1)
                {
                    Console.WriteLine("The item has been removed from your pack.");
                    weightCount -= item._weight;
                    itemCount -= 1;
                    volumeCount -= item._volume;
                    arrowCount--;
                }
                else if (item is Rope && ropeCount > 1)
                {
                    Console.WriteLine("The item has been removed from your pack.");
                    weightCount -= item._weight;
                    itemCount -= 1;
                    volumeCount -= item._volume;
                    ropeCount--;
                }
                else if (item is Water && waterCount > 1)
                {
                    Console.WriteLine("The item has been removed from your pack.");
                    weightCount -= item._weight;
                    itemCount -= 1;
                    volumeCount -= item._volume;
                    waterCount--;
                }
                else if (item is Food && foodCount > 1)
                {
                    Console.WriteLine("The item has been removed from your pack.");
                    weightCount -= item._weight;
                    itemCount -= 1;
                    volumeCount -= item._volume;
                    foodCount--;
                }
                else if (item is Sword && swordCount > 1)
                {
                    Console.WriteLine("The item has been removed from your pack.");
                    weightCount -= item._weight;
                    itemCount -= 1;
                    volumeCount -= item._volume;
                    swordCount--;
                }
                else
                {
                    Console.WriteLine("You are not carrying any of those items, so this cannot be removed.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                }
                
                PackStatus();
                Console.Write("Press any key to continue.");
                Console.ReadKey();
            }

            return true;
        }
    }
}