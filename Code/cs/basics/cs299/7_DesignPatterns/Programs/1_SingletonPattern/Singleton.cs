public class Singleton{

  // Instance variables

  private static Singleton uniqueInstance = null;

  private Singleton(){
     // Initialization of instance variables
  }

  public static Singleton Instance(){
    if (uniqueInstance == null)
      uniqueInstance = new Singleton();

    return uniqueInstance;
  }

  // Methods

}
