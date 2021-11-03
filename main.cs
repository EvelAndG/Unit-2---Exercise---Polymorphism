// from https://www.w3schools.com/cs/cs_inheritance.php
using System;

namespace MyApplication
{
//////////////////////////////////////////////////////////////////////////////////////////
  class SiegeWeapon  // Base class (parent) 
  {
    public virtual void Attack()
    {
      Console.WriteLine("I am attacking you with a generic siege weapon.");
    }
  }
//////////////////////////////////////////////////////////////////////////////////////////
  class Catapult : SiegeWeapon  // Derived class (child) 
  {
    public override void Attack()
    {
      Console.WriteLine("I am throwing rocks with a giant wooden arm.");
    }
  }
//////////////////////////////////////////////////////////////////////////////////////////
  class Trebuchet : SiegeWeapon  // Derived class (child) 
  {
    public override void Attack()
    {
      Console.WriteLine("I am throwing rocks with a giant slingshot.");
    }
  }
//////////////////////////////////////////////////////////////////////////////////////////

	class Ballista : SiegeWeapon
	{
		public override void Attack()
		{
			Console.WriteLine("The ballista fires a massive arrow!");
		}
	}

	class BatteringRam : SiegeWeapon
	{
		public override void Attack()
		{
			Console.WriteLine("The Battering ram is breaking through the gate!");
		}
	}
  class Program
  {
    static void Main(string[] args)
    {
      
      SiegeWeapon firstWeapon= new SiegeWeapon();
      firstWeapon.Attack();

      //notice the type here
      SiegeWeapon secondWeapon= new Catapult();
      secondWeapon.Attack();

      //notice the type here
      Catapult thirdWeapon= new Catapult();
      thirdWeapon.Attack();

			Ballista fourthWeapon = new Ballista();
			fourthWeapon.Attack();

			SiegeWeapon fifthWeapon = new BatteringRam();
			fifthWeapon.Attack();


    }
  }
}