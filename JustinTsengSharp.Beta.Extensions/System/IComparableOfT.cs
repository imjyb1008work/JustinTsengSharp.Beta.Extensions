using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static class IComparableOfTExtensions
	{
		public static bool IsBetween<T>(this T @this, T start, T end) where T : IComparable<T>
		{
			return Comparer<T>.Default.Compare(@this, start) >= 0 && Comparer<T>.Default.Compare(@this, end) <= 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="this"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="comparer"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">comparer is null</exception>
		public static bool IsBetween<T>(this T @this, T start, T end, IComparer<T> comparer) where T : IComparable<T>
		{
			if (comparer == null)
			{
				throw new ArgumentNullException(nameof(comparer));
			}

			return comparer.Compare(@this, start) >= 0 && comparer.Compare(@this, end) <= 0;
		}
	}
}
