using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePatternExample
{
    public class Observer : IObserver
    {
        public string Name { get; }

        public Observer(string name)
        {
            Name = name;
        }

        public void Notificate(PHWater pHWater)
        {
            Console.WriteLine($"Notifying that the water ph is at { pHWater.PhValue }");
        }
    }
}
