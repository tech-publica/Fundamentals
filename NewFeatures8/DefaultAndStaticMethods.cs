using System;

namespace NewFeatures8
{
  interface ILogger
  {
    void Log(string text) => Console.WriteLine(text);
    static int myStaticField = 10;
    static void MyStaticMethod()
    {
      myStaticField = 20;
      Console.WriteLine("static in interface");
    }
  }

  class Test : ILogger
  {
    void MyMethod()
    {
      //   Log("hello, world!"); // error
      Test t = new Test();
      //   t.Log("hello, world!"); // error
      ILogger iLog = new Test();
      iLog.Log("hello, world!"); // OK
      // MyStaticMethod(); // error
      // t.MyStaticMethod(); // error
      // iLog.MyStaticMethod(); // error
      // Test.MyStaticMethod(); // error
      // ILogger.MyStaticMethod(); // OK
    }
  }

}
