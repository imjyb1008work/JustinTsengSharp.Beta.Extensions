using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace System.IO.JustinTsengSharp.Beta.Extensions
{
	public static class StreamExtensions
	{
#if NET35
		public static void CopyTo(this Stream @this, Stream destination, int bufferSize = 81920)
		{
			if (destination is null)
			{
				throw new ArgumentNullException(nameof(destination));
			}

			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(bufferSize));
			}

			byte[] buffer = new byte[bufferSize];

			int read;
			while ((read = @this.Read(buffer, 0, buffer.Length)) > 0)
			{
				destination.Write(buffer, 0, read);
			}
		}
#endif
	}
}
