using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Character
    {
        
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };

        private Inventory inventory = new Inventory();

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _speed = 5;

        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Speed: " + _speed);
            Console.WriteLine("Combat Damagr: " + (_strength + inventory.GetItemDamage()));
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
    }
}
