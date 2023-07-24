using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_LAB_4
{
    internal sealed class KartCheck: BankCheck
    {
        int Limite; // лимит по карте

        public KartCheck(int l)
        {
            Limite = l;
        }

        public KartCheck(int o, int p, int r, int l, double nomerCheck, double codBanka) : base(nomerCheck, codBanka)
        {
            Limite = l;


        }

        public override int Balans()
        {
            return Limite;
        }

        public override int Remainder()
        {
            return Limite;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" \nЛимит счета =  {Limite}");
        }
    }

    
}
