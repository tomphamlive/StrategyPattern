using System;

namespace StrategyPattern
{
    //The superclass from which all other ducks inherit
    public abstract class Duck
    {
        //All ducks quack and swim, so the Duck class implements these behaviors
        public virtual void Quack()
        {
            Console.WriteLine("quack quack");
        }
        public virtual void Swim()
        {
            Console.WriteLine("swim swim");
        }

        //All duck subtypes look different, so each subtype will provide their own implementation
        public abstract void Display();

        //A requirement comes in that ducks need to FLY, so you add a Fly method to the Duck class.
        //What you didn't realize was NOT all ducks should fly (like rubber ducks)
        public virtual void Fly()
        {
            Console.WriteLine("flying flying");
        }

        //The problem with adding new behaviors to a superclass so that its subtypes will inherit them is:
        //If the behavior isn't appropriate to certain subtypes, then those subtypes must be modified to override
        //the behavior inherited from the superclass.
        //Imagine if you have a lot of derived Duck types, each time you add a new behavior to Duck, you'll have to make sure
        //that behavior is appropriate for ALL ducks. For those that are NOT appropriate, you'll have to override the behavior
        //in the derived class.
        //
        //This type of design is not flexible because a small change to the superclass can potentially cause lots of changes
        //to be made in its derived classes, which is not only a maintenance issue, but a high risk of introducing new bugs.

        //To solve this problem, we apply a standard design principle called ENCAPSULATION:
        //Identify the parts of your system that varies and separate them, so that they don't affect the rest of your system.

        //In our Duck class, Quack and Fly vary across ducks, so we're going to separate them from Duck into Interfaces.
        //See Duck2
    }
}
