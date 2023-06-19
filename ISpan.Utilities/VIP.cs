using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Utilities
{
	public class VIP:Member
	{
		public override int Add(int num1, int num2)
		{
			return num1 + num2 + 100;
		}
	}
}
