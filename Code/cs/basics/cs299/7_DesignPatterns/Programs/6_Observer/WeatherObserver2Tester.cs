// WeatherObserverTester2.cs - Application of the two different Watchers. 


using Templates.Observer;

class WeatherObserverTester 
{

	public static void Main()
	{

		WeatherCenter subj = new WeatherCenter(25.0F, 0.0F, 1020.0F);
		TemperatureWatcher
			o1 = new TemperatureWatcher(subj, 25.0F, "w1"),
			o2 = new TemperatureWatcher(subj, 25.0F, "w2");
		RainWatcher
			o3 = new RainWatcher(subj, 0.0F, "w3");

		// subj.AddNotifier(o1.TemperatureAlarm);
		subj.AddNotifier(new WeatherNotification(o1.TemperatureAlarm));
		//subj.AddNotifier(o2.TemperatureAlarm);
		subj.AddNotifier(new WeatherNotification(o2.TemperatureAlarm));
		//subj.AddNotifier(o3.RainAlarm);
		subj.AddNotifier(new WeatherNotification(o3.RainAlarm));

		subj.WeatherUpdate(23.0F, 0.0F, 1020.0F);
		subj.WeatherUpdate(23.0F, 2.0F, 1020.0F);
		subj.WeatherUpdate(23.0F, 0.0F, 1020.0F);
		subj.WeatherUpdate(24.0F, 0.3F,  920.0F);
		subj.WeatherUpdate(21.0F, 3.7F, 1050.0F);

	}

}
