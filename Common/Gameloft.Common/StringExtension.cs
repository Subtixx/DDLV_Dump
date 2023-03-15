using System;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class StringExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x41145D0", Offset = "0x4112FD0", VA = "0x1841145D0")]
		public static bool Contains(this string value, string substring, StringComparison comp)
		{
			if (value != null)
			{
				int num = value.IndexOf(substring, comp);
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4114690", Offset = "0x4113090", VA = "0x184114690")]
		public static bool TryIsGameVersionHigher(this string v1, string v2, out bool isGameVersionHigher)
		{
			string strA = ToComparableVersion(v1);
			string text = ToComparableVersion(v2);
			if (text != null)
			{
			}
			bool flag = text == null;
			bool value = default(bool);
			if (flag)
			{
				value = string.Compare(strA, text) > 0;
			}
			isGameVersionHigher.m_value = value;
			return flag;
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41147D0", Offset = "0x41131D0", VA = "0x1841147D0")]
			static string Format(int major, int minor, int hotfix, int build)
			{
				//Discarded unreachable code: IL_0053
				object[] array;
				while (true)
				{
					array = new object[4];
					if (array == null || array != null)
					{
						array[0] = array;
						if (array == null || array != null)
						{
							array[1] = array;
							if (array == null || array != null)
							{
								array[2] = array;
								if (array == null || array != null)
								{
									break;
								}
							}
						}
					}
				}
				array[3] = array;
				return string.Format("{0:0000000000}_{1:0000000000}_{2:0000000000}_{3:0000000000}", array);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4114A30", Offset = "0x4113430", VA = "0x184114A30")]
			static string ToComparableVersion(string version)
			{
				Match match = Regex.Match(version, "^(\\d+)\\.(\\d+)$");
				if (!match.Success)
				{
					Match match2 = Regex.Match(version, "^(\\d+)\\.(\\d+)\\.(\\d+)(\\.(\\d+))?$");
					if (!match2.Success)
					{
					}
					int major2 = int.Parse(match2.Groups[1].Value);
					int minor2 = int.Parse(match2.Groups[2].Value);
					int hotfix2 = int.Parse(match2.Groups[3].Value);
					if (match2.Groups.Count > 5 && !string.IsNullOrEmpty(match2.Groups[4].Value))
					{
						string value2 = match2.Groups[5].Value;
						bool flag2 = default(bool);
						if (!flag2)
						{
						}
					}
					int build2 = 0;
					return Format(major2, minor2, hotfix2, build2);
				}
				int num = int.Parse(match.Groups[1].Value);
				int num2 = int.Parse(match.Groups[2].Value);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4114730", Offset = "0x4113130", VA = "0x184114730")]
		public static bool TryIsGameVersionLower(this string v1, string v2, out bool isGameVersionLower)
		{
			string strA = ToComparableVersion(v1);
			string text = ToComparableVersion(v2);
			if (text != null)
			{
			}
			int value = 0;
			bool flag = text == null;
			if (flag)
			{
				int num = string.Compare(strA, text);
			}
			isGameVersionLower.m_value = (byte)value != 0;
			return flag;
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41147D0", Offset = "0x41131D0", VA = "0x1841147D0")]
			static string Format(int major, int minor, int hotfix, int build)
			{
				//Discarded unreachable code: IL_0053
				object[] array;
				while (true)
				{
					array = new object[4];
					if (array == null || array != null)
					{
						array[0] = array;
						if (array == null || array != null)
						{
							array[1] = array;
							if (array == null || array != null)
							{
								array[2] = array;
								if (array == null || array != null)
								{
									break;
								}
							}
						}
					}
				}
				array[3] = array;
				return string.Format("{0:0000000000}_{1:0000000000}_{2:0000000000}_{3:0000000000}", array);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4114A30", Offset = "0x4113430", VA = "0x184114A30")]
			static string ToComparableVersion(string version)
			{
				Match match = Regex.Match(version, "^(\\d+)\\.(\\d+)$");
				if (!match.Success)
				{
					Match match2 = Regex.Match(version, "^(\\d+)\\.(\\d+)\\.(\\d+)(\\.(\\d+))?$");
					if (!match2.Success)
					{
					}
					int major2 = int.Parse(match2.Groups[1].Value);
					int minor2 = int.Parse(match2.Groups[2].Value);
					int hotfix2 = int.Parse(match2.Groups[3].Value);
					if (match2.Groups.Count > 5 && !string.IsNullOrEmpty(match2.Groups[4].Value))
					{
						string value2 = match2.Groups[5].Value;
						bool flag2 = default(bool);
						if (!flag2)
						{
						}
					}
					int build2 = 0;
					return Format(major2, minor2, hotfix2, build2);
				}
				int num2 = int.Parse(match.Groups[1].Value);
				int num3 = int.Parse(match.Groups[2].Value);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4114600", Offset = "0x4113000", VA = "0x184114600")]
		public static bool TryCompareGameVersion(this string v1, string v2, out int result)
		{
			string strA = ToComparableVersion(v1);
			string text = ToComparableVersion(v2);
			if (text != null)
			{
			}
			bool flag = text == null;
			if (flag)
			{
				int num = (result.m_value = string.Compare(strA, text));
			}
			return flag;
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41147D0", Offset = "0x41131D0", VA = "0x1841147D0")]
			static string Format(int major, int minor, int hotfix, int build)
			{
				//Discarded unreachable code: IL_0053
				object[] array;
				while (true)
				{
					array = new object[4];
					if (array == null || array != null)
					{
						array[0] = array;
						if (array == null || array != null)
						{
							array[1] = array;
							if (array == null || array != null)
							{
								array[2] = array;
								if (array == null || array != null)
								{
									break;
								}
							}
						}
					}
				}
				array[3] = array;
				return string.Format("{0:0000000000}_{1:0000000000}_{2:0000000000}_{3:0000000000}", array);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4114A30", Offset = "0x4113430", VA = "0x184114A30")]
			static string ToComparableVersion(string version)
			{
				Match match = Regex.Match(version, "^(\\d+)\\.(\\d+)$");
				if (!match.Success)
				{
					Match match2 = Regex.Match(version, "^(\\d+)\\.(\\d+)\\.(\\d+)(\\.(\\d+))?$");
					if (!match2.Success)
					{
					}
					int major2 = int.Parse(match2.Groups[1].Value);
					int minor2 = int.Parse(match2.Groups[2].Value);
					int hotfix2 = int.Parse(match2.Groups[3].Value);
					if (match2.Groups.Count > 5 && !string.IsNullOrEmpty(match2.Groups[4].Value))
					{
						string value = match2.Groups[5].Value;
						bool flag2 = default(bool);
						if (!flag2)
						{
						}
					}
					int build2 = 0;
					return Format(major2, minor2, hotfix2, build2);
				}
				int num2 = int.Parse(match.Groups[1].Value);
				int num3 = int.Parse(match.Groups[2].Value);
				throw new NullReferenceException();
			}
		}
	}
}
