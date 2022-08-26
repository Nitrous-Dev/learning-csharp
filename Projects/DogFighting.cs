using System;

namespace TestingArea
{
  class Dog
  {
    public string name;
    private string color;
    private string attack01;
    private string attack02;
    private string attack03;
    public int attackSlots;
    private double exp;

    public Dog(string _name, string _color, string _attack01, string _attack02, string _attack03, int _attackSlots)
    {
        name = _name;
        color = _color;
        attack01 = _attack01;
        attack02 = _attack02;
        attack03 = _attack03;
        attackSlots = _attackSlots;
        exp = 0f;
    }

    public void attackOneSlot()
    {
        Console.WriteLine(name + " uses " + attack01 + " to attack his foes!");
        Console.WriteLine(attack01 + " used 1 attack slot!");

        attackSlots -= 1;
        exp += 0.5f;
    }

    public void attackTwoSlots()
    {
        Console.WriteLine(name + " uses " + attack02 + " to attack his foes!");
        Console.WriteLine(attack02 + " used 2 attack slots!");

        attackSlots -= 2;
        exp += 1f;
    }

    public void scareOneSlot()
    {
        Console.WriteLine(name + " uses " + attack03 + " to scare his foes!");
        Console.WriteLine(attack02 + " used 1 attack slot!");

        attackSlots -= 1;
        exp += 0.5f;
    }

    public void regenerate()
    {
        Console.WriteLine(name + "took a small break to reset all of his attack slots!");
        attackSlots = 5;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
        Dog dog01 = new Dog("Good Dog", "Tan", "Slash", "Bite", "Bark", 5);

        Console.WriteLine("Your dog's name is " + dog01.name);
        Console.WriteLine("His fur is " + dog01.color + " ,and he loves to fight!" + "\n")

        Console.WriteLine("1. Slash");
        Console.WriteLine("2. Bite");
        Console.WriteLine("3. Bark");
        Console.WriteLine("4. Regenerate");

        while (dog01.attackSlots > 0)
        {
            int Attack = Convert.ToInt32(Console.ReadLine());

            if (Attack == 1)
            {
                Console.WriteLine("\n");
                dog01.attackOneSlot();
            }
            else if (Attack == 2)
            {
                Console.WriteLine("");
                dog01.attackTwoSlots();
            }
            else if (Attack == 3)
            {
                Console.WriteLine("");
                dog01.scareOneSlot();

            }
            else if (Attack == 4)
            {
                Console.WriteLine("");
                dog01.regenerate();
            }

        }
        
        Console.WriteLine(dog01.name + "ran out of attack slots, so he is done for today.");

        Console.ReadKey();

        static type hi 
    }
  }
}
