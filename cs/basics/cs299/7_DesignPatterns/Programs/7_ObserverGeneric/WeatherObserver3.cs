using System;
using System.Collections.Generic;

namespace Templates.Observer {

 public interface IObserver{
    void Update();
 }

 // An observer
 public class TemperatureWatcher: IObserver {
   private float currentTemperature;
   private WeatherCenter mySubject;
   private string watcherName; 

   public TemperatureWatcher (WeatherCenter s, float initTemp, string name){
     mySubject = s;
     currentTemperature = initTemp;
     watcherName = name;
   }   

   public void Update(){
      SubjectState state = mySubject.GetState();
      currentTemperature = state.temperature;      
      Console.WriteLine("Temperature watcher {1}: the temperature is now {0}.", 
                        currentTemperature, watcherName);
   }

 }

 // Another observer
 public class RainWatcher: IObserver {
   private float currentRainAmount;
   private WeatherCenter mySubject;
   private string watcherName; 

   public RainWatcher (WeatherCenter s, float initAmount, string name){
     mySubject = s;
     currentRainAmount = initAmount;
     watcherName = name;
   }   

   public void Update(){
      SubjectState state = mySubject.GetState();
      currentRainAmount += state.rainAmount;
      Console.WriteLine("Rain watcher {1}: Accumulated rain fall: {0}.", currentRainAmount, watcherName);
   }

 }

 // A subject
 public class WeatherCenter {

   private float temperature,
                 rainAmount,
                 airPressure;

   public WeatherCenter(float temp, float rain, float pres){
      temperature = temp;
      rainAmount = rain;
      airPressure = pres;
   }

   public void WeatherUpdate(float temp, float rain, float pres){
      float oldTemperature = this.temperature,
            oldAirPressure = this.airPressure;

      this.temperature = temp;
      this.rainAmount = rain;
      this.airPressure = pres;

      if (Math.Abs(oldTemperature - this.temperature) > 2.0F ||
          rain > 0.5F ||
          Math.Abs(oldAirPressure - this.airPressure) > 3.0F)
       this.Notify();
   }
        
   private List<IObserver> observers = new List<IObserver>();

   public void Attach(IObserver o){  
     observers.Add(o);
   }

   public void Detach(IObserver o){
     observers.Remove(o);
   }

   public void Notify(){
     foreach(IObserver o in observers)
        o.Update();
   }

   public SubjectState GetState(){
     return new SubjectState(temperature, rainAmount, airPressure);
   }

 }

 public class SubjectState {
   public float temperature,
                rainAmount,
                airPressure;

   public SubjectState(float temp, float rain, float pres){
     temperature = temp;
     rainAmount = rain;
     airPressure = pres;
   }
 }

}
    