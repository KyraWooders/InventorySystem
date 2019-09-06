using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        public static Random random = new Random(); 

        static void Main(string[] args)
        {

            //create a bunch of monsters
            Creature Orge = new Monster("Sherk", 100, 20, 20);
            Creature Donkey = new Monster("Donkey!!!", 100, 20, 30);
            Creature Porge = new Monster("Fiona", 100, 30, 10);
            Creature PC = new Monster("Prince Charming", 100, 2, 30);
            Creature Gin = new Monster("Gingy", 100, 5, 60);
            Creature Puss = new Monster("Puss in Boots", 100, 70, 40);
            Creature Fairy = new Monster("Fairy Godmother", 100, 90, 100);
            Creature Pin = new Monster("Pinocchio", 100, 30, 20);

            
            string name = "";
            Console.WriteLine("Enter name of party member 1:");
            name = Console.ReadLine();
            string choice = "";
            while (choice != "1" && choice != "2")
            {

                //display menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Rouge");
                Console.WriteLine("3: Mage");
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
            else if (choice == "3")
            {
                player = new Mage(name);
            }
            else
            {
                player = new Character(name);
            }
            //create two arrays and place the monsters into them
            Creature[] goodTeam = { player, Orge, Porge };
            Creature[] badTeam = { Donkey, PC };
            Creature[] babeTeam = { Gin, Puss };
            Creature[] queenTeam = { Fairy, Pin };
            Creature[] empty = { };

            Scene courtyard = new Scene("Courtyard", 1, 3, -1, 2, empty, "You're in the courtyard. There's a Graveyard to the North, the Castle Gate in the South, and a village in the West.");
            Scene graveyard = new Scene("Graveyard", -1, 0, -1, -1, badTeam, "You're in the spooky Graveyard. There's a Courtyard to the South.");
            Scene village = new Scene("Village", -1, -1, 0, -1, babeTeam, "You're in a nice small village. There's a Courtyard to the East.");
            Scene castlegate = new Scene("Castlegate", 0, -1, -1, -1, queenTeam, "You're at the Castle Gate. The evil queen lives in there. There's a Courtyard to the North.");


            Scene[] scenes = { courtyard, graveyard, village, castlegate };
            Map map = new Map(0, scenes, goodTeam);

            map.Menu();

            Console.ReadKey();






            
            //create an encounter from the two arrays of monsters
            Encounter encounter = new Encounter(goodTeam, badTeam);
            encounter.Print();
            player.OpenInventory();
            
            encounter.Start();
            Console.ReadKey();



            return;
            
            
            //string name = "";
            //string choice = "";
            //Console.WriteLine("Enter name of party member 1:");
            //name = Console.ReadLine();
            //while (choice != "1" && choice != "2")
            //{

            //    //display menu
            //    Console.WriteLine("/nChoose a job:");
            //    Console.WriteLine("1: Knight");
            //    Console.WriteLine("2: Rouge");
            //    choice = Console.ReadLine();
            //}
            //Character play;
            //if (choice == "1")
            //{
            //    player = new Knight(name);
            //}
            //else if (choice == "2")
            //{
            //    player = new Rouge(name);
            //}
            //else
            //{
            //    player = new Character(name);
            //}
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
