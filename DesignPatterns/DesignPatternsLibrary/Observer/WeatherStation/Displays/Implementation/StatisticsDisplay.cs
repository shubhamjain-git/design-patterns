using System;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private readonly ISubject subject;
        private float minTemperature = 220.0f;
        private float maxTemperature = -20.0f;
        private float sumOfTemperatures = 0.0f;
        private float avgTemperature;
        private float count = 0;

        public StatisticsDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        ~StatisticsDisplay()
        {
            subject.RemoveObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + avgTemperature + "/" + maxTemperature + "/" + minTemperature);
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherData weatherData)
            {
                float currentTemperature = weatherData.GetTemperature();
                sumOfTemperatures += currentTemperature;
                count += 1;
                avgTemperature = sumOfTemperatures / count;
                minTemperature = currentTemperature < minTemperature ? currentTemperature : minTemperature;
                maxTemperature = currentTemperature > maxTemperature ? currentTemperature : maxTemperature;
                Display();
            }
        }
    }
}
