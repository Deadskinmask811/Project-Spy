using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy.GameObjects;

namespace Project_Spy
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello
            CommandManager commandMgr = new CommandManager();
            InputManager inputMgr = new InputManager();
            Player player = new Player();
            GameObject rock1 = new Rock();
            GameObject rock2 = new Rock();
            rock2.Name = "SMALL_ROCK";            
            // temporary array of objects to mimic scene objects
            GameObject[] objs = { rock1, rock2 };
            string input = inputMgr.GetInput();
            //command gets ToUpper and Split here.
            commandMgr.SetUpCommand(input);
            
            if (inputMgr.IsValidLength() && commandMgr.isValidActionCommand(player.Actions) && commandMgr.isValidObjectCommand(objs)) 
            {
                // return input as string[].
                string[] command = commandMgr.getCommand();
                //returns GameObject whos name matches command[1]
                GameObject obj = commandMgr.getValidObject(objs);
                
                // If valid game object, proceed to do action upon it.
                if(obj != null)
                {
                    if (command[0].Equals("THROW"))
                    {
                        player.Throw(obj);
                    }
                }    
            }
            else
            {
                Console.WriteLine("invalid command");
            }
            
            Console.ReadKey();
        }
    }
}
