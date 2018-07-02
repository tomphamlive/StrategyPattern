using System;

namespace StrategyPattern
{
    //Quack behaviors are separated from the Duck class and can be reused elsewhere.
    //Different quack behaviors can be added without modifying existing quack behaviors, or modifying any duck classes.
    //This is programming to Interfaces instead of Implementations -- another design principle.
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack...");
        }
    }
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("squeak...");
        }
    }
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("silent...");
        }
    }
    //...add other quack behaviors
}
