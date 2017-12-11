using System;

namespace simduck.Behaviours
{
    public class LoudQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("QUACK QUACK!!!");            
        }
    }
}