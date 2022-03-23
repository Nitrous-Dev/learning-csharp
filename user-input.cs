using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your favorite video game console:");

        string favoriteConsole = Console.ReadLine();

        Console.WriteLine("Your favorite video game console is the: " + favoriteConsole);

        Console.WriteLine("Please enter your favorite number:");

        int favoriteNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your favorite number is: " + favoriteNumber);

        Console.WriteLine("Please enter your favorite video game engine:");

        string favoriteEngine = Console.ReadLine();

        Console.WriteLine("Your favorite video game engine is: " + favoriteEngine);
    }
  }
}