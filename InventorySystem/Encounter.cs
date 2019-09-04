using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Encounter
    {
        private Creature[] _goodMonsters;
        private Creature[] _badMonsters;

        public Encounter(Creature[] team1, Creature[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            //Iterate through good monsters and print each
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //Iterate through bad monsters and print each
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
                currentMonster.Print();
            }

        }

        private int GetTotalXP(Creature[] team)
        {
            int total = 0;
            for (int i = 0; i< team.Length; i++)
            {
                total += team[i].GetXP();
            }
            return total;
        }
        //monster fight
        public void BeginRound()
        {

            //Iterate through good monsters
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            //Iterate through bad monsters
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
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
                    Creature currentMonster = _goodMonsters[i];
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
                    Creature currentMonster = _badMonsters[i];
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
                    if (goodIsAlive)
                    {
                        //give Xp to each character in good team 
                        foreach (Creature cr in _goodMonsters)
                        {
                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                               ch.Experience += GetTotalXP(_badMonsters);
                            }
                            
                        }
                    }
                    else if (badIsAlive)
                    {
                        //give Xp to each character in bad team 
                        foreach (Creature cr in _badMonsters)
                        {
                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalXP(_goodMonsters);
                            }

                        }
                    }
                }
                Print();
            }
        }
    }
}
