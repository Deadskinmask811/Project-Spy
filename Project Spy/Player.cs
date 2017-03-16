using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy;

namespace Project_Spy
{
    class Player
    {
        public string Name
        {
            get
            {
                return "Spyguy";
            }
        }

        public int ID
        {
            get
            {
                return 700;
            }
        }

        public string[] Actions
        {
            get
            {
                return new string[] { "THROW", "SHOOT", "OPEN" };
            }
        }
               

        public void Throw(GameObject obj)
        {
            try
            {
                if (obj.Throwable)
                {
                    Console.WriteLine("{0} throws {1} on the GROUND!!!!", Name, obj.Name);                    
                }
                else
                {
                    Console.WriteLine("{0} cannot be thrown...", obj.Name);
                }
            }
            catch (Exception e)
            {                
                Console.WriteLine("Exception: {0}" ,e);
            }
        }
    }
}
