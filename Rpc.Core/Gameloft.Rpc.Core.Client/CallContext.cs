using System.Threading;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class CallContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000F8")]
		public MethodDescriptor Method
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CallOptions CallOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x38DA020", Offset = "0x38D8A20", VA = "0x1838DA020")]
		public CallContext(MethodDescriptor descriptor, CallOptions callOptions, CancellationToken cancellationToken)
		{
			Method = descriptor;
			CallOptions = callOptions;
			CancellationToken = cancellationToken;
			/*Error: Unexpected end of block*/;
		}
	}
}
