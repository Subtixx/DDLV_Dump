using System;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public abstract class Interceptor : ICallInvoker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ICallInvoker continuationInvoker;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40000D9")]
		public IService Service
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38DEAA0", Offset = "0x38DD4A0", VA = "0x1838DEAA0")]
		public Interceptor(ICallInvoker continuationInvoker)
		{
			this.continuationInvoker = continuationInvoker;
			if ((object)typeof(IService).TypeHandle == null)
			{
			}
			Service = (IService)typeof(IService).TypeHandle;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x19AD630", Offset = "0x19AC030", VA = "0x1819AD630", Slot = "6")]
		public virtual Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : class, IMessage, new()where TRequest : class, IMessage, new()
		{
			ICallInvoker callInvoker = continuationInvoker;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num != (int)num2)
				{
					num++;
				}
			}
			num += 312;
			throw new NullReferenceException();
		}
	}
}
