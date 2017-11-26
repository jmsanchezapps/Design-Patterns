using System;

namespace SimUDuck.Model
{
    //No Quack. No fly
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck!!");
        }
    }
}
