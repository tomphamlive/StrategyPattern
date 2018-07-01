using System;

namespace StrategyPattern
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a redhead");
        }
    }

    public class RedHeadDuck2 : Duck2
    {
        //each duck type specifies its fly and quack behaviors
        public RedHeadDuck2()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a redhead");
        }
    }
}
