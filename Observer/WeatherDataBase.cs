namespace Observer
{
    internal abstract class WeatherDataBase
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        protected abstract void Notify();

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;

            Notify();
        }

        public float GetTemperature()
        {
            return _temp;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}