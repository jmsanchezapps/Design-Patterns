using System;

namespace SimUDuck.Model
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quackk!!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming!!");
        }

        public abstract void Display();
    }
}
