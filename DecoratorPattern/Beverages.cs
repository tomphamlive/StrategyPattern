namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public abstract decimal Cost();
    }
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override decimal Cost()
        {
            return 1.50M;
        }
    }
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override decimal Cost()
        {
            return 2.00M;
        }
    }
}
