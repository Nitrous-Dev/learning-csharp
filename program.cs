using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string myName = "Rohan";
      int favoriteNumber = 53;
      char theLetter;
      theLetter = 'R';

      // This is my first comment.
      /* This is my first
      multi line comment.*/

      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World, but on a different line.");

      Console.Write("This is a sentence.");
      Console.WriteLine("This is another sentence.");

      Console.WriteLine("Hello, my name is " + myName + ".");
      Console.WriteLine(favoriteNumber + " is my favorite number.");
      Console.WriteLine("The first letter of my name is " + theLetter + ".");
    }
  }
}
