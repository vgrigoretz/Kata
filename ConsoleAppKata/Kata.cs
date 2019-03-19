using System;

namespace ConsoleAppKata
{
	public class Kata
	{
		public int Add(string numbers)
		{
			int sum = 0;

			if (numbers.Length == 0)
			{
				return 0;
			}
			else
			{
				string[] str_arr = numbers.Split(new Char[] { ',', '\\', '\n', '.' },
								 StringSplitOptions.RemoveEmptyEntries);
				int[] nr_array = Array.ConvertAll(str_arr, Int32.Parse);

				//var array = numbers.ToCharArray().Where(x => int.TryParse(x.ToString(), out int myInt)).Select(x => int.Parse(x.ToString())).ToArray();
				foreach (var number in nr_array)
				{
					if (number < 0)
					{
						throw new ArgumentOutOfRangeException(String.Format
							("{0} Negatives not allowed: ", number));
					}
					else
					{
						sum = sum + number;
					}
				}
			}
			return sum;
		}
	}
}
