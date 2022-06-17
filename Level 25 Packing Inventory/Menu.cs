using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_25_Packing_Inventory
{
    internal class Menu
    {
        public string _selection = " ";


        public void printMenu()
        {
            Console.Clear();
            Console.WriteLine(
            "\n-----------" +
            "\n| 1. Arrow |" +
            "\n| 2. Rope  |" +
            "\n| 3. Water |" +
            "\n| 4. Food  |" +
            "\n| 5. Sword |" +
            "\n------------");
        }

        public void Selection()
        {
            string selection = " ";
            


            while (_selection != "A" &&  _selection != "R")
            {
                Console.WriteLine("\nWould you like to (A)dd or (R)emove an item?");
                selection = Console.ReadLine().ToUpper();

                if (selection == "A" || selection == "R")
                {
                    _selection = selection;
                }
                else
                {
                    Console.WriteLine("That was not a valid option.");
                }
            }
        }


         
        public InventoryItems ItemSelector()
        {
            int userInput;
            
            if (_selection == "R")
            {
                printMenu();
                Console.WriteLine("\nPlease select an item from the menu to remove from your pack");
            }
            else
            {
                printMenu();
                Console.WriteLine("\nPlease select an item from the menu to add to your pack");
            }
            //resets _selection variable in order to trigger the loop in the future. 
            _selection = " ";

            userInput = Convert.ToInt16(Console.ReadLine());
            while (userInput <= 0 || userInput >= 6)
            {
                Console.WriteLine("That is not a valid input. Please select 1-5.");
            }

            if (userInput == 1)
            {
                InventoryItems itemSelection1 = new Arrow();
                return itemSelection1;
            }
            else if (userInput == 2)
            {
                InventoryItems itemselection2 = new Rope();
                return itemselection2;
            }
            else if (userInput == 3)
            {
                InventoryItems itemselection3 = new Water();
                return itemselection3;
            }
            else if (userInput == 4)
            {
                InventoryItems itemselection4 = new Food();
                return itemselection4;
            }
            else if (userInput == 5)
            {
                InventoryItems itemselection5 = new Sword();
                return itemselection5;
            }

            InventoryItems itemselection6 = new InventoryItems(0, 0);
            return itemselection6;
        }
    }
    
}

