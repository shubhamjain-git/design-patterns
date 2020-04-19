using System;

namespace DesignPatternsLibrary.Observer.WeatherStation
{
    public class ThirdPartyDisplay : IDisplayElement, IObserver
    {
        private readonly ISubject subject;

        public ThirdPartyDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        ~ThirdPartyDisplay()
        {
            subject.RemoveObserver(this);
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update(ISubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
