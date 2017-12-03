using System;

namespace SimUDuck.Model.Behaviors
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeaking!!");
        }
    }
}
