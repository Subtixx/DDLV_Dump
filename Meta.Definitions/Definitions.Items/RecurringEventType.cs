using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000623")]
	public enum RecurringEventType
	{
		[Cpp2IlInjected.Token(Token = "0x40021C2")]
		[OriginalName("RecurringEventType_ItemSpawningInVillage")]
		ItemSpawningInVillage = 0,
		[Cpp2IlInjected.Token(Token = "0x40021C3")]
		[OriginalName("RecurringEventType_FishSpawningInVillage")]
		FishSpawningInVillage = 2,
		[Cpp2IlInjected.Token(Token = "0x40021C4")]
		[OriginalName("RecurringEventType_WildCropsSpawningInVillage")]
		WildCropsSpawningInVillage = 4,
		[Cpp2IlInjected.Token(Token = "0x40021C5")]
		[OriginalName("RecurringEventType_FlowerSpawningInVillage")]
		FlowerSpawningInVillage = 5,
		[Cpp2IlInjected.Token(Token = "0x40021C6")]
		[OriginalName("RecurringEventType_FlowerDryingInVillage")]
		FlowerDryingInVillage = 6,
		[Cpp2IlInjected.Token(Token = "0x40021C7")]
		[OriginalName("RecurringEventType_ChooseVillageArea")]
		ChooseVillageArea = 7,
		[Cpp2IlInjected.Token(Token = "0x40021C8")]
		[OriginalName("RecurringEventType_MiningRockTurningSpecial")]
		MiningRockTurningSpecial = 8,
		[Cpp2IlInjected.Token(Token = "0x40021C9")]
		[OriginalName("RecurringEventType_PendingFishUpgrade")]
		PendingFishUpgrade = 9
	}
}
