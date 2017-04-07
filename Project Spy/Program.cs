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
            GameManager gm = new GameManager();
            gm.buildCommand();
            gm.getValidObjectFromCommand();
            gm.attemptPlayerAction();            
            
            Console.ReadKey();
        }
    }
}
