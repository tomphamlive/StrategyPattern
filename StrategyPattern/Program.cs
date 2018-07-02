using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck2> ducks = new List<Duck2>
            {
                new MallardDuck2(),
                new RedHeadDuck2(),
                new RubberDuck2()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Quack();
                duck.Swim();
                duck.Fly();
                Console.WriteLine();
            }

            Duck2 rubberDuck = new RubberDuck2();
            rubberDuck.Display();
            rubberDuck.Fly();
            rubberDuck.FlyBehavior = new FlyWithWings();
            rubberDuck.Fly();
        }
    }
}  
