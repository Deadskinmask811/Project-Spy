using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Spy;
using Project_Spy.GameObjects;

namespace Project_Spy.Scenes
{
    class TestScene : Scene
    {
        public override string Name
        {
            get
            {
                return "Test Scene";
            }
        }

        public override GameObject[] Objects
        {
            get
            {
                return new GameObject[] { new Rock(), new Rock("SMALL_ROCK"), new Rock("MARBLE_ROCK") };
            }
        }

        public override string Summary
        {
            get
            {
                return "Test Scene Summary...";
            }
        }
                

        public TestScene(string sceneName) : base(sceneName)
        {
        }
    }
}
