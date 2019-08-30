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
            
            //create a bunch of monsters
            Creature Orge = new Monster("Sherk", 100, 20);
            Creature Donkey = new Monster("Donkey!!!", 10, 20);
            Creature Porge = new Monster("Fiona", 100, 30);
            Creature PC = new Monster("Prince Charming", 10, 2);
            Character player = new Character("OwO");
            //create two arrays and place the monsters into them
            Creature[] goodTeam = { player, Orge, Porge };
            Creature[] badTeam = { Donkey, PC };
            //create an encounter from the two arrays of monsters
            Encounter encounter = new Encounter(goodTeam, badTeam);
            encounter.Print();
            encounter.Start();
            


            Console.ReadKey();
            return;
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
            Character play;
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
            Character UwU = new Rouge("UwU");
            Character TwT = new Mage("TwT");
            Character OmO = new Knight("OmO");
            TwT.Print();
            UwU.Print();

            while (choice != "0")
            {

                //display menu
                Console.WriteLine("/nWhoose inventorey?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.GetName());
                Console.WriteLine("2: " + TwT.GetName());
                Console.WriteLine("3: " + UwU.GetName());

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine(player.GetName());
                    player.Print();
                }
                else if (choice == "2")
                {
                    Console.WriteLine(TwT.GetName());
                    TwT.Print();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(UwU.GetName());
                    UwU.Print();
                }

                int[] testArray = new int[4];

                testArray[0] = 1;
                testArray[1] = 3;
                testArray[2] = 5;
                testArray[3] = 7;

                int[] testArray2 = { 2, 4, 6, 8 };

                string[] stringArray = new string[3];

                Character[] party = { player, UwU, TwT, new Character("OmO") };


                Console.ReadKey();
            }
        }
    }
}
