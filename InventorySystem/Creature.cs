using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventorySystem
{
    class Creature
    {
        protected int _health = 100;
        protected int _maxHealth = 100;
        
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
        public virtual int Heal()
        {
            return 0;
        }
        public virtual void Fight(Creature target)
        {

        }
        public virtual void Fight(Creature[] targets)
        {

        }
        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "Fang";
        }
        public virtual void Print()
        {

        }
        public virtual int GetXP()
        {
            return 0;
        }
        
        

        public virtual void Save(StreamWriter writer)
        {
            
        }
        public virtual int GetLevel()
        {
            return 0;
        }
    }
}
