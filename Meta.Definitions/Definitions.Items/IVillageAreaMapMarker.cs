using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Scene;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A2")]
	public interface IVillageAreaMapMarker
	{
		[Cpp2IlInjected.Token(Token = "0x17001381")]
		List<VillageAreaType> VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6004AF8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
