using System;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public abstract class Interceptor : ICallInvoker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly ICallInvoker continuationInvoker;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public Interceptor(ICallInvoker continuationInvoker)
		{
			this.continuationInvoker = continuationInvoker;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x19AD630", Offset = "0x19AC030", VA = "0x1819AD630", Slot = "5")]
		public virtual Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : IMessage, new()where TRequest : IMessage, new()
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
