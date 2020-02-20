using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltInExApp
{
    //Define the data that the provider is responsible for sending to observers.
    //Although the provider and the data that it sends to observers can be a single type, they are generally represented by different types.
    public struct WeatherData
    {
        private int temperature;
        private int humidity;
        private int pressure;

        public WeatherData(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public int Temperature
        {
            get { return this.temperature; }
        }

        public int Humidity
        {
            get { return this.humidity; }
        }

        public int Pressure
        {
            get { return this.pressure; }
        }
    }
}
