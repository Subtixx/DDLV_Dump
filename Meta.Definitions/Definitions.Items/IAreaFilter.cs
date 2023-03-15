using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Scene;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000692")]
	public interface IAreaFilter
	{
		[Cpp2IlInjected.Token(Token = "0x17001373")]
		List<VillageAreaType> AreaFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6004AE4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
