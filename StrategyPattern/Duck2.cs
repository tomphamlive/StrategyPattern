using System;

//Strategy is a pattern that allows different behaviors or algorithms to be chosen dynamically at runtime.
//  It provides the flexibility of extending new behaviors or algorithms to a class without having to modify it (Open-Close principle). 
//  Behaviors are extended using Interfaces, which represent the different types of behaviors.
//With the Strategy pattern, behaviors of a baseclass aren't inherited by its subclasses;
//  only the Interfaces which represent the behaviors are inherited.
//The Strategy pattern is implemented by Composing a base class with Interfaces that represent different types of behaviors,
//  and each subclass selects a particular concrete behavior at runtime.
namespace StrategyPattern
{
    //In our Duck class, Quack and Fly are behaviors that vary across ducks,
    //so they are separated from Duck, and encapsulated into Interfaces (IFlyBehavior and IQuackBehavior)
    //These interfaces will be implemented by some other class; NOT the Duck class
    public abstract class Duck2   
    {
        //The Duck class is composed of these interfaces (Favor Composition over Inheritance)
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        //Implementation of Fly and Quack is delegated to the interfaces; it's not implemented by Duck itself
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
