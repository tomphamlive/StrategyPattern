using System;

namespace StrategyPattern
{
    //In our Duck class, Quack and Fly vary across ducks, so we're going to separate them from Duck
    //and put them into Interfaces.
    //These interfaces will be implemented by some other class; NOT the Duck class

    //The superclass will be composed of these interfaces
    public abstract class Duck2   
    {
        //favor Composition over Inheritance
        protected IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        //Implementation of Fly and Quack is delegated to the interfaces
        public void Fly()
        {
            FlyBehavior.Fly();
        }
        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public virtual void Swim()
        {
            Console.WriteLine("swim swim");
        }

        //All duck subtypes look different, so each subtype will provide their own implementation
        public abstract void Display();
    }
}
