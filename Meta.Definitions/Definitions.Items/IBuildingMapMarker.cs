using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A3")]
	public interface IBuildingMapMarker
	{
		[Cpp2IlInjected.Token(Token = "0x6004AF9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world);
	}
}
