using System.Collections.Generic;

namespace ObserverPattern
{
    public class Publisher : IPublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        private double _data;
        public double Data
        {
            get => _data;
            private set
            {
                _data = value;
                NotifySubscribers();
            }
        }

        public void ModifyData()
        {
            Data += 2;
        }

        public void Register(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void Unregister(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(Data);
            }
        }
    }
}
