using System.Collections.Generic;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        private bool changed;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            if (changed)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(this);
                }
                changed = false;
            }            
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void MeasurementsChanged()
        {
            SetChanged();
            NotifyObservers();
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        private void SetChanged()
        {
            changed = true;
        }
    }
}
