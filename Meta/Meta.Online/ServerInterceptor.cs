using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Server;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F21")]
	internal class ServerInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DBD")]
		private readonly NetworkDataProvider networkData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003DBE")]
		private readonly ServerTransactionContext serverTransactionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003DBF")]
		private readonly Serilog.ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003DC0")]
		private bool isDevelopment;

		[Cpp2IlInjected.Token(Token = "0x170015A2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003DBC")]
		private IProfileHolder ProfileHolder
		{
			[Cpp2IlInjected.Token(Token = "0x6007C78")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170015A3")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6007C79")]
			[Cpp2IlInjected.Address(RVA = "0x1774530", Offset = "0x1772F30", VA = "0x181774530")]
			get
			{
				//Discarded unreachable code: IL_001c, IL_0023
				IProfileHolder profileHolder = ProfileHolder;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return profileHolder.Profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C7A")]
		[Cpp2IlInjected.Address(RVA = "0x1774390", Offset = "0x1772D90", VA = "0x181774390")]
		public ServerTransactionContext GetTransactionContext(Profile profile, CallContext callContext)
		{
			//Discarded unreachable code: IL_0042
			//IL_0040: Expected O, but got I4
			ServerTransactionContext serverTransactionContext = this.serverTransactionContext;
			MetadataCollection _003CRequestMetadata_003Ek__BackingField = callContext.RequestMetadata;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				callContext.RequestMetadata.Add("TransactionTime", utcNow);
			}
			serverTransactionContext.profile = profile;
			int num2 = 0;
			serverTransactionContext.UtcNow = (DateTime?)(object)num2;
			return serverTransactionContext;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C7B")]
		[Cpp2IlInjected.Address(RVA = "0x17744B0", Offset = "0x1772EB0", VA = "0x1817744B0")]
		internal ServerInterceptor(ICallInvoker continuationInvoker, Serilog.ILogger logger, IProfileHolder profileHolder, NetworkDataProvider networkData, ServerTransactionContext serverTransactionContext, bool isDevelopment)
			: base(continuationInvoker)
		{
			//IL_001c: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			this.logger = logger;
			ProfileHolder = profileHolder;
			this.networkData = (NetworkDataProvider)0;
			this.isDevelopment = false;
			this.serverTransactionContext = (ServerTransactionContext)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C7C")]
		[Cpp2IlInjected.Address(RVA = "0x1B227B0", Offset = "0x1B211B0", VA = "0x181B227B0", Slot = "6")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__11<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
