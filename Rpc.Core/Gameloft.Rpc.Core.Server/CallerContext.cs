using System.Net;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class CallerContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EndPoint EndPoint
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public CallerContext(EndPoint endPoint)
		{
			EndPoint = endPoint;
			/*Error: Unexpected end of block*/;
		}
	}
}
