using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _west;
        private int _east;
        private string _hidden;

        public Scene(string name, int northID, int SouthID, int eastID, int westID, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = SouthID;
            _west = westID;
            _east = eastID;
            _hidden = "Nothing was found.";
        }

        public Scene(string name, int northID, int SouthID, int eastID, int westID, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = SouthID;
            _west = westID;
            _east = eastID;
            _hidden = hidden;
        }
        //return the name
        public string GetName()
        {
            return _name;
        }
        //reture the description
        public string GetDescription()
        {
            return _description;
        }

        public int ChooseExit()
        {
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {
                Console.WriteLine("Which Direction Will You Go?  (N/S/E/W)");
                choice = Console.ReadLine();
                //set choice
                choice = choice.ToUpper();
            }
            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else
            {
                return -1;
            }

        }
        public string GetHidden()
        {
            return _hidden;
        }
    }
}
