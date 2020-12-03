using System.Collections.Generic;

namespace Types.Variance
{
  public class Person { }
  public class Programmer : Person { }

  public interface IWriteOnlyPair<in T>
  {
    T First {set;}
    T Second { set; }
  }

  public class Pair<T> : IWriteOnlyPair<T>
  {
    public T First {get; set;}
    public T Second {get; set;}
    public Pair() {}
    public Pair(T first, T second)
    {
      First = first;
      Second = second;
    }
  }


  public class ContravariantExample
  {
    public static void ShowContravariance()
    {
          Pair<Person> pp = new Pair<Person>();
          ContravariantDoPairProgramming(pp);
        //  NotContravariantDoPairProgramming(pp); //error
    }

    public static void ContravariantDoPairProgramming(IWriteOnlyPair<Programmer> wp)
    {
        wp.First = new Programmer();
    }
    public static void NotContravariantDoPairProgramming(Pair<Programmer> wp)
    {
     
    }

  }

}