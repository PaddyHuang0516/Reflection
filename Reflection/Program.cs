
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member member = GetMember();
			int result = member.Add(1,2);

			Console.WriteLine(result);
		}

		private static Member GetMember()
		{
			//ISpan.Utilities.Member  類別全名
			//ISpan.Utilities  dll全名

			//string setting = "ISpan.Utilities.Member,ISpan.Utilities";
			string setting = "ISpan.Utilities.VIP,ISpan.Utilities";
			string[] settings = setting.Split(',');
			string className = settings[0];
			string dllName = settings[1];

			Member obj = (Member)Assembly.Load(dllName).CreateInstance(className);
			return obj;
			//return new Member();
		}
	}
}
