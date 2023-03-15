using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class ClientBase
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected ICallInvoker CallInvoker
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public ClientBase(ICallInvoker callInvoker)
		{
			CallInvoker = callInvoker;
			/*Error: Unexpected end of block*/;
		}
	}
}
