using System;

using GameFactory.Mobs;

namespace GameFactory.Factories

{
    class EzLvlFactory : IMobsFactory
    {
        private static Random rnd = new Random();

        public IMobs Create()
        {
            string[] mobs = new string[] {
                "курица",
                "волк",
                "монстр"
            };

            switch (mobs[rnd.Next(0, mobs.Length)]) 
            {
                case "курица":
                    return new Chicken();
                case "волк":
                    return new Wolf();
                case "монстр":
                    return new Monster();
                default:
                    throw new Exception("Таких классов нет");
            }
        }

        public override string ToString()
        {
            return "Лёгкий уровень сложности";
        }
    }
}
