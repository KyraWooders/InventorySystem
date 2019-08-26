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

            Character hero = new Character("OwO");
            hero.Print();
            Character UwU = new Character("UwU");
            UwU.Print();
            Character TwT = new Character("TwT");
            TwT.Print();

            hero.Experience = 100;
            hero.Experience++;
            hero.Experience = hero.Experience + 100;
            hero.Experience++;
            hero.Experience = hero.Experience + 200;
            hero.Experience++;
            hero.Experience = hero.Experience + 300;
            hero.Experience++;
            hero.Experience = hero.Experience + 400;
            hero.Experience++;
            hero.Experience = hero.Experience + 500;
            hero.Experience++;
            hero.Experience = hero.Experience + 600;
            hero.Experience++;
            hero.Experience = hero.Experience + 700;
            hero.Experience++;

            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            Character[] party = { hero, UwU, TwT, new Character("OmO") };
            

            Console.ReadKey();
        }
    }
}
