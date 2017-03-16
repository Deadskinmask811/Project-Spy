using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy.GameObjects;

namespace Project_Spy
{
    class CommandManager
    {
        private string[] command;

        public void SetUpCommand(string input)
        {
            command = input.ToUpper().Split();
        }
        
        public bool isValidActionCommand(string[] playerAction)
        {            
            foreach(string action in playerAction)
            {
                if (command[0].Equals(action))
                {
                    return true;
                }
            }            
            return false;
        }

        public bool isValidObjectCommand(GameObject[] objs)
        {
            foreach(GameObject obj in objs)
            {
                if (command[1].Equals(obj.Name))
                {
                    return true;
                }
            }
            return false;         
        }

        public GameObject getValidObject(GameObject[] objs)
        {
            foreach(GameObject obj in objs)
            {
                if (command[1].Equals(obj.Name))
                {
                    return obj;
                }
            }
            return null;
        }

        public string[] getCommand()
        {
            return command;
        }
    }
}
