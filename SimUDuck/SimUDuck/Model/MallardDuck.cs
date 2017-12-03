﻿using SimUDuck.Model.Behaviors;
using System;

namespace SimUDuck.Model
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck!!");
        }
    }
}
