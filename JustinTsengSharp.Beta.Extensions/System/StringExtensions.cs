using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmpty(this string @this)
		{
			return string.IsNullOrEmpty(@this);
		}

		/// <summary>
		/// 此方法參考至微軟 string.IsNullOrWhiteSpace(String value) 的原始碼 
		/// .net framework 3.5 並沒有實作 string.IsNullOrWhiteSpace(String value) 此方法
		/// </summary>
		/// <param name="this"></param>
		/// <returns></returns>
		public static bool IsNullOrWhiteSpace(this string @this)
		{

			if (@this == null) return true;

			for (int i = 0; i < @this.Length; i++)
			{
				if (!Char.IsWhiteSpace(@this[i])) return false;
			}

			return true;
		}

		public static string SubStringOrEmpty(this string @this, int startIndex, int length)
		{
			if (string.IsNullOrEmpty(@this))
			{
				return string.Empty;
			}

			try
			{
#if NET35
				return string.Join(string.Empty, new string[] { new string(@this.Skip(startIndex).Take(length).ToArray()) });
#else
				return string.Join(string.Empty, @this.Skip(startIndex).Take(length));
#endif
			}
			catch
			{
				return string.Empty;
			}
		}

		public static bool StartsWithOrFalse(this string @this, string value)
		{
			try
			{
				return @this.StartsWith(value);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static bool StartsWithOrFalse(this string @this, string value, StringComparison comparisonType)
		{
			try
			{
				return @this.StartsWith(value, comparisonType);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static bool StartsWithOrFalse(this string @this, string value, bool ignoreCase, CultureInfo culture)
		{
			try
			{
				return @this.StartsWith(value, ignoreCase, culture);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static bool EndsWithOrFalse(this string @this, string value)
		{
			try
			{
				return @this.EndsWith(value);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static bool EndsWithOrFalse(this string @this, string value, StringComparison comparisonType)
		{
			try
			{
				return @this.EndsWith(value, comparisonType);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static bool EndsWithOrFalse(this string @this, string value, bool ignoreCase, CultureInfo culture)
		{
			try
			{
				return @this.EndsWith(value, ignoreCase, culture);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return false;
			}
		}

		public static string ReplaceOrEmpty(this string @this, char oldValue, char newValue)
		{
			try
			{
				return @this.Replace(oldValue, oldValue);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return string.Empty;
			}
		}

		public static string ReplaceOrEmpty(this string @this, string oldValue, string newValue)
		{
			try
			{
				return @this.Replace(oldValue, oldValue);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return string.Empty;
			}
		}
	}
}
