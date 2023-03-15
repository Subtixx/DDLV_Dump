using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006E0")]
	public enum GridFloorType
	{
		[Cpp2IlInjected.Token(Token = "0x40022DD")]
		[OriginalName("Void")]
		Void = 0,
		[Cpp2IlInjected.Token(Token = "0x40022DE")]
		[OriginalName("Beach")]
		Beach = 1,
		[Cpp2IlInjected.Token(Token = "0x40022DF")]
		[OriginalName("Wetland")]
		Wetland = 2,
		[Cpp2IlInjected.Token(Token = "0x40022E0")]
		[OriginalName("Meadow")]
		Meadow = 4,
		[Cpp2IlInjected.Token(Token = "0x40022E1")]
		[OriginalName("Urban")]
		Urban = 8,
		[Cpp2IlInjected.Token(Token = "0x40022E2")]
		[OriginalName("Savannah")]
		Savannah = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40022E3")]
		[OriginalName("Forest")]
		Forest = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40022E4")]
		[OriginalName("DarkMountains")]
		DarkMountains = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40022E5")]
		[OriginalName("Cliff")]
		Cliff = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40022E6")]
		[OriginalName("Shore")]
		Shore = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40022E7")]
		[OriginalName("Water")]
		Water = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40022E8")]
		[OriginalName("Floor")]
		Floor = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40022E9")]
		[OriginalName("Wall")]
		Wall = 0x800,
		[Cpp2IlInjected.Token(Token = "0x40022EA")]
		[OriginalName("Surface")]
		Surface = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40022EB")]
		[OriginalName("BlockAutomaticSpawning")]
		BlockAutomaticSpawning = 0x40000
	}
}
