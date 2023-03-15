using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ArrayExtention
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB690", Offset = "0x7DA090", VA = "0x1807DB690")]
	public static bool Contains<T>(this T[] array, T Element)
	{
		int num = 0;
		if (num < array.Length)
		{
			num++;
			return true;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2F07280", Offset = "0x2F05C80", VA = "0x182F07280")]
	public static bool Contains(this string[] array, string Element)
	{
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			if (!string.Equals(array[num], Element))
			{
				num++;
			}
			return true;
		}
		int num2 = 0;
		throw new NullReferenceException();
	}
}
