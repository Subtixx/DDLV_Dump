using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C17")]
	internal class UseToolActionData : IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004374")]
		public Toolbox.ToolType ToolType;

		[Cpp2IlInjected.Token(Token = "0x6003707")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UseToolActionData()
		{
		}
	}
}
