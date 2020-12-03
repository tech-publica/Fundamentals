namespace Types.Variance
{
  public delegate TResult DumbFunc<T, TResult>(T arg);
  public delegate TResult VariantFunc<in T, out TResult>(T arg);
  public class Delegates
  {
    public static void ShowDelegateVariance()
    {
      DumbFunc<Animal, Programmer> df = GetOwnerProgrammer;
      //  DumbFunc<Tiger, Person> df2 = df;   // NOPE
      VariantFunc<Animal, Programmer> vf = GetOwnerProgrammer;
      VariantFunc<Tiger, Person> vf2 = vf; // OK :)
    }
    public static Programmer GetOwnerProgrammer(Animal animal)
    {
      return new Programmer();
    }

  }
}

