using System;

namespace StrategyPattern
{
    //Fly behaviors are separated from the Duck class and can be reused elsewhere.
    //New fly behaviors can be added without modifying existing fly behaviors, or modifying any duck classes
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("flying...");
        }
    }
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("no fly...");
        }
    }
}
