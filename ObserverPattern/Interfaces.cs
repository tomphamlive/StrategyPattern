//The Observer (or Pub/Sub) pattern defines a one-to-many relationship between a Publisher and its Subscribers.
//When the Publisher's data has changed, the Publisher notifies all its Subscribers of the change.
namespace ObserverPattern
{
    public interface IPublisher
    {
        //Register a subscriber
        void Register(ISubscriber subscriber);

        //Unregister a subscriber
        void Unregister(ISubscriber subscriber);

        //Notifies all subscribers when the publisher's state has changed
        void NotifySubscribers();
    }

    public interface ISubscriber
    {
        //subscribe for notification
        void Subscribe();

        void Unsubscribe();

        //Updates the subscriber with data from the publisher
        void Update(object data);
    }
}
