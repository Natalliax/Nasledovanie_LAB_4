using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_LAB_4
{
    public class Сirculation : BankCheck
    {
        int O, P, R; //  о - остаток, p - приход, r - расход

        public Сirculation(int o, int p, int r)
        {
            O = o; P = p; R = r;
        }

        
        public Сirculation(int o, int p, int r, int nomerCheck, int codBanka): base(nomerCheck,codBanka)
        {
            O = o; P = p; R = r;
        }

        public override int Balans()
        {
            return O + P;
        }

        public override int Remainder()
        {
            return O + P - R;
        }

        public override void Print()
        {
            Console.WriteLine($" \nБансковский счет {NomerCheck}, \nкод банка {CodBanka}, \nостаток на утро {O}, \nприход за день {P}, \nрасход за день {R} ");
        }
    }
    }

