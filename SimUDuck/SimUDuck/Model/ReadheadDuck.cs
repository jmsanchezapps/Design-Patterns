using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    public class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a readhead quak!!");
        }
    }
}
