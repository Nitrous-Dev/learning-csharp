using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // This is where I will learn how to do math stuff in C#.

      //More variables...
      int math1 = 50 + 20;
      int math2 = math1 + 100;
      int math3 = math1 + math2;
      int math4 = 10;
      int modulusTest = 4 % 5;
      math4 += 5;
      // First way to do type casting.
      Console.WriteLine(math1.ToString() + " " + math2.ToString() + " " + math3.ToString() +  " " + modulusTest);

      // Second way to do type casting.
      Console.WriteLine(Convert.ToString(math1 + " ") + Convert.ToString(math2 + " ") + Convert.ToString(math3 + " ") + modulusTest);

      // The testing continues?!
      Console.WriteLine(math4);
    }
  }
}