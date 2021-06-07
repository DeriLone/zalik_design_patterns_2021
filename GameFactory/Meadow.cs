using System;
using System.Linq;

namespace GameFactory.Factories
{
    class Meadow
    {
        private IMobs[] mobs;

        public Meadow(IMobs[] mobs)
        {
            this.mobs = mobs;
        }

        public void MobsInfo()
        {
            var chicken = mobs.Where((item) => {
                return item.ToString() == "Курица";
            }).Count();

            Console.WriteLine($"{chicken} Курица");


            var wolf = mobs.Where((item) => {
                return item.ToString() == "Волк";
            }).Count();

            Console.WriteLine($"{wolf} Волк");


            var monster = mobs.Where((item) => {
                return item.ToString() == "Монстр";
            }).Count();

            Console.WriteLine($"{monster} Монстр");
        }
    }
}
