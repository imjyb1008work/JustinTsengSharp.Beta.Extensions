using System;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class DoubleExtensions
	{
		public static double Round(this double @this)
		{
			return Math.Round(@this);
		}

		public static double Round(this double @this, int decimals)
		{
			return Math.Round(@this, decimals);
		}

		public static double Round(this double @this, int digits, MidpointRounding mode)
		{
			return Math.Round(@this, digits, mode);
		}

		public static double Floor(this double @this, int digits = default)
		{
			var pow = (int)10.Pow(digits);
			return Math.Floor(@this * pow) / pow;
		}

		public static double Ceiling(this double @this, int digits = default)
		{
			var pow = (int)10.Pow(digits);
			return Math.Ceiling(@this * pow) / pow;
		}
	}
}
