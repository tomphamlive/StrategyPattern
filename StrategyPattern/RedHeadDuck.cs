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
        //FlyBehavior and QuackBehavior are Interfaces inherited from Duck
        //Interface inheritance is fine
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
