namespace DisemvowelTrolls;

public class Kata
{
	public static string Disemvowel(string str)
	{
		var vowels = new[]{'a', 'e', 'i', 'o', 'u'};
		return str
			.Where(c => !vowels.Contains(c))
			.Aggregate("", (result, c) => result + c);
	}
}