using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Meta.Online;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000388")]
	internal class InventoryFullInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001815")]
		private readonly Client client;

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0x11BBA30", Offset = "0x11BA430", VA = "0x1811BBA30")]
		public InventoryFullInterceptor(ICallInvoker continuationInvoker, IUnityContext unityContext)
			: base(continuationInvoker)
		{
			if (unityContext == null)
			{
			}
			int num = 0;
			client = (Client)unityContext;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0x19AD700", Offset = "0x19AC100", VA = "0x1819AD700", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__2<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
