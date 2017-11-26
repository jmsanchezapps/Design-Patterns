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
            Duck rubberDuck = new RubberDuck();
            Duck decoyDuck = new DecoyDuck();

            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();

            readheadduck.Display();
            readheadduck.Quack();
            readheadduck.Fly();

            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Fly();

            decoyDuck.Display();
            decoyDuck.Quack();
            decoyDuck.Fly();

            Console.ReadKey();
        }
    }
}
