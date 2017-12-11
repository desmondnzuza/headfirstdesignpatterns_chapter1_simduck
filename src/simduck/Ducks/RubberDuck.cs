using System;
using simduck.Behaviours;

namespace simduck.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWays(), new NormalQuack())       
        {            
        }

        public override void Display()
        {
            Console.WriteLine("Im a rubber ducky. Hi");
        }
    }
}