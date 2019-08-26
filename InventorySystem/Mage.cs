using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Mage : Character
    {
        public Mage(string name) : base(name)
        {
            _health = 100;
            _mana = 200;
            _strength = 10;
            _speed = 10;
        }
    }
}
