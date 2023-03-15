using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using Meta.Online.Economy;
using Meta.Util;
using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.ClientModels;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E3B")]
	public class AuthManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000E3C")]
		public class AppleAAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E3D")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40039A2")]
				public string userId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40039A3")]
				public string identityToken;

				[Cpp2IlInjected.Token(Token = "0x6007818")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170014F4")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x6007812")]
				[Cpp2IlInjected.Address(RVA = "0xEE3020", Offset = "0xEE1A20", VA = "0x180EE3020")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6007813")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007811")]
			[Cpp2IlInjected.Address(RVA = "0xEE2FB0", Offset = "0xEE19B0", VA = "0x180EE2FB0")]
			public AppleAAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_apple", "apple")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6007814")]
			[Cpp2IlInjected.Address(RVA = "0xEE2D40", Offset = "0xEE1740", VA = "0x180EE2D40", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__5))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007815")]
			[Cpp2IlInjected.Address(RVA = "0xEE2BF0", Offset = "0xEE15F0", VA = "0x180EE2BF0", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__6))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007816")]
			[Cpp2IlInjected.Address(RVA = "0xEE2E90", Offset = "0xEE1890", VA = "0x180EE2E90", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__7))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007817")]
			[Cpp2IlInjected.Address(RVA = "0xEE2A70", Offset = "0xEE1470", VA = "0x180EE2A70", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E41")]
		public class CustomIDAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E42")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40039B4")]
				public string CustomID;

				[Cpp2IlInjected.Token(Token = "0x600782A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170014F5")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x6007820")]
				[Cpp2IlInjected.Address(RVA = "0xEE4460", Offset = "0xEE2E60", VA = "0x180EE4460")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6007821")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600781F")]
			[Cpp2IlInjected.Address(RVA = "0xEE43F0", Offset = "0xEE2DF0", VA = "0x180EE43F0")]
			public CustomIDAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_customid", "custom id")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6007822")]
			[Cpp2IlInjected.Address(RVA = "0xEE3D20", Offset = "0xEE2720", VA = "0x180EE3D20")]
			[AsyncStateMachine(typeof(_003CLoginID_003Ed__5))]
			public Task<LoginToPlayFabResult> LoginID(string customID, LoginToPlayFabRequest loginRequest)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007823")]
			[Cpp2IlInjected.Address(RVA = "0xEE3E80", Offset = "0xEE2880", VA = "0x180EE3E80", Slot = "4")]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				if (InData != null)
				{
					LoginData inData = InData;
					AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
					int num = 0;
					Task<> result = default(Task<>);
					return (Task<LoginToPlayFabResult>)(object)result;
				}
				Serilog.ILogger _003CLog_003Ek__BackingField = base.mgr.client.Log;
				Type type = GetType();
				string text = $"{type}.Login should not be called without a valid GameIDInfo set";
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007824")]
			[Cpp2IlInjected.Address(RVA = "0xEE3BB0", Offset = "0xEE25B0", VA = "0x180EE3BB0")]
			[AsyncStateMachine(typeof(_003CLinkIDWith_003Ed__7))]
			public Task<PlayFabError> LinkIDWith(string customID, PlayFabAuthenticationContext otherContext, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007825")]
			[Cpp2IlInjected.Address(RVA = "0xEE38E0", Offset = "0xEE22E0", VA = "0x180EE38E0", Slot = "5")]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				PlayFabResult<LoginResult> playFabResult = other.LoginResult;
				if (playFabResult != null)
				{
					int num = 0;
					if (playFabResult == null || playFabResult != null)
					{
					}
					if (num != 0)
					{
						LoginData inData = InData;
						PlayFabResult<LoginResult> playFabResult2 = other.LoginResult;
						AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
						int num2 = 0;
						Task<> result = default(Task<>);
						return (Task<PlayFabError>)(object)result;
					}
				}
				Serilog.ILogger _003CLog_003Ek__BackingField = base.mgr.client.Log;
				Type type = GetType();
				string text = $"Prog error : Asked to {type}.LinkWith but that auth is not currently logged in";
				int num3 = 0;
				Task<> task = Task.FromResult(PlayFabErrorExt.UnknownError);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007826")]
			[Cpp2IlInjected.Address(RVA = "0xEE41D0", Offset = "0xEE2BD0", VA = "0x180EE41D0")]
			public Task<PlayFabResult<UnlinkCustomIDResult>> UnlinkID(string id, PlayFabAuthenticationContext otherContext)
			{
				//Discarded unreachable code: IL_002b
				//IL_002a: Expected O, but got I4
				//IL_002a: Expected O, but got I4
				PlayFabClientInstanceAPI playFabClientInstanceAPI = playFabClient;
				UnlinkCustomIDRequest unlinkCustomIDRequest = new UnlinkCustomIDRequest();
				unlinkCustomIDRequest.AuthenticationContext = otherContext;
				unlinkCustomIDRequest.CustomId = id;
				int num = 0;
				int num2 = 0;
				return (Task<PlayFabResult<UnlinkCustomIDResult>>)(object)playFabClientInstanceAPI.UnlinkCustomIDAsync(unlinkCustomIDRequest, (object)num2, (Dictionary<, >)num);
			}

			[Cpp2IlInjected.Token(Token = "0x6007827")]
			[Cpp2IlInjected.Address(RVA = "0xEE4290", Offset = "0xEE2C90", VA = "0x180EE4290", Slot = "6")]
			public override Task<PlayFabError> Unlink()
			{
				//Discarded unreachable code: IL_0017
				string customID = InData.CustomID;
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007828")]
			[Cpp2IlInjected.Address(RVA = "0xEE4090", Offset = "0xEE2A90", VA = "0x180EE4090")]
			[AsyncStateMachine(typeof(_003CUnlinkID_003Ed__11))]
			public Task<PlayFabError> UnlinkID(string id)
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007829")]
			[Cpp2IlInjected.Address(RVA = "0xEE3880", Offset = "0xEE2280", VA = "0x180EE3880", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				return (Task<bool>)(object)Task.FromResult(result: false);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E46")]
		public class EpicAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E47")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40039C8")]
				public string AccessToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40039C9")]
				public string ClientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40039CA")]
				public string AccountId;

				[Cpp2IlInjected.Token(Token = "0x6007838")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40039C7")]
			private LoginResponse customIdLoginResponse;

			[Cpp2IlInjected.Token(Token = "0x170014F6")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x6007832")]
				[Cpp2IlInjected.Address(RVA = "0xEE4A40", Offset = "0xEE3440", VA = "0x180EE4A40")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6007833")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007831")]
			[Cpp2IlInjected.Address(RVA = "0xEE49D0", Offset = "0xEE33D0", VA = "0x180EE49D0")]
			public EpicAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_epic", "epic")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6007834")]
			[Cpp2IlInjected.Address(RVA = "0xEE4770", Offset = "0xEE3170", VA = "0x180EE4770", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__6))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007835")]
			[Cpp2IlInjected.Address(RVA = "0xEE4620", Offset = "0xEE3020", VA = "0x180EE4620", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__7))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007836")]
			[Cpp2IlInjected.Address(RVA = "0xEE48B0", Offset = "0xEE32B0", VA = "0x180EE48B0", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__8))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007837")]
			[Cpp2IlInjected.Address(RVA = "0xEE44E0", Offset = "0xEE2EE0", VA = "0x180EE44E0", Slot = "7")]
			[AsyncStateMachine(typeof(_003CDoHasAlreadyAuthTypeLinkedWith_003Ed__9))]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<bool>)(object)result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E4C")]
		public class GameloftIDAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E4D")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40039E3")]
				public string IdToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40039E4")]
				public string Email;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40039E5")]
				public string Password;

				[Cpp2IlInjected.Token(Token = "0x600785B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000E4E")]
			public class AccountRecoveryEmailResult
			{
				[Cpp2IlInjected.Token(Token = "0x2000E4F")]
				public enum ErrorCode
				{
					[Cpp2IlInjected.Token(Token = "0x40039E9")]
					Success,
					[Cpp2IlInjected.Token(Token = "0x40039EA")]
					InvalidPassword,
					[Cpp2IlInjected.Token(Token = "0x40039EB")]
					UserNotFound,
					[Cpp2IlInjected.Token(Token = "0x40039EC")]
					InvalidCode,
					[Cpp2IlInjected.Token(Token = "0x40039ED")]
					MaxResetPwdAttemptsReached,
					[Cpp2IlInjected.Token(Token = "0x40039EE")]
					UnknownError
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40039E6")]
				public HttpStatusCode StatusCode;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40039E7")]
				public ErrorCode ResultCode;

				[Cpp2IlInjected.Token(Token = "0x170014F9")]
				public bool IsOK
				{
					[Cpp2IlInjected.Token(Token = "0x600785C")]
					[Cpp2IlInjected.Address(RVA = "0x2032490", Offset = "0x2030E90", VA = "0x182032490")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600785D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public AccountRecoveryEmailResult()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000E50")]
			public enum EmailPasswordErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x40039F0")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40039F1")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x40039F2")]
				InvalidEmailAddress,
				[Cpp2IlInjected.Token(Token = "0x40039F3")]
				InvalidPassword,
				[Cpp2IlInjected.Token(Token = "0x40039F4")]
				EmailAddressNotAvailable
			}

			[Cpp2IlInjected.Token(Token = "0x2000E51")]
			public class RegisterEmailPasswordResult
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40039F5")]
				public EmailPasswordErrorCode Error;

				[Cpp2IlInjected.Token(Token = "0x170014FA")]
				public bool IsLoggedIn
				{
					[Cpp2IlInjected.Token(Token = "0x600785E")]
					[Cpp2IlInjected.Address(RVA = "0xC58490", Offset = "0xC56E90", VA = "0x180C58490")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600785F")]
					[Cpp2IlInjected.Address(RVA = "0xC584C0", Offset = "0xC56EC0", VA = "0x180C584C0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014FB")]
				public bool HasError
				{
					[Cpp2IlInjected.Token(Token = "0x6007860")]
					[Cpp2IlInjected.Address(RVA = "0x20324B0", Offset = "0x2030EB0", VA = "0x1820324B0")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014FC")]
				public bool IsRegistered
				{
					[Cpp2IlInjected.Token(Token = "0x6007861")]
					[Cpp2IlInjected.Address(RVA = "0x2032530", Offset = "0x2030F30", VA = "0x182032530")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014FD")]
				public bool IsEmailInvalid
				{
					[Cpp2IlInjected.Token(Token = "0x6007862")]
					[Cpp2IlInjected.Address(RVA = "0x20324F0", Offset = "0x2030EF0", VA = "0x1820324F0")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014FE")]
				public bool IsPasswordInvalid
				{
					[Cpp2IlInjected.Token(Token = "0x6007863")]
					[Cpp2IlInjected.Address(RVA = "0x2032510", Offset = "0x2030F10", VA = "0x182032510")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014FF")]
				public bool IsEmailAlreadyInUse
				{
					[Cpp2IlInjected.Token(Token = "0x6007864")]
					[Cpp2IlInjected.Address(RVA = "0x20324D0", Offset = "0x2030ED0", VA = "0x1820324D0")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6007865")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public RegisterEmailPasswordResult()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40039E2")]
			private GameloftIdConnection gameloftIdConnection;

			[Cpp2IlInjected.Token(Token = "0x170014F7")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x6007841")]
				[Cpp2IlInjected.Address(RVA = "0xEE6510", Offset = "0xEE4F10", VA = "0x180EE6510")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6007842")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170014F8")]
			public bool IsRemembered
			{
				[Cpp2IlInjected.Token(Token = "0x6007844")]
				[Cpp2IlInjected.Address(RVA = "0xEE6590", Offset = "0xEE4F90", VA = "0x180EE6590")]
				get
				{
					//Discarded unreachable code: IL_0016
					return base.mgr.client.CredentialProvider.HasGameloftID;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007843")]
			[Cpp2IlInjected.Address(RVA = "0xEE6440", Offset = "0xEE4E40", VA = "0x180EE6440")]
			public GameloftIDAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_gameloftid", "gameloft")
			{
				GameloftIdConnection gameloftIdConnection = (this.gameloftIdConnection = new GameloftIdConnection(base.mgr.client.IsGameRunningInRelease));
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007845")]
			[Cpp2IlInjected.Address(RVA = "0xEE4B60", Offset = "0xEE3560", VA = "0x180EE4B60")]
			public void AccountRegistered(string email, string pwd)
			{
				if ("GameloftIDAuthenticator AccountRegistered should only be called with valid email but it's empty or null." == null)
				{
					AuthManager authManager = base.mgr;
					if ("GameloftIDAuthenticator AccountRegistered should only be called with valid email but it's empty or null." == null)
					{
						if (!authManager.client.CredentialProvider.HasGameloftID)
						{
							base.mgr.client.CredentialProvider.RememberGameloftIDEmail = email;
							base.mgr.client.CredentialProvider.RememberGameloftIDPassword = pwd;
						}
					}
					else
					{
						Serilog.ILogger _003CLog_003Ek__BackingField = authManager.client.Log;
					}
					return;
				}
				Serilog.ILogger _003CLog_003Ek__BackingField2 = base.mgr.client.Log;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007846")]
			[Cpp2IlInjected.Address(RVA = "0xEE4AC0", Offset = "0xEE34C0", VA = "0x180EE4AC0")]
			private void AccountConfirmed()
			{
				//Discarded unreachable code: IL_0039
				if (string.IsNullOrEmpty(base.mgr.client.CredentialProvider.RememberGameloftIDLink))
				{
					base.mgr.client.CredentialProvider.RememberGameloftIDLink = "";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007847")]
			[Cpp2IlInjected.Address(RVA = "0xEE5EA0", Offset = "0xEE48A0", VA = "0x180EE5EA0")]
			public bool SaveCredentials(string email, string pwd, bool confirmAccount)
			{
				if (base.mgr.client.CredentialProvider.HasGameloftID)
				{
					int num = 0;
				}
				base.mgr.client.CredentialProvider.RememberGameloftIDEmail = email;
				base.mgr.client.CredentialProvider.RememberGameloftIDPassword = pwd;
				if (confirmAccount && base.mgr.client.CredentialProvider.RememberGameloftIDLink != null)
				{
					base.mgr.client.CredentialProvider.RememberGameloftIDLink = "";
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007848")]
			[Cpp2IlInjected.Address(RVA = "0xEE5880", Offset = "0xEE4280", VA = "0x180EE5880")]
			public void RefreshPassword(string pwd)
			{
				//Discarded unreachable code: IL_0017
				base.mgr.client.CredentialProvider.RememberGameloftIDPassword = pwd;
			}

			[Cpp2IlInjected.Token(Token = "0x6007849")]
			[Cpp2IlInjected.Address(RVA = "0xEE5BD0", Offset = "0xEE45D0", VA = "0x180EE5BD0")]
			public void RememberMe(string email, string pwd)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600784A")]
			[Cpp2IlInjected.Address(RVA = "0xEE53A0", Offset = "0xEE3DA0", VA = "0x180EE53A0")]
			public Task<bool> ForgetMe()
			{
				//Discarded unreachable code: IL_001c
				base.mgr.client.CredentialProvider.ResetGameloftID();
				return (Task<bool>)(object)Task.FromResult(result: true);
			}

			[Cpp2IlInjected.Token(Token = "0x600784B")]
			[Cpp2IlInjected.Address(RVA = "0xEE4E60", Offset = "0xEE3860", VA = "0x180EE4E60")]
			[AsyncStateMachine(typeof(_003CConfirmAccountCreation_003Ed__14))]
			public Task<bool> ConfirmAccountCreation(string email, string verificationCode)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<bool>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600784C")]
			[Cpp2IlInjected.Address(RVA = "0xEE4D00", Offset = "0xEE3700", VA = "0x180EE4D00")]
			[AsyncStateMachine(typeof(_003CAuthorize_003Ed__15))]
			private Task<GameloftIdConnection.ErrorCode> Authorize(string email, string password)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GameloftIdConnection.ErrorCode>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600784D")]
			[Cpp2IlInjected.Address(RVA = "0xEE5730", Offset = "0xEE4130", VA = "0x180EE5730", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__16))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600784E")]
			[Cpp2IlInjected.Address(RVA = "0xEE5250", Offset = "0xEE3C50", VA = "0x180EE5250", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__17))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600784F")]
			[Cpp2IlInjected.Address(RVA = "0xEE6320", Offset = "0xEE4D20", VA = "0x180EE6320", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__18))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007850")]
			[Cpp2IlInjected.Address(RVA = "0xEE4FC0", Offset = "0xEE39C0", VA = "0x180EE4FC0", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6007851")]
			[Cpp2IlInjected.Address(RVA = "0xEE6020", Offset = "0xEE4A20", VA = "0x180EE6020")]
			[AsyncStateMachine(typeof(_003CSendAccountRecoveryEmail_003Ed__21))]
			public Task<AccountRecoveryEmailResult> SendAccountRecoveryEmail(string email)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AccountRecoveryEmailResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007852")]
			[Cpp2IlInjected.Address(RVA = "0xEE6160", Offset = "0xEE4B60", VA = "0x180EE6160")]
			[AsyncStateMachine(typeof(_003CSetNewPassword_003Ed__22))]
			public Task<AccountRecoveryEmailResult> SetNewPassword(string email, string newPassword, string verificationCode)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AccountRecoveryEmailResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007853")]
			[Cpp2IlInjected.Address(RVA = "0xEE5A30", Offset = "0xEE4430", VA = "0x180EE5A30")]
			public Task<RegisterEmailPasswordResult> RegisterEmailPassword(string email, string password)
			{
				//Discarded unreachable code: IL_001b
				PlayFabAuthenticationContext currentAuthContext = base.mgr.onlineClient.CurrentAuthContext;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RegisterEmailPasswordResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007854")]
			[Cpp2IlInjected.Address(RVA = "0xEE58C0", Offset = "0xEE42C0", VA = "0x180EE58C0")]
			[AsyncStateMachine(typeof(_003CRegisterEmailPassword_003Ed__26))]
			public Task<RegisterEmailPasswordResult> RegisterEmailPassword(PlayFabAuthenticationContext bindTo, string email, string password)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RegisterEmailPasswordResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007855")]
			[Cpp2IlInjected.Address(RVA = "0xEE5510", Offset = "0xEE3F10", VA = "0x180EE5510")]
			[AsyncStateMachine(typeof(_003CGetParsedResponseContent_003Ed__27))]
			private Task<JObject> GetParsedResponseContent(HttpResponseMessage response, string actionName)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<JObject>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007856")]
			[Cpp2IlInjected.Address(RVA = "0xEE5450", Offset = "0xEE3E50", VA = "0x180EE5450")]
			private GameloftIdConnection.ErrorCode GetErrorCodeFromResponse(JObject parsedResponseContent)
			{
				if (parsedResponseContent != null)
				{
					GameloftIdConnection gameloftIdConnection = this.gameloftIdConnection;
					uint num = num + 20;
					num += num;
					GameloftIdConnection.ErrorCode result = default(GameloftIdConnection.ErrorCode);
					return result;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007857")]
			[Cpp2IlInjected.Address(RVA = "0xEE5670", Offset = "0xEE4070", VA = "0x180EE5670")]
			public bool IsEmailValid(string email)
			{
				int num = email.IndexOf("@");
				if (!string.IsNullOrEmpty(email) && num > 0)
				{
					return num < email.m_stringLength;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007858")]
			[Cpp2IlInjected.Address(RVA = "0xEE56F0", Offset = "0xEE40F0", VA = "0x180EE56F0")]
			public bool IsPasswordValid(string password)
			{
				//Discarded unreachable code: IL_000e
				return password.m_stringLength <= 100;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E5B")]
		public delegate Task OnPreLoginAction();

		[Cpp2IlInjected.Token(Token = "0x2000E5C")]
		public class PSNAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E5D")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003A38")]
				public string AuthCode;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003A39")]
				public int IssuerId;

				[Cpp2IlInjected.Token(Token = "0x6007883")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001500")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x600787C")]
				[Cpp2IlInjected.Address(RVA = "0xEE6C00", Offset = "0xEE5600", VA = "0x180EE6C00")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x600787D")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600787E")]
			[Cpp2IlInjected.Address(RVA = "0xEE6B90", Offset = "0xEE5590", VA = "0x180EE6B90")]
			public PSNAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_psn", "playstation")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600787F")]
			[Cpp2IlInjected.Address(RVA = "0xEE6920", Offset = "0xEE5320", VA = "0x180EE6920", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__5))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007880")]
			[Cpp2IlInjected.Address(RVA = "0xEE67D0", Offset = "0xEE51D0", VA = "0x180EE67D0", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__6))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007881")]
			[Cpp2IlInjected.Address(RVA = "0xEE6A70", Offset = "0xEE5470", VA = "0x180EE6A70", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__7))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007882")]
			[Cpp2IlInjected.Address(RVA = "0xEE6650", Offset = "0xEE5050", VA = "0x180EE6650", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E61")]
		public class SteamAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E62")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003A4A")]
				public string SteamTicket;

				[Cpp2IlInjected.Token(Token = "0x6007891")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001501")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x600788A")]
				[Cpp2IlInjected.Address(RVA = "0xEE73B0", Offset = "0xEE5DB0", VA = "0x180EE73B0")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x600788B")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600788C")]
			[Cpp2IlInjected.Address(RVA = "0xEE7340", Offset = "0xEE5D40", VA = "0x180EE7340")]
			public SteamAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_steam", "steam")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600788D")]
			[Cpp2IlInjected.Address(RVA = "0xEE70D0", Offset = "0xEE5AD0", VA = "0x180EE70D0", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__5))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600788E")]
			[Cpp2IlInjected.Address(RVA = "0xEE6F80", Offset = "0xEE5980", VA = "0x180EE6F80", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__6))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600788F")]
			[Cpp2IlInjected.Address(RVA = "0xEE7220", Offset = "0xEE5C20", VA = "0x180EE7220", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__7))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007890")]
			[Cpp2IlInjected.Address(RVA = "0xEE6E00", Offset = "0xEE5800", VA = "0x180EE6E00", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E66")]
		public class SwitchNSAAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E67")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.Token(Token = "0x600789F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001502")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x6007899")]
				[Cpp2IlInjected.Address(RVA = "0xEE79E0", Offset = "0xEE63E0", VA = "0x180EE79E0")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x600789A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007898")]
			[Cpp2IlInjected.Address(RVA = "0xEE7970", Offset = "0xEE6370", VA = "0x180EE7970")]
			public SwitchNSAAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_nintendo_nsa", "nintendo switch")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600789B")]
			[Cpp2IlInjected.Address(RVA = "0xEE7700", Offset = "0xEE6100", VA = "0x180EE7700", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__5))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600789C")]
			[Cpp2IlInjected.Address(RVA = "0xEE75B0", Offset = "0xEE5FB0", VA = "0x180EE75B0", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__6))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600789D")]
			[Cpp2IlInjected.Address(RVA = "0xEE7850", Offset = "0xEE6250", VA = "0x180EE7850", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__7))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600789E")]
			[Cpp2IlInjected.Address(RVA = "0xEE7430", Offset = "0xEE5E30", VA = "0x180EE7430", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E6B")]
		public class XboxAuthenticator : AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E6C")]
			public class LoginData : LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003A6C")]
				public string XboxToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003A6D")]
				public string GamerTag;

				[Cpp2IlInjected.Token(Token = "0x60078AD")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001503")]
			public new LoginData InData
			{
				[Cpp2IlInjected.Token(Token = "0x60078A6")]
				[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8480", VA = "0x180EF9A80")]
				get
				{
					LoginDataBase loginDataBase = base.InData;
					if (loginDataBase == null)
					{
						int num = 0;
					}
					int num2 = 0;
					while (loginDataBase != null)
					{
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x60078A7")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				set
				{
					base.InData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078A8")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A10", Offset = "0xEF8410", VA = "0x180EF9A10")]
			public XboxAuthenticator(AuthManager _mgr)
				: base(_mgr, "online.acclink_nativeauth_xbox", "xbox")
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60078A9")]
			[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF81A0", VA = "0x180EF97A0", Slot = "4")]
			[AsyncStateMachine(typeof(_003CLogin_003Ed__5))]
			public override Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<LoginToPlayFabResult>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60078AA")]
			[Cpp2IlInjected.Address(RVA = "0xEF9650", Offset = "0xEF8050", VA = "0x180EF9650", Slot = "5")]
			[AsyncStateMachine(typeof(_003CDoLinkWith_003Ed__6))]
			protected override Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60078AB")]
			[Cpp2IlInjected.Address(RVA = "0xEF98F0", Offset = "0xEF82F0", VA = "0x180EF98F0", Slot = "6")]
			[AsyncStateMachine(typeof(_003CUnlink_003Ed__7))]
			public override Task<PlayFabError> Unlink()
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60078AC")]
			[Cpp2IlInjected.Address(RVA = "0xEF94D0", Offset = "0xEF7ED0", VA = "0x180EF94D0", Slot = "7")]
			protected override Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E70")]
		public class LoginToPlayFabRequest
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A7E")]
			public bool CreateAccount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003A7F")]
			public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003A80")]
			public CustomIDAuthenticator CurrentGameCustomIdAuth;

			[Cpp2IlInjected.Token(Token = "0x60078B4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LoginToPlayFabRequest()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E71")]
		public class LoginToPlayFabResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A81")]
			public PlayFabClientInstanceAPI client;

			[Cpp2IlInjected.Token(Token = "0x17001504")]
			public PlayFabResult<LoginResult> LoginResult
			{
				[Cpp2IlInjected.Token(Token = "0x60078B5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CLoginResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078B6")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CLoginResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001505")]
			public bool NewUser
			{
				[Cpp2IlInjected.Token(Token = "0x60078B7")]
				[Cpp2IlInjected.Address(RVA = "0xEE65D0", Offset = "0xEE4FD0", VA = "0x180EE65D0")]
				get
				{
					if (LoginResult != null)
					{
						int num = 0;
					}
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001506")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003A83")]
			public bool NewDevice
			{
				[Cpp2IlInjected.Token(Token = "0x60078B8")]
				[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60078B9")]
				[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60078BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LoginToPlayFabResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E72")]
		public class PlatformTokenData
		{
			[Cpp2IlInjected.Token(Token = "0x17001507")]
			public string AuthTokenStr
			{
				[Cpp2IlInjected.Token(Token = "0x60078BB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthTokenStr_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078BC")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAuthTokenStr_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001508")]
			public string AuthUserIDStr
			{
				[Cpp2IlInjected.Token(Token = "0x60078BD")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthUserIDStr_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078BE")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CAuthUserIDStr_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlatformTokenData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E73")]
		public class PlatformTokenFetchResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A86")]
			public PlatformTokenData TokenData;

			[Cpp2IlInjected.Token(Token = "0x17001509")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x60078C0")]
				[Cpp2IlInjected.Address(RVA = "0xAE6160", Offset = "0xAE4B60", VA = "0x180AE6160")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078C1")]
			[Cpp2IlInjected.Address(RVA = "0xEE6C80", Offset = "0xEE5680", VA = "0x180EE6C80")]
			public PlatformTokenFetchResult WithValidTokenData(PlatformTokenData tokenData)
			{
				TokenData = tokenData;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60078C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlatformTokenFetchResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E74")]
		public class PlatformTokenFetchRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60078C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlatformTokenFetchRequest()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E75")]
		public interface IPlatformTokenProvider
		{
			[Cpp2IlInjected.Token(Token = "0x60078C4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<PlatformTokenFetchResult> Fetch(PlatformTokenFetchRequest request, CancellationToken ct);
		}

		[Cpp2IlInjected.Token(Token = "0x2000E76")]
		public class PlatformTokenProviderWithCache : IPlatformTokenProvider
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A87")]
			private IPlatformTokenProvider tokenProviderImpl;

			[Cpp2IlInjected.Token(Token = "0x1700150A")]
			public PlatformTokenData CachedToken
			{
				[Cpp2IlInjected.Token(Token = "0x60078C5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCachedToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078C6")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCachedToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078C7")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public PlatformTokenProviderWithCache(IPlatformTokenProvider tokenProviderPlatformImpl)
			{
				tokenProviderImpl = tokenProviderPlatformImpl;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60078C8")]
			[Cpp2IlInjected.Address(RVA = "0xEE6CA0", Offset = "0xEE56A0", VA = "0x180EE6CA0", Slot = "4")]
			[AsyncStateMachine(typeof(_003CFetch_003Ed__6))]
			public Task<PlatformTokenFetchResult> Fetch(PlatformTokenFetchRequest request, CancellationToken ct)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlatformTokenFetchResult>)(object)result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E78")]
		public abstract class AuthentificatorBase
		{
			[Cpp2IlInjected.Token(Token = "0x2000E79")]
			public class LoginDataBase
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003A95")]
				public IPlatformTokenProvider PlatformTokenProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003A96")]
				public EconomyManagerBuilder EconomyManagerBuilder;

				[Cpp2IlInjected.Token(Token = "0x60078E2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public LoginDataBase()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4003A94")]
			public PlayFabClientInstanceAPI playFabClient;

			[Cpp2IlInjected.Token(Token = "0x1700150B")]
			public LoginDataBase InData
			{
				[Cpp2IlInjected.Token(Token = "0x60078CB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CInData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078CC")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CInData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700150C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003A90")]
			protected AuthManager mgr
			{
				[Cpp2IlInjected.Token(Token = "0x60078CD")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700150D")]
			public string AuthNameStringID
			{
				[Cpp2IlInjected.Token(Token = "0x60078CE")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthNameStringID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078CF")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CAuthNameStringID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700150E")]
			public string AuthPlatformName
			{
				[Cpp2IlInjected.Token(Token = "0x60078D0")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthPlatformName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078D1")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003CAuthPlatformName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700150F")]
			public PlayFabResult<LoginResult> LoginResult
			{
				[Cpp2IlInjected.Token(Token = "0x60078D2")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CLoginResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078D3")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CLoginResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001510")]
			public bool IsGameloftIdLinked
			{
				[Cpp2IlInjected.Token(Token = "0x60078D7")]
				[Cpp2IlInjected.Address(RVA = "0xEE37F0", Offset = "0xEE21F0", VA = "0x180EE37F0")]
				get
				{
					if (LoginResult != null)
					{
						if (this == null || AuthNameStringID != null)
						{
						}
						bool result;
						if (false)
						{
							return result;
						}
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001511")]
			public bool IsNewUser
			{
				[Cpp2IlInjected.Token(Token = "0x60078DA")]
				[Cpp2IlInjected.Address(RVA = "0xEE3830", Offset = "0xEE2230", VA = "0x180EE3830")]
				get
				{
					PlayFabResult<LoginResult> playFabResult = LoginResult;
					if (playFabResult != null)
					{
						if (playFabResult != null)
						{
						}
						if (0 == 0)
						{
						}
					}
					int num = 0;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078D4")]
			[Cpp2IlInjected.Address(RVA = "0xEE3740", Offset = "0xEE2140", VA = "0x180EE3740")]
			public unsafe AuthentificatorBase(AuthManager _mgr, string authNameStringID, string authPlatformName)
			{
				//IL_000b: Expected O, but got I4
				int num = 0;
				base.FieldGetter((string)num, authNameStringID, ref *(object*)authPlatformName);
				mgr = _mgr;
				AuthNameStringID = authNameStringID;
				AuthPlatformName = authPlatformName;
				PlayFabClientInstanceAPI playFabClientInstanceAPI = (playFabClient = new PlayFabClientInstanceAPI());
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60078D5")]
			[Cpp2IlInjected.Address(RVA = "0xEE3520", Offset = "0xEE1F20", VA = "0x180EE3520")]
			public bool IsLoggedIn()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60078D6")]
			[Cpp2IlInjected.Address(RVA = "0xEE3560", Offset = "0xEE1F60", VA = "0x180EE3560")]
			public bool IsSameUser(AuthentificatorBase other)
			{
				while (LoginResult != null)
				{
					int num = 0;
					if (this != null)
					{
					}
					if (num == 0 || other.LoginResult == null)
					{
						break;
					}
					if (other == null)
					{
						continue;
					}
					string text = other.AuthNameStringID;
					if (text != null)
					{
						if (text.m_stringLength == 0)
						{
						}
						break;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60078D8")]
			[Cpp2IlInjected.Address(RVA = "0xEE30E0", Offset = "0xEE1AE0", VA = "0x180EE30E0")]
			public string GetPlayFabID()
			{
				PlayFabResult<LoginResult> playFabResult = LoginResult;
				if (playFabResult == null || this == null || playFabResult == null)
				{
				}
				return "unknown";
			}

			[Cpp2IlInjected.Token(Token = "0x60078D9")]
			[Cpp2IlInjected.Address(RVA = "0xEE30A0", Offset = "0xEE1AA0", VA = "0x180EE30A0")]
			public string GetCustomID()
			{
				PlayFabResult<LoginResult> playFabResult = LoginResult;
				if (playFabResult != null && playFabResult != null && this != null)
				{
					LoginDataBase loginDataBase = InData;
					if (loginDataBase != null && loginDataBase != null)
					{
						IPlatformTokenProvider platformTokenProvider = loginDataBase.PlatformTokenProvider;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60078DB")]
			[Cpp2IlInjected.Address(RVA = "0xAE6160", Offset = "0xAE4B60", VA = "0x180AE6160")]
			public bool HasLoginData()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60078DC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract Task<LoginToPlayFabResult> Login(LoginToPlayFabRequest loginRequest);

			[Cpp2IlInjected.Token(Token = "0x60078DD")]
			[Cpp2IlInjected.Address(RVA = "0xEE35F0", Offset = "0xEE1FF0", VA = "0x180EE35F0")]
			[AsyncStateMachine(typeof(_003CLinkWith_003Ed__32))]
			public Task<PlayFabError> LinkWith(AuthentificatorBase other, bool forceLink)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlayFabError>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60078DE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract Task<PlayFabError> DoLinkWith(AuthentificatorBase other, bool forceLink);

			[Cpp2IlInjected.Token(Token = "0x60078DF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract Task<PlayFabError> Unlink();

			[Cpp2IlInjected.Token(Token = "0x60078E0")]
			[Cpp2IlInjected.Address(RVA = "0xEE3130", Offset = "0xEE1B30", VA = "0x180EE3130")]
			public Task<bool> HasAlreadyAuthTypeLinkedWith(AuthentificatorBase other)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60078E1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract Task<bool> DoHasAlreadyAuthTypeLinkedWith(AuthentificatorBase other);
		}

		[Cpp2IlInjected.Token(Token = "0x2000E7B")]
		public class GetAuthEntityResult
		{
			[Cpp2IlInjected.Token(Token = "0x17001512")]
			public string PlayFabId
			{
				[Cpp2IlInjected.Token(Token = "0x60078E5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078E6")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001513")]
			public string EntityToken
			{
				[Cpp2IlInjected.Token(Token = "0x60078E7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CEntityToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60078E8")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CEntityToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60078E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetAuthEntityResult()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400399B")]
		private readonly OnlineClient onlineClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400399C")]
		private int _logccounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400399D")]
		public LoginToPlayFabResult ActiveLogin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40039A1")]
		public GetPlayerCombinedInfoRequestParams AccountManagerLoginPayLoad;

		[Cpp2IlInjected.Token(Token = "0x170014EE")]
		private Client client
		{
			[Cpp2IlInjected.Token(Token = "0x6007800")]
			[Cpp2IlInjected.Address(RVA = "0x18ECBB0", Offset = "0x18EB5B0", VA = "0x1818ECBB0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return onlineClient.client;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EF")]
		public bool IsNativeAuth
		{
			[Cpp2IlInjected.Token(Token = "0x6007803")]
			[Cpp2IlInjected.Address(RVA = "0x18ECBA0", Offset = "0x18EB5A0", VA = "0x1818ECBA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F0")]
		public AuthentificatorBase CurrentAuth
		{
			[Cpp2IlInjected.Token(Token = "0x6007804")]
			[Cpp2IlInjected.Address(RVA = "0x18ECB90", Offset = "0x18EB590", VA = "0x1818ECB90")]
			get
			{
				AuthentificatorBase authentificatorBase = NativeAuth;
				if (authentificatorBase == null)
				{
				}
				return authentificatorBase;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x400399E")]
		public AuthentificatorBase NativeAuth
		{
			[Cpp2IlInjected.Token(Token = "0x6007805")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170014F2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400399F")]
		public CustomIDAuthenticator GameCustomIDAuthentificator
		{
			[Cpp2IlInjected.Token(Token = "0x6007806")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170014F3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40039A0")]
		public GameloftIDAuthenticator GameloftIDAuthenticatorInst
		{
			[Cpp2IlInjected.Token(Token = "0x6007807")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400008E")]
		public event OnPreLoginAction OnPreLogin
		{
			[Cpp2IlInjected.Token(Token = "0x60077FE")]
			[Cpp2IlInjected.Address(RVA = "0x18ECAF0", Offset = "0x18EB4F0", VA = "0x1818ECAF0")]
			[CompilerGenerated]
			add
			{
				OnPreLoginAction onPreLogin = this.OnPreLogin;
				Delegate @delegate = Delegate.Combine(onPreLogin, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPreLogin)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60077FF")]
			[Cpp2IlInjected.Address(RVA = "0x18ECBD0", Offset = "0x18EB5D0", VA = "0x1818ECBD0")]
			[CompilerGenerated]
			remove
			{
				OnPreLoginAction onPreLogin = this.OnPreLogin;
				Delegate @delegate = Delegate.Remove(onPreLogin, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPreLogin)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007801")]
		[Cpp2IlInjected.Address(RVA = "0x18EBDB0", Offset = "0x18EA7B0", VA = "0x1818EBDB0")]
		public void DebugLog(string msg)
		{
			//Discarded unreachable code: IL_0045
			//IL_0042: Expected O, but got I4
			int num = 0;
			if (DebugSettings.Settings.debugAccountLinking_)
			{
				Client client = onlineClient.client;
				if (client != null)
				{
					Serilog.ILogger _003CLog_003Ek__BackingField = client.Log;
					string text = $"[AL][{++_logccounter}]: {msg}";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007802")]
		[Cpp2IlInjected.Address(RVA = "0x18EC150", Offset = "0x18EAB50", VA = "0x1818EC150")]
		public string GetLastNativeKey(AuthentificatorBase nativeAuth)
		{
			//Discarded unreachable code: IL_0013
			string _003CAuthPlatformName_003Ek__BackingField = nativeAuth.AuthPlatformName;
			return "last_native_" + _003CAuthPlatformName_003Ek__BackingField;
		}

		[Cpp2IlInjected.Token(Token = "0x6007808")]
		[Cpp2IlInjected.Address(RVA = "0x18EC730", Offset = "0x18EB130", VA = "0x1818EC730")]
		public AuthManager(OnlineClient onlineClient)
		{
			//IL_002a: Expected O, but got I4
			GetPlayerCombinedInfoRequestParams getPlayerCombinedInfoRequestParams = new GetPlayerCombinedInfoRequestParams
			{
				GetUserAccountInfo = true
			};
			AccountManagerLoginPayLoad = getPlayerCombinedInfoRequestParams;
			base._002Ector();
			this.onlineClient = onlineClient;
			int num = 0;
			NativeAuth = (AuthentificatorBase)num;
			IUnityContext _003CUnityContext_003Ek__BackingField = onlineClient.client.UnityContext;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((long)getPlayerCombinedInfoRequestParams <= 9)
			{
				_003CUnityContext_003Ek__BackingField = (IUnityContext)(object)((object)_003CUnityContext_003Ek__BackingField + (object)_003CUnityContext_003Ek__BackingField);
				SteamAuthenticator steamAuthenticator = new SteamAuthenticator(this);
				EpicAuthenticator epicAuthenticator = new EpicAuthenticator(this);
				XboxAuthenticator xboxAuthenticator = new XboxAuthenticator(this);
				PSNAuthenticator pSNAuthenticator = new PSNAuthenticator(this);
				SwitchNSAAuthenticator switchNSAAuthenticator = new SwitchNSAAuthenticator(this);
				AppleAAuthenticator appleAAuthenticator = (AppleAAuthenticator)(NativeAuth = new AppleAAuthenticator(this));
			}
			AuthentificatorBase authentificatorBase = NativeAuth;
			OnlineClient onlineClient2 = this.onlineClient;
			if (authentificatorBase == null)
			{
				Client client = default(Client);
				if (client == null)
				{
					goto IL_00cd;
				}
				Serilog.ILogger _003CLog_003Ek__BackingField = client.Log;
			}
			Client client2 = default(Client);
			if (client2 != null)
			{
				Serilog.ILogger _003CLog_003Ek__BackingField2 = client2.Log;
				string _003CAuthPlatformName_003Ek__BackingField = authentificatorBase.AuthPlatformName;
				string text = "[AL] AuthManager: NativeAuth successfully found with following auth type: " + _003CAuthPlatformName_003Ek__BackingField;
			}
			goto IL_00cd;
			IL_00cd:
			CustomIDAuthenticator customIDAuthenticator = (GameCustomIDAuthentificator = new CustomIDAuthenticator(this));
			GameloftIDAuthenticator gameloftIDAuthenticator = (GameloftIDAuthenticatorInst = new GameloftIDAuthenticator(this));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007809")]
		[Cpp2IlInjected.Address(RVA = "0x18EBEC0", Offset = "0x18EA8C0", VA = "0x1818EBEC0")]
		[AsyncStateMachine(typeof(_003CDoDebugCleaning_003Ed__42))]
		private Task DoDebugCleaning()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600780A")]
		[Cpp2IlInjected.Address(RVA = "0x18EC300", Offset = "0x18EAD00", VA = "0x1818EC300")]
		[AsyncStateMachine(typeof(_003CLoginToPlayFab_003Ed__44))]
		public Task<PlayFabError> LoginToPlayFab(LoginToPlayFabRequest request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600780B")]
		[Cpp2IlInjected.Address(RVA = "0x18EC460", Offset = "0x18EAE60", VA = "0x1818EC460")]
		public void LogoutFromPlayFab(CancellationToken ct)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600780C")]
		[Cpp2IlInjected.Address(RVA = "0x18EC120", Offset = "0x18EAB20", VA = "0x1818EC120")]
		public bool GameloftIDAccountRegistered(string email, string pwd)
		{
			//Discarded unreachable code: IL_0013
			GameloftIDAuthenticator gameloftIDAuthenticator = GameloftIDAuthenticatorInst;
			int confirmAccount = 0;
			return gameloftIDAuthenticator.SaveCredentials(email, pwd, (byte)confirmAccount != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600780D")]
		[Cpp2IlInjected.Address(RVA = "0x18EBFC0", Offset = "0x18EA9C0", VA = "0x1818EBFC0")]
		[AsyncStateMachine(typeof(_003CForceGameloftIdLinkToCurrentAuth_003Ed__47))]
		public Task<bool> ForceGameloftIdLinkToCurrentAuth(string email, string pwd)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600780E")]
		[Cpp2IlInjected.Address(RVA = "0x18EC630", Offset = "0x18EB030", VA = "0x1818EC630")]
		[AsyncStateMachine(typeof(_003CRefreshUserAccountInfo_003Ed__48))]
		public Task RefreshUserAccountInfo(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600780F")]
		[Cpp2IlInjected.Address(RVA = "0x18EC1A0", Offset = "0x18EABA0", VA = "0x1818EC1A0")]
		[AsyncStateMachine(typeof(_003CLinkWithGameloftIdAndRelogin_003Ed__49))]
		public Task<bool> LinkWithGameloftIdAndRelogin(string email, string pwd)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007810")]
		[Cpp2IlInjected.Address(RVA = "0x18EC4F0", Offset = "0x18EAEF0", VA = "0x1818EC4F0")]
		[AsyncStateMachine(typeof(_003CRefreshGameloftIDPasswordAndLogin_003Ed__50))]
		public Task<bool> RefreshGameloftIDPasswordAndLogin(string pwd)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}
	}
}
