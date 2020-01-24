using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePatternExample
{
    public interface IObserver
    {
        string Name { get; }
        void Notificate(PHWater pHWater);
    }
}
