using System;

namespace bored
{
  class Car
  {
    public string name;
    public string color;
    public string model;
    public string brand;
    private int gas;
    private int year;

    public Car(string color_, string model_, string brand_, string name_)
    {
        name = name_;
        color = color_;
        model = model_;
        brand = brand_;
        gas = 3;

    }

    public void drive()
    {
        if (gas > 0)
        {
            Console.WriteLine(name + " used one gallon of gas.");
            gas--;
        }
        else
        {
            Console.WriteLine(name + " has no gas left. :(");
        }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
        Car car01 = new Car("a", "b", "c", "d");
        
        car01.drive();
        
        //Checks to see if a key is pressed
        Console.ReadKey();
    }
  }
}