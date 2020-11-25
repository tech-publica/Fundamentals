using System;
using Fundamentals.Basics;
using System.Collections.Generic;

namespace Fundamentals
{
  // fully qualified name of this class is Fundamentals.Program
  class Program
  {

    // entry point of the program
    static void Main(string[] args)
    {
      
        List<int> li = new List<int>();

        String[] ss = new String[3];
        for (int i = 0; i < 3; i++)
        {
          Console.Write("please give me the next value...>");
          ss[i] = Console.ReadLine(); // riccardo.123
        }

        String name = ss[0].Substring(ss[0].IndexOf('.')); // "riccardo"

        String[] parts = ss[0].Split('.');
        String n = parts[0]; // "riccardo"
  

        String clientName;
        Console.WriteLine("please give me a name");
        clientName = Console.ReadLine();

        Console.WriteLine("Hello World!");

        int x1 = 10; // value type on the stack LIFO f1 -> f2 -> f3
        int x2 = 20;
        int s = Swap(x1, x2);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
        Person p1 = new Person(); // the object lives lives on the HEAP
        p1.firstname = "Riccardo";
        Person p2 = new Person(); // the object lives lives on the HEAP
        p2.firstname = "Aarti";
        Swap(p1, p2);
        Console.WriteLine(p1.firstname);
        Console.WriteLine(p2.firstname);
 

        Point po = new Point();


        int h = (int)10.7; //forced cast narrowing cast.. dangerous!

        int[] nums = new int[10];
        int first = nums[0];
        Console.WriteLine(first);

        String[] names = new String[] { "riccardo", "aarti" };
        string firstString = names[0];
        Console.WriteLine(firstString == null);


     
    }

    // pass by value (copy)
    static int Swap(int x1, int x2)
    {
      int temp = x1;
      x1 = x2;
      x2 = temp;
      int sum = x1 + x2;
      return sum;
    }

    static Person Swap(Person p1, Person p2)
    {
      string temp = p1.firstname;
      p1.firstname = p2.firstname;
      p2.firstname = temp;
      return p2;
    }
  }
}
