using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Auth;
using Mdl.Systems;
using Meta.Online;
using Steamworks;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002F0")]
	public class WindowsPlayFabAccountLinking : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002F1")]
		private struct LoginResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40015EC")]
			public readonly Token? Token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40015ED")]
			public readonly Result Result;

			[Cpp2IlInjected.Token(Token = "0x17000194")]
			public bool Completed
			{
				[Cpp2IlInjected.Token(Token = "0x6000D11")]
				[Cpp2IlInjected.Address(RVA = "0xF87740", Offset = "0xF86140", VA = "0x180F87740")]
				get
				{
					return Result == Result.Success;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000195")]
			public bool IsTokenExpired
			{
				[Cpp2IlInjected.Token(Token = "0x6000D12")]
				[Cpp2IlInjected.Address(RVA = "0xF87750", Offset = "0xF86150", VA = "0x180F87750")]
				get
				{
					return Result == Result.AuthOriginatingExchangeCodeSessionExpired;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xF876E0", Offset = "0xF860E0", VA = "0x180F876E0")]
			public LoginResult(Token? token, Result result)
			{
				int num = (int)(Result = result);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015E5")]
		private TaskCompletionSource<LoginResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015E6")]
		private string tokenCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015E7")]
		private DateTime tokenCacheExpirationTime;

		[Cpp2IlInjected.Token(Token = "0x40015E8")]
		private static string LastToken;

		[Cpp2IlInjected.Token(Token = "0x40015E9")]
		private static string LastConfirmedToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015EA")]
		private int numberOfTryingLogin = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40015EB")]
		private int consecutiveFailures;

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		private bool IsUsingWindowsAccountLinking
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0B")]
			[Cpp2IlInjected.Address(RVA = "0x842390", Offset = "0x840D90", VA = "0x180842390")]
			get
			{
				int num = 0;
				if (Application.platform == RuntimePlatform.WindowsPlayer)
				{
					return true;
				}
				int num2 = 0;
				return Application.platform == RuntimePlatform.WindowsEditor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFE")]
		[Cpp2IlInjected.Address(RVA = "0x840EE0", Offset = "0x83F8E0", VA = "0x180840EE0")]
		[AsyncStateMachine(typeof(_003CAssignEpicId_003Ed__2))]
		private Task<(string, Client.FailureFallback)> AssignEpicId()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFF")]
		[Cpp2IlInjected.Address(RVA = "0x841370", Offset = "0x83FD70", VA = "0x180841370")]
		private void EpicServiceLoginCompleted(Token? token, Result result)
		{
			//Discarded unreachable code: IL_001d
			string text = string.Format("Epic service login completed with following result => {0}{1}", ".", " and epic token was not found.");
			TaskCompletionSource<LoginResult> taskCompletionSource = tcs;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0x841020", Offset = "0x83FA20", VA = "0x180841020")]
		[AsyncStateMachine(typeof(_003CAssignSteamId_003Ed__4))]
		private Task<(string, Client.FailureFallback)> AssignSteamId()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0x841D40", Offset = "0x840740", VA = "0x180841D40")]
		[AsyncStateMachine(typeof(_003COnSteamPreLogin_003Ed__5))]
		private Task OnSteamPreLogin()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0x841820", Offset = "0x840220", VA = "0x180841820")]
		private static void GrantPromoItems()
		{
			//IL_000b: Expected O, but got I4
			bool flag = default(bool);
			string text = $"[Steam] WindowsPlayFabAccountLinking - GrantPromoItems()={flag}";
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0x842010", Offset = "0x840A10", VA = "0x180842010")]
		[AsyncStateMachine(typeof(_003CSetupSteamAuthentification_003Ed__7))]
		private Task SetupSteamAuthentification()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0x539530", Offset = "0x537F30", VA = "0x180539530")]
		private bool HasTokenCache()
		{
			return !string.IsNullOrEmpty(tokenCache);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0x8418D0", Offset = "0x8402D0", VA = "0x1808418D0")]
		private bool IsTokenCacheExpired()
		{
			if (string.IsNullOrEmpty(tokenCache))
			{
				int num = 0;
			}
			int num2 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = tokenCacheExpirationTime;
			return utcNow > dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0x841F10", Offset = "0x840910", VA = "0x180841F10")]
		private void SetTokenCache(string _token)
		{
			if ("[Steam] SetTokenCache has invalid token" == null)
			{
				LastToken = _token;
			}
			tokenCache = _token;
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			tokenCacheExpirationTime = dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0x8416D0", Offset = "0x8400D0", VA = "0x1808416D0")]
		[AsyncStateMachine(typeof(_003CGetTokenFromCache_003Ed__15))]
		private Task<string> GetTokenFromCache(int timeoutMs = 20000)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0x841520", Offset = "0x83FF20", VA = "0x180841520")]
		private unsafe static (string, HAuthTicket) GetAuthSessionTicket()
		{
			//IL_0043: Expected O, but got I4
			int num = 0;
			byte[] array = new byte[1024];
			int length = array.Length;
			uint hAuthTicket = SteamUser.GetAuthSessionTicket(array, length, out *(uint*)num).m_HAuthTicket;
			StringBuilder stringBuilder = new StringBuilder();
			int length2 = array.Length;
			if (num < length2)
			{
				StringBuilder stringBuilder2 = stringBuilder.AppendFormat("{0:x2}", num);
				num++;
			}
			string text = stringBuilder.ToString();
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0x841280", Offset = "0x83FC80", VA = "0x180841280")]
		[AsyncStateMachine(typeof(_003CAssignWindowsStoreId_003Ed__18))]
		private Task<(string, Client.FailureFallback)> AssignWindowsStoreId()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0x841E40", Offset = "0x840840", VA = "0x180841E40")]
		[AsyncStateMachine(typeof(_003COnWinStorePreLogin_003Ed__19))]
		private Task OnWinStorePreLogin()
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0x842110", Offset = "0x840B10", VA = "0x180842110")]
		public void Start()
		{
			int num = 0;
			if (Application.platform != RuntimePlatform.WindowsPlayer)
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.WindowsEditor)
				{
					return;
				}
			}
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.OnUserCredentialInitCB value = AssignWindowsIds;
			metaClient.OnUserCredentialInit += value;
			int num3 = 0;
			bool flag = PlatformUtils.UseSteam();
			if (!flag)
			{
				int num4 = 0;
				if (flag)
				{
					OnlineClient onlineClient = default(OnlineClient);
					AuthManager authentificationManager = onlineClient.AuthentificationManager;
					AuthManager.OnPreLoginAction value2 = OnWinStorePreLogin;
					authentificationManager.OnPreLogin += value2;
				}
				return;
			}
			OnlineClient onlineClient2 = default(OnlineClient);
			AuthManager authentificationManager2 = onlineClient2.AuthentificationManager;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x841950", Offset = "0x840350", VA = "0x180841950")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_00a4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client.OnUserCredentialInitCB value = AssignWindowsIds;
				metaClient.OnUserCredentialInit -= value;
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				OnlineClient metaOnlineClient = _003CInstance_003Ek__BackingField2.MetaOnlineClient;
				if (metaOnlineClient != null && metaOnlineClient.AuthentificationManager != null)
				{
					AuthManager authentificationManager = SystemRoot.Instance.MetaOnlineClient.AuthentificationManager;
					AuthManager.OnPreLoginAction value2 = OnSteamPreLogin;
					authentificationManager.OnPreLogin -= value2;
					AuthManager authentificationManager2 = SystemRoot.Instance.MetaOnlineClient.AuthentificationManager;
					AuthManager.OnPreLoginAction value3 = OnWinStorePreLogin;
					authentificationManager2.OnPreLogin -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x841160", Offset = "0x83FB60", VA = "0x180841160")]
		[AsyncStateMachine(typeof(_003CAssignWindowsIds_003Ed__25))]
		public Task AssignWindowsIds(Action<string, Client.FailureFallback> userCredentialInitCompleted)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x842380", Offset = "0x840D80", VA = "0x180842380")]
		public WindowsPlayFabAccountLinking()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
