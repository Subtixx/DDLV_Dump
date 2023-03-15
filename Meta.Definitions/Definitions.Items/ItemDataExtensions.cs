using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000672")]
	public static class ItemDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6004A89")]
		[Cpp2IlInjected.Address(RVA = "0x22CF4D0", Offset = "0x22CDED0", VA = "0x1822CF4D0")]
		public static bool IsMissionItem(this IItemData itemData)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IIsMissionItem).TypeHandle != null)
			{
			}
			return (byte)(int)typeof(IIsMissionItem).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8A")]
		[Cpp2IlInjected.Address(RVA = "0x22CF5D0", Offset = "0x22CDFD0", VA = "0x1822CF5D0")]
		public static bool IsUndiggableItem(this IItemData itemData)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IUndiggable).TypeHandle != null)
			{
			}
			return (byte)(int)typeof(IUndiggable).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8B")]
		[Cpp2IlInjected.Address(RVA = "0x22CE4B0", Offset = "0x22CCEB0", VA = "0x1822CE4B0")]
		public static bool CanGiveItem(this IItemData itemData)
		{
			if ((object)typeof(IIsMissionItem).TypeHandle != null && (object)typeof(IIsMissionItem).TypeHandle != null)
			{
				int num = 0;
			}
			return (object)typeof(IIsMissionItem).TypeHandle != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8C")]
		[Cpp2IlInjected.Address(RVA = "0x22CE990", Offset = "0x22CD390", VA = "0x1822CE990")]
		public static IHasUnlockConditions GetUnlockConditions(this IItemData itemData)
		{
			bool flag = default(bool);
			if (((object)typeof(ItemDatabase).TypeHandle == null || !flag) && (object)typeof(ItemDatabase).TypeHandle != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				SetItemData setItemData = default(SetItemData);
				bool flag2 = default(bool);
				if (setItemData != null && !flag2)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8D")]
		[Cpp2IlInjected.Address(RVA = "0x22CF430", Offset = "0x22CDE30", VA = "0x1822CF430")]
		public static bool IsBuyable(this IItemData itemData)
		{
			//IL_0020: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			if ((object)typeof(IIsHiddable).TypeHandle != null && (object)typeof(IIsHiddable).TypeHandle != null)
			{
				int num = 0;
			}
			if ((object)typeof(IIsHiddable).TypeHandle != null)
			{
				return (byte)(int)typeof(IIsHiddable).TypeHandle != 0;
			}
			return (byte)(int)typeof(IIsHiddable).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8E")]
		[Cpp2IlInjected.Address(RVA = "0x22CF530", Offset = "0x22CDF30", VA = "0x1822CF530")]
		public static bool IsNotBuyable(this IItemData itemData)
		{
			//IL_0020: Expected I4, but got O
			do
			{
				if ((object)typeof(IIsHiddable).TypeHandle != null && (object)typeof(IIsHiddable).TypeHandle != null)
				{
					return true;
				}
			}
			while ((object)typeof(IIsHiddable).TypeHandle != null);
			return (byte)(int)typeof(IIsHiddable).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8F")]
		[Cpp2IlInjected.Address(RVA = "0x22CE5B0", Offset = "0x22CCFB0", VA = "0x1822CE5B0")]
		public static GridArea GetGridArea(this IGridPlaceableItemData gridPlaceable)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A90")]
		[Cpp2IlInjected.Address(RVA = "0x22CECB0", Offset = "0x22CD6B0", VA = "0x1822CECB0")]
		public unsafe static bool HasAllTraits(this IHasTraits hasTraits, [Optional] Complexity? complexity, [Optional] Mood? mood, [Optional] Normality? normality, [Optional] Sturdiness? sturdiness)
		{
			//Discarded unreachable code: IL_0018, IL_001e
			Complexity complexity2 = default(Complexity);
			Mood mood2 = default(Mood);
			Normality normality2 = default(Normality);
			if ((IntPtr)typeof(IHasTraits).TypeHandle != (IntPtr)(void*)(int)complexity2 || (IntPtr)typeof(IHasTraits).TypeHandle != (IntPtr)(void*)(int)mood2 || mood2 != (Mood)normality2)
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A91")]
		[Cpp2IlInjected.Address(RVA = "0x22CEFE0", Offset = "0x22CD9E0", VA = "0x1822CEFE0")]
		public unsafe static bool HasOneTrait(this IHasTraits hasTraits, [Optional] Complexity? complexity, [Optional] Mood? mood, [Optional] Normality? normality, [Optional] Sturdiness? sturdiness)
		{
			//Discarded unreachable code: IL_001b
			Complexity complexity2 = default(Complexity);
			Mood mood2 = default(Mood);
			Normality normality2 = default(Normality);
			if ((IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)complexity2 || (IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)mood2 || mood2 == (Mood)normality2)
			{
				return true;
			}
			Sturdiness sturdiness2 = default(Sturdiness);
			return Sturdiness.Strong == sturdiness2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A92")]
		[Cpp2IlInjected.Address(RVA = "0x22CE540", Offset = "0x22CCF40", VA = "0x1822CE540")]
		[IteratorStateMachine(typeof(_003CGetAllTags_003Ed__9))]
		public static IEnumerable<int> GetAllTags(this IHasTags hasTagsItemData)
		{
			new _003CGetAllTags_003Ed__9(-2)._003C_003E3__hasTagsItemData = hasTagsItemData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A93")]
		[Cpp2IlInjected.Address(RVA = "0x22CE690", Offset = "0x22CD090", VA = "0x1822CE690")]
		public static IEnumerable<Item> GetItemTags(this IHasTags hasTagsItemData)
		{
			//Discarded unreachable code: IL_0036
			_003CGetAllTags_003Ed__9 _003CGetAllTags_003Ed__ = new _003CGetAllTags_003Ed__9(-2);
			_003CGetAllTags_003Ed__._003C_003E3__hasTagsItemData = hasTagsItemData;
			Func<int, Item> _003C_003E9__10_ = _003C_003Ec._003C_003E9__10_0;
			if (_003C_003E9__10_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			return (IEnumerable<Item>)Enumerable.Select<int, Item>((IEnumerable<>)(object)_003CGetAllTags_003Ed__, (Func<, >)(object)_003C_003E9__10_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A94")]
		[Cpp2IlInjected.Address(RVA = "0x22CE810", Offset = "0x22CD210", VA = "0x1822CE810")]
		public static IEnumerable<TagItem> GetTagItems(this IHasTags hasTagsItemData)
		{
			//Discarded unreachable code: IL_0036
			_003CGetAllTags_003Ed__9 _003CGetAllTags_003Ed__ = new _003CGetAllTags_003Ed__9(-2);
			_003CGetAllTags_003Ed__._003C_003E3__hasTagsItemData = hasTagsItemData;
			Func<int, TagItem> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
			if (_003C_003E9__11_ == null)
			{
				TagItem result = default(TagItem);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => result);
			}
			return (IEnumerable<TagItem>)Enumerable.Select<int, TagItem>((IEnumerable<>)(object)_003CGetAllTags_003Ed__, (Func<, >)(object)_003C_003E9__11_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A95")]
		[Cpp2IlInjected.Address(RVA = "0x22CF190", Offset = "0x22CDB90", VA = "0x1822CF190")]
		public static bool HasTag(this IHasTags hasTagsItemData, Item tag)
		{
			int itemID = tag.ItemID;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (!flag && (!flag || !flag2 || !flag3))
			{
				int num3 = 0;
				itemID += itemID;
				num3 += 328;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A96")]
		[Cpp2IlInjected.Address(RVA = "0x22CEB30", Offset = "0x22CD530", VA = "0x1822CEB30")]
		public static bool HasAllTags(this IHasTags hasTagsItemData, IEnumerable<Item> tags)
		{
			//Discarded unreachable code: IL_0020, IL_0026
			int num = 0;
			int num2 = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				bool flag = default(bool);
				while (flag)
				{
				}
				int num3 = 0;
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A97")]
		[Cpp2IlInjected.Address(RVA = "0x22CEE60", Offset = "0x22CD860", VA = "0x1822CEE60")]
		public static bool HasOneTag(this IHasTags hasTagsItemData, IEnumerable<Item> tags)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			int num2 = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A98")]
		[Cpp2IlInjected.Address(RVA = "0x22CF350", Offset = "0x22CDD50", VA = "0x1822CF350")]
		public static bool HasTagsOfEachType(this IHasTags hasTagsItemData, IEnumerable<(TagItemType tagType, Item[] tags)> tagsByType)
		{
			//Discarded unreachable code: IL_0022
			Func<(TagItemType, Item[]), bool> func = (Func<(TagItemType, Item[]), bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0027
				IEnumerable<int> allTags = (IEnumerable<int>)ItemDataExtensions.GetAllTags(hasTagsItemData);
				Func<int, bool> cpp2il__autoParamName__idx_ = (Func<int, bool>)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				return ((IEnumerable<>)allTags).Any<int>((Func<, >)(object)cpp2il__autoParamName__idx_);
			};
			return ((IEnumerable<>)tagsByType).All<(TagItemType, Item[])>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A99")]
		[Cpp2IlInjected.Address(RVA = "0x19ADCD0", Offset = "0x19AC6D0", VA = "0x1819ADCD0")]
		public static IEnumerable<T> WithAllTags<T>(this IEnumerable<T> hasTagsEnumerable, IEnumerable<Item> tags) where T : IHasTags
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)hasTagsEnumerable).GetEnumerator();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A9A")]
		[Cpp2IlInjected.Address(RVA = "0x19ADCD0", Offset = "0x19AC6D0", VA = "0x1819ADCD0")]
		public static IEnumerable<T> WithTagsOfEachType<T>(this IEnumerable<T> hasTagsEnumerable, IEnumerable<(TagItemType tagType, Item[] tags)> tagsByType) where T : IHasTags
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)hasTagsEnumerable).GetEnumerator();
			throw new NullReferenceException();
		}
	}
}
