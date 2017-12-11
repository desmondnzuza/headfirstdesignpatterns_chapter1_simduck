using System;

namespace simduck.Behaviours
{
    public class FlyNoWays : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Oh no... I can't fly");            
        }
    }
}