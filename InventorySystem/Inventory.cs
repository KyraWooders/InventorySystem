using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        int damage = 1;
        float gold = 0.00f;
        
        public void Menu()
        {
            string choice = "";
            

            while (choice != "0")
            {
                //display menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Epuip Weapon");
                Console.WriteLine("2: Unepuip Weapon");
                Console.WriteLine("3: Add Gold");
                Console.WriteLine("4: Lost Gold");

                //get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {
                    EquipWeapon();
                }
                else if (choice == "2")
                {
                    UnequipWeapon();
                }
                else if (choice == "3")
                {
                    Console.Write("How much gold? ");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.Write("How much gold? ");
                    float lostGold = Convert.ToSingle(Console.ReadLine());
                    LoseGold(lostGold);
                }
            }
        }

        public void EquipWeapon()
        {
            Console.WriteLine("Equipped a weapon.");
            damage = 25;
            Console.WriteLine("Damage: " + damage);
        }

        public void UnequipWeapon()
        {
            Console.WriteLine("UnEquipped a weapon.");
            damage = 1;
            Console.WriteLine("Damage: " + damage);

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }
        public void LoseGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold.");
            gold -= amount;
            if (gold <= 0)
            {
                gold = 0;
            }
            Console.WriteLine("Gold: " + gold);
        }
    }
}
