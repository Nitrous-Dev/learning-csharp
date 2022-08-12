using System;

namespace TestingArea
{
  class Dog
  {
    public string name;
    public string color;
    public string favoriteAttack;
    private int attackSlots;
    private int exp;

    public Dog(string _name, string _color, string _favoriteAttack)
    {
        name = _name;
        color = _color;
        favoriteAttack = _favoriteAttack;
        attackSlots = 3;
        exp = 0.25;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Dog dog01 = new Dog("");

      
    }
  }
}
