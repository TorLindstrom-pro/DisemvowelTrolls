using System.Linq;

namespace DisemvowelTrolls;

public class Kata
{
	public static string Disemvowel(string str)
	{
		var vowels = new[]{'a', 'e', 'i', 'o', 'u'};
		return str
			.Where(c => !vowels.Contains(char.ToLower(c)))
			.Aggregate("", (result, c) => result + c);
	}
}