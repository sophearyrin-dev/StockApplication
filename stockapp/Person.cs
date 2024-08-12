public class Person
{

  public string FirstName;
  public string LastName;
  // Constructor with no parameters
  public Person()
  {
    Console.WriteLine("Hello from Person constructor");
  }

  // Constructor with parameters
  public Person(string FirstName, string LastName)
  {
    this.FirstName = FirstName;
    this.LastName = LastName;
  }

}