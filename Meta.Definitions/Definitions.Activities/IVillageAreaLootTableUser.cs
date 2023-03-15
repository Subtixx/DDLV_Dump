using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008A9")]
	public interface IVillageAreaLootTableUser
	{
		[Cpp2IlInjected.Token(Token = "0x60060CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(VillageAreaType, Item)> GetVillageAreaLootTables();
	}
}
