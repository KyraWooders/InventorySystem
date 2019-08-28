using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Monster
    {
        private string _name = "";
        private int _health = 100;
        private int _damage = 10;
        private int _maxHealth = 100;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _maxHealth = health;
            _damage = damage;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetDamage()
        {
            return _damage;
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("\n" + _name);
            Console.WriteLine("Health: " + _health + "/" + _maxHealth);
            Console.WriteLine("Damage: " + _damage);
        }
        public void Fight(Monster target)
        {
            if (Health <= 0)
            {
                return;
            }
            //get the damage of this
            int damage = GetDamage();
            //subtract the damage from target health
            target.Health -= damage;
            //output 
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + "!");
        }
    }
}
