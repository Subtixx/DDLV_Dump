using Cpp2IlInjected;
using Definitions.Util;
using Meta.Grids;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000476")]
	public interface IDefaultGridStateProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6001396")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitFromGridState(GridState gridState);

		[Cpp2IlInjected.Token(Token = "0x6001397")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ForceGridState(ref GridState gridState, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6001398")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ChangeGridState(GridState gridState, ITransactionContext context);
	}
}
