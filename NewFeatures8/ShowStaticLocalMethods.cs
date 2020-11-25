namespace NewFeatures8
{
  public class ShowStaticLocalMethods
  {
    void MyMethod()
    {
      int x = 10;
      void localMethod()
      {
        x = 20;
      }
      static void localStaticMethod()
      {
        //   x = 30;   // error
      }
    }
  }
}
