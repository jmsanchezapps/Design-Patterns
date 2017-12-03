using System;

namespace SimUDuck.Model.Behaviors
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quackk!!");
        }
    }
}
