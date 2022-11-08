﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class ObjectExtensions
	{
		public static byte ToByteOrDefault(this object @this, byte defaultValue = default)
		{
			try
			{
				return Convert.ToByte(@this);
			}
			catch (Exception)
			{
				return defaultValue;
			}
		}

		public static int ToInt32(this object @this, int? defaultValue = null)
		{
			try
			{
				return @this.ToInt32();
			}
			catch
			{
				if (defaultValue == null)
				{
					throw;
				}

				return defaultValue.Value;
			}
		}

		public static short ToShortOrDefault(this object @this, short defaultValue = default)
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

		public static long ToLongOrDefault(this object @this, long defaultValue = default)
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

		public static float ToFloatOrDefault(this object @this, float defaultValue = default)
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

		public static string ToStringOrDefault(this object @this, string defaultValue = default)
		{
			try
			{
				return Convert.ToString(@this);
			}
			catch
			{
				return defaultValue;
			}
		}

		public static string ToStringOrEmpty(this object @this)
		{
			try
			{
				return Convert.ToString(@this);
			}
			catch
			{
				return string.Empty;
			}
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

		public static bool HasValue(object @this)
		{
			return @this != null;
		}

		public static bool IsNull(this object @this)
		{
			return @this == null;
		}

		public static bool IsNotNull(this object @this)
		{
			return @this != null;
		}

	}
}
