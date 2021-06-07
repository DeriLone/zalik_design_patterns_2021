using System;

using GameFactory.Mobs;

namespace GameFactory.Factories
{
    class HardLvlFactory : IMobsFactory
    {
        private static Random rnd = new Random();
        public IMobs Create()
        {
            string[] mobs = new string[] {
                "Волк",
                "Монстр"
            };

            switch (mobs[rnd.Next(0, mobs.Length)])
            {
                case "Волк":
                    return new Wolf();
                case "Монстр":
                    return new Monster();
                default:
                    throw new Exception("Таких классов нет");
            }
        }

        public override string ToString()
        {
            return "Сложный уровень сложности";
        }
    }
}
