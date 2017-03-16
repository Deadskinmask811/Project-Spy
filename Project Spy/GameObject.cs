using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spy
{
    abstract class GameObject
    {
        private string name;     
        public abstract string Name { get; set; }        
        public abstract int ID { get; }
        public abstract bool Throwable { get; }        
    }
}
