using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static class DecimalExtensions
	{
		public static decimal Round(this decimal @this)
		{
			return Math.Round(@this);
		}

		public static decimal Round(this decimal @this, int decimals)
		{
			return Math.Round(@this, decimals);
		}

		public static decimal Round(this decimal @this, int decimals, MidpointRounding mode)
		{
			return Math.Round(@this, decimals, mode);
		}

		public static decimal Floor(this decimal @this, int decimals = default)
		{
			var pow = (int)10.Pow(decimals);
			return Math.Floor(@this * pow) / pow;
		}

		public static decimal Ceiling(this decimal @this, int decimals = default)
		{
			var pow = (int)10.Pow(decimals);
			return Math.Ceiling(@this * pow) / pow;
		}
	}
}
