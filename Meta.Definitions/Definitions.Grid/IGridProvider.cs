using Cpp2IlInjected;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000719")]
	public interface IGridProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		uint AddGrid(string gridDataPath);

		[Cpp2IlInjected.Token(Token = "0x6004EE3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveGrid(uint gridID);
	}
}
