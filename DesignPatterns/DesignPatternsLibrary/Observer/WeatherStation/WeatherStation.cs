using System;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class WeatherStation : IDesignPattern
    {
        private readonly WeatherData weatherData = new WeatherData();
        IDisplayElement display;

        public WeatherStation()
        {
            Console.WriteLine("!!Welcome to the Shubham's Weather Station!!");
        }

        public WeatherData GetWeatherDataInstance()
        {
            return weatherData;
        }
        
        public IDisplayElement GetDispalyElement(string displayName)
        {            
            switch (displayName)
            {
                case WeatherStationConstants.CURRENT_CONDITIONS_DISPLAY:
                    display = new CurrentConditionsDisplay(weatherData);
                    break;

                case WeatherStationConstants.FORECAST_DISPLAY:
                    display = new ForecastDisplay(weatherData);
                    break;

                case WeatherStationConstants.HEAT_INDEX_DISPLAY:
                    display = new HeatIndexDisplay(weatherData);
                    break;

                case WeatherStationConstants.STATISTICS_DISPLAY:
                    display = new StatisticsDisplay(weatherData);
                    break;

                case WeatherStationConstants.THIRD_PARTY_DISPLAY:
                    display = new ThirdPartyDisplay(weatherData);
                    break;

                default:
                    throw new NotImplementedException();
            }
            return display;
        }

        public void RunExample()
        {
            display = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 30.4f);
        }
    }
}
