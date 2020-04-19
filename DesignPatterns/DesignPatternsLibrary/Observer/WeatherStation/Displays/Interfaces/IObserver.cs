namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
