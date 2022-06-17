using Level_25_Packing_Inventory;

/*Establishes arrays with maximum potential numbers of each items
Rope[] rope = new Rope[20];
Arrow[] arrow = new Arrow[30];
Bow[] bow = new Bow[7];
Sword[] sword = new Sword[6];
Food[] food = new Food[30];
Water[] water = new Water[10];*/

Menu menu = new Menu();
Pack myPack = new Pack();
bool hold = false;


while (hold == false)
{
    menu.printMenu();
    menu.Selection();
    myPack.AddOrRemove(menu._selection,menu.ItemSelector());
    
}






//Hold console open
//Console.ReadKey();
