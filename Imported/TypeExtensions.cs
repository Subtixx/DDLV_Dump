using System;
using System.Collections;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class TypeExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4570", Offset = "0x3DC2F70", VA = "0x183DC4570")]
	public static string ToShortString(this Type type)
	{
		//Discarded unreachable code: IL_0065
		string text = type.ToString();
		char[] array = new char[1];
		array[0] = '.';
		string[] array2 = text.Split(array);
		int num = array2.Length - 1;
		string text2 = array2[num];
		char[] array3 = new char[1];
		array3[0] = '+';
		string[] array4 = text2.Split(array3);
		int num2 = array4.Length - 1;
		return array4[num2];
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC44E0", Offset = "0x3DC2EE0", VA = "0x183DC44E0")]
	public static bool IsList(this Type type)
	{
		Guid gUID = typeof(IList).GUID;
		throw new NullReferenceException();
	}
}
