using System;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class ByteExtensions
	{
		public static double Pow(this byte @this, double value)
		{
			return Math.Pow(@this, value);
		}
	}
}
