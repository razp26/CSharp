using System;

namespace ObserverPatternBuiltInExApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataHandler provider = new WeatherDataHandler();

            CurrentConditionsDisplay observer1 = new CurrentConditionsDisplay();
            // It is possible to have n observers
            //CurrentConditionsDisplay observer2 = new CurrentConditionsDisplay();

            observer1.Subscribe(provider);

            // It is possible tu Subscribe n observers
            //observer2.Subscribe(provider);

            for (int i = 0; i <= 50; i++)
            {
                System.Threading.Thread.Sleep(2500);
                provider.GetMeasurements();
            }

            Console.WriteLine("End of execution.");
            Console.ReadKey();
        }
    }
}
