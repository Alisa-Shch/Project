namespace Observer
{
    internal class GeneralDisplay : IObserver
    {
        private WeatherDataBase _weatherData;

        public GeneralDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.Attach(this);
        }

        public GeneralDisplay(WeatherDataEvent weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Общие значения: {_weatherData.GetTemperature()} градусов по Фаренгейту и {_weatherData.GetHumidity()}% влажности");
        }
    }
}