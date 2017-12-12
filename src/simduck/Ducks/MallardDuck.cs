using System;
using simduck.Behaviours;

namespace simduck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithRocket(), new LoudQuack())       
        {            
        }

        public override void Display()
        {
            Console.WriteLine("Im a Mallard. Hi");
        }
    }
}