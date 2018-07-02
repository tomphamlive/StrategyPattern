//The Observer (or Pub/Sub) pattern defines a one-to-many relationship between a Publisher and its Subscribers.
//When the Publisher's data has changed, the Publisher notifies all its Subscribers of the change.
namespace ObserverPattern
{
    public class PublisherData
    {
        public double DoubleData { get; set; }
    }

    public interface IPublisher
    {
        //Register a subscriber with the publisher
        void RegisterSubscriber(ISubscriber subscriber);

        //Remove a subscriber from the publisher
        void RemoveSubscriber(ISubscriber subscriber);

        //Notifies all subscribers when the publisher's state has changed
        void NotifySubscribers();

        PublisherData PublisherData { get; set; }
    }

    public interface ISubscriber
    {
        void Subscribe();
        void Unsubscribe();

        //Updates the subscriber with data from the publisher
        void Update(PublisherData publisherData);
    }
}
