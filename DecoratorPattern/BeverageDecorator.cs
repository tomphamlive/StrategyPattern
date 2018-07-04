//Decorator pattern is used to extend behaviors of a class
//by composing the class in a decorator class of the same type.
namespace DecoratorPattern
{
    //BeverageDecorator "decorates" or extends behaviors
    //of a Beverage through Composition.
    //
    //Eventhough BeverageDecorator derives from Beverage,
    //it doesn't inherit any implementation because Beverage
    //is abstract. BeverageDecorator inherits Beverage's interface.
    public abstract class BeverageDecorator : Beverage
    {
        //Composition
        protected Beverage BeverageToDecorate { get; set; }
    }
    //Mocha is a BeverageDecorator, and itself is a Beverage.
    //Mocha doesn't inherit any implementation from BeverageDecorator.
    public class Mocha : BeverageDecorator
    {
        private const decimal MochaCost = 0.25M;
        private const string MochaDescription = "Mocha";

        public Mocha(Beverage beverage)
        {
            BeverageToDecorate = beverage;

            //Mocha extends the description of its beverage with its description
            Description = BeverageToDecorate.Description + " " + MochaDescription;
        }

        public override decimal Cost()
        {
            //Mocha extends the cost of its beverage with its cost
            return BeverageToDecorate.Cost() + MochaCost;
        }
    }
    //SteamMilk is a BeverageDecorator, and itself is a Beverage.
    //SteamMilk doesn't inherit any implementation from BeverageDecorator.
    public class SteamMilk : BeverageDecorator
    {
        private const decimal SteamMilkCost = 0.10M;
        private const string SteamMilkDescription = "Steam Milk";

        public SteamMilk(Beverage beverage)
        {
            BeverageToDecorate = beverage;

            Description = BeverageToDecorate.Description + " " + SteamMilkDescription;
        }

        public override decimal Cost()
        {
            return BeverageToDecorate.Cost() + SteamMilkCost;
        }
    }
}
