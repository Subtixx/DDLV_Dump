using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007B6")]
	public interface IDateCondition
	{
		[Cpp2IlInjected.Token(Token = "0x60054D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate);

		[Cpp2IlInjected.Token(Token = "0x60054D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate);
	}
}
