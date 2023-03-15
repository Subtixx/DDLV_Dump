using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000715")]
	public interface IGridStateNeedInitialize
	{
		[Cpp2IlInjected.Token(Token = "0x6004EDF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context);
	}
}
