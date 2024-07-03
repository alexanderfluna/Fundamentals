public class Person{

  private string name;
  private Date dateOfBirth, dateOfDeath;

  public Person (string name, Date dateOfBirth){
    this.name = name;
    this.dateOfBirth = dateOfBirth;
    this.dateOfDeath = null;
  }

  public Date GetDateOfBirth(){
     return dateOfBirth;
  }

  public ushort AgeAsOf(Date d){
    return (ushort)(d.GetYear() - dateOfBirth.GetYear());
  }

  public bool Alive(){
    return dateOfDeath == null;
  }

  public override string ToString(){
    return "Person: " + name + " " + dateOfBirth;
  }

  // Other getter and setter methods

}