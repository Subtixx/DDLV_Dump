using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Rewards;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200066A")]
	public interface IItemStateProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004A7A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ItemState GetItemState(Random random, [Optional] RewardGenerationParameters parameters);
	}
}
