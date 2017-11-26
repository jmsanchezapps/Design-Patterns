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

        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }

        public abstract void Display();
    }
}
