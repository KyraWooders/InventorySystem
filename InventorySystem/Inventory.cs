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
                Console.WriteLine("5: Epuip Armor");
                Console.WriteLine("6: Unepuip Armor");

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
                else if (choice == "5")
                {
                    EquipArmor();
                }
                else if (choice == "6")
                {
                    UnequipArmor();
                }
            }
        }
        public void lightArmor()
        {
            Console.WriteLine("You have equiped Light Armor!");
            weight = 5;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
            if (weight > maxWeight)
            {
                Console.WriteLine("You can't eqiup the armor.");
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
                    Dagger(10, 5);
                }
                else if (choice == "2")
                {
                    Sword(20, 10);
                }
                else if (choice == "3")
                {
                    WarHammer(50, 25);
                }
                else if (choice == "4")
                {
                    MasterSword(100, 1200);
                }
            }
           
            
        }
        public void UnequipWeapon()
        {
            Console.WriteLine("UnEquipped a weapon.");
            damage = 1;
            Console.WriteLine("Damage: " + damage);
            weight = 0;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
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
        public void EquipArmor()
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("What armor would you like?");
                Console.WriteLine("0: Cancel");
                Console.WriteLine("1: Light Armor");
                Console.WriteLine("2: Medium Armor");
                Console.WriteLine("3: Heavy Armor");

                //get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {

                }
                else if (choice == "2")
                {

                }
                else if (choice == "3")
                {

                }
            }
        }
        public void UnequipArmor()
        {
            Console.WriteLine("UnEquipped the Armor.");
            weight = 0;
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
        }
        bool Dagger(int damage, int weight)
        {
            //check weight
            if (weight > maxWeight)
            {
                Console.WriteLine("You can't eqiup the weapon.");
                Console.WriteLine("");
                return false;
            }
            Console.WriteLine("You have equiped the Dagger!");
            Console.WriteLine("Damage: " + damage + "PP");
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
            return true;
        }
        bool Sword(int damage, int weight)
        {
            //check weight
            if (weight > maxWeight)
            {
                Console.WriteLine("You can't eqiup the weapon.");
                Console.WriteLine("");
                return false;
            }
            Console.WriteLine("You have equiped the Sword!");
            Console.WriteLine("Damage: " + damage + "PP");
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
            return true;
        }
        bool WarHammer(int damage, int weight)
        {
            //check weight
            if (weight > maxWeight)
            {
                Console.WriteLine("You can't eqiup the weapon.");
                Console.WriteLine("");
                return false;
            }
            Console.WriteLine("You have equiped the Warhammer!");
            Console.WriteLine("Damage: " + damage + "PP");
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
            return true;
        }
        bool MasterSword(int damage, int weight)
        {
            //check weight
            if (weight > maxWeight)
            {
                Console.WriteLine("You can't eqiup the weapon.");
                Console.WriteLine("");
                return false;
            }
            Console.WriteLine("You have equiped the Master Sword!");
            Console.WriteLine("Damage: " + damage + "PP");
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("");
            return true;
        }
       
    }
}
