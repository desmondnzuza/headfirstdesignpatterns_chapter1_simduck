using System;

namespace simduck.Behaviours
{
    public class NormalQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack Quack");            
        }
    }
}