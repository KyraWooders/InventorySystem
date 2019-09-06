using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventorySystem
{
    class Map
    {
        private int _currentLocation = 0;
        private Scene[] _sceneList;
        private Creature[] _players;

        public Map(int startingSceneID, Scene[] scenes, Creature[] players)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
            _players = players;
        }

        public void PrintCurrentScene()
        {
            //if the current sene ID is within range
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //print the current scene's name and descr
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }

            
        }

       public int CurrentSceneID
       {
            get
            {
                return _currentLocation;
            }
            set
            {
                if (value >= 0 && value < _sceneList.Length)
                {
                    _currentLocation = value;
                }
                else
                {
                    Console.WriteLine("\nInvalid scene ID");
                }
            }
       }

        public void Menu()
        {

            string choice = "";
            while (choice != "0")
            {
                //let the player know where they are 
                PrintCurrentScene();
                //print the menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Search");
                Console.WriteLine("3: Save");
                Console.WriteLine("4: Save Character");
                Console.WriteLine("5: Load");
                //get the player choice
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Travel();
                }
                else if(choice == "2")
                {
                    Search();
                }
                else if (choice == "3")
                {
                    Save("save.txt");
                }
                else if (choice == "4")
                {
                    Load("save.txt");
                }
                else if (choice == "5")
                {
                    Heal();
                }
            }
        }

        public void Travel()
        {
            int destination = -1;
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {

                destination = _sceneList[_currentLocation].ChooseExit();
            }
            if (destination >= 0 && destination < _sceneList.Length)
            {
                CurrentSceneID = destination;
            }
            else
            {
                Console.WriteLine("There is nowhere");
            }
        }
        public void Search()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                CheckForMonster();
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
            
            
        }
        public void CheckForMonster()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Scene currentScene = _sceneList[_currentLocation];
                if (currentScene.GetCleared() == false)
                {
                    Encounter encounter = new Encounter(_players, currentScene.GetEnemies());
                    encounter.Start();
                }
            }
        }
        
        public void Save(string path)
        {
            //create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //write to it the same way we write to the console
            writer.WriteLine(CurrentSceneID);
            //close write
            writer.Close();
        }
        public void Load(string path)
        {
            if (File.Exists(path))
            {
                //create a reader for the file at our path
                StreamReader reader = File.OpenText(path);
                //write to it the same way we read from the console 
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                //close read
                reader.Close();
            }
            else
            {
                Console.WriteLine("save file can't be found");
            }

        }
        public void Heal()
        {
            
        }
    }
}
