using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppleAuth;
using AppleAuth.Interfaces;
using AppleAuth.Native;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Auth;
using glPlayFab;
using Mdl.Systems;
using Mdl.Ui;
using Meta.Online;
using Steamworks;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002B6")]
	public class ApplePlayFabAccountLinking : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002B7")]
		private struct LoginResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400152B")]
			public readonly Token? Token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400152C")]
			public readonly Result Result;

			[Cpp2IlInjected.Token(Token = "0x1700016C")]
			public bool Completed
			{
				[Cpp2IlInjected.Token(Token = "0x6000C12")]
				[Cpp2IlInjected.Address(RVA = "0xF87740", Offset = "0xF86140", VA = "0x180F87740")]
				get
				{
					return Result == Result.Success;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700016D")]
			public bool IsTokenExpired
			{
				[Cpp2IlInjected.Token(Token = "0x6000C13")]
				[Cpp2IlInjected.Address(RVA = "0xF87750", Offset = "0xF86150", VA = "0x180F87750")]
				get
				{
					return Result == Result.AuthOriginatingExchangeCodeSessionExpired;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0xF876E0", Offset = "0xF860E0", VA = "0x180F876E0")]
			public LoginResult(Token? token, Result result)
			{
				int num = (int)(Result = result);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400151C")]
		private IAppleAuthManager appleAuthManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400151D")]
		private string userId = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400151E")]
		private string userIdKey = "macOSUserIdKey";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400151F")]
		private string identityToken = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001520")]
		private string identityTokenKey = "macOSIdentityToken";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001521")]
		private bool haveTokenStored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4001522")]
		private bool isTokenExpired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001523")]
		private TaskCompletionSource<ICredential> appleLoginTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001524")]
		private TaskCompletionSource<bool> appleCheckCredentialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001525")]
		private TaskCompletionSource<LoginResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001526")]
		private string tokenCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001527")]
		private DateTime tokenCacheExpirationTime;

		[Cpp2IlInjected.Token(Token = "0x4001528")]
		private static string LastToken;

		[Cpp2IlInjected.Token(Token = "0x4001529")]
		private static string LastConfirmedToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400152A")]
		private int consecutiveFailures;

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		private bool IsUsingAppleAccountLinking
		{
			[Cpp2IlInjected.Token(Token = "0x6000C06")]
			[Cpp2IlInjected.Address(RVA = "0xA44490", Offset = "0xA42E90", VA = "0x180A44490")]
			get
			{
				int num = 0;
				if (Application.platform == RuntimePlatform.OSXPlayer)
				{
				}
				int num2 = 0;
				return Application.platform == RuntimePlatform.OSXEditor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0xA43CC0", Offset = "0xA426C0", VA = "0x180A43CC0")]
		private void checkAppleTokenExpired()
		{
			//IL_001c: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0200: Expected O, but got I4
			//IL_0200: Expected O, but got I4
			DateTime dateTime = default(DateTime);
			string text3 = default(string);
			string text4 = default(string);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				bool flag = TokenStorage.Load();
				int num4 = 0;
				string text = (userId = TokenStorage.Get(userIdKey, (string)num4));
				int num5 = 0;
				string text2 = (identityToken = TokenStorage.Get(identityTokenKey, (string)num5));
				if (string.Equals(identityToken, "") || (long)identityToken == 0 || string.Equals(userId, "") || (long)userId == 0)
				{
					break;
				}
				string token = identityToken;
				haveTokenStored = true;
				int? _003CExp_003Ek__BackingField = new JwtSecurityToken(token).Payload.Exp;
				int num6 = 0;
				if (DateTime.Now < dateTime)
				{
					isTokenExpired = false;
				}
				string[] array = new string[8];
				if ("checkAppleTokenExpired now: " != null && "checkAppleTokenExpired now: " == null)
				{
					continue;
				}
				array[0] = "checkAppleTokenExpired now: ";
				int num7 = 0;
				DateTime now = DateTime.Now;
				if (text3 != null && text3 == null)
				{
					continue;
				}
				array[1] = text3;
				if (" expire: " != null && " expire: " == null)
				{
					continue;
				}
				array[2] = " expire: ";
				if (text4 != null && text4 == null)
				{
					continue;
				}
				array[3] = text4;
				if (" userId: " != null && " userId: " == null)
				{
					continue;
				}
				array[4] = " userId: ";
				string text5 = userId;
				if (text5 != null && " userId: " == null)
				{
					continue;
				}
				array[5] = text5;
				if (" identityToken: " == null || " identityToken: " != null)
				{
					array[6] = " identityToken: ";
					string text6 = identityToken;
					if (text6 == null || " identityToken: " != null)
					{
						array[7] = text6;
						string msg = string.Concat(array);
						object[] args = Array.Empty<object>();
						GameLog.Info(msg, args);
						break;
					}
				}
			}
			haveTokenStored = false;
			int num8 = 0;
			bool flag2 = isTokenExpired;
			bool flag3 = default(bool);
			string msg2 = $"checkAppleTokenExpired haveTokenStored: {flag3} isTokenExpired: {flag3}";
			object[] args2 = Array.Empty<object>();
			GameLog.Info(msg2, args2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0xA41B10", Offset = "0xA40510", VA = "0x180A41B10")]
		[AsyncStateMachine(typeof(_003CAssignAppStoreId_003Ed__10))]
		private Task<(string, Client.FailureFallback)> AssignAppStoreId()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA42D90", VA = "0x180A44390")]
		[AsyncStateMachine(typeof(_003CcheckCredentialState_003Ed__11))]
		private Task checkCredentialState()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0xA41D50", Offset = "0xA40750", VA = "0x180A41D50")]
		[AsyncStateMachine(typeof(_003CAssignEpicId_003Ed__14))]
		private Task<(string, Client.FailureFallback)> AssignEpicId()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0xA41FD0", Offset = "0xA409D0", VA = "0x180A41FD0")]
		private void EpicServiceLoginCompleted(Token? token, Result result)
		{
			//Discarded unreachable code: IL_002a
			string msg = string.Format("Epic service login completed with following result => {0}{1}", ".", " and epic token was not found.");
			object[] args = Array.Empty<object>();
			GameLog.Info(msg, args);
			TaskCompletionSource<LoginResult> taskCompletionSource = tcs;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0xA41E90", Offset = "0xA40890", VA = "0x180A41E90")]
		[AsyncStateMachine(typeof(_003CAssignSteamId_003Ed__16))]
		private Task<(string, Client.FailureFallback)> AssignSteamId()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(string, Client.FailureFallback)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA42C40", Offset = "0xA41640", VA = "0x180A42C40")]
		[AsyncStateMachine(typeof(_003COnSteamPreLogin_003Ed__17))]
		private Task OnSteamPreLogin()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA42480", Offset = "0xA40E80", VA = "0x180A42480")]
		private static void GrantPromoItems()
		{
			//IL_000b: Expected O, but got I4
			bool flag = default(bool);
			string msg = $"[Steam] WindowsPlayFabAccountLinking - GrantPromoItems()={flag}";
			object[] args = Array.Empty<object>();
			GameLog.Info(msg, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA42E40", Offset = "0xA41840", VA = "0x180A42E40")]
		[AsyncStateMachine(typeof(_003CSetupSteamAuthentification_003Ed__19))]
		private Task SetupSteamAuthentification()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA42530", Offset = "0xA40F30", VA = "0x180A42530")]
		private bool HasTokenCache()
		{
			return !string.IsNullOrEmpty(tokenCache);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA42890", Offset = "0xA41290", VA = "0x180A42890")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA42D40", Offset = "0xA41740", VA = "0x180A42D40")]
		private void SetTokenCache(string _token)
		{
			if ("[Steam] SetTokenCache has invalid token" == null)
			{
				LastToken = _token;
			}
			object[] args = Array.Empty<object>();
			GameLog.Info("[Steam] SetTokenCache has invalid token", args);
			tokenCache = _token;
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			tokenCacheExpirationTime = dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0xA42330", Offset = "0xA40D30", VA = "0x180A42330")]
		[AsyncStateMachine(typeof(_003CGetTokenFromCache_003Ed__27))]
		private Task<string> GetTokenFromCache(int timeoutMs = 20000)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0xA42180", Offset = "0xA40B80", VA = "0x180A42180")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0xA42F40", Offset = "0xA41940", VA = "0x180A42F40")]
		public void Start()
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			if (Application.platform != RuntimePlatform.OSXPlayer)
			{
				int num2 = 0;
				if (Application.platform != 0)
				{
					return;
				}
			}
			AppleAuthManager appleAuthManager = (AppleAuthManager)(this.appleAuthManager = new AppleAuthManager(new PayloadDeserializer()));
			int num3 = 0;
			if (PlatformUtils.UseSteam())
			{
				OnlineClient onlineClient = default(OnlineClient);
				AuthManager authentificationManager = onlineClient.AuthentificationManager;
				AuthManager.OnPreLoginAction value = OnSteamPreLogin;
				authentificationManager.OnPreLogin += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0xA42550", Offset = "0xA40F50", VA = "0x180A42550")]
		public void Init()
		{
			bool isAgeGatePassed = BaseUiRoot.isAgeGatePassed;
			object[] args = Array.Empty<object>();
			string msg = default(string);
			GameLog.Info(msg, args);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.OnUserCredentialInitCB onUserCredentialInitCB = AssignAppleIds;
			metaClient.OnUserCredentialInit -= onUserCredentialInitCB;
			int num = 0;
			if (onUserCredentialInitCB == null)
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					int num3 = 0;
					if (Application.platform != 0)
					{
						return;
					}
				}
				int num4 = 0;
				if (!PlatformUtils.UseSteam())
				{
					int num5 = 0;
					if (!PlatformUtils.UseEpic())
					{
						return;
					}
				}
				Client.OnUserCredentialInitCB value = AssignAppleIds;
				Client client = default(Client);
				client.OnUserCredentialInit += value;
				return;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0xA42910", Offset = "0xA41310", VA = "0x180A42910")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_007c
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client.OnUserCredentialInitCB value = AssignAppleIds;
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
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0xA41C30", Offset = "0xA40630", VA = "0x180A41C30")]
		[AsyncStateMachine(typeof(_003CAssignAppleIds_003Ed__35))]
		public Task AssignAppleIds(Action<string, Client.FailureFallback> userCredentialInitCompleted)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0xA43BB0", Offset = "0xA425B0", VA = "0x180A43BB0")]
		private void Update()
		{
			int num = 0;
			if (Application.platform != RuntimePlatform.OSXPlayer)
			{
				int num2 = 0;
				if (Application.platform != 0)
				{
					return;
				}
			}
			if (appleAuthManager == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0xA43C20", Offset = "0xA42620", VA = "0x180A43C20")]
		public ApplePlayFabAccountLinking()
		{
		}
	}
}
