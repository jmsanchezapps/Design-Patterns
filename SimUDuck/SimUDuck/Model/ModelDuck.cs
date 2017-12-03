using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck!!");
        }
    }
}
