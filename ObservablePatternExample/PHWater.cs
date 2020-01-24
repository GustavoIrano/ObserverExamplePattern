using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePatternExample
{
    //Subject
    public abstract class PHWater
    {
        private int _phValue;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public PHWater(int phValue)
        {
            _phValue = phValue;
        }

        public int PhValue
        {
            get => _phValue;
            set
            {
                if (_phValue == value) return;

                _phValue = value;
                Notificate();
            }
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Notifying {observer.Name} that the water ph must be 34");
        }

        private void Notificate()
        {
            foreach (var observe in _observers)
            {
                observe.Notificate(this);
            }

            Console.WriteLine("");
        }
    }
}
