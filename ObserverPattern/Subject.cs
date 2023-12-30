using System.Collections.Generic;
using System;

interface ISubject
{
    void registerObserver(IObserver o);
    void unRegisterObserver(IObserver o);
    void notifyObserver();
}


class WeatherData : ISubject
{
    private float temp, humidity, pressure;
    private List<IObserver> observers;


    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    public void registerObserver(IObserver o)
    {
        observers.Add(o);
    }
    public void unRegisterObserver(IObserver o)
    {
        observers.Remove(o);
    }
    public void notifyObserver()
    {
        foreach (IObserver observer in observers)
        {
            observer.update();
        }
    }

    public void measurmentsChanged()
    {
        this.notifyObserver();
    }

    public void setMeasurements(float temp, float humidity, float pressure)
    {
        this.temp = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        measurmentsChanged();
    }

    public float getTemp()
    {
        return temp;
    }
    public float getHumidity()
    {
        return humidity;
    }
    public float getPressure()
    {
        return pressure;
    }
}






