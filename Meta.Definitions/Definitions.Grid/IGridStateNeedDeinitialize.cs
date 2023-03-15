using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000716")]
	public interface IGridStateNeedDeinitialize
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Deinitialize(in WorldProfile worldProfile);
	}
}
