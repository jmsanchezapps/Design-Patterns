using SimUDuck.Model;
using SimUDuck.Model.Behaviors;
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
            Duck modelDuck = new ModelDuck();

            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            readheadduck.Display();
            readheadduck.PerformQuack();
            readheadduck.PerformFly();

            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();

            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();

            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.FlyBehavior = new FlyRocketPowered();
            modelDuck.PerformFly();

            Console.ReadKey();
        }
    }
}
