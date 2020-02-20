using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltInExApp
{
    //Define an IDisposable implementation that the provider can return to subscribers so that they can stop receiving notifications at any time.
    //The following example defines a nested Unsubscriber class that is passed a reference to the subscribers collection and to the subscriber when the class is instantiated.
    //This code enables the subscriber to call the object's IDisposable.Dispose implementation to remove itself from the subscribers collection.

    public class Unsuscriber : IDisposable
    {
        private List<IObserver<WeatherData>> observers;
        private IObserver<WeatherData> observer;

        public Unsuscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (!(observer == null))
            {
                observers.Remove(observer);
            }
        }
    }
}
