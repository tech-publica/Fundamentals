using System;
namespace Fundamentals.Basics
{
  //blueprint
  public class Person
  {
    //state
    public string firstname;
    string lastname;
    int age;

    //behaviour
    void SayHello()
    {
      Console.WriteLine("Hello, I am " + firstname + " " + lastname);
    }

  }
}
