using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace JustinTsengSharp.Beta.Extensions.System
{
	public static class NullableTExtensions
	{
		public static bool IsNull<T>(this Nullable<T> @this) where T : struct
		{
			return @this == null;
		}

		public static string ToStringOrEmpty<T>(this Nullable<T> @this) where T : struct
		{
			try
			{
				return @this.ToString();
			}
			catch
			{
				return string.Empty;
			}
		}

		public static string ToStringOrDefault<T>(this Nullable<T> @this, string defaultValue = default) where T : struct
		{
			try
			{
				return @this.ToString();
			}
			catch
			{
				return defaultValue;
			}
		}

		public static bool ToBoolean<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToBoolean(@this);
		}

		public static bool ToBooleanOrDefault<T>(this Nullable<T> @this, bool defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToBoolean(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static char ToChar<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToChar(@this);
		}

		public static char ToCharOrDefault<T>(this Nullable<T> @this, char defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToChar(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static DateTime ToDateTime<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToDateTime(@this);
		}

		public static DateTime ToDateTimeOrDefault<T>(this Nullable<T> @this, DateTime defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToDateTime(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static short ToInt16<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToInt16(@this);
		}

		public static short ToInt16OrDefault<T>(this Nullable<T> @this, short defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToInt16(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static int ToInt32<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToInt32(@this);
		}

		public static int ToInt32OrDefault<T>(this Nullable<T> @this, int defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToInt32(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static long ToInt64<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToInt64(@this);
		}

		public static long ToInt64OrDefault<T>(this Nullable<T> @this, long defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToInt64(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static float ToSingle<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToSingle(@this);
		}

		public static float ToSingleOrDefault<T>(this Nullable<T> @this, float defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToSingle(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static double ToDouble<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToDouble(@this);
		}

		public static double ToDoubleOrDefault<T>(this Nullable<T> @this, double defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToDouble(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static decimal ToDecimal<T>(this Nullable<T> @this) where T : struct
		{
			return Convert.ToDecimal(@this);
		}

		public static decimal ToDecimalOrDefault<T>(this Nullable<T> @this, decimal defaultValue = default) where T : struct
		{
			try
			{
				return Convert.ToDecimal(@this);
			}
			catch
			{
				return default;
			}
		}
	}
}
