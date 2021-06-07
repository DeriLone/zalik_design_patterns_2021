using System;

using GameFactory.Factories;

namespace GameFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobsFactory[] lvls = new IMobsFactory[] {
                new EzLvlFactory(),
                new MidleLvlFactory(),
                new HardLvlFactory()
            };

            Console.WriteLine("Выберете уровень сложности:");

            for (int i = 0; i < lvls.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lvls[i].ToString()}");
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (lvlNumber > -1 && lvlNumber < lvls.Length)
            {
                Game game = new Game(lvls[lvlNumber]);
                game.StartGame();
            }
            else
            {
                Console.WriteLine("Недопустимое число");
            }

            Console.ReadKey();
        }
    }
}
