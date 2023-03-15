using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.UserInfo;
using EpicSdk.Configuration;
using Meta.Online.Economy;
using UnityEngine;

namespace EpicSdk.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public class EpicSdkService : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private PlatformInterface PlatformInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private UserInfoInterface UserInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private FriendsInterface FriendsInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private AuthInterface AuthInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private EcomInterface EcomInterface;

		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static EpicSdkService _instance;

		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static bool? _useEpic;

		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private static Action<Token?, Result> _onLoginComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private Token? userAuthToken;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EpicAccountId AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CAccountId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CAccountId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CUserId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CUserId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CDisplayName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CDisplayName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public static EpicSdkService Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x1367750", Offset = "0x1366150", VA = "0x181367750")]
			get
			{
				//Discarded unreachable code: IL_0037
				//IL_000f: Expected O, but got I4
				EpicSdkService instance = _instance;
				int num = 0;
				if (instance == (UnityEngine.Object)num)
				{
					int num2 = 0;
					if (UseEpic())
					{
						bool flag = InitInstance(new GameObject("Epic SDK").AddComponent<EpicSdkService>());
					}
				}
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x1366760", Offset = "0x1365160", VA = "0x181366760")]
		private static bool InitInstance(EpicSdkService instance)
		{
			//IL_001d: Expected O, but got I4
			if (_instance != instance)
			{
				EpicSdkService instance2 = _instance;
				int num = 0;
				if (!(instance2 != (UnityEngine.Object)num))
				{
					int num2 = 0;
					if (UseEpic())
					{
						_instance = instance;
						UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
						goto IL_003b;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
			goto IL_003b;
			IL_003b:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x1367670", Offset = "0x1366070", VA = "0x181367670")]
		public unsafe static bool UseEpic()
		{
			//IL_001b: Expected O, but got I4
			int num = 0;
			if (!TryGetEpicPasswordFromArgs(out *(string*)num))
			{
				int num2 = 0;
				if (EpicFileExists())
				{
				}
			}
			_useEpic = (bool?)(object)num;
			bool result = default(bool);
			return result;
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x1367510", Offset = "0x1365F10", VA = "0x181367510")]
			static bool EpicFileExists()
			{
				int num3 = 0;
				if (Application.webSecurityEnabled)
				{
				}
				int num4 = 0;
				bool flag = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "epic.txt"));
				string message = default(string);
				Debug.Log(message);
				int num5 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x13650B0", Offset = "0x1363AB0", VA = "0x1813650B0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0121, IL_012d, IL_0133
			if (InitInstance(this))
			{
				EpicServiceConfig epicServiceConfig = Resources.Load<EpicServiceConfig>("EpicStoreConfig");
				Utf8String utf8String = epicServiceConfig._productName;
				int num = 0;
				Utf8String utf8String2 = Application.version;
				Result result = default(Result);
				if (result != 0)
				{
					throw new NullReferenceException();
				}
				LogMessageFunc _003C_003E9__23_ = _003C_003Ec._003C_003E9__23_0;
				if (_003C_003E9__23_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(LogMessageFunc)delegate(ref LogMessage logMessage)
					{
						LogLevel _003CLevel_003Ek__BackingField = logMessage.Level;
						if (_003CLevel_003Ek__BackingField != LogLevel.Error && _003CLevel_003Ek__BackingField != LogLevel.Fatal)
						{
							Utf8String _003CMessage_003Ek__BackingField = logMessage.Message;
							Debug.Log($"[epic]: {_003CMessage_003Ek__BackingField}");
						}
						else
						{
							Utf8String _003CMessage_003Ek__BackingField2 = logMessage.Message;
							Debug.LogError($"[epic]: {_003CMessage_003Ek__BackingField2}");
						}
					};
				}
				Result result2 = LoggingInterface.SetCallback(_003C_003E9__23_);
				int num2 = 0;
				Utf8String utf8String3 = epicServiceConfig._productId;
				Utf8String utf8String4 = epicServiceConfig._sandboxId;
				Utf8String utf8String5 = epicServiceConfig._deploymentReleaseId;
				Utf8String utf8String6 = epicServiceConfig._clientId;
				Utf8String utf8String7 = epicServiceConfig._clientSecret;
				PlatformInterface platformInterface = default(PlatformInterface);
				PlatformInterface = platformInterface;
				UserInfoInterface userInfoInterface = (UserInterface = PlatformInterface.GetUserInfoInterface());
				FriendsInterface friendsInterface = (FriendsInterface = PlatformInterface.GetFriendsInterface());
				AuthInterface authInterface = (AuthInterface = PlatformInterface.GetAuthInterface());
				Debug.Log($"[EPIC]: Initialization done (ReleaseDeployment={EcomInterface = PlatformInterface.GetEcomInterface()})");
			}
			else
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x1367650", Offset = "0x1366050", VA = "0x181367650")]
		private void Update()
		{
			PlatformInterface?.Tick();
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x1366BC0", Offset = "0x13655C0", VA = "0x181366BC0")]
		private void OnDestroy()
		{
			PlatformInterface platformInterface;
			do
			{
				platformInterface = PlatformInterface;
			}
			while ((object)platformInterface == null);
			platformInterface.Release();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x1366B40", Offset = "0x1365540", VA = "0x181366B40")]
		public void OnApplicationFocus(bool hasFocus)
		{
			if ((object)PlatformInterface == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x1366B60", Offset = "0x1365560", VA = "0x181366B60")]
		private void OnApplicationQuit()
		{
			//Discarded unreachable code: IL_000e
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				Result result = PlatformInterface.Shutdown();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x13670E0", Offset = "0x1365AE0", VA = "0x1813670E0")]
		public static bool TryGetEpicArgs(string name, out string value, [Optional] string otherRequiredArgs)
		{
			//Discarded unreachable code: IL_004a
			int num = 0;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)delegate(string x)
			{
				//Discarded unreachable code: IL_000f
				string value2 = name;
				return x.StartsWith(value2);
			};
			string text = name;
			int num2 = default(int);
			string text2 = commandLineArgs[num2];
			int stringLength = text.m_stringLength;
			return text2.Substring(stringLength) == null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x13672A0", Offset = "0x1365CA0", VA = "0x1813672A0")]
		public static bool TryGetEpicPasswordFromArgs(out string password)
		{
			//IL_0037: Expected O, but got I4
			int num = 0;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (_003C_003Ec._003C_003E9__29_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((string x) => string.Equals(x, "-AUTH_TYPE=exchangecode"));
			}
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				return TryGetEpicArgs("-AUTH_PASSWORD=", out password, (string)num2);
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x1367420", Offset = "0x1365E20", VA = "0x181367420")]
		public static bool TryGetEpicUsernameFromArgs(out string username)
		{
			//IL_000e: Expected O, but got I4
			int num = 0;
			return TryGetEpicArgs("-epicusername=", out username, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x1367260", Offset = "0x1365C60", VA = "0x181367260")]
		public static bool TryGetEpicLanguageFromArgs(out string language)
		{
			//IL_000e: Expected O, but got I4
			int num = 0;
			return TryGetEpicArgs("-epiclocale=", out language, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x13668A0", Offset = "0x13652A0", VA = "0x1813668A0")]
		public unsafe bool Login([Optional] Action<Token?, Result> onComplete)
		{
			//IL_001d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (UseEpic())
			{
				int num3 = 0;
				if (TryGetEpicPasswordFromArgs(out *(string*)num2))
				{
					Utf8String utf8String = (string)num2;
				}
				int num4 = 0;
				int num5 = 0;
				_instance = (EpicSdkService)(object)onComplete;
				AuthInterface authInterface = AuthInterface;
				OnLoginCallback onLoginCallback = OnLoginCallback;
				if (onComplete == null)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x1364C90", Offset = "0x1363690", VA = "0x181364C90")]
		private void ApplyLoginCallback(EpicAccountId id)
		{
			//IL_0045: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			int num;
			Result result = default(Result);
			object[] array;
			while (true)
			{
				AccountId = id;
				Debug.Log($"[EPIC]: Login succeeded, User Id: {id}");
				Action<UserInfoData?> action = (Action<UserInfoData?>)(object)(Action<T>)delegate
				{
					//IL_0009: Expected O, but got I4
					//IL_000f: Expected O, but got I4
					int num2 = 0;
					UserId = (string)num2;
					string text = (DisplayName = (Utf8String)num2);
					throw new NullReferenceException();
				};
				num = 0;
				this.GetUserInfo(id, (Action<>)(object)action, true);
				AuthInterface authInterface = AuthInterface;
				if (result != 0)
				{
					Debug.LogError($"[EPIC]: failed to copy user auth token with following error => {result}.");
					return;
				}
				array = new object[4];
				if (num != 0 && array == null)
				{
					continue;
				}
				array[0] = num;
				if (num != 0 && array == null)
				{
					continue;
				}
				array[1] = num;
				if (array == null || array != null)
				{
					array[2] = num;
					if (num == 0 || array != null)
					{
						break;
					}
				}
			}
			array[3] = num;
			Debug.Log(string.Format("[EPIC]: successfully copied user auth token with following information:\nAccessToken={0}\nClientId={1}\n{2}\nExpiresAt={3}", array));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x1365CC0", Offset = "0x13646C0", VA = "0x181365CC0")]
		public Task<EpicRedeemer.EpicRedeemCredential> GetEpicCredentialAsync()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1366BF0", Offset = "0x13655F0", VA = "0x181366BF0")]
		private unsafe void OnLoginCallback(ref LoginCallbackInfo loginCallbackInfo)
		{
			//IL_003b: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			int num;
			bool flag = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				num = 0;
				if (!flag)
				{
					break;
				}
				object[] array = new object[4];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				bool flag2 = TryGetEpicPasswordFromArgs(out *(string*)num);
				if (flag2 && !flag2)
				{
					continue;
				}
				array[1] = flag2;
				if (!flag3 || flag3)
				{
					array[2] = flag3;
					int num2 = 0;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					if (!flag3 || flag3)
					{
						array[3] = flag3;
						Debug.LogError(string.Format("[EPIC]: Login failed: {0} (FromLauncher: {1}, ReleaseDeployment={2}, TimeSinceStartup={3:F2})", array));
						AuthInterface authInterface = AuthInterface;
						int num3 = 0;
						int num4 = 0;
						authInterface.DeletePersistentAuth(ref *(DeletePersistentAuthOptions*)num, num4, (OnDeletePersistentAuthCallback)num3);
						EpicAccountId _003CLocalUserId_003Ek__BackingField = loginCallbackInfo.LocalUserId;
						ApplyLoginCallback(_003CLocalUserId_003Ek__BackingField);
						break;
					}
				}
			}
			if (_onLoginComplete != null)
			{
				Token? token = userAuthToken;
			}
			_instance = (EpicSdkService)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x1367020", Offset = "0x1365A20", VA = "0x181367020")]
		private void OnStatusChange(ref LoginStatusChangedCallbackInfo data)
		{
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			LoginStatus _003CPrevStatus_003Ek__BackingField = data.PrevStatus;
			LoginStatus _003CCurrentStatus_003Ek__BackingField = data.CurrentStatus;
			Debug.Log($"[EPIC] OnStatusChange {_003CPrevStatus_003Ek__BackingField} => {_003CPrevStatus_003Ek__BackingField}");
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1365650", Offset = "0x1364050", VA = "0x181365650")]
		public void CheckoutOffer(string offerId, [Optional] OnCheckoutCallback MyCheckoutCB)
		{
			//IL_0028: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass39_0();
			CS_0024_003C_003E8__locals0.offerId = offerId;
			string offerId2 = CS_0024_003C_003E8__locals0.offerId;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				EpicAccountId epicAccountId = AccountId;
				int num = 0;
				if (!(epicAccountId == (Handle)num))
				{
					EcomInterface ecomInterface = EcomInterface;
					int num2 = 0;
					if (!(ecomInterface == (Handle)num2))
					{
						EpicAccountId epicAccountId2 = AccountId;
						CheckoutEntry[] array = new CheckoutEntry[1];
						Utf8String utf8String = (Utf8String)(array[0] = (CheckoutEntry)(Utf8String)CS_0024_003C_003E8__locals0.offerId);
						EcomInterface ecomInterface2 = EcomInterface;
						if (MyCheckoutCB == null)
						{
							OnCheckoutCallback onCheckoutCallback = delegate
							{
								string message = default(string);
								Debug.Log(message);
							};
						}
						return;
					}
				}
			}
			Debug.Log("[EPIC] Cannot process to checkout");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x13664B0", Offset = "0x1364EB0", VA = "0x1813664B0")]
		private void GetUserInfo(EpicAccountId id, Action<UserInfoData?> callback, bool useCache = true)
		{
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (useCache && flag)
			{
				if (callback != null)
				{
				}
				string text = $"[EPIC]: CACHED USER DATA Id: {num}, DisplayName: {num}, ";
				string text2 = $"Country: {num}, Language: {num}";
				Debug.Log(text + text2);
				return;
			}
			UserInfoInterface userInterface = UserInterface;
			OnQueryUserInfoCallback onQueryUserInfoCallback = QueryCallback;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x1391FF0", Offset = "0x13909F0", VA = "0x181391FF0")]
			void QueryCallback(ref QueryUserInfoCallbackInfo result)
			{
				//IL_001b: Expected O, but got I4
				//IL_003a: Expected O, but got I4
				UserInfoInterface userInterface2 = UserInterface;
				Result result2 = default(Result);
				int num2 = default(int);
				string message = default(string);
				if (result2 != 0)
				{
					message = $"[EPIC]: Error on copy user data: {result2}";
					num2 = 0;
					Debug.LogError(message);
					return;
				}
				((Action<T>)(object)callback)?.Invoke((T)num2);
				string text3 = $"[EPIC]: GOT USER DATA Id: {message}, DisplayName: {message}, ";
				string text4 = $"Country: {message}, Language: {message}";
				Debug.Log(text3 + text4);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x1366190", Offset = "0x1364B90", VA = "0x181366190")]
		public Task<IEnumerable<CatalogOffer>> GetOffersAsync()
		{
			EpicAccountId epicAccountId = AccountId;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IEnumerable<CatalogOffer>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x13662D0", Offset = "0x1364CD0", VA = "0x1813662D0")]
		[AsyncStateMachine(typeof(_003CGetOffersAsync_003Ed__42))]
		public Task<IEnumerable<CatalogOffer>> GetOffersAsync(EpicAccountId id)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IEnumerable<CatalogOffer>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x1366410", Offset = "0x1364E10", VA = "0x181366410")]
		[IteratorStateMachine(typeof(_003CGetOffers_003Ed__43))]
		private IEnumerable<CatalogOffer> GetOffers(EpicAccountId id)
		{
			_003CGetOffers_003Ed__43 _003CGetOffers_003Ed__ = new _003CGetOffers_003Ed__43(-2);
			_003CGetOffers_003Ed__._003C_003E4__this = this;
			_003CGetOffers_003Ed__._003C_003E3__id = id;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1365F10", Offset = "0x1364910", VA = "0x181365F10")]
		[AsyncStateMachine(typeof(_003CGetItemOwnershipAsync_003Ed__44))]
		public Task<IEnumerable<ItemOwnership>> GetItemOwnershipAsync(EpicAccountId id)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<IEnumerable<ItemOwnership>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x1366050", Offset = "0x1364A50", VA = "0x181366050")]
		[AsyncStateMachine(typeof(_003CGetItemOwnershipTokensAsync_003Ed__45))]
		public Task<string> GetItemOwnershipTokensAsync(EpicAccountId id)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x1365990", Offset = "0x1364390", VA = "0x181365990")]
		[AsyncStateMachine(typeof(_003CGetEntitlementsAsync_003Ed__46))]
		public Task<IEnumerable<Entitlement>> GetEntitlementsAsync(EpicAccountId id, bool includeRedeemed)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<IEnumerable<Entitlement>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x1365C30", Offset = "0x1364630", VA = "0x181365C30")]
		[IteratorStateMachine(typeof(_003CGetEntitlements_003Ed__47))]
		private IEnumerable<Entitlement> GetEntitlements(EpicAccountId id)
		{
			_003CGetEntitlements_003Ed__47 _003CGetEntitlements_003Ed__ = new _003CGetEntitlements_003Ed__47(-2);
			_003CGetEntitlements_003Ed__._003C_003E4__this = this;
			_003CGetEntitlements_003Ed__._003C_003E3__id = id;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x1365AE0", Offset = "0x13644E0", VA = "0x181365AE0")]
		[AsyncStateMachine(typeof(_003CGetEntitlementsOwnershipAsync_003Ed__48))]
		public Task<IEnumerable<Entitlement>> GetEntitlementsOwnershipAsync(EpicAccountId id, bool includeRedeemed)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<IEnumerable<Entitlement>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1365890", Offset = "0x1364290", VA = "0x181365890")]
		[AsyncStateMachine(typeof(_003CDebugTraceEntitlements_003Ed__49))]
		public Task DebugTraceEntitlements()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x1365E00", Offset = "0x1364800", VA = "0x181365E00")]
		private void GetFriends(EpicAccountId id)
		{
			//Discarded unreachable code: IL_0030
			EpicAccountId epicAccountId = id;
			FriendsInterface friendsInterface = FriendsInterface;
			OnQueryFriendsCallback onQueryFriendsCallback = delegate
			{
				//Discarded unreachable code: IL_0007, IL_0043
				//IL_003d: Expected O, but got I4
				string message = default(string);
				Debug.Log(message);
			};
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EpicSdkService()
		{
		}
	}
}
