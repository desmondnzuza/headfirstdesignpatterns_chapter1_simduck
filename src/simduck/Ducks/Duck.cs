using System;
using simduck.Behaviours;

namespace simduck.Ducks
{
    public abstract class Duck
    {
        private readonly IFlyBehaviour _flyBehaviour;
        private readonly IQuackBehaviour _quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
        }

        public void Swim()
        {
            System.Console.WriteLine("I'm swimming");
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }
    }
}