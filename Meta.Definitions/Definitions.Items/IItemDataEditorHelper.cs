using System;
using System.Reflection;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000671")]
	public static class IItemDataEditorHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6004A82")]
		[Cpp2IlInjected.Address(RVA = "0x27B2900", Offset = "0x27B1300", VA = "0x1827B2900")]
		public static void SetItem(IItemData itemData, Item item)
		{
			//Discarded unreachable code: IL_0014
			int itemID = item.ItemID;
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("ID");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A83")]
		[Cpp2IlInjected.Address(RVA = "0x27B29B0", Offset = "0x27B13B0", VA = "0x1827B29B0")]
		public static void SetName(IItemData itemData, string name)
		{
			//Discarded unreachable code: IL_000d
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("Name");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A84")]
		[Cpp2IlInjected.Address(RVA = "0x27B2530", Offset = "0x27B0F30", VA = "0x1827B2530")]
		public static void SetDefaultDisplayName(IItemData itemData)
		{
			//Discarded unreachable code: IL_004e
			if ("DisplayName" == null)
			{
				return;
			}
			int num = 0;
			num += num;
			num++;
			FieldDescriptor fieldDescriptor = default(FieldDescriptor);
			CustomOptions customOptions = fieldDescriptor.CustomOptions;
			bool flag = default(bool);
			if (!flag)
			{
				string text = default(string);
				string text2 = text + "DisplayName";
				bool flag2 = default(bool);
				if (flag2)
				{
					string text3 = text2 + "_f";
				}
				Type type = default(Type);
				PropertyInfo property = type.GetProperty("DisplayName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A85")]
		[Cpp2IlInjected.Address(RVA = "0x27B2780", Offset = "0x27B1180", VA = "0x1827B2780")]
		public static void SetDisplayName(IItemData itemData, string name)
		{
			//Discarded unreachable code: IL_000d
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("DisplayName");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A86")]
		[Cpp2IlInjected.Address(RVA = "0x27B2880", Offset = "0x27B1280", VA = "0x1827B2880")]
		public static void SetIconAddress(IItemData itemData, string iconAddress)
		{
			//Discarded unreachable code: IL_000d
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("IconAddress");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A87")]
		[Cpp2IlInjected.Address(RVA = "0x27B2A30", Offset = "0x27B1430", VA = "0x1827B2A30")]
		public static void SetPrefabAddress(IItemData itemData, string prefabAddress)
		{
			//Discarded unreachable code: IL_000d
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("PrefabAddress");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A88")]
		[Cpp2IlInjected.Address(RVA = "0x27B2800", Offset = "0x27B1200", VA = "0x1827B2800")]
		public static void SetGridAreaData(IGridPlaceableItemData gridPlaceableItemData, GridAreaData gridAreaData)
		{
			//Discarded unreachable code: IL_000d
			Type type = default(Type);
			PropertyInfo property = type.GetProperty("GridAreaData");
		}
	}
}
