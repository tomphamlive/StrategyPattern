using System;

namespace StrategyPattern
{
    //In the original Duck class, Fly is implemented in Duck. Duck's derived classes had to override it,
    //if a different behavior for Fly was needed. That's programming to Implementations.
    //
    //But by separating the Fly behavior from the Duck class into an Interface,
    //Different fly behaviors can be added without modifying existing fly behaviors, or existing duck classes.
    //This is programming to Interfaces instead of Implementations -- another design principle.
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
