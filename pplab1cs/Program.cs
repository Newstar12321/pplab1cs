using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pplab1cs
{
    class Program
    {
        static void Main(string[] args)
        {
			const int SUM = 13;
			int k = 0;

			for (int i = 0; i < 1000; i++)
			{
				if ((i / 100 + i % 100 / 10 + i % 10) == SUM)
				{
					k++;
				}
			}
			k *= k;
			Console.WriteLine(k);
			Console.ReadKey();
		}
    }
}
