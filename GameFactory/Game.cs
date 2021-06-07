using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFactory.Factories
{
    class Game
    {
        private Meadow location;
        
        public Game(IMobsFactory factory)
        {

            IMobs[] mobs = new IMobs[100];

            for (int i = 0; i < mobs.Length; i++)
            {
                mobs[i] = factory.Create();
            }

            location = new Meadow(mobs); 

        }

        
        public void StartGame()
        {
            Console.WriteLine("Локация загружена");

            location.MobsInfo();

        }
    }
}
