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
            Monster Orge = new Monster("Sherk", 1000, 205);
            Monster Donkey = new Monster("Donkey!!!", 10000, 2);
            Monster Porge = new Monster("Feonna", 10000, 2);
            Monster PC = new Monster("Prince Charming", 1000, 205);
            //create two arrays and place the monsters into them
            Monster[] goodTeam = { Orge, Porge };
            Monster[] badTeam = { Donkey, PC };
            //create an encounter from the two arrays of monsters
            Encounter encounter = new Encounter(goodTeam, badTeam);



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
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + TwT.Name());
                Console.WriteLine("3: " + UwU.Name());

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine(player.Name());
                    player.Print();
                }
                else if (choice == "2")
                {
                    Console.WriteLine(TwT.Name());
                    TwT.Print();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(UwU.Name());
                    UwU.Print();
                }

                player.Experience = 100;
                player.Experience++;
                player.Experience = player.Experience + 100;
                player.Experience++;
                player.Experience = player.Experience + 200;
                player.Experience++;
                player.Experience = player.Experience + 300;
                player.Experience++;
                player.Experience = player.Experience + 400;
                player.Experience++;
                player.Experience = player.Experience + 500;
                player.Experience++;
                player.Experience = player.Experience + 600;
                player.Experience++;
                player.Experience = player.Experience + 700;
                player.Experience++;

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
