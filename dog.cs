using System;

namespace TestingArea
{
  class Dog
  {
    public string name;
    public string color;
    public string attack01;
    public string attack02;
    public string attack03;
    private int attackSlots;
    private double exp;

    public Dog(string _name, string _color, string _attack01, string _attack02, string _attack03)
    {
        name = _name;
        color = _color;
        attack01 = _attack01;
        attack02 = _attack02;
        attack03 = _attack03;
        attackSlots = 5;
        exp = 0f;
    }

    public void firstAttack()
    {
        Console.WriteLine(name + " uses " + attack01 + " to attack his foes!");
        Console.WriteLine(attack01 + " used 2 attack slots!");

        attackSlots -= 2;
        exp += 0.25f;
    }

    public void secondAttack()
    {
        Console.WriteLine(name + " uses " + attack02 + " to attack his foes!");
        Console.WriteLine(attack02 + " used 2 attack slots!");

        attackSlots -= 2;
        exp += 0.25f;
    }

    public void slots()
    {
        attackSlots = 5;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
        Dog dog01 = new Dog("Good Dog", "Tan", "Slash", "Bite", "Bark");

        Console.WriteLine("The dog's name is " + dog01.name + "\n");

        Console.WriteLine("1. Slash");
        Console.WriteLine("2. Bite");
        Console.WriteLine("3. Bark");

        int firstAttack = Convert.ToInt32(Console.ReadLine());

        slots();

        while (attackSlots > 0)
        {
            if (firstAttack == 1)
        {
            Console.WriteLine("\n");
            dog01.slashAttack();
        }
        else if (firstAttack == 2)
        {
            Console.WriteLine("")
            dog01.slashAttack();
        }
        }
        
        Console.WriteLine(dog01.name + "ran out of attack slots, so he is done for today.")

        Console.ReadKey();
    }
  }
}
