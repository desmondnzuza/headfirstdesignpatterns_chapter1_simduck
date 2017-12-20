using System;
using simduck.Behaviours;

namespace simduck.Equipment
{
    public abstract class DuckCall
    {
        private IQuackBehaviour _quackBehaviour;

        public DuckCall(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }

        public void MakeSound()
        {
            _quackBehaviour.Quack();
        }

        public void ChangeQuackBehaviour(IQuackBehaviour newBehaviour)
        {
            _quackBehaviour = newBehaviour;
        }

        public abstract string Description();
    }
}