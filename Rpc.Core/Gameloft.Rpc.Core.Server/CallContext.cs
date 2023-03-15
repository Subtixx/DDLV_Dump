using System.Threading;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CallContext
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MethodDescriptor Method
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MetadataCollection RequestMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AuthContext AuthContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CallerContext CallerContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38DA090", Offset = "0x38D8A90", VA = "0x1838DA090")]
		public CallContext(MethodDescriptor descriptor, MetadataCollection requestMetadata, AuthContext authContext, CallerContext callerContext, CancellationToken cancellationToken)
		{
			//IL_0022: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			Method = descriptor;
			RequestMetadata = requestMetadata;
			AuthContext = authContext;
			CallerContext = (CallerContext)0;
			CancellationToken = (CancellationToken)0;
			/*Error: Unexpected end of block*/;
		}
	}
}
