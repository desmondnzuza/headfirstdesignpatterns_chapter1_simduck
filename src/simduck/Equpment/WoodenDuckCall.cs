using System;
using simduck.Behaviours;

namespace simduck.Equipment
{
    public class WoodenDuckCall : DuckCall
    {
        public WoodenDuckCall() : base(new NormalQuack())
        {            
        }

        public override string Description()
        {
            return "Wooden Duck Call";
        }
    }
}