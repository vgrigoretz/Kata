using ConsoleAppKata;
using System;
using NUnit.Framework;

namespace ConsoleAppKataTest
{
	class KataTest
	{
		Kata kata = new Kata();

		[Test]
		public void Return_0_for_empty_string()
		{
			Assert.AreEqual(0, kata.Add(""));
		}

		[Test]
		public void Return_3_for_input_1_and_2()
		{
			Assert.AreEqual(3, kata.Add("1,2"));
		}

		[Test]
		public void Return_15_for_input_1_to_5()
		{
			Assert.AreEqual(15, kata.Add("1,2,3,4,5"));
		}

		[Test]
		public void Return_15_for_input_1_to_5_with_different_delimiters()
		{
			Assert.AreEqual(15, kata.Add("1.2\n3,4,5"));
		}

		[Test]
		public void Throw_exception_for_neggative_nr()
		{
			Assert.Throws(typeof(ArgumentOutOfRangeException), () => kata.Add("1, -2, 4"));
		}
	}
}
