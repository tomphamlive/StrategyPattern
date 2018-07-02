using System.Collections.Generic;

namespace ObserverPattern
{
    public class Publisher : IPublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        private PublisherData _publisherData;
        public PublisherData PublisherData
        {
            get => _publisherData;
            set
            {
                _publisherData = value;
                NotifySubscribers();
            }
        }

        public void RegisterSubscriber(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(PublisherData);
            }
        }
    }
}
