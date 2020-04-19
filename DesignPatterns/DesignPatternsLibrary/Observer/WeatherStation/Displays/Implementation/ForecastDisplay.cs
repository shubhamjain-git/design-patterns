using System;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private readonly ISubject subject;
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        ~ForecastDisplay()
        {
            subject.RemoveObserver(this);
        }

        public void Display()
        {
            if (Math.Abs(lastPressure - currentPressure) < 1)
                Console.WriteLine("Forecast: More of the same!");
            else if (lastPressure > currentPressure)
                Console.WriteLine("Forecast: Improving weather on the way!");
            else
                Console.WriteLine("Forecast: Watch out for cooler, rainy weather!");
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherData weatherData)
            {
                lastPressure = currentPressure;
                currentPressure = weatherData.GetPressure();
                Display();
            }
        }
    }
}
