using System;

namespace JustinTsengSharp.Beta.Extensions
{
	public static class DateTimeExtensions
	{
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
