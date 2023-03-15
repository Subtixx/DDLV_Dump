using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000041")]
public class StringUtility : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3000", Offset = "0x3DC1A00", VA = "0x183DC3000")]
	public static string Concat(string[] array, string separator = "")
	{
		//Discarded unreachable code: IL_0050
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			if (num > 0 && array[num] != "")
			{
				string text = "" + separator;
			}
			string text2 = array[num];
			string text3 = "" + text2;
			num++;
		}
		return "";
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F07280", Offset = "0x2F05C80", VA = "0x182F07280")]
	public static bool Contains(string[] array, string element = "")
	{
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			if (!string.Equals(array[num], element))
			{
				num++;
			}
			return true;
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public StringUtility()
	{
	}
}
