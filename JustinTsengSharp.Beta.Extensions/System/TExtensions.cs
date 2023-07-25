namespace System.JustinTsengSharp.Beta.Extensions
{
	public static partial class TExtensions
	{
		public static bool HasReference<T>(this T @this) where T : class
		{
			return @this != null;
		}
	}
}
