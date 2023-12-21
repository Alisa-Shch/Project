namespace Observer
{
    internal class WeatherData : WeatherDataBase, ISubject
    {
        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            if (observer == null) 
            {
                throw new ArgumentNullException(nameof(observer));
            }
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }
            _observers.Remove(observer);
        }

        protected override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}