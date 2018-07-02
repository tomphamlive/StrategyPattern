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
            _publisher.RegisterSubscriber(this);
        }

        public void Unsubscribe()
        {
            _publisher.RemoveSubscriber(this);
        }

        public void Update(PublisherData publisherData)
        {
            Console.WriteLine($"SubscriberA received data: {publisherData.DoubleData}");
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
            _publisher.RegisterSubscriber(this);
        }

        public void Unsubscribe()
        {
            _publisher.RemoveSubscriber(this);
        }

        public void Update(PublisherData publisherData)
        {
            Console.WriteLine($"SubscriberB received data: {publisherData.DoubleData}");
        }
    }
}
