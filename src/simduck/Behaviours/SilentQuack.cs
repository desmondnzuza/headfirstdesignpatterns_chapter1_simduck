using System;

namespace simduck.Behaviours
{
    public class SilentQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("......");            
        }
    }
}