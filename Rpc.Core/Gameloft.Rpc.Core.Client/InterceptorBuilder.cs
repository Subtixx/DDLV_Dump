using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class InterceptorBuilder : InterceptorBuilderBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly HostBuilder hostBuilder;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000109")]
		public InterceptorFunc Func
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
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
