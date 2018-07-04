using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //I order a dark roast, which is a beverage with a description and a cost
            Beverage darkRoast = new DarkRoast();
            Console.WriteLine(darkRoast.Description + " " + darkRoast.Cost());

            //How do I extend the description and cost of this beverage
            //if I want to add mocha and steam milk to my dark roast?
            Beverage beverage = new SteamMilk(new Mocha(darkRoast));
            Console.WriteLine(beverage.Description + " " + beverage.Cost());
        }
    }
}
