using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // A ton of variables.
      string firstName = "Rohan ";
      string lastName = "Nathawat";
      string fullName = firstName + lastName;
      int favoriteNumber = 74;
      int anotherNumber = 28;
      char theLetter;
      bool someBool = false;
      const double doubleNumber = 5.6;
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
    }
  }
}
