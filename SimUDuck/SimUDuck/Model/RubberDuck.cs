﻿using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    //No Quack, Squeak. No fly
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck!!");
        }
    }
}
