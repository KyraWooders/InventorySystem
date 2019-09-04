using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Character : Creature
    {

        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };
        private int _damage = 10;
        


        private Inventory inventory = new Inventory();

        
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _speed = 5;

        public Character(string name)
        {
            _name = name;
            
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _damage;
        }
        
        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Speed: " + _speed);
            Console.WriteLine("Combat Damage: " + (_strength + inventory.GetItemDamage() + GetDamage()));
            Console.WriteLine("");

        }
        public void OpenInventory()
        {
            Inventory inventory = new Inventory();
            inventory.Menu();
        }

        public int Experience
        {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;

                Console.WriteLine(_name + " gained XP and now has " + _xp + "xp.");

                //stay in bound
                if (_level <= _requiredXP.Length)
                {
                    //check the xp (-1 makes sure to get the first xp)
                    if (_xp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + "'s has leveled up!");
                        Console.WriteLine("Level: " + _level);
                        Console.WriteLine("");

                    }
                }
            }
        }
        public override void Fight(Creature target)
        {
            if (Health <= 0)
            {
                return;
            }
            //get the damage of this
            int damage = GetDamage() + _strength + inventory.GetItemDamage();
            //subtract the damage from target health
            target.Health -= damage;
            //output 
            Console.WriteLine("");
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + "!");
            Console.WriteLine("");
        }
        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            bool vaildInput = false;
            while (!vaildInput)
            {
                Console.WriteLine("\nWho Will " + GetName() + " fight?");
                //Iterate throught
                for (int i = 0; i < targets.Length; i++)
                {
                    //print the current number (i) and current target
                    string targetName = targets[i].GetName();
                    Console.WriteLine(i + ":" + targetName);
                }
                //readline to get user input
                string input = Console.ReadLine();
                //convert the input to an integer
                int choice = Convert.ToInt32(input);
                //check that the choice is valid (above 0 and below the array lenght)
                if (choice >= 0 && choice < targets.Length)
                {
                    ////set validInput to true
                    vaildInput = true;
                    //fight the chosen target
                    Fight(targets[choice]);
                }


            }

        }
    }
}
