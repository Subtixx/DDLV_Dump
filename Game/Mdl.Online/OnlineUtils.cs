using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x200039B")]
	public class OnlineUtils
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		private static Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000F75")]
			[Cpp2IlInjected.Address(RVA = "0xF05730", Offset = "0xF04130", VA = "0x180F05730")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0xF05320", Offset = "0xF03D20", VA = "0x180F05320")]
		public static bool HasInternetAvailableAndAllowed()
		{
			//Discarded unreachable code: IL_002e
			bool isInternetOn = SystemRoot.Instance.MetaClient.OnlineClient.IsInternetOn;
			if (!isInternetOn)
			{
				return isInternetOn;
			}
			return !SystemRoot.Instance.Client.IsForcedOffline;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F77")]
		[Cpp2IlInjected.Address(RVA = "0xF054B0", Offset = "0xF03EB0", VA = "0x180F054B0")]
		[AsyncStateMachine(typeof(_003CTryAskForOnlineConnectionWithNativePrompt_003Ed__3))]
		public static Task<OnlineClient.OnlineStatus> TryAskForOnlineConnectionWithNativePrompt(CancellationToken ct, bool skipPermission = false, bool forceLogoutIfNotLoggedIn = false)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<OnlineClient.OnlineStatus>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F78")]
		[Cpp2IlInjected.Address(RVA = "0xF05600", Offset = "0xF04000", VA = "0x180F05600")]
		[AsyncStateMachine(typeof(_003CTryConnectToInternet_003Ed__4))]
		public static Task<bool> TryConnectToInternet(bool skipPermission, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F79")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public OnlineUtils()
		{
		}
	}
}
