using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }
    }

    public class MallardDuck2 : Duck2
    {
        //each duck type specifies its fly and quack behaviors
        public MallardDuck2()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }
    }
}
