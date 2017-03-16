using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spy.GameObjects
{
    class Rock : GameObject
    {
        private string name = "ROCK";     
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override int ID
        {
            get
            {
                return 1;
            }
        }
        
        public override bool Throwable
        {
            get
            {
                return true;
            }
        }        
    }
}
