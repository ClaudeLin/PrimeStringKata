using NUnit.Framework;
using PrimeStringKata;

namespace PrimeStringKataTest
{
	[TestFixture]
	public class PrimeStringTest
	{
		[Test]
		[TestCase("a",true)]
		[TestCase("aa",false)]
		[TestCase("abab",false)]
		[TestCase("abc",true)]
		[TestCase("abcabcabcd",true)]
		[TestCase("asdfasdfasdfasdf",false)]
		[TestCase("asdasdadasd",true)]
		public void TestIsPrimeString(string inputString, bool expected)
		{
			var target = new PrimeString();

			var actual = target.IsPrimeString(inputString);

			Assert.AreEqual(expected, actual);
		}
	}

}
