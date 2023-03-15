using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000745")]
	public static class FlagEnumExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600205A")]
		[Cpp2IlInjected.Address(RVA = "0x1456080", Offset = "0x1454A80", VA = "0x181456080")]
		public static Enum[] GetUniqueEnumNames(Type enumType)
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_004b
			int num = 0;
			List<Enum> list = (List<Enum>)(object)new List<T>();
			IEnumerator enumerator = Enum.GetValues(enumType).GetEnumerator();
			int num4 = default(int);
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = default(int);
				if (num3 > 0)
				{
					while (num3 != num4)
					{
					}
				}
			}
			if (num4 != 0)
			{
			}
			return (Enum[])(object)((List<T>)(object)list).ToArray();
		}

		[Cpp2IlInjected.Token(Token = "0x600205B")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5BF0", Offset = "0x1BB45F0", VA = "0x181BB5BF0")]
		public static T[] GetUniqueEnumNames<T>() where T : Enum
		{
			//IL_0019: Expected O, but got I4
			Type typeFromHandle = typeof(Type);
			int num = 0;
			int num2 = ((IComparable)(object)GetUniqueEnumNames(typeFromHandle)).CompareTo((object)num);
			/*Error: Unexpected end of block*/;
		}
	}
}
