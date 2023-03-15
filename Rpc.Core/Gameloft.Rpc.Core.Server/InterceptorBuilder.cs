using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class InterceptorBuilder : InterceptorBuilderBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly HostBuilder hostBuilder;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40000D3")]
		public InterceptorFunc Func
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x38DDE40", Offset = "0x38DC840", VA = "0x1838DDE40")]
		internal InterceptorBuilder(HostBuilder hostBuilder, InterceptorFunc interceptorFunc, object interceptorType)
			: base(interceptorType)
		{
			this.hostBuilder = hostBuilder;
			Func = interceptorFunc;
			/*Error: Unexpected end of block*/;
		}
	}
}
