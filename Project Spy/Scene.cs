using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spy
{
    abstract class Scene
    {
        private string name;
        private GameObject[] objects;
        //private string summary;

        public abstract string Name { get; }
        public abstract GameObject[] Objects { get; }
        public abstract string Summary { get; }

        public Scene(string sceneName)
        {
            name = sceneName;
        }

        // children need method to display summary that has names of objects within that you can interact with.
    }
}
