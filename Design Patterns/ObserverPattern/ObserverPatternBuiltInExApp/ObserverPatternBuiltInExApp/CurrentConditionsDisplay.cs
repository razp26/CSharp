using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltInExApp
{
    // Define the observer, which is a type that implements the System.IObserver<T> interface.
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        private IDisposable unsuscriber;

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            unsuscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsuscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted.");
        }

        public virtual void OnError(Exception ex)
        {
            // Do nothing
        }

        public virtual void OnNext(WeatherData weatherData)
        {
            Console.WriteLine("Current conditions: " + weatherData.Temperature + " F degrees and " + weatherData.Humidity + "% humidity.");
        }
    }
}
