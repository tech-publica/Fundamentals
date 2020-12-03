using System;
using Fundamentals.Basics;
using System.Collections.Generic;
using System.Collections;
using Extensions;
using System.Linq;
namespace Fundamentals
{

  // public interface MyInterface
  // {
  //   void A();
  //   void B();
  // }

  // public class MyClass : MyInterface
  // {
  //   public void A() {/* .... */}
  // }

  // fully qualified name of this class is Fundamentals.Program
  class Program
  {

    // entry point of the program
    static void Main(string[] args)
    {
       List<int> myList = new List<int>(210); // intelligent array 
 
      int[][] arrayMat= new int[3][];
      for ( int i =0; i < arrayMat.Length; i++)
      {
        arrayMat[i] = new int[(i+1) *2];
      }

       myList.Add(2);
       myList.Add(3);
      myList.Add(9);
      myList.Add(3);
      myList.RemoveAt(3);

      int biggeThan100 = myList.Where( num => num > 100).Count();

      int[] myIntArray = new int[10];
      int res = myList[0];
      int res2 = myIntArray[0];
      HashSet<Person> mySet = new HashSet<Person>();

      // linq is lazy
      var peopleWithR  = mySet.Where(p => p.Name.StartsWith("R")).ToList();  // linq operators work one element at a time
       var names =   peopleWithR.Select(p => p.Name + " works as " + p.WorkId);
      var bonuses = peopleWithR.Select( p => p.Bonus);
                    
      var  myStringList = result.ToList();  
      string firstName =   myStringList[0];


       var result2 = from p in mySet 
                   where p.Name.StartsWith("R")
                   select p.Name + " works as " + p.WorkId;

      Dictionary<int, Person> dict = new Dictionary<int, Person>();
     
       


      dict.Add(200, new Person());
      dict.Add(4, new Person());

      Person found = dict[4];

      LinkedList<int> myLinked = new LinkedList<int>();
    
    //  char last = StringExtensions.LastChar("hello"); // works , but ugly
       char last = "hello".LastChar(); // syntactic sugar

      // LinqParseXMl xmlParser = new LinqParseXMl();
      // xmlParser.ParseDocument("XML/example.xml");
      var xmlReader = new UseXmlReader();
      xmlReader.ParseFile("XML/example.xml");
      Console.WriteLine("done");


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

    static void Swap(Person p1, Person p2)
    {
      var temp = p1;
      p1 = p2;
      p2 = temp;

    }
  }
}
