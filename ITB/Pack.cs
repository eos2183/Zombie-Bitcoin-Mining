using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;

namespace ITB
{
	class Pack
	{
		public static string Reverse(string str)
		{
			return new string(str.Reverse<char>().ToArray<char>());
		}
	}
}
