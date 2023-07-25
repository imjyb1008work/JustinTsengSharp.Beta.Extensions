using System;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static partial class ByteExtensions
	{
		public static double Pow(this byte @this, double value)
		{
			return Math.Pow(@this, value);
		}
	}
}
