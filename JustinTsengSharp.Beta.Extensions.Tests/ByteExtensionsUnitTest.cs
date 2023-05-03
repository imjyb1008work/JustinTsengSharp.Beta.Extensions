using System.JustinTsengSharp.Beta.Extensions;
using JustinTsengSharp.Beta.Extensions.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.JustinTsengSharp.Beta.Extensions;
namespace JustinTsengSharp.Beta.Extensions.Tests
{
	[TestClass]
	public class ByteExtensionsUnitTest
	{
		[TestMethod]
		[DataRow(0, false)]
		[DataRow(1, true)]
		[DataRow(12, true)]
		public void ToBoolean(int input, bool expected)
		{
		}
	}

	[TestClass]
	public class UnitTest
	{
		private int max = 100_000_000;

		[TestMethod]
		public void ToBooleanV1()
		{
			byte value = 0;
			bool flag = false;
			for (int i = 0; i < max; i++)
			{
				flag = Convert.ToBoolean(value);
			}
		}

		[TestMethod]
		public void ToBooleanV2()
		{
			byte value = 0;
			bool flag = false;
			for (int i = 0; i < max; i++)
			{
				flag = value.ToBoolean();
			}
		}
	}
}