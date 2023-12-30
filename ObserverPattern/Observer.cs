using System;

interface IObserver
{
    void update();
}

interface IDisplay
{
    void display();
}



class CurrentConditionsDisplay : IObserver, IDisplay
{
    private float temp, humidity, pressure;
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }
    public void update()
    {
        this.temp = weatherData.getTemp();
        this.pressure = weatherData.getPressure();
        this.humidity = weatherData.getHumidity();
        this.display();
    }
    public void display()
    {
        Console.WriteLine("temp: " + this.temp + " humidity: " + this.humidity + " pressure: " + this.pressure);
    }
}
class HeatIndexDisplay : IObserver, IDisplay
{
    private float temp, humidity;
    private WeatherData weatherData;

    public HeatIndexDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }
    public void update()
    {
        this.temp = weatherData.getTemp();
        this.humidity = weatherData.getHumidity();
        this.display();
    }
    public void display()
    {
        Console.WriteLine("heatIndex: " + (temp + humidity) / 2);
    }
}

