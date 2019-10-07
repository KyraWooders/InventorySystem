using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    delegate void Spell(Creature target);
    class Spellbook
    {
        public Spell Page1;
        public Spell Page2;

        public Spell[] book;

        public Spellbook(int pages)
        {
            Page1 = BlankPage;
            Page2 = BlankPage;

            book = new Spell[pages];
            for (int i = 0; i < pages; i++)
            {
                book[i] = BlankPage;
            }
        }

        public void BlankPage(Creature target)
        {

        }

    }
}
