using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007C7")]
	public interface ICondition
	{
		[Cpp2IlInjected.Token(Token = "0x1700158E")]
		string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005579")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700158F")]
		ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600557A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6005578")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x600557B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LockedInfo GetLockedInfo(MissionItemData data);
	}
}
