using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltInExApp
{
    //Define the data provider, which is a type that implements the System.IObservable<T> interface. 
    //The provider's generic type argument is the type that the provider sends to observers.
    public class WeatherDataHandler : IObservable<WeatherData>
    {
        // Determine how the provider will store references to observers so that each observer can be notified when appropriate.
        private List<IObserver<WeatherData>> observers;
        private WeatherData currentWeatherData;

        public WeatherDataHandler()
        {
            observers = new List<IObserver<WeatherData>>();
            GetMeasurements();
        }

        // Implement the IObservable<T>.Subscribe method. The method is passed a reference to the System.IObserver<T> interface.
        // The method should then return the IDisposable implementation developed in Unsuscriber Class.
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsuscriber(observers, observer);
        }

        public void GetMeasurements()
        {
            // Store the previous Weather Data, so notification is only sent after at least 1 change.
            Nullable<WeatherData> previous = currentWeatherData;

            if (!previous.HasValue)
            {
                // First measurement
                currentWeatherData = new WeatherData(GetRandomNumber(0, 100), GetRandomNumber(5, 95), GetRandomNumber(5, 95));
            }
            else
            {
                currentWeatherData = new WeatherData(GetRandomNumber(previous.Value.Temperature - 1, previous.Value.Temperature + 2),
                    GetRandomNumber(previous.Value.Humidity - 1, previous.Value.Humidity + 2),
                    GetRandomNumber(previous.Value.Pressure - 1, previous.Value.Pressure + 2));
            }

            if (!previous.HasValue || (Math.Abs(previous.Value.Temperature - currentWeatherData.Temperature) > 0 
                || Math.Abs(previous.Value.Humidity - currentWeatherData.Humidity) > 0
                /*|| Math.Abs(previous.Value.Pressure - currentWeatherData.Pressure) > 0*/))
            {
                // Notifying Observers
                foreach (var observer in observers)
                {
                    observer.OnNext(currentWeatherData);
                }
            }
        }


        // Example method for generating random float numbers
        private int GetRandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
