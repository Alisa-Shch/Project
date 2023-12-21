namespace Observer
{
    internal class WeatherDataEvent : WeatherDataBase
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        public event Action? WeatherChanged;

        public new void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;

            OnWeatherChanged();
        }

        protected virtual void OnWeatherChanged()
        {
            WeatherChanged?.Invoke();
        }

        public float GetTemperatureEvent()
        {
            return _temp;
        }

        public float GetHumidityEvent()
        {
            return _humidity;
        }

        public float GetPressureEvent()
        {
            return _pressure;
        }

        protected override void Notify() { }
    }
}