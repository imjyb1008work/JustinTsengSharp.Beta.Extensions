using System;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static class FloatExtensions
	{
		public static double Round(this float @this)
		{
			return Math.Round(@this);
		}

		public static double Round(this float @this, int decimals)
		{
			return Math.Round(@this, decimals);
		}

		public static double Round(this float @this, int digits, MidpointRounding mode)
		{
			return Math.Round(@this, digits, mode);
		}

		public static double Floor(this float @this, int digits = default)
		{
			var pow = (int)10.Pow(digits);
			return Math.Floor(@this * pow) / pow;
		}

		public static double Ceiling(this float @this, int digits = default)
		{
			var pow = (int)10.Pow(digits);
			return Math.Ceiling(@this * pow) / pow;
		}
	}
}
