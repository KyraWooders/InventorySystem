using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Encounter
    {
        private Monster[] _goodMonsters;
        private Monster[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            //Iterate through good monsters and print each
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //Iterate through bad monsters and print each
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }

        }
        //monster fight
        public void BeginRound()
        {

            //Iterate through good monsters
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            //Iterate through bad monsters
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);
            }
        }

        public void Start()
        {
            Console.WriteLine("\nEncounter Start!");
            bool stillFighting = true;
            while (stillFighting)
            {
                //check if team 1 is alive
                bool goodIsAlive = true;
                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Monster currentMonster = _goodMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        //our team is alive and not dead, break out of the loop
                        goodIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        //our team may be dead
                        goodIsAlive = false;
                    }
                }
                //check if team 2 is alive
                bool badIsAlive = true;
                int totalBadHeajth = 0;
                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Monster currentMonster = _badMonsters[i];
                    //total up the health of each monster on this team
                    totalBadHeajth += currentMonster.Health;
                }
                badIsAlive = totalBadHeajth > 0;

                if (goodIsAlive && badIsAlive)
                {
                    stillFighting = true;
                    BeginRound();
                    
                }
                else
                {
                    stillFighting = false;
                }
                Print();
            }
        }
    }
}
