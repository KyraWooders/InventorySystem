using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class AttackItem : Item 
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        public AttackItem(string newName, int newDamage, int newWeight)
        {
            Name = newName;
            _damage = newDamage;
            weight = newWeight;
        }
        
    }
}
