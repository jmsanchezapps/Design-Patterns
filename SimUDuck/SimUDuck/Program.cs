using SimUDuck.Model;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck readheadduck = new ReadheadDuck();

            mallardDuck.Display();
            readheadduck.Display();

            Console.ReadKey();
        }
    }
}
