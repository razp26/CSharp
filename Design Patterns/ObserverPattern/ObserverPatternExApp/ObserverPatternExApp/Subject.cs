using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExApp
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();

    }
}
