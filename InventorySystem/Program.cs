using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventory inventory = new Inventory();
            // inventory.Menu();
            string name = "";
            string choice = "";
            Console.WriteLine("Enter name of party member 1:");
            name = Console.ReadLine();
            while (choice != "1" && choice != "2")
            {
               
                //display menu
                Console.WriteLine("/nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Rouge");
                choice = Console.ReadLine();
            }
            Character player;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Rouge(name);
            }
            else
            {
                player = new Character(name);
            }
            player.Print();
            player.OpenInventory();

            Character OmO = new Knight("OmO");

            while (choice != "1" && choice != "2")
            {

                //display menu
                Console.WriteLine("/nChoose a job:");
                Console.WriteLine("1: " + OmO.Name());
                Console.WriteLine("2: Rouge");
                choice = Console.ReadLine();
            }
            Character ;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Rouge(name);
            }
            else
            {
                player = new Character(name);
            }

            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            Character[] party = { player, new Character("OmO") };
            

            Console.ReadKey();
        }
    }
}
