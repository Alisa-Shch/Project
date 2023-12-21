namespace Observer
{
    internal class Program
    {
        static void Main()
        {
            WeatherData weatherData = new();
            GeneralDisplay generalDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForengateDisplay forengateDisplay = new(weatherData);

            weatherData.SetMeasurements(43, 21, 25);
            weatherData.SetMeasurements(54, 36, 43);
            weatherData.SetMeasurements(62, 15, 58);
        }
    }
}