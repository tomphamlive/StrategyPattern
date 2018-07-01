using System;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a rubber duck");
        }

        //rubber ducks don't quack, so Quack is overriden to squeak
        public override void Quack()
        {
            Console.WriteLine("squeak squeak");
        }

        //rubber ducks don't fly, so Fly is overriden to no fly
        public override void Fly()
        {
            Console.WriteLine("no flying");
        }
    }

    public class RubberDuck2 : Duck2
    {
        //each duck type specifies its fly and quack behaviors
        public RubberDuck2()
        {
            QuackBehavior = new NoQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a rubber duck");
        }
    }
}
