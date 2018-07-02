namespace StrategyPattern
{
    //Use interfaces to encapsulate behaviors that vary among different types of Ducks
    public interface IFlyBehavior
    {
        void Fly();
    }
    public interface IQuackBehavior
    {
        void Quack();
    }
}
