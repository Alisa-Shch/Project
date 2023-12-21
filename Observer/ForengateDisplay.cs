namespace Observer
{
    internal class ForengateDisplay : IObserver
    {
        private WeatherDataBase _weatherData;
        private float _lastPressure;
        private float _currentPressure;

        public ForengateDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.Attach(this);
        }

        public ForengateDisplay(WeatherDataEvent weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            if (_weatherData != null)
            {
                _lastPressure = _currentPressure;
                _currentPressure = _weatherData.GetPressure();
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Прогноз погоды: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Погода улучшается!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("Изменений в погоде не обнаружено");
            }
            else
            {
                Console.WriteLine("Ожидаются заморозки");
            }
        }
    }
}