using System;

namespace SYS_Les6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class PickUps
    {
        public virtual void onPickUp()
        {
            Console.WriteLine("You pick up the thing");
        }

        public void HitByMouse(int x, int y)
        {
            int ItemX = 10;
            int ItemY = 30;

            if (x == ItemX && y == ItemY)
            {
                onPickUp();
            }
        }
    }
    abstract class Equipment : PickUps
    {
        public virtual void Equip()
        {

        }
    }

    class Armor : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Dit is een zwaard");
        }
    }
    class Weapon : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Dit is een helm");
        }
    }

    class HealingPotion : PickUps
    {
        public override void onPickUp()
        {
            base.onPickUp();
            Console.WriteLine("Je hebt nu een HealthPotion in je inv");
        }
    }
    class ManaPotion : PickUps
    {
        public override void onPickUp()
        {
            base.onPickUp();
            Console.WriteLine("Je hebt nu een ManaPotion in je inv");
        }
    }
}
