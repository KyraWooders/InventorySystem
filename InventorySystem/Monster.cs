using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Monster : Creature
    {
        private string _name = "";
        private int _damage = 10;
        private int _xp = 10;

        public Monster(string name, int health, int damage, int xp)
        {
            _name = name;
            _health = health;
            _maxHealth = health;
            _damage = damage;
            _xp = xp;
        }
        public override string GetName()
        {
            return _name;
        }
        public override int GetDamage()
        {
            return _damage;
        }
        public override int GetXP()
        {
            return _xp;
        }
        public override int Heal()
        {
            
            _health = _maxHealth;
            return _health;
        }
        public override void Print()
        {
            Console.WriteLine("\n" + _name);
            Console.WriteLine("Health: " + _health + "/" + _maxHealth);
            Console.WriteLine("Damage: " + _damage);
        }
        public override void Fight(Creature target)
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
            Console.WriteLine("");
        }
        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }
            Random random = new Random();
            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);



            //bool vaildInput = false;
            //while (!vaildInput)
            //{
            //    Console.WriteLine("\nWho Will " + GetName() + " fight?");
            //    //Iterate throught
            //    for (int i = 0; i < targets.Length; i++)
            //    {
            //        //print the current number (i) and current target
            //        string targetName = targets[i].GetName();
            //        Console.WriteLine(i + ":" + targetName);
            //    }
            //    //readline to get user input
            //    string input = Console.ReadLine();
            //    //convert the input to an integer
            //    int choice = Convert.ToInt32(input);
            //    //check that the choice is valid (above 0 and below the array lenght)
            //    if (choice >= 0 && choice < targets.Length)
            //    {
            //        ////set validInput to true
            //        vaildInput = true;
            //        //fight the chosen target
            //        Fight(targets[choice]);
                    

            //    }
               
                
            //}

        }
        
    }
}
