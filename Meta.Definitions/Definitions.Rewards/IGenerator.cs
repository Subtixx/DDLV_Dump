using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000239")]
	public interface IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x600156E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items);

		[Cpp2IlInjected.Token(Token = "0x600156F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items);
	}
}
