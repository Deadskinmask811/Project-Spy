using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy.GameObjects;
using Project_Spy.Scenes;

namespace Project_Spy
{
    class Program
    {
        static void Main(string[] args)
        {            
            CommandManager commandMgr = new CommandManager();
            InputManager inputMgr = new InputManager();
            Player player = new Player();
            Scene test = new TestScene("test scene");
            
            string input = inputMgr.GetInput();
            //command gets ToUpper and Split here.
            commandMgr.SetUpCommand(input);
            
            //move all of this logic below into the GameManager class to handle validity of command and process it into a player action.
            // Game manager will also take care of "packing" and building scenes into missions and tracking which scene the player is in and move the player between then.
            if (inputMgr.IsValidLength() && commandMgr.isValidActionCommand(player.Actions) && commandMgr.isValidObjectCommand(test.Objects)) 
            {
                // return input as string[].
                string[] command = commandMgr.getCommand();
                //returns GameObject whos name matches command[1]
                GameObject obj = commandMgr.getValidObject(test.Objects);
                
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
