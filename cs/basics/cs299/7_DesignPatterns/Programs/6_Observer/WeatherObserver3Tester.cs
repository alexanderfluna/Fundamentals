using Templates.Observer;

class Client {

  public static void Main(){

     WeatherCenter subj = new WeatherCenter(25.0F, 0.0F, 1020.0F);
     TemperatureWatcher
              o1 = new TemperatureWatcher(subj, 25.0F, "w1"),
              o2 = new TemperatureWatcher(subj, 25.0F, "w2");

     RainWatcher
              o3 = new RainWatcher(subj, 0.0F, "w3");

     subj.Attach(o1);
     subj.Attach(o2);
     subj.Attach(o3);

     subj.WeatherUpdate(23.0F, 0.0F, 1020.0F);
     subj.WeatherUpdate(23.0F, 5.0F, 1020.0F);
     subj.WeatherUpdate(23.0F, 0.1F, 1020.0F);
     subj.WeatherUpdate(24.0F, 0.0F,  920.0F);
     subj.WeatherUpdate(21.0F, 0.9F, 1050.0F);

  }

}