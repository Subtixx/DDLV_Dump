using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200076B")]
	public class ItemIDAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AD1")]
		public ItemType ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AD2")]
		public Enum[] SubItemTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AD3")]
		public string FilteringMethod;

		[Cpp2IlInjected.Token(Token = "0x60020F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
		public ItemIDAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60020F6")]
		[Cpp2IlInjected.Address(RVA = "0x11BFA50", Offset = "0x11BE450", VA = "0x1811BFA50")]
		public ItemIDAttribute(ItemType itemType)
		{
			ItemType = itemType;
		}

		[Cpp2IlInjected.Token(Token = "0x60020F7")]
		[Cpp2IlInjected.Address(RVA = "0x11BFA80", Offset = "0x11BE480", VA = "0x1811BFA80")]
		public ItemIDAttribute(ItemType itemType, params object[] subItemTypes)
		{
			ItemType = itemType;
			Func<object, Enum> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
			if (_003C_003E9__5_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(object x)
				{
					if (x == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (x != null)
					{
					}
					throw new InvalidCastException();
				};
			}
			Enum[] array = (SubItemTypes = Enumerable.Select<object, Enum>((IEnumerable<>)(object)subItemTypes, (Func<, >)(object)_003C_003E9__5_).ToArray<Enum>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020F8")]
		[Cpp2IlInjected.Address(RVA = "0x11BF9B0", Offset = "0x11BE3B0", VA = "0x1811BF9B0")]
		public Dictionary<ItemType, Enum[]> GetFilters()
		{
			int num = 0;
			if (ItemType != (ItemType)num)
			{
				Dictionary<ItemType, Enum[]> dictionary = (Dictionary<ItemType, Enum[]>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020F9")]
		[Cpp2IlInjected.Address(RVA = "0x11BF890", Offset = "0x11BE290", VA = "0x1811BF890")]
		public Func<Item, bool> GetFilteringMethod(Type type)
		{
			//IL_003d: Expected O, but got I4
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			string filteringMethod = FilteringMethod;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				string filteringMethod2 = FilteringMethod;
				MethodInfo methodInfo = (CS_0024_003C_003E8__locals0.methodInfo = type.GetMethod(filteringMethod2, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
				MethodInfo methodInfo2 = CS_0024_003C_003E8__locals0.methodInfo;
				int num = 0;
				if (!(methodInfo2 == (MethodInfo)num))
				{
					return (Func<Item, bool>)(object)(Func<T, TResult>)delegate(Item item)
					{
						//IL_002f: Expected O, but got I4
						MethodInfo methodInfo3;
						object[] array;
						do
						{
							int itemID = item.ItemID;
							methodInfo3 = CS_0024_003C_003E8__locals0.methodInfo;
							array = new object[1];
						}
						while (array != null && array == null);
						array[0] = array;
						int num3 = 0;
						object obj = methodInfo3.Invoke(num3, array);
						throw new NullReferenceException();
					};
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}
	}
}
