using System;
using Cpp2IlInjected;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200105A")]
	[Flags]
	public enum GoBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x400435C")]
		None = 1,
		[Cpp2IlInjected.Token(Token = "0x400435D")]
		Item = 2,
		[Cpp2IlInjected.Token(Token = "0x400435E")]
		Move = 4,
		[Cpp2IlInjected.Token(Token = "0x400435F")]
		TalkToCharacter = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4004360")]
		GardeningPlant = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4004361")]
		ItemFiltering = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4004362")]
		GoToPlayerHouse = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4004363")]
		GoToVillage = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4004364")]
		GoToCharacterHouse = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4004365")]
		GoToCastle = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4004366")]
		GoToRestaurant = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4004367")]
		GoToCharacterCurrentWorld = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4004368")]
		GoToCharacterPosition = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4004369")]
		GoToCharacterToListen = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400436A")]
		GoToShop = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400436B")]
		GoToStore = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400436C")]
		Tutorial = 0x40000,
		[Cpp2IlInjected.Token(Token = "0x400436D")]
		EndOfMission = 0x80000,
		[Cpp2IlInjected.Token(Token = "0x400436E")]
		RoyalDuties = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x400436F")]
		GoToCave = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4004370")]
		Behaviors = 0x100026,
		[Cpp2IlInjected.Token(Token = "0x4004371")]
		Decorators = 0x2F7FC0
	}
}
