using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Gameloft.Rpc.Core.Server;
using Gameloft.Rpc.Transport.Queue.Server;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FB7")]
	public class Simulator<SERVER, CLIENT> : IDisposable where SERVER : ServiceBase where CLIENT : ClientBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40040C9")]
		private readonly ServerTransactionContext serverTransactionContext;

		[Cpp2IlInjected.Token(Token = "0x17001645")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40040C7")]
		public Gameloft.Rpc.Core.Server.Host LocalServerHost
		{
			[Cpp2IlInjected.Token(Token = "0x6007F43")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001646")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40040C8")]
		public Gameloft.Rpc.Core.Client.Host LocalClientHost
		{
			[Cpp2IlInjected.Token(Token = "0x6007F44")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001647")]
		public CLIENT ClientService
		{
			[Cpp2IlInjected.Token(Token = "0x6007F45")]
			[Cpp2IlInjected.Address(RVA = "0x2147940", Offset = "0x2146340", VA = "0x182147940")]
			get
			{
				((IDisposable)LocalClientHost).Dispose();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001648")]
		public SERVER ServerService
		{
			[Cpp2IlInjected.Token(Token = "0x6007F46")]
			[Cpp2IlInjected.Address(RVA = "0x2147990", Offset = "0x2146390", VA = "0x182147990")]
			get
			{
				((IDisposable)LocalServerHost).Dispose();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007F47")]
		[Cpp2IlInjected.Address(RVA = "0x21478C0", Offset = "0x21462C0", VA = "0x1821478C0")]
		private Simulator([Optional] Gameloft.Rpc.Core.Server.Host localServerHost, [Optional] Gameloft.Rpc.Core.Client.Host localClientHost, [Optional] ServerTransactionContext serverTransactionContext)
		{
			((Simulator<, >)(object)this).LocalServerHost = localServerHost;
			((Simulator<, >)(object)this).LocalClientHost = localClientHost;
			((Simulator<, >)(object)this).serverTransactionContext = serverTransactionContext;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F48")]
		[Cpp2IlInjected.Address(RVA = "0x2147440", Offset = "0x2145E40", VA = "0x182147440")]
		private static Gameloft.Rpc.Core.Server.Host CreateServerHost(Serilog.ILogger logger, IProfileHolder profileHolder, ProfileEventDispatcher dispatcher, NetworkDataProvider networkData, ServerTransactionContext serverTransactionContext, bool isDevelopment)
		{
			//Discarded unreachable code: IL_0048, IL_004e
			int num = 0;
			Gameloft.Rpc.Core.Server.HostBuilder hostBuilder = new Gameloft.Rpc.Core.Server.HostBuilder();
			ProfileEventDispatcher.FewMinutesHavePass onFewMinutesHavePass = dispatcher.OnFewMinutesHavePass;
			ProfileEventDispatcher.DiscussionEnded onDiscussionEnded = dispatcher.OnDiscussionEnded;
			IntPtr extra_arg = ((Delegate)onFewMinutesHavePass).extra_arg;
			Gameloft.Rpc.Core.Server.InterceptorFunc interceptorFunc = new Gameloft.Rpc.Core.Server.InterceptorFunc("CreateServerHost", extra_arg);
			Gameloft.Rpc.Core.Server.InterceptorBuilder interceptorBuilder = hostBuilder.AddInterceptor<ServerInterceptor>(interceptorFunc);
			Gameloft.Rpc.Core.Server.HostBuilder hostBuilder2 = hostBuilder.UseQueueTransport();
			return hostBuilder.Build();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F49")]
		[Cpp2IlInjected.Address(RVA = "0x2146E90", Offset = "0x2145890", VA = "0x182146E90")]
		public static Simulator<SERVER, CLIENT> CreateAndStart(Client client, LocalProfileHolder profileHolder, ProfileEventDispatcher dispatcher, NetworkDataProvider networkData, ServerTransactionContext serverTransactionContext)
		{
			//IL_0007: Expected I, but got O
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			((Delegate)interceptorFunc).method_ptr = (IntPtr)client;
			IntPtr method_ptr = ((Delegate)interceptorFunc).method_ptr;
			int num = 0;
			Gameloft.Rpc.Core.Client.HostBuilder hostBuilder = new Gameloft.Rpc.Core.Client.HostBuilder();
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc2 = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			Gameloft.Rpc.Core.Client.InterceptorBuilder interceptorBuilder = hostBuilder.AddInterceptor<LogExceptionInterceptor>(interceptorFunc2);
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc3 = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			Gameloft.Rpc.Core.Client.InterceptorBuilder interceptorBuilder2 = hostBuilder.AddInterceptor<PlayFabRequestResultInterceptor>(interceptorFunc3);
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc4 = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			Gameloft.Rpc.Core.Client.InterceptorBuilder interceptorBuilder3 = hostBuilder.AddInterceptor<SemaphoreInterceptor>(interceptorFunc4);
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc5 = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			Gameloft.Rpc.Core.Client.InterceptorBuilder interceptorBuilder4 = hostBuilder.AddInterceptor<ClientRequestResultInterceptor>(interceptorFunc5);
			Gameloft.Rpc.Core.Client.InterceptorFunc interceptorFunc6 = default(Gameloft.Rpc.Core.Client.InterceptorFunc);
			Gameloft.Rpc.Core.Client.InterceptorBuilder interceptorBuilder5 = hostBuilder.AddInterceptor<ClientInterceptor>(interceptorFunc6);
			IntPtr method_ptr2 = ((Delegate)interceptorFunc).method_ptr;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			Gameloft.Rpc.Core.Client.Host host = hostBuilder.Build();
			num2 += num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F4A")]
		[Cpp2IlInjected.Address(RVA = "0x2147810", Offset = "0x2146210", VA = "0x182147810")]
		internal void StartServer([Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0017
			LocalServerHost.Server.StartAsync(ct).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F4B")]
		[Cpp2IlInjected.Address(RVA = "0x2147760", Offset = "0x2146160", VA = "0x182147760", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0023
			((HostBase<TServiceType>)(object)LocalClientHost)?.Dispose();
			((HostBase<TServiceType>)(object)LocalServerHost)?.Dispose();
		}
	}
}
