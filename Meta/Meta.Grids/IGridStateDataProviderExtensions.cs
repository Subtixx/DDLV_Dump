using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001089")]
	public static class IGridStateDataProviderExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6008677")]
		[Cpp2IlInjected.Address(RVA = "0x1707F20", Offset = "0x1706920", VA = "0x181707F20")]
		public static GridState GetGridState(this IGridStateDataProvider gridStateProvider, in WorldProfile worldProfile, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(IGridStateDataProvider).TypeHandle == null)
			{
				return (GridState)typeof(IGridStateDataProvider).TypeHandle;
			}
			return new GridState();
		}
	}
}
