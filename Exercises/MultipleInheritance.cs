using System;

public class MultipleInheritance
{
  public void ShowMultipleInheritance()
  {
              //BankAccont b = new CaymanAccount(1000); 
              SuperHero sh = new SuperHero();
              Human h = new SuperHero();
              FlyingHero fh = new SuperHero();
              F1(sh);
  }

 // ignorance(of the concrete type which implements Human) is bliss 
  public void F1(Human human)
  {
      human.Walk();
  }
}



public class Person
{
  public string WorkId { get; set; }
  public string Name { get; set; }
  public void Eat()
  {
    Console.WriteLine("Eating slowly because I am unemployed...");
  }
  public void Speak()
  {
    Console.WriteLine("Hello world");
  }
}


public class Worker
{
  public int Age { get; set; }
  public void Eat()
  {
    Console.WriteLine("Eating quickly because I am in lunch break...");
  }
  public void Work()
  {
    Console.WriteLine("work work work");
  }
}


public class Programmer : Person //, Worker
{

}

public interface Human
{
  void Speak();  //implicitly  public and abstract
  void Walk();
}
public interface FlyingHero
{
  void Speak();
  void Fly();
}

public class SuperHero : Human, FlyingHero
{

  public void Walk() {  Console.WriteLine("I am walking"); }
  public void Fly() { Console.WriteLine("I am flying");  }
  public void Speak() { Console.WriteLine("I am speaking"); }

}
