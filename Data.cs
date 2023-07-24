using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;


namespace Nasledovanie_LAB_4
{
	public class Data : BankCheck
	{
		public Data()
		{
		}

		public Data(int nomerCheck, int codBanka) : base(nomerCheck, codBanka)
		{
		}
		public override int Balans()
		{
			return 0;
		}
		public override int Remainder()
		{
			return 0;
		}

		new public void Print()
		{
			base.Print();
			Console.WriteLine($" \nБансковский счет {NomerCheck}, код банка {CodBanka}");
		}

	}
}

