using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200023A")]
	public interface IGeneratorFilter : IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x6001570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, ExtraFilterInfo extraFilter, [Optional] List<ItemWithState> items);
	}
}
