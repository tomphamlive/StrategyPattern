using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            ISubscriber subscriberA = new SubscriberA(publisher);
            subscriberA.Subscribe();
            Console.WriteLine("A subscribes");

            ISubscriber subscriberB = new SubscriberB(publisher);
            subscriberB.Subscribe();
            Console.WriteLine("B subscribes");

            //when publisher's data is changed
            //subscribers get notified
            Console.WriteLine("Publisher's data is modified.");
            publisher.ModifyData();
            publisher.ModifyData();

            //one subscriber unsubscribes
            subscriberB.Unsubscribe();
            Console.WriteLine("B unsubscribed");

            //change data again
            Console.WriteLine("Publisher's data is modified.");
            publisher.ModifyData();
            publisher.ModifyData();

            //only subscriberA is notified
        }
    }
}
