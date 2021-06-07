using System;

using GameFactory.Mobs;

namespace GameFactory.Factories
{
    class MidleLvlFactory : IMobsFactory
    {
        private static int HardMobsCount = 0;

        public IMobs Create()
        {
            if (HardMobsCount < 10)
            {
                HardMobsCount += 1;
                return new Monster();
            }

            IMobsFactory ezFactory = new EzLvlFactory();
            return ezFactory.Create();
        }

        public override string ToString()
        {
            return "Средний уровень сложности";
        }
    }
}
