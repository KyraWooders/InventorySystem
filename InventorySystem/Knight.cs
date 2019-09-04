using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            _health = 300;
            _maxHealth = 300;
            _mana = 20;
            _strength = 40;
            _speed = 10;
        }
    }
}
