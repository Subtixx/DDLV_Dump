using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002E3")]
	public class SwitchPlatformInterfaceRegister : MonoBehaviour, INativeNetworkManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0x106A480", Offset = "0x1068E80", VA = "0x18106A480", Slot = "4")]
		public bool IsInternetAvailable()
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			DebugSettings settings = DebugSettings.Settings;
			bool result = !settings.nxSimulateNoInternet_;
			Debug.Log($"Editor SwitchNativeNetworkManager.IsInternetAvailable={settings} called");
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0x106A570", Offset = "0x1068F70", VA = "0x18106A570", Slot = "5")]
		[AsyncStateMachine(typeof(_003CTestInternetConnection_003Ed__1))]
		public Task<bool> TestInternetConnection(bool promptOnError, bool updateOnlineUser, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SwitchPlatformInterfaceRegister()
		{
		}
	}
}
