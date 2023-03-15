using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public class FakeProfilePlayer : IProfilePlayer
	{
		[Cpp2IlInjected.Token(Token = "0x17000332")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4D")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2D70", Offset = "0x2CA1770", VA = "0x182CA2D70", Slot = "7")]
			get
			{
				return 200;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40005F3")]
		public MapField<int, int> MemoryShards
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "8")]
			get;
		} = (MapField<int, int>)(object)new MapField<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x17000334")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005F4")]
		public Item CurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
		public IContainerInventoryProvider GetContainerInventoryProvider()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2C70", Offset = "0x2CA1670", VA = "0x182CA2C70", Slot = "5")]
		public void ApplyBuff(BuffType buffType, ref int value, bool isReduction = false, int extraBuff = 0)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2CB0", Offset = "0x2CA16B0", VA = "0x182CA2CB0", Slot = "6")]
		public void ApplyBuff(BuffType buffType, ref TimeSpan value, bool isReduction = false, int extraBuff = 0)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public int GetItemAmount(Item item, [Optional] ItemState state)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "10")]
		public bool IsWearing(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "11")]
		public bool IsToolUnlocked(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
		public bool IsRecipeInCookbook(Item recipeItem)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "13")]
		public bool HasRecipeInCookbookWith(int minStarRating)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D54")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "14")]
		public bool HasItem(Item item, int amount = 1)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D55")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "15")]
		public bool IsCraftingRecipeUnlocked(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D56")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public bool IsCraftingRecipeAvailable(Item item, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D57")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "17")]
		public bool ManaHasAlreadyMissed()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D59")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "19")]
		public bool IsFtueEventCompleted(Item ftueItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0x127C4C0", Offset = "0x127AEC0", VA = "0x18127C4C0", Slot = "20")]
		public DateTime? GetTimestamp(string guid)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2CF0", Offset = "0x2CA16F0", VA = "0x182CA2CF0")]
		public FakeProfilePlayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "16")]
		bool IProfilePlayer.IsCraftingRecipeAvailable(Item item, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
