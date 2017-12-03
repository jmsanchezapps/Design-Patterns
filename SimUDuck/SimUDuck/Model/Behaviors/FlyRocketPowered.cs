using System;

namespace SimUDuck.Model.Behaviors
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!!");
        }
    }
}
