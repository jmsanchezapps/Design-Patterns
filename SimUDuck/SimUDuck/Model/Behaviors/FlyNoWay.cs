using System;

namespace SimUDuck.Model.Behaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!!");
        }
    }
}
