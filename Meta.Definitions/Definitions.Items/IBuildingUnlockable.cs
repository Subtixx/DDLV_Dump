using Cpp2IlInjected;
using Google.Protobuf.Collections;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000682")]
	public interface IBuildingUnlockable
	{
		[Cpp2IlInjected.Token(Token = "0x1700135C")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004ABF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700135D")]
		Item UnlockWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700135E")]
		int UnlockAtPlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700135F")]
		string LockedPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001360")]
		RepeatedField<CurrencyCost> UnlockCurrencyCost
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001361")]
		int ManaCost
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001362")]
		string UnlockDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
}
