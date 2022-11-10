using System;
using System.Diagnostics;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class DateTimeExtensions
	{
		public static string ToDateTimeString(this DateTime @this)
		{
			try
			{
				return @this.ToString(DateTimeStringConfig.Value, DateTimeStringConfig.Provider);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return @this.ToString();
			}
		}

		public static string ToDateString(this DateTime @this)
		{
			try
			{
				return @this.ToString(DateStringConfig.Value, DateStringConfig.Provider);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return @this.ToShortDateString();
			}
		}

		public static string ToTimeString(this DateTime @this)
		{
			try
			{
				return @this.ToString(TimeStringConfig.Value, TimeStringConfig.Provider);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				return @this.ToShortTimeString();
			}
		}

		public static bool IsBetween(this DateTime @this, DateTime start, DateTime end, bool isCompareOnlyDate = false)
		{
			if (isCompareOnlyDate)
			{
				return @this.Date >= start.Date && @this.Date <= end.Date;
			}

			return @this >= start && @this <= end;
		}

		public static bool IsLeapYear(this DateTime @this)
		{
			return DateTime.IsLeapYear(@this.Year);
		}

		public static int PrevYear(this DateTime @this)
		{
			return @this.AddYears(-1).Year;
		}

		public static int NextYear(this DateTime @this)
		{
			return @this.AddYears(1).Year;
		}

		public static int PrevMonth(this DateTime @this)
		{
			return @this.AddMonths(-1).Month;
		}

		public static int NextMonth(this DateTime @this)
		{
			return @this.AddMonths(1).Month;
		}

		public static int DaysInMonth(this DateTime @this)
		{
			return DateTime.DaysInMonth(@this.Year, @this.Month);
		}

		public static DateTime FirstDateInMonth(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, 1);
		}

		public static DateTime LastDateInMonth(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, DateTime.DaysInMonth(@this.Year, @this.Month));
		}
	}
}
