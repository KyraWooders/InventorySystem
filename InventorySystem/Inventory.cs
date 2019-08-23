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
        int weight = 0;
        int maxWeight = 100;
        
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
            string choice = "";
            while (choice != "0")
            {

                //weapon choice
                Console.WriteLine("What weapon would you like?");
                Console.WriteLine("0: cancel");
                Console.WriteLine("1: Dagger");
                Console.WriteLine("2: Sword");
                Console.WriteLine("3: Warhammer");
                Console.WriteLine("4: Master Sword");

                //input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {
                    Dagger();
                }
                else if (choice == "2")
                {
                    Sword();
                }
                else if (choice == "3")
                {
                    WarHammer();
                }
                else if (choice == "4")
                {
                    MasterSword();
                }
            }
           
            
        }
        public void Dagger()
        {
            Console.WriteLine("You have equiped the Dagger!");
            damage = 10;
            Console.WriteLine("Damage: " + damage + "PP");
            weight = 5;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
        }
        public void Sword()
        {
            Console.WriteLine("You have equiped the Sword!");
            damage = 20;
            Console.WriteLine("Damage: " + damage + "PP");
            weight = 10;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
        }
        public void WarHammer()
        {
            Console.WriteLine("You have equiped the Warhammer!");
            damage = 50;
            Console.WriteLine("Damage: " + damage + "PP");
            weight = 25;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
        }
        public void MasterSword()
        {
            Console.WriteLine("You have equiped the Master Sword!");
            damage = 100;
            Console.WriteLine("Damage: " + damage + "PP");
            weight = 100;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
        }
        public void UnequipWeapon()
        {
            Console.WriteLine("UnEquipped a weapon.");
            damage = 1;
            Console.WriteLine("Damage: " + damage);
            weight = 0;
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
            //if they lose more monz than they have
            if (gold <= 0)
            {
                gold = 0;
            }
            Console.WriteLine("Gold: " + gold);
        }
    }
}
