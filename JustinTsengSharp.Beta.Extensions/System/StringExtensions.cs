using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static class StringExtensions
	{
		public static string Trim(this string @this, string trimString)
		{
			return @this.Trim(trimString.ToCharArray());
		}

		public static string TrimSafe(this string @this, params char[] trimChars)
		{
			try
			{
				return @this.Trim(trimChars);
			}
			catch
			{
				return @this;
			}
		}

		public static string TrimSafe(this string @this, string trimString)
		{
			try
			{
				return @this.Trim(trimString.ToCharArray());
			}
			catch
			{
				return @this;
			}
		}

		public static string TrimStart(this string @this, string trimString)
		{
			return @this.TrimStart(trimString.ToCharArray());
		}

		public static string TrimStartSafe(this string @this, string trimString)
		{
			try
			{
				return @this.TrimStart(trimString.ToCharArray());
			}
			catch
			{
				return @this;
			}
		}

		public static string TrimStartSafe(this string @this, params char[] trimChars)
		{
			try
			{
				return @this.TrimStart();
			}
			catch
			{
				return @this;
			}
		}

		public static string TrimEnd(this string @this, string trimString)
		{
			return @this.TrimEnd(trimString.ToCharArray());
		}

		/// <summary>
		/// 呼叫TrimEnd方法，若發生例外時則回傳自身
		/// </summary>
		/// <param name="this"></param>
		/// <returns></returns>
		public static string TrimEndSafe(this string @this, params char[] trimChars)
		{
			try
			{
				return @this.TrimEnd(trimChars);
			}
			catch
			{
				return @this;
			}
		}

		public static string TrimEndSafe(this string @this, string trimString)
		{
			try
			{
				return @this.TrimEnd(trimString.ToCharArray());
			}
			catch
			{
				return @this;
			}
		}

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

		public static string Left(this string @this, int length)
		{
			return @this.Substring(0, length);
		}

		public static string LeftSafe(this string @this, int length)
		{
			if (@this.IsNullOrWhiteSpace() || length < 0) { return @this; }
			return @this.Substring(0, length);
		}

		public static string Right(this string @this, int length)
		{
			int startIndex = @this.Length - length;
			return @this.Substring(startIndex, length);
		}

		public static string RightSafe(this string @this, int length)
		{
			if (@this.IsNullOrWhiteSpace() || length < 0) { return @this; }
			return string.Concat(@this.Reverse().Take(length).Reverse());
		}

		public static bool StartsWithOrFalse(this string @this, string value)
		{
			try
			{
				return @this.StartsWith(value);
			}
			catch
			{
				return false;
			}
		}

		public static bool StartsWithOrFalse(this string @this, string value, StringComparison comparisonType)
		{
			try
			{
				return @this.StartsWith(value, comparisonType);
			}
			catch
			{
				return false;
			}
		}

		public static bool StartsWithOrFalse(this string @this, string value, bool ignoreCase, CultureInfo culture)
		{
			try
			{
				return @this.StartsWith(value, ignoreCase, culture);
			}
			catch
			{
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
			catch
			{
				return false;
			}
		}

		public static bool EndsWithOrFalse(this string @this, string value, bool ignoreCase, CultureInfo culture)
		{
			try
			{
				return @this.EndsWith(value, ignoreCase, culture);
			}
			catch
			{
				return false;
			}
		}

		public static string ReplaceOrThis(this string @this, char oldValue, char newValue)
		{
			try
			{
				return @this.Replace(oldValue, oldValue);
			}
			catch
			{
				return @this;
			}
		}

		public static string ReplaceOrThis(this string @this, string oldValue, string newValue)
		{
			try
			{
				return @this.Replace(oldValue, oldValue);
			}
			catch
			{
				return @this;
			}
		}
	}
}
