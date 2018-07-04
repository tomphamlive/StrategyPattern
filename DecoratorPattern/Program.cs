using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //order a dark roast
            Beverage darkRoast = new DarkRoast();
            Console.WriteLine(darkRoast.Description + " " + darkRoast.Cost());

            //order a dark roast with mocha and steam milk
            //Decorate using composition
            Beverage beverage = new SteamMilk(new Mocha(darkRoast));
            Console.WriteLine(beverage.Description + " " + beverage.Cost());
        }
    }
}
