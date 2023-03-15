using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000714")]
	public interface IGridStateDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004EDE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context);
	}
}
