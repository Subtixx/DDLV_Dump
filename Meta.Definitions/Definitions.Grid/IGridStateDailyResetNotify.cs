using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000718")]
	public interface IGridStateDailyResetNotify
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GridStateDailyResetResult ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context);
	}
}
