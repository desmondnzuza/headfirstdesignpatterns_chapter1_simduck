using System;
using simduck.Behaviours;

namespace simduck.Equipment
{
    public class SteelDuckCall : DuckCall
    {
        public SteelDuckCall() : base(new LoudQuack())
        {            
        }

        public override string Description()
        {
            return "Steel Duck Call";
        }
    }
}