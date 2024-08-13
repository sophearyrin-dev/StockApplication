public class Person
{
  public string FirstName;
  public string LastName;
  // Constructor with no parameters
  public Person()
  {
    Console.WriteLine("Hello from Person constructor");
  }

  public Person(string firstName, string lastName)
   : this()
   {
    this.FirstName = firstName;
    this.LastName = lastName;
  }

  // Constructor with parameters
  public Person(string FirstName, string LastName)
  {
    this.FirstName = FirstName;
    this.LastName = LastName;
  }

}