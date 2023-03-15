using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RpcMethodBinding
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public delegate Task<CallResult<IMessage>> MethodInvokerDelegate(ICallInvoker callInvoker, IMessage request, CallContext context);

		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate Task<IMessage> MethodImplDelegate(IMessage requestMessage, CallContext context);

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public delegate IMessage CreateRequestDelegate();

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000E2")]
		public MethodDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MethodInvokerDelegate MethodInvoker
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MethodImplDelegate MethodImpl
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CreateRequestDelegate CreateRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x79F820", Offset = "0x79E220", VA = "0x18079F820")]
		public RpcMethodBinding(MethodDescriptor descriptor, MethodInvokerDelegate methodInvoker, MethodImplDelegate methodImpl, CreateRequestDelegate createRequest)
		{
			//IL_0022: Expected O, but got I4
			Descriptor = descriptor;
			MethodInvoker = methodInvoker;
			MethodImpl = methodImpl;
			CreateRequest = (CreateRequestDelegate)0;
			/*Error: Unexpected end of block*/;
		}
	}
}
