using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Nasledovanie_LAB_4
{
	public abstract class BankCheck
	{
		protected double NomerCheck, CodBanka;

		public BankCheck()
		{
			
		}

		public BankCheck(double nomerCheck, double codBanka)
		{
			NomerCheck = nomerCheck;
			CodBanka = codBanka;
		}

		public global::System.Double nomerCheck { get => nomerCheck; set => nomerCheck = value; }
		public global::System.Double codBanka { get => codBanka; set => codBanka = value; }

		public abstract int Balans();
		public abstract int Remainder();

		public virtual void Print()
		{
			
			Console.WriteLine($" \nБансковский счет {NomerCheck}, код банка {CodBanka}");
		}
	}
}
