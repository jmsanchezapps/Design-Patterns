using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    //No Quack. No fly
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck!!");
        }
    }
}
