using System;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private readonly ISubject subject;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        ~CurrentConditionsDisplay()
        {
            subject.RemoveObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature
                + "F degrees and " + humidity + "% humidity");
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherData weatherData)
            {
                this.temperature = weatherData.GetTemperature();
                this.humidity = weatherData.GetHumidity();
                Display();
            }
        }
    }
}
