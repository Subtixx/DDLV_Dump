using Cpp2IlInjected;
using Meta;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000490")]
	internal class WallGridScript : GridScript
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001CD8")]
		public House.Types.WallPosition WallPosition;

		[Cpp2IlInjected.Token(Token = "0x6001452")]
		[Cpp2IlInjected.Address(RVA = "0xD4D8B0", Offset = "0xD4C2B0", VA = "0x180D4D8B0")]
		public WallGridScript()
		{
		}
	}
}
