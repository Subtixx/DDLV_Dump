using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005DE")]
	public enum BuildingItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4002006")]
		[OriginalName("BuildingItemType_House")]
		House,
		[Cpp2IlInjected.Token(Token = "0x4002007")]
		[OriginalName("BuildingItemType_Stall")]
		Stall,
		[Cpp2IlInjected.Token(Token = "0x4002008")]
		[OriginalName("BuildingItemType_Garden")]
		Garden,
		[Cpp2IlInjected.Token(Token = "0x4002009")]
		[OriginalName("BuildingItemType_Other")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400200A")]
		[OriginalName("BuildingItemType_OffGridBuilding")]
		OffGridBuilding,
		[Cpp2IlInjected.Token(Token = "0x400200B")]
		[OriginalName("BuildingItemType_PlayerHouse")]
		PlayerHouse
	}
}
