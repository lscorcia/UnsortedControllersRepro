namespace UnsortedControllersRepro
{
    /// <summary>
    /// Weather forecast details
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Forecast date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Air temperature (degrees Celsius)
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Air temperature (degrees Fahrenheit)
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Short description of the weather conditions
        /// </summary>
        public string? Summary { get; set; }
    }
}