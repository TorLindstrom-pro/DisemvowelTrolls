using System.Linq;

namespace DisemvowelTrolls;

public class Kata
{
	public static string Disemvowel(string str) => string.Concat(str.Where(c => !"aeiou".Contains(char.ToLower(c))));
}