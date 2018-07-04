using System;

namespace ObserverPattern
{
    public class SubscriberA : ISubscriber
    {
        private IPublisher _publisher;

        public SubscriberA(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public void Subscribe()
        {
            _publisher.Register(this);
        }

        public void Unsubscribe()
        {
            _publisher.Unregister(this);
        }

        public void Update(object publisherData)
        {
            Console.WriteLine($"SubscriberA received data: {publisherData}");
        }
    }

    public class SubscriberB : ISubscriber
    {
        private IPublisher _publisher;

        public SubscriberB(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public void Subscribe()
        {
            _publisher.Register(this);
        }

        public void Unsubscribe()
        {
            _publisher.Unregister(this);
        }

        public void Update(object publisherData)
        {
            Console.WriteLine($"SubscriberB received data: {publisherData}");
        }
    }
}
