using System;
using simduck.Behaviours;

namespace simduck.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWays(), new SilentQuack())       
        {            
        }

        public override void Display()
        {
            Console.WriteLine("Im a decoy duck. Hi");
        }
    }
}