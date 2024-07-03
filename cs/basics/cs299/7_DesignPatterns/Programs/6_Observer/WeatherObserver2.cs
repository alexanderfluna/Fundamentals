// WeatherObserver2.cs - A WeatherCenter (subject) 
// and Temperature/Rain Watchers (observer) with events. 

using System;
using System.Collections;

namespace Templates.Observer 
{

	// Delegate type:
	public delegate void 
	WeatherNotification(float temp, float rain, float pres);

	// An observer
	public class TemperatureWatcher 
	{

		private float currentTemperature;
		private WeatherCenter mySubject;
		private string watcherName; 

		public TemperatureWatcher (WeatherCenter s, float initTemp, string name)
		{
			mySubject = s;
			currentTemperature = initTemp;
			watcherName = name;
		}   

		public void TemperatureAlarm(float temp, float rain, float pres)
		{
			currentTemperature = temp;
			Console.WriteLine(
				"Temperature watcher {1}: the temperature is now {0}.", 
				currentTemperature, watcherName);
		}
	}    

	public class RainWatcher 
	{

		private float currentRainAmount;
		private WeatherCenter mySubject;
		private string watcherName; 

		public RainWatcher (WeatherCenter s, float initAmount, string name)
		{
			mySubject = s;
			currentRainAmount = initAmount;
			watcherName = name;
		}      

		public void RainAlarm(float temp, float rain, float pres)
		{
			currentRainAmount = rain;
			Console.WriteLine("Rain watcher {1}: Accumulated rain fall: {0}.", 
				currentRainAmount, watcherName);
		}   
	}    

	// A subject
	public class WeatherCenter 
	{

		private float temperature,
			rainAmount,
			airPressure;

		public WeatherCenter(float temp, float rain, float pres)
		{
			temperature = temp;
			rainAmount = rain;
			airPressure = pres;
		}

		public void WeatherUpdate(float temp, float rain, float pres)
		{
			float oldTemperature = this.temperature,
				oldRainAmount = this.rainAmount,
				oldAirPressure = this.airPressure;

			this.temperature = temp;
			this.rainAmount += rain;
			this.airPressure = pres;

			if (Math.Abs(oldTemperature - this.temperature) > 2.0F ||
				rain > 0.5F ||
				Math.Abs(oldAirPressure - this.airPressure) > 3.0F)
				this.Notify();
		}
        
		private event WeatherNotification weatherNotifier;

		public void AddNotifier(WeatherNotification n)
		{
			weatherNotifier += n;
		}

		public void RemoveNotifier(WeatherNotification n)
		{
			weatherNotifier -= n;
		}

		public void Notify()
		{
			weatherNotifier(temperature, rainAmount, airPressure);
		}

	}    


}
    
