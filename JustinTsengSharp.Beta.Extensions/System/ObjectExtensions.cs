using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static class ObjectExtensions
	{
		public static bool ToBoolean(this double @this)
		{
			return Convert.ToBoolean(@this);
		}

		public static bool ToBooleanOrDefault(this double @this, bool defaultValue = default)
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

		public static char ToChar(this double @this)
		{
			return Convert.ToChar(@this);
		}

		public static char ToCharOrDefault(this double @this, char defaultValue = default)
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

		public static DateTime ToDateTime(this double @this)
		{
			return Convert.ToDateTime(@this);
		}

		public static DateTime ToDateTimeOrDefault(this double @this, DateTime defaultValue = default)
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

		public static short ToInt16(this double @this)
		{
			return Convert.ToInt16(@this);
		}

		public static short ToInt16OrDefault(this double @this, short defaultValue = default)
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

		public static int ToInt32(this double @this)
		{
			return Convert.ToInt32(@this);
		}

		public static int ToInt32OrDefault(this double @this, int defaultValue = default)
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

		public static long ToInt64(this double @this)
		{
			return Convert.ToInt64(@this);
		}

		public static long ToInt64OrDefault(this double @this, long defaultValue = default)
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

		public static float ToSingle(this double @this)
		{
			return Convert.ToSingle(@this);
		}

		public static float ToSingleOrDefault(this double @this, float defaultValue = default)
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

		public static double ToDouble(this double @this)
		{
			return Convert.ToDouble(@this);
		}

		public static double ToDoubleOrDefault(this double @this, double defaultValue = default)
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

		public static decimal ToDecimal(this double @this)
		{
			return Convert.ToDecimal(@this);
		}

		public static decimal ToDecimalOrDefault(this double @this, decimal defaultValue = default)
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

		public static bool HasValue(object @this)
		{
			return @this != null;
		}

		public static bool IsDBNull(this object @this)
		{
			return Convert.IsDBNull(@this);
		}

		public static bool IsNull(this object @this)
		{
			return @this == null;
		}

		public static bool IsNotNull(this object @this)
		{
			return @this != null;
		}

		public static T GetCustomAttribute<T>(this object @this) where T : Attribute
		{
			var type = @this.GetType();
			return (T)(type.IsEnum ?
				Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T)) :
				Attribute.GetCustomAttribute(type, typeof(T)));
		}
	}
}
