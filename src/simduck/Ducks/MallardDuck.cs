using System;
using simduck.Behaviours;

namespace simduck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new LoudQuack())       
        {            
        }

        public override void Display()
        {
            Console.WriteLine("Im a Mallard. Hi");
        }
    }
}