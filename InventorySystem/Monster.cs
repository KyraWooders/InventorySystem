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

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
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
            }
        }
    }
}
