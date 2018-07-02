using System;

//Strategy is a behavior pattern that enables selection of different behaviors at runtime.
//Behaviors of a class shouldn't be inherited, but should be encapsulated using interfaces.
//Strategy follows the Open-Close principle, in which classes are open for extension (via interfaces), but closed for modification.
namespace StrategyPattern
{
    //In our Duck class, Quack and Fly are behaviors that vary across ducks,
    //so they are separated from Duck, and encapsulated into Interfaces (IFlyBehavior and IQuackBehavior)
    //These interfaces will be implemented by some other class; NOT the Duck class
    public abstract class Duck2   
    {
        //The Duck class, however, is composed of these interfaces
        //Favor Composition over Inheritance
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        //Implementation of Fly and Quack is delegated to some other classes that implements the interfaces, not Duck
        public void Fly()
        {
            FlyBehavior.Fly();
        }
        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("swim swim");
        }

        //All duck subtypes look different, so each subtype will provide their own implementation
        public abstract void Display();
    }
}
