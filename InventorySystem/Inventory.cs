using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        private int _itemDamage = 10;
        private int _itemDefense = 0;
        private int _itemWeight = 0;
        private int Damage = 1;
        private float _gold = 0.00f;
        private int _weight = 0;
        private int _maxWeight = 100;
        private int _armorWeight = 0;
        //do 
        private AttackItem sword = new AttackItem("MasterSword", 100, 1200);
        private AttackItem dagger = new AttackItem("Dagger", 10, 5);
        private AttackItem sword2 = new AttackItem("Sword", 20, 10);
        private AttackItem warhammer = new AttackItem("warhammer", 50, 25);
        private AttackItem[] weapons = new AttackItem[4];
        public Inventory()
        {
            AttackItem[] weaponBag = {sword, dagger, sword2, warhammer};
            weapons = weaponBag;
        }
        public int ItemWeight()
        {
            return _itemWeight;
        }
        //returns the damage our weapon deals 
        public int GetItemDamage()
        {
            return _itemDamage;
        }
        //Returns the defense our armor grants
        public int GetItemDefense()
        {
            return _itemDefense;
        }
        
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
                    _itemDamage = weapons[1].Damage;
                    _itemWeight = weapons[1].weight;
                    //check weight
                    if (_itemWeight > _maxWeight)
                    {
                        Console.WriteLine("You can't eqiup the weapon.");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("You have equiped the Dagger!");
                    Console.WriteLine("Damage: " + _itemDamage + "PP");
                    Console.WriteLine("Weight: " + _itemWeight);
                    Console.WriteLine("");
                    
                }
                else if (choice == "2")
                {
                    _itemDamage = weapons[2].Damage;
                    _itemWeight = weapons[2].weight;
                    //check weight
                    if (_itemWeight > _maxWeight)
                    {
                        Console.WriteLine("You can't eqiup the weapon.");
                        Console.WriteLine("");
                        
                    }
                    Console.WriteLine("You have equiped the Sword!");
                    Console.WriteLine("Damage: " + _itemDamage + "PP");
                    Console.WriteLine("Weight: " + _itemWeight);
                    Console.WriteLine("");
                    
                }
                else if (choice == "3")
                {
                    _itemDamage = weapons[3].Damage;
                    _itemWeight = weapons[3].weight;
                    //check weight
                    if (_itemWeight > _maxWeight)
                    {
                        Console.WriteLine("You can't eqiup the weapon.");
                        Console.WriteLine("");
                        
                    }
                    Console.WriteLine("You have equiped the Warhammer!");
                    Console.WriteLine("Damage: " + _itemDamage + "PP");
                    Console.WriteLine("Weight: " + _itemWeight);
                    Console.WriteLine("");
                    
                }
                else if (choice == "4")
                {
                    _itemDamage = weapons[0].Damage;
                    _itemWeight = weapons[0].weight;
                    //check weight
                    if (_itemWeight > _maxWeight)
                    {
                        Console.WriteLine("You can't eqiup the weapon.");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("You have equiped the Master Sword!");
                    Console.WriteLine("Damage: " + _itemDamage + "PP");
                    Console.WriteLine("Weight: " + _itemWeight);
                    Console.WriteLine("");
                }
            }
           
            
        }
        public void UnequipWeapon()
        {
            Console.WriteLine("UnEquipped a weapon.");
            Damage = 1;
            Console.WriteLine("Damage: " + Damage);
            _weight = 0;
            Console.WriteLine("Weight: " + _weight);
            Console.WriteLine("");
        }
        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
        }
        public void LoseGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold.");
            _gold -= amount;
            //if they lose more monz than they have
            if (_gold <= 0)
            {
                _gold = 0;
            }
            Console.WriteLine("Gold: " + _gold);
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
            _weight = 0;
            Console.WriteLine("Weight: " + _weight);
            Console.WriteLine("");
        }
        public void lightArmor()
        {
            Console.WriteLine("You have equiped Light Armor!");
            _weight = 5;
            Console.WriteLine("Weight: " + _weight);
            Console.WriteLine("");
            if (_weight > _maxWeight)
            {
                Console.WriteLine("You can't eqiup the armor.");
            }
        }
        
    }
}
