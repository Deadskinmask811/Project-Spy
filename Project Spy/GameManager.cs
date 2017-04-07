using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy.Scenes;

namespace Project_Spy
{
    class GameManager
    {
        //private Scene currentScene;
        private CommandManager commandMgr;
        private InputManager inputMgr;
        private Player player;

        private string command;
        private string[] splitCommand;
        private GameObject obj;

        // temp solution... this scene will be replaced by a 'Mission Manager' object that will control which scene is displayed within a Mission object.
        private Scene test;

        public GameManager()
        {
            commandMgr = new CommandManager();
            inputMgr = new InputManager();
            player = new Player();
            test = new TestScene("test scene");
        }
        
        public void getCommand()
        {
            command = inputMgr.GetInput();
        }

        public void formatCommand()
        {
            commandMgr.SetUpCommand(command);
        }

        public bool validateCommand()
        {
            return inputMgr.IsValidLength() && commandMgr.isValidActionCommand(player.Actions) && commandMgr.isValidObjectCommand(test.Objects);
        }

        public void commandToArray()
        {
            splitCommand = commandMgr.getCommand();
        }

        public void buildCommand()
        {
            getCommand();
            formatCommand();
            if (validateCommand())
            {
                commandToArray();
            }
            else
            {
                Console.WriteLine("invalid commnad");
            }
            getValidObjectFromCommand();
            
        }

        public void getValidObjectFromCommand()
        {
            obj = commandMgr.getValidObject(test.Objects);
        }

        public void attemptPlayerAction()
        {
            if (obj != null)
            {   
                if (splitCommand[0].Equals("THROW"))
                {   
                    player.Throw(obj);
                }
            }
        }
    }
}
