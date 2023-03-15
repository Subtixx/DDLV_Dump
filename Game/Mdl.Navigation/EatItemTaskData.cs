using Cpp2IlInjected;
using Meta;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BB5")]
	public class EatItemTaskData : IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004149")]
		public EatItem.Types.Request Request;

		[Cpp2IlInjected.Token(Token = "0x60035FF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EatItemTaskData()
		{
		}
	}
}
