using System;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class Int16Extensions
	{
		public static double Pow(this short @this, double value)
		{
			return Math.Pow(@this, value);
		}
	}
}
