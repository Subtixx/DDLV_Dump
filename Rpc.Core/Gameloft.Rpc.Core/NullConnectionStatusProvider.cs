using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core.Server;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class NullConnectionStatusProvider : IConnectionStatus
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static IConnectionStatus Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x38DF730", Offset = "0x38DE130", VA = "0x1838DF730")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		private NullConnectionStatusProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x38DF630", Offset = "0x38DE030", VA = "0x1838DF630", Slot = "4")]
		Task IConnectionStatus.ClientConnectedAsync(AuthContext authContext, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x38DF680", Offset = "0x38DE080", VA = "0x1838DF680", Slot = "5")]
		Task IConnectionStatus.ClientDisconnectedAsync(AuthContext authContext, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x38DF6D0", Offset = "0x38DE0D0", VA = "0x1838DF6D0")]
		static NullConnectionStatusProvider()
		{
			NullConnectionStatusProvider nullConnectionStatusProvider = new NullConnectionStatusProvider();
			/*Error: Unexpected end of block*/;
		}
	}
}
