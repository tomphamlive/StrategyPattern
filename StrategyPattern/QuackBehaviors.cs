using System;

namespace StrategyPattern
{
    //Quack behaviors are separated from the Duck class and can be reused elsewhere.
    //New quack behaviors can be added without modifying existing quack behaviors, or modifying any duck classes
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
