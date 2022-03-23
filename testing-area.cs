using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // A ton of variables.
      string firstName = "Rohan ", lastName = "Nathawat";
      string fullName = firstName + lastName;
      int favoriteNumber = 74, anotherNumber = 28;
      int myNum = 46;
      int myNumSecond = 39;
      long veryLongNumber = 10000000000L;
      char theLetter;
      bool someBool = false;
      double myDouble = myNumSecond;
      double d1 = 12E4D;
      const double doubleNumber = 5.6D;
      float floatingNumber = 7.39F;
      someBool = true;
      theLetter = 'R';

      // This is my first comment.
      /* This is my first
      multi line comment.*/

      // These are my first lines of code.
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World, but on a different line.");

      // More lines of code.
      Console.Write("This is a sentence. ");
      Console.WriteLine("This is another sentence.");

      // This area is where I tested out my variables.
      Console.WriteLine("Hello, my name is " + fullName + ".");
      Console.WriteLine(favoriteNumber + " is my favorite number.");
      Console.WriteLine("The first letter of my name is " + theLetter + ".");
      Console.WriteLine(doubleNumber);
      Console.WriteLine(someBool);
      Console.WriteLine(favoriteNumber + anotherNumber);
      Console.WriteLine(veryLongNumber);
      Console.WriteLine(floatingNumber);
      Console.WriteLine(d1);
      Console.WriteLine(Convert.ToString(myNum));
      Console.WriteLine(myDouble);
    }
  }
}
