/*
    The Observer Pattern defines a one-to-many
    dependency between objects so that when one
    object changes state, all of its dependents are
    notified and updated automatically.
*/

using System;

class Program
{
    static void Main()
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        HeatIndexDisplay headDisplay = new HeatIndexDisplay(weatherData);

        weatherData.setMeasurements(80, 65, 30.4f);
        weatherData.setMeasurements(82, 70, 29.2f);
        weatherData.setMeasurements(78, 90, 29.2f);
    }
}