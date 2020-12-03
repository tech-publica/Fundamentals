using System.Collections.Generic;
namespace Types.Variance
{
  public class Animal { }
  public class Tiger : Animal { }



  public class CovarianceExample
  {
    public static void ShowVariance()
    {
      List<Tiger> mra = new List<Tiger>();
      // NotCovariantTakeCareOfAnimals(mra);   // error
      CovariantTakeCareOfAnimals(mra);  // OK

    }

    public static void CovariantTakeCareOfAnimals(IReadOnlyList<Animal> mra)
    {
      Animal a = mra[0];
      foreach (Animal an in mra)
      {
        // do something with an
      }
    }

    public static void NotCovariantTakeCareOfAnimals(List<Animal> mra)
    {
      Animal a = mra[0];
      foreach (Animal an in mra)
      {
        // do something with an
      }
    }


  }
}