namespace Observer
{
    internal class StatisticsDisplay : IObserver
    {
        private WeatherDataBase _weatherData;
        private float _maxTemp = float.MinValue;
        private float _minTemp = float.MaxValue;
        private float _sumTemp;
        private int _numReadings = 0;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.Attach(this);
        }

        public StatisticsDisplay(WeatherDataEvent weatherData)
        {
            _weatherData = weatherData ?? throw new ArgumentNullException(nameof(weatherData));
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            float temp = _weatherData.GetTemperature();
            _sumTemp += temp;
            _numReadings++;

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }
            if (temp < _minTemp)
            {
                _minTemp = temp;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Значения по статистике: Средняя/Максимальная/Минимальная температура = {_sumTemp/_numReadings}/{_maxTemp}/{_minTemp}");
        }
    }
}