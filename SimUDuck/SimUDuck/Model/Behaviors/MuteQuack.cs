using System;

namespace SimUDuck.Model.Behaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quackk!!");
        }
    }
}
