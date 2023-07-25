using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.JustinTsengSharp.Beta.Extensions
{
	public static partial class ObjectExtensions
	{
		public static bool ToBoolean(this object @this)
		{
			return Convert.ToBoolean(@this);
		}

		public static bool ToBooleanOrDefault(this object @this, bool defaultValue = default)
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

		public static char ToChar(this object @this)
		{
			return Convert.ToChar(@this);
		}

		public static char ToCharOrDefault(this object @this, char defaultValue = default)
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

		public static DateTime ToDateTime(this object @this)
		{
			return Convert.ToDateTime(@this);
		}

		public static DateTime ToDateTimeOrDefault(this object @this, DateTime defaultValue = default)
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

		public static short ToInt16(this object @this)
		{
			return Convert.ToInt16(@this);
		}

		public static short ToInt16OrDefault(this object @this, short defaultValue = default)
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

		public static int ToInt32(this object @this)
		{
			return Convert.ToInt32(@this);
		}

		public static int ToInt32OrDefault(this object @this, int defaultValue = default)
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

		public static long ToInt64(this object @this)
		{
			return Convert.ToInt64(@this);
		}

		public static long ToInt64OrDefault(this object @this, long defaultValue = default)
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

		public static float ToSingle(this object @this)
		{
			return Convert.ToSingle(@this);
		}

		public static float ToSingleOrDefault(this object @this, float defaultValue = default)
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

		public static double ToDouble(this object @this)
		{
			return Convert.ToDouble(@this);
		}

		public static double ToDoubleOrDefault(this object @this, double defaultValue = default)
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

		public static decimal ToDecimal(this object @this)
		{
			return Convert.ToDecimal(@this);
		}

		public static decimal ToDecimalOrDefault(this object @this, decimal defaultValue = default)
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

		public static string ToStringOrDefault(this object @this, string defaultValue = default)
		{
			try
			{
				return @this.ToString();
			}
			catch
			{
				return default;
			}
		}

		public static string ToStringSafe(this object @this)
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

		public static bool IsDBNull(this object @this)
		{
			return Convert.IsDBNull(@this);
		}

		public static bool IsNull(this object @this)
		{
			return @this == null;
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
