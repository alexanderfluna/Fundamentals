using System;

class Client{

  public static void Main(){

    Person p = new Person("Hanne", new Date(1926, 12, 24));

    Date d = p.GetDateOfBirth();
    d.SetYear((ushort)(d.GetYear() - 100));
    Console.WriteLine("{0}", p);

    Date today = new Date(2006,9,27);
    Console.WriteLine("Age of Hanne as of {0}: {1}.", 
                      today, p.AgeAsOf(today));
  }

}

