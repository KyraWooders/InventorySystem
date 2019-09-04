using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Rouge : Character
    {
        public Rouge(string name) : base(name)
        {
            _health = 100;
            _maxHealth = 100;
            _mana = 10;
            _strength = 20;
            _speed = 50;
        }
    }
}
