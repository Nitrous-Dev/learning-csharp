using System;

namespace TestingArea
{
  class Dog
  {
    public string name;
    public string color;
    public string favoriteAttack;
    private int attackSlots;
    private double exp;

    public Dog(string _name, string _color, string _favoriteAttack)
    {
        name = _name;
        color = _color;
        favoriteAttack = _favoriteAttack;
        attackSlots = 5;
        exp = 0f;
    }

    public void favorite_Attack()
    {
        Console.WriteLine(name + " uses " + favoriteAttack + " to attack his foes!");
        Console.WriteLine(favoriteAttack + " used 2 attack slots!");

        attackSlots -= 2;
        exp += 0.25f;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
        Dog dog01 = new Dog("Good Dog", "Tan", "Slash");

        Console.WriteLine("The dog's name is " + dog01.name + "\n");

        Console.WriteLine("1. Favorite Attack");
        Console.WriteLine("2. Nothing");

        int firstAttack = Convert.ToInt32(Console.ReadLine());

        if (firstAttack == 1)
        {
            Console.WriteLine("");
            dog01.favorite_Attack();
        }
        else if (firstAttack == 2)
        {
            Console.WriteLine("")
            dog01.favorite_Attack();
        }
    }
  }
}
