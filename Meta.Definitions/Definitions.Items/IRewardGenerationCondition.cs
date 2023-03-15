using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Rewards;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000669")]
	public interface IRewardGenerationCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004A79")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] RewardGenerationParameters parameters);
	}
}
