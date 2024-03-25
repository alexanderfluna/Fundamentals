// WeatherObserver.cs - A WeatherCenter (subject) and TemperatureWatcher (observer).

using System;
using System.Collections;

namespace Templates.Observer 
{

	// An observer
	public class TemperatureWatcher 
	{

		private float currentTemperature;
		private WeatherCenter mySubject;
		private string watcherName; 

		public TemperatureWatcher (WeatherCenter s, float initTemp, 
			string name)
		{
			mySubject = s;
			currentTemperature = initTemp;
			watcherName = name;
		}   

		public void Update()
		{
			SubjectState state = mySubject.GetState();
			currentTemperature = state.temperature;      
			Console.WriteLine
				("Temperature watcher {1}: the temperature is now {0}.", 
				currentTemperature, watcherName);
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
        
		private ArrayList observers = new ArrayList();

		public void Attach(TemperatureWatcher o)
		{  
			observers.Add(o);
		}

		public void Detach(TemperatureWatcher o)
		{
			observers.Remove(o);
		}

		public void Notify()
		{
			foreach(TemperatureWatcher o in observers)
				o.Update();
		}

		public SubjectState GetState()
		{
			return new SubjectState(temperature, rainAmount, airPressure);
		}

	}

	public class SubjectState 
	{
		public float temperature,
			rainAmount,
			airPressure;

		public SubjectState(float temp, float rain, float pres)
		{
			temperature = temp;
			rainAmount = rain;
			airPressure = pres;
		}
	}

}
    
