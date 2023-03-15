using System;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public class VersionParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x15049A0", Offset = "0x15033A0", VA = "0x1815049A0", Slot = "5")]
		public unsafe override bool IsMatch(string matcher)
		{
			string[] array4 = default(string[]);
			string text2 = default(string);
			while (true)
			{
				int num = 0;
				Match match = Regex.Match(base.Value, "(\\d+)\\.(\\d+)\\.(\\d+)");
				char[] array = new char[1];
				array[0] = '.';
				string[] array2 = matcher.Split(array);
				int count = match.Groups.Count;
				if (array2.Length != count)
				{
					break;
				}
				int length = array2.Length;
				if (num < length)
				{
					Match match2 = Regex.Match(array2[num].ToString(), "\\{(.+?)\\}");
					if (match2.Success)
					{
						string text = match2.Groups[1].ToString();
						char[] array3 = new char[2];
						int length2 = array3.Length;
						array3[0] = '%';
						array3[0] = '=';
						if (array4.Length == 2 && int.TryParse(array4[0], out *(int*)num) && int.TryParse(array4[1], out *(int*)num) && int.TryParse(match.Groups[1].ToString(), out *(int*)num))
						{
							if (!new ModuloOperation().Validate(num, num, num))
							{
								break;
							}
							if (text2 == null || text2 != null)
							{
								throw new IndexOutOfRangeException();
							}
							continue;
						}
					}
					num++;
				}
				string text3 = string.Join(".", array2).Replace("*", "(\\d+)");
				string pattern = "^" + text3;
				return Regex.IsMatch(base.Value, pattern);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public VersionParam()
		{
		}
	}
}
