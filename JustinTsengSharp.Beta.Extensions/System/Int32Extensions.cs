using System;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class Int32Extensions
	{
		public static double Pow(this int @this, double value)
		{
			return Math.Pow(@this, value);
		}
	}
}
