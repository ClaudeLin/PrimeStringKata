using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeStringKata;

namespace PrimeStringKataTest
{
	[TestClass]
	public class PrimeStringTest
	{
		[TestMethod]
		public void Check_a_should_be_true()
		{
			var target = new PrimeString();
			var inputString = "a";

			var actual = target.IsPrimeString(inputString);

			Assert.IsTrue(actual);
		}

		
	}
}
