using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Security.X509;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class DefaultProcessor : IRequestProcessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly Dictionary<string, ICallInvoker> serviceCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly ILogger logger;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x38DA6E0", Offset = "0x38D90E0", VA = "0x1838DA6E0")]
		public DefaultProcessor(IEnumerable<ICallInvoker> services, ILogger logger)
		{
			//Discarded unreachable code: IL_005e, IL_0064, IL_006a, IL_0070
			int num = 0;
			Dictionary<string, ICallInvoker> dictionary = (serviceCollection = (Dictionary<string, ICallInvoker>)(object)new Dictionary<TKey, TValue>());
			((Mono.Security.X509.X509Extension)this).Decode();
			if (dictionary != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						num += num;
						num += num;
						num += num;
						goto IL_0054;
					}
					num++;
				}
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
			goto IL_0054;
			IL_0054:
			if (dictionary != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x38DA560", Offset = "0x38D8F60", VA = "0x1838DA560", Slot = "4")]
		[AsyncStateMachine(typeof(_003CGameloft_002DRpc_002DCore_002DServer_002DIRequestProcessor_002DHandleRequestAsync_003Ed__3))]
		Task<WrappedResponse> IRequestProcessor.HandleRequestAsync(WrappedRequest wrappedRequest, AuthContext authContext, CallerContext callerContext, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<WrappedResponse>)(object)result;
		}
	}
}
