using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { get;  set; }

        public IFlyBehavior FlyBehavior { get; set; }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming!!");
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public abstract void Display();
    }
}
