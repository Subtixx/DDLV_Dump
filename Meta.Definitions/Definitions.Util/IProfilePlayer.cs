using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface IProfilePlayer
	{
		[Cpp2IlInjected.Token(Token = "0x17000325")]
		int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000D13")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000326")]
		MapField<int, int> MemoryShards
		{
			[Cpp2IlInjected.Token(Token = "0x6000D14")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		Item CurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000D1E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IContainerInventoryProvider GetContainerInventoryProvider();

		[Cpp2IlInjected.Token(Token = "0x6000D11")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ApplyBuff(BuffType buffType, ref int value, bool isReduction = false, int extraBuff = 0);

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ApplyBuff(BuffType buffType, ref TimeSpan value, bool isReduction = false, int extraBuff = 0);

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int GetItemAmount(Item item, [Optional] ItemState state);

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IsWearing(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsToolUnlocked(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IsRecipeInCookbook(Item recipeItem);

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HasRecipeInCookbookWith(int minStarRating);

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HasItem(Item item, int amount = 1);

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool IsCraftingRecipeUnlocked(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool IsCraftingRecipeAvailable(Item item, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool ManaHasAlreadyMissed();

		[Cpp2IlInjected.Token(Token = "0x6000D1F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool IsFtueEventCompleted(Item ftueItem);

		[Cpp2IlInjected.Token(Token = "0x6000D20")]
		[Cpp2IlInjected.Address(Slot = "16")]
		DateTime? GetTimestamp(string guid);
	}
}
