using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex023_Inheritance.Abilitys
{
    class Ability
    {
        public Ability(byte rechargeTime = 0)
        {
            this.rechargeTime = rechargeTime;
        }
        protected string name;
        public string Name => name;
        protected byte rechargeTime;
        public byte RechargeTime => rechargeTime;

    }

}
