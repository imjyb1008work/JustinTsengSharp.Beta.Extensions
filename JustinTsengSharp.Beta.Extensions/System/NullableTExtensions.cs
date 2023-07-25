namespace System.JustinTsengSharp.Beta.Extensions
{
	public static partial class NullableTExtensions
	{
		public static bool HasValue<T>(this Nullable<T> @this) where T : struct
		{
			return @this.HasValue();
		}
	}
}
