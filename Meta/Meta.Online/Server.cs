using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FB4")]
	public class Server
	{
		[Cpp2IlInjected.Token(Token = "0x17001644")]
		public static bool UseCheats
		{
			[Cpp2IlInjected.Token(Token = "0x6007F3C")]
			[Cpp2IlInjected.Address(RVA = "0x1774C30", Offset = "0x1773630", VA = "0x181774C30")]
			[CompilerGenerated]
			get
			{
				//IL_0006: Expected I4, but got O
				return (byte)(int)typeof(Server).TypeHandle != 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6007F3D")]
			[Cpp2IlInjected.Address(RVA = "0x1774C70", Offset = "0x1773670", VA = "0x181774C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007F3E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Server()
		{
		}
	}
}
