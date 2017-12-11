using System;

namespace simduck.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Im flying with my wings");            
        }
    }
}