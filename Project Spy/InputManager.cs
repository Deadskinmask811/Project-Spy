using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spy
{
    class InputManager
    {
        private string input;

        public InputManager()
        {
        }

        public string GetInput()
        {
            return input = Console.ReadLine();
        }

        public bool IsValidLength()
        {
            return input.Split().Length == 2;
        }

        // reset the value of input to null, use this after each input is processed.
        public void ClearnInput()
        {
            input = null;
        }
    }
}
