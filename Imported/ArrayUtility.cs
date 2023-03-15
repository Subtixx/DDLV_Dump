using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ArrayUtility : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DCAC0", Offset = "0x7DB4C0", VA = "0x1807DCAC0")]
	public static T[] Remove<T>(T[] array, T element)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DC780", Offset = "0x7DB180", VA = "0x1807DC780")]
	public static void Remove<T>(ref T[] array, T element)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7DC780", Offset = "0x7DB180", VA = "0x1807DC780")]
	public static void Add<T>(ref T[] array, T element)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA00", Offset = "0x7DB400", VA = "0x1807DCA00")]
	public static T[] Insert<T>(T[] array, T element, int at)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7DC840", Offset = "0x7DB240", VA = "0x1807DC840")]
	public static List<T> ArrayToList<T>(T[] array)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8C0", Offset = "0x7DB2C0", VA = "0x1807DC8C0")]
	public static bool Contains<T>(T[] array, T Element)
	{
		int num = 0;
		if (num < array.Length)
		{
			num++;
			return true;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7DC960", Offset = "0x7DB360", VA = "0x1807DC960")]
	public static int IndexOf<T>(T[] array, T Element)
	{
		int num = 0;
		if (num < array.Length)
		{
			return num + 1;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2F07870", Offset = "0x2F06270", VA = "0x182F07870")]
	public static int IndexOf(string[] array, string Element)
	{
		//Discarded unreachable code: IL_0025
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			if (!string.Equals(array[num], Element))
			{
				num++;
			}
			return num;
		}
		return -1;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7DCB70", Offset = "0x7DB570", VA = "0x1807DCB70")]
	public static int findIndex<T>(T[] array, T value)
	{
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			T val = array[num];
			string a = default(string);
			string b = default(string);
			if (!string.Equals(a, b))
			{
				num++;
			}
			return num;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2F07310", Offset = "0x2F05D10", VA = "0x182F07310")]
	public static object[] ConvertToObjectArray(object obj)
	{
		//Discarded unreachable code: IL_00b3, IL_00b8, IL_00c1, IL_00e7, IL_00f3, IL_00ff, IL_010b
		//IL_00d0: Expected O, but got I4
		Type type = obj.GetType();
		Type typeFromHandle = typeof(float[]);
		bool flag = ((object)type).Equals((object)typeFromHandle);
		if (!flag)
		{
			bool flag2 = obj.GetType().IsList();
			if (!flag2 && !flag2)
			{
				throw new InvalidCastException();
			}
			if (!flag2)
			{
				throw new InvalidCastException();
			}
			object[] array = new object[flag2 ? 1u : 0u];
			int num = 0;
			if ((long)num < (long)(IntPtr)array)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				num += 4;
				num++;
			}
		}
		if (flag)
		{
			object[] array2 = new object[0];
			int num3 = 0;
			if (num3 < array2.Length)
			{
				if (array2 != null && array2 == null)
				{
					throw new IndexOutOfRangeException();
				}
				array2[0] = array2;
				num3++;
			}
			return array2;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F07750", Offset = "0x2F06150", VA = "0x182F07750")]
	public static string[] ConvertToStringArray(object[] obj)
	{
		//Discarded unreachable code: IL_003c
		string[] array;
		while (true)
		{
			array = new string[obj.Length];
			int num = 0;
			int length = obj.Length;
			if (num >= length)
			{
				break;
			}
			string text = obj[num].ToString();
			if (text == null || text != null)
			{
				array[0] = text;
				num++;
				break;
			}
		}
		return array;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ArrayUtility()
	{
	}
}
