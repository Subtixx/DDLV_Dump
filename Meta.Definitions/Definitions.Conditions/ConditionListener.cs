using System;
using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007C5")]
	[Flags]
	public enum ConditionListener
	{
		[Cpp2IlInjected.Token(Token = "0x40026C8")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40026C9")]
		PlayerLevel = 1,
		[Cpp2IlInjected.Token(Token = "0x40026CA")]
		CurrencyAmount = 2,
		[Cpp2IlInjected.Token(Token = "0x40026CB")]
		ItemAmount = 4,
		[Cpp2IlInjected.Token(Token = "0x40026CC")]
		MissionCompleted = 8,
		[Cpp2IlInjected.Token(Token = "0x40026CD")]
		MissionStepChanged = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40026CE")]
		FriendshipLevel = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40026CF")]
		Character = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40026D0")]
		DialogueFlag = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40026D1")]
		MemoryShard = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40026D2")]
		Realm = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40026D3")]
		Area = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40026D4")]
		AvatarCustomization = 0x800,
		[Cpp2IlInjected.Token(Token = "0x40026D5")]
		MissionOngoing = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40026D6")]
		ToolUnlocked = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x40026D7")]
		MissionObjectiveCompleted = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x40026D8")]
		MissionObjectiveChanged = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x40026D9")]
		Scene = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x40026DA")]
		ManaAlreadyMissed = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x40026DB")]
		Hangout = 0x40000,
		[Cpp2IlInjected.Token(Token = "0x40026DC")]
		Time = 0x80000,
		[Cpp2IlInjected.Token(Token = "0x40026DD")]
		CraftingRecipeVisibility = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x40026DE")]
		CookingRecipeVisibility = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x40026DF")]
		Keyhole = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x40026E0")]
		FTUEEvent = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x40026E1")]
		Weather = 0x1000000,
		[Cpp2IlInjected.Token(Token = "0x40026E2")]
		MissionAvailable = 0x2000000,
		[Cpp2IlInjected.Token(Token = "0x40026E3")]
		ToolUpgraded = 0x4000000,
		[Cpp2IlInjected.Token(Token = "0x40026E4")]
		All = int.MaxValue
	}
}
