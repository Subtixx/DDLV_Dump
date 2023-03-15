using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using glPlayFab;
using Mdl.Online;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Meta.Util;
using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000718")]
	[RequiredAllNotNull]
	public class StartMenuLinkAccount : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000719")]
		private enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40028FE")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x40028FF")]
			Offline,
			[Cpp2IlInjected.Token(Token = "0x4002900")]
			Unlinked,
			[Cpp2IlInjected.Token(Token = "0x4002901")]
			Linked,
			[Cpp2IlInjected.Token(Token = "0x4002902")]
			ConfirmCreateAccount,
			[Cpp2IlInjected.Token(Token = "0x4002903")]
			LoginFailure
		}

		[Cpp2IlInjected.Token(Token = "0x200071A")]
		private enum ResetPasswordState
		{
			[Cpp2IlInjected.Token(Token = "0x4002905")]
			Hidden,
			[Cpp2IlInjected.Token(Token = "0x4002906")]
			Step1,
			[Cpp2IlInjected.Token(Token = "0x4002907")]
			Step2
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40028DB")]
		[SerializeField]
		[Header("Offline")]
		private GameObject _offlinePanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40028DC")]
		[SerializeField]
		private TextButton _testConnectionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40028DD")]
		[SerializeField]
		[Header("Unlinked")]
		[FormerlySerializedAs("_onlineUnlinkedPanel")]
		private GameObject _unlinkedPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40028DE")]
		[SerializeField]
		private TextBase _lblLoginInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40028DF")]
		[SerializeField]
		private TMP_InputField _emailTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40028E0")]
		[SerializeField]
		private TMP_InputField _pwdTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40028E1")]
		[SerializeField]
		private TextButton _loginAccountBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40028E2")]
		[SerializeField]
		private TextButton _createAccountBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40028E3")]
		[SerializeField]
		[Header("Linked")]
		[FormerlySerializedAs("_onlineLinkedPanel")]
		private GameObject _linkedPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40028E4")]
		[SerializeField]
		private TMP_Text _connectedEmailText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40028E5")]
		[SerializeField]
		private TextButton _linkedResetPasswordBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40028E6")]
		[SerializeField]
		[Header("Confirm Create Account")]
		private GameObject _linkAccountConfirmCreationPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40028E7")]
		[SerializeField]
		private TMP_InputField _accountCreationCodeTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40028E8")]
		[SerializeField]
		private TextButton _cancelAccountCreationBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40028E9")]
		[SerializeField]
		private TextButton _loginWithCodeBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40028EA")]
		[SerializeField]
		[Header("Reset Password")]
		private GameObject _linkAccountResetPasswordPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40028EB")]
		[SerializeField]
		private TMP_InputField _emailResetTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40028EC")]
		[SerializeField]
		private TextButton _sendPasswordBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40028ED")]
		[SerializeField]
		private TextButton _sendPasswordBtnDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40028EE")]
		[SerializeField]
		private Button _closePasswordResetBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40028EF")]
		[SerializeField]
		[Header("Enter New Password")]
		private GameObject _linkAccountSetNewPasswordPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40028F0")]
		[SerializeField]
		private TMP_InputField _setNewPasswordEmailTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40028F1")]
		[SerializeField]
		private TMP_InputField _setNewPasswordNewPwdTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40028F2")]
		[SerializeField]
		private TMP_InputField _setNewPasswordCodeTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40028F3")]
		[SerializeField]
		private TextButton _setNewPasswordBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40028F4")]
		[SerializeField]
		[Header("Error Logging In")]
		private GameObject _loginFailurePanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40028F5")]
		[SerializeField]
		private TMP_InputField _loginFailureEmailTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40028F6")]
		[SerializeField]
		private TMP_InputField _loginFailurePasswordTextInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40028F7")]
		[SerializeField]
		private TextButton _loginFailureLoginBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40028F8")]
		[SerializeField]
		private TextButton _loginFailureResetPasswordBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40028F9")]
		[SerializeField]
		[Header("Focus Navigation")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40028FA")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40028FB")]
		private State _state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40028FC")]
		private ResetPasswordState _resetPasswordState;

		[Cpp2IlInjected.Token(Token = "0x1700068B")]
		private AccountLinkingManager AccLinkMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002D2E")]
			[Cpp2IlInjected.Address(RVA = "0x85E5A0", Offset = "0x85CFA0", VA = "0x18085E5A0")]
			get
			{
				int num = 0;
				return AccountLinkingManager.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068C")]
		private static Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6002D2F")]
			[Cpp2IlInjected.Address(RVA = "0x85E630", Offset = "0x85D030", VA = "0x18085E630")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068D")]
		private AuthManager AuthMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002D30")]
			[Cpp2IlInjected.Address(RVA = "0x85E5B0", Offset = "0x85CFB0", VA = "0x18085E5B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return MetaClient.OnlineClient.AuthentificationManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068E")]
		private new CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6002D31")]
			[Cpp2IlInjected.Address(RVA = "0x85E5E0", Offset = "0x85CFE0", VA = "0x18085E5E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068F")]
		private State CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x6002D32")]
			[Cpp2IlInjected.Address(RVA = "0x85E620", Offset = "0x85D020", VA = "0x18085E620")]
			get
			{
				return _state;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D33")]
			[Cpp2IlInjected.Address(RVA = "0x85E700", Offset = "0x85D100", VA = "0x18085E700")]
			set
			{
				//IL_0023: Expected I4, but got I8
				if (_state != value)
				{
					_state = value;
					if (value == State.Unknown)
					{
						SyncOnlineClientState();
					}
					_resetPasswordState = ResetPasswordState.Hidden;
					UpdateVisuals();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000690")]
		private ResetPasswordState CurrentResetPasswordState
		{
			[Cpp2IlInjected.Token(Token = "0x6002D34")]
			[Cpp2IlInjected.Address(RVA = "0x85E610", Offset = "0x85D010", VA = "0x18085E610")]
			get
			{
				return _resetPasswordState;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D35")]
			[Cpp2IlInjected.Address(RVA = "0x85E6E0", Offset = "0x85D0E0", VA = "0x18085E6E0")]
			set
			{
				if (_resetPasswordState != value)
				{
					_resetPasswordState = value;
					UpdateVisuals();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D36")]
		[Cpp2IlInjected.Address(RVA = "0x85C750", Offset = "0x85B150", VA = "0x18085C750", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D37")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D38")]
		[Cpp2IlInjected.Address(RVA = "0x85D140", Offset = "0x85BB40", VA = "0x18085D140", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0096
			((object)this)._002Ector();
			TMP_InputField.OnChangeEvent onValueChanged = _emailResetTextInput.m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnResetPasswordTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			int num = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField = MetaClient.OnlineClient;
			OnlineClient.ConnectionModeChanged value = ConnectionModeChangedCB;
			_003COnlineClient_003Ek__BackingField.OnConnectionModeChanged += value;
			int num2 = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField2 = MetaClient.OnlineClient;
			OnlineClient.OnlineConnectionChanged value2 = OnlineConnectionChangedCB;
			_003COnlineClient_003Ek__BackingField2.OnOnlineConnectionChanged += value2;
			int num3 = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField3 = MetaClient.OnlineClient;
			OnlineClient.LoginFailure value3 = LoginFailureCB;
			_003COnlineClient_003Ek__BackingField3.OnLoginFailure += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D39")]
		[Cpp2IlInjected.Address(RVA = "0x85E1D0", Offset = "0x85CBD0", VA = "0x18085E1D0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0096
			((object)this)._002Ector();
			TMP_InputField.OnChangeEvent onValueChanged = _emailResetTextInput.m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnResetPasswordTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			int num = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField = MetaClient.OnlineClient;
			OnlineClient.ConnectionModeChanged value = ConnectionModeChangedCB;
			_003COnlineClient_003Ek__BackingField.OnConnectionModeChanged -= value;
			int num2 = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField2 = MetaClient.OnlineClient;
			OnlineClient.OnlineConnectionChanged value2 = OnlineConnectionChangedCB;
			_003COnlineClient_003Ek__BackingField2.OnOnlineConnectionChanged -= value2;
			int num3 = 0;
			OnlineClient _003COnlineClient_003Ek__BackingField3 = MetaClient.OnlineClient;
			OnlineClient.LoginFailure value3 = LoginFailureCB;
			_003COnlineClient_003Ek__BackingField3.OnLoginFailure -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3A")]
		[Cpp2IlInjected.Address(RVA = "0x85B910", Offset = "0x85A310", VA = "0x18085B910")]
		public void Init()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3B")]
		[Cpp2IlInjected.Address(RVA = "0x85B400", Offset = "0x859E00", VA = "0x18085B400")]
		private void ConnectionModeChangedCB(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			SyncOnlineClientState();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3C")]
		[Cpp2IlInjected.Address(RVA = "0x85B400", Offset = "0x859E00", VA = "0x18085B400")]
		private void OnlineConnectionChangedCB(Profile profile, bool isLoggedIn, CancellationToken ct)
		{
			SyncOnlineClientState();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3D")]
		[Cpp2IlInjected.Address(RVA = "0x85B400", Offset = "0x859E00", VA = "0x18085B400")]
		private void LoginFailureCB(PlayFabError playFabError)
		{
			SyncOnlineClientState();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3E")]
		[Cpp2IlInjected.Address(RVA = "0x85D580", Offset = "0x85BF80", VA = "0x18085D580")]
		[AsyncStateMachine(typeof(_003CSyncOnlineClientStateAsync_003Ed__58))]
		private Task SyncOnlineClientStateAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3F")]
		[Cpp2IlInjected.Address(RVA = "0x85D680", Offset = "0x85C080", VA = "0x18085D680")]
		private void SyncOnlineClientState()
		{
			//IL_0090: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0156: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_0276: Expected O, but got I4
			//IL_0287: Expected O, but got I4
			//IL_0298: Expected O, but got I4
			//IL_02c2: Expected O, but got I4
			//IL_02d5: Expected O, but got I4
			//IL_035e: Expected O, but got I4
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			Meta.Online.Client client = default(Meta.Online.Client);
			while (true)
			{
				int num = 0;
				OnlineClient _003COnlineClient_003Ek__BackingField = MetaClient.OnlineClient;
				int error = 0;
				_003COnlineClient_003Ek__BackingField.LogOnlineStatus("StartMenuLinkAccount.SyncOnlineClientState", (byte)error != 0);
				int num2 = 0;
				if (!MetaClient.OnlineClient.IsInternetOn)
				{
					break;
				}
				int num3 = 0;
				bool isLoggedInWithAllServices = MetaClient.OnlineClient.IsLoggedInWithAllServices;
				int num4 = 0;
				bool hasGameloftID = MetaClient.CredentialProvider.HasGameloftID;
				int num5 = 0;
				if (isLoggedInWithAllServices)
				{
					int num6 = 0;
					LoginResult _003CloginResult_003Ek__BackingField = MetaClient.OnlineClient.ClientSession.loginResult;
					if (_003CloginResult_003Ek__BackingField != null)
					{
						string gameloftIDLink = _003CloginResult_003Ek__BackingField.GetGameloftIDLink();
					}
				}
				bool flag = string.IsNullOrEmpty((string)num5);
				if (!hasGameloftID)
				{
				}
				int num7 = 0;
				string rememberGameloftIDLink = MetaClient.CredentialProvider.RememberGameloftIDLink;
				bool flag2 = string.Equals((string)num5, rememberGameloftIDLink);
				if (!flag2 && !hasGameloftID)
				{
					int num8 = 0;
					bool hasGameloftIDCredentials = MetaClient.CredentialProvider.HasGameloftIDCredentials;
				}
				int num9 = 0;
				PlayFabError lastLoginPlayFabError = MetaClient.OnlineClient.LastLoginPlayFabError;
				if (!hasGameloftID || lastLoginPlayFabError != null)
				{
				}
				object[] array = new object[6];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (num5 != 0 && array == null)
				{
					continue;
				}
				array[1] = num5;
				if (array != null && array == null)
				{
					continue;
				}
				array[2] = array;
				if (flag3 && !flag3)
				{
					continue;
				}
				array[3] = flag3;
				if (flag4 && !flag4)
				{
					continue;
				}
				array[4] = flag4;
				if (lastLoginPlayFabError != null && !flag4)
				{
					continue;
				}
				array[5] = lastLoginPlayFabError;
				Debug.Log(string.Format("StartMenuLinkAccount.SyncOnlineClientState isGameloftIDRemembered={0} gameloftIdSubject={1} isGameloftIdLinked={2} isGameloftIdCodeRequired={3} isEmailLoginError={4} lastLoginPlayFabError={5}", array));
				if (num5 == 0)
				{
					if (!flag2)
					{
						if (num5 == 0)
						{
							if (_state == State.Unlinked)
							{
								goto IL_0231;
							}
							UpdateVisuals();
						}
						if (_state == State.ConfirmCreateAccount)
						{
							goto IL_0231;
						}
						UpdateVisuals();
					}
					if (_state == State.Linked)
					{
						goto IL_01dd;
					}
				}
				if (_state != State.LoginFailure)
				{
					UpdateVisuals();
				}
				goto IL_01dd;
				IL_01dd:
				if (flag2)
				{
					TMP_Text connectedEmailText = _connectedEmailText;
					int num10 = 0;
					string text = (connectedEmailText.text = MetaClient.CredentialProvider.RememberGameloftIDEmail);
				}
				if (num5 != 0)
				{
					TMP_InputField loginFailureEmailTextInput = _loginFailureEmailTextInput;
					int num11 = 0;
					string text2 = (loginFailureEmailTextInput.text = MetaClient.CredentialProvider.RememberGameloftIDEmail);
				}
				goto IL_0231;
				IL_0231:
				int num12 = 0;
				AuthManager authentificationManager = MetaClient.OnlineClient.AuthentificationManager;
				AuthManager.AuthentificatorBase _003CNativeAuth_003Ek__BackingField = authentificationManager.NativeAuth;
				if (_003CNativeAuth_003Ek__BackingField != null)
				{
					string _003CAuthNameStringID_003Ek__BackingField = _003CNativeAuth_003Ek__BackingField.AuthNameStringID;
					if (authentificationManager == null)
					{
						string _003CAuthNameStringID_003Ek__BackingField2 = _003CNativeAuth_003Ek__BackingField.AuthNameStringID;
						int num13 = 0;
						string text3 = LocalizationManager.FromStringID(_003CAuthNameStringID_003Ek__BackingField2, (IResolver)num13);
						int num14 = 0;
						string text4 = LocalizationManager.FromStringID("online.acclink_status_ok", (IResolver)num14);
						int num15 = 0;
						string text5 = LocalizationManager.FromStringID("online.acclink_status_error", (IResolver)num15);
						bool flag5 = _003CNativeAuth_003Ek__BackingField.IsLoggedIn();
						string text6 = text3 + " " + text4;
					}
				}
				int num16 = 0;
				string text7 = LocalizationManager.FromStringID("online.acclink_nativeauth_unsupported", (IResolver)num16);
				int num17 = 0;
				if (PlatformUtils.GetRuntimePlatform() == RuntimePlatform.OSXPlayer && Exception.IsImmutableAgileException((Exception)0))
				{
					LocalStorage _003CLocalStorage_003Ek__BackingField = client.LocalStorage;
					if (((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Exists)
					{
						JToken value = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.OnlineInfo.PlayFabId;
						TokenStorage.Set("LastPlayfabId", value);
						int num18 = 0;
						bool flag6 = TokenStorage.Save();
					}
				}
				int num19 = 0;
				string playFabId = MetaClient.OnlineClient.PlayFabId;
				Debug.Log("Online User ID: " + playFabId + " Native Login Value: " + text7);
				State state = _state;
				Debug.Log($"StartMenuLinkAccount.SyncOnlineClientState now in CurrentState={state}");
				return;
			}
			int num20 = 0;
			if (_state != State.Offline)
			{
				UpdateVisuals();
			}
			while (_resetPasswordState == (ResetPasswordState)num20)
			{
			}
			_resetPasswordState = (ResetPasswordState)num20;
			UpdateVisuals();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D40")]
		[Cpp2IlInjected.Address(RVA = "0x85E3D0", Offset = "0x85CDD0", VA = "0x18085E3D0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_00f4
			GameObject offlinePanel = _offlinePanel;
			bool active = _state == State.Offline;
			offlinePanel.SetActive(active);
			GameObject unlinkedPanel = _unlinkedPanel;
			bool active2 = _state == State.Unlinked;
			unlinkedPanel.SetActive(active2);
			GameObject linkAccountConfirmCreationPanel = _linkAccountConfirmCreationPanel;
			bool active3 = _state == State.ConfirmCreateAccount;
			linkAccountConfirmCreationPanel.SetActive(active3);
			GameObject linkedPanel = _linkedPanel;
			bool active4 = _state == State.Linked;
			linkedPanel.SetActive(active4);
			GameObject loginFailurePanel = _loginFailurePanel;
			bool active5 = _state == State.LoginFailure;
			loginFailurePanel.SetActive(active5);
			GameObject linkAccountResetPasswordPanel = _linkAccountResetPasswordPanel;
			bool active6 = _resetPasswordState == ResetPasswordState.Step1;
			linkAccountResetPasswordPanel.SetActive(active6);
			GameObject linkAccountSetNewPasswordPanel = _linkAccountSetNewPasswordPanel;
			bool active7 = _resetPasswordState == ResetPasswordState.Step2;
			linkAccountSetNewPasswordPanel.SetActive(active7);
			GameObject gameObject = _closePasswordResetBtn.gameObject;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool active8 = !instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			gameObject.SetActive(active8);
			InitFocusNavigationFocusBasedOnCurrentTab();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D41")]
		[Cpp2IlInjected.Address(RVA = "0x85B7D0", Offset = "0x85A1D0", VA = "0x18085B7D0")]
		public void InitFocusNavigationFocusBasedOnCurrentTab()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D42")]
		[Cpp2IlInjected.Address(RVA = "0x85B6D0", Offset = "0x85A0D0", VA = "0x18085B6D0")]
		[AsyncStateMachine(typeof(_003CInitFocusNavigationFocusBasedOnCurrentTabTask_003Ed__62))]
		private Task InitFocusNavigationFocusBasedOnCurrentTabTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D43")]
		[Cpp2IlInjected.Address(RVA = "0x85C010", Offset = "0x85AA10", VA = "0x18085C010", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			InitFocusNavigationFocusBasedOnCurrentTab();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D44")]
		[Cpp2IlInjected.Address(RVA = "0x85C030", Offset = "0x85AA30", VA = "0x18085C030")]
		public void OnCreateAccountPressed()
		{
			//Discarded unreachable code: IL_001a
			TextButton createAccountBtn = _createAccountBtn;
			int num = ((createAccountBtn.IsHighlighted = false) ? 1 : 0);
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D45")]
		[Cpp2IlInjected.Address(RVA = "0x85C3C0", Offset = "0x85ADC0", VA = "0x18085C3C0")]
		public void OnLoginPressed()
		{
			//Discarded unreachable code: IL_001f
			TextButton loginAccountBtn = _loginAccountBtn;
			int num = ((loginAccountBtn.IsHighlighted = false) ? 1 : 0);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D46")]
		[Cpp2IlInjected.Address(RVA = "0x85C1A0", Offset = "0x85ABA0", VA = "0x18085C1A0")]
		public void OnLoginFailureLoginPressed()
		{
			//Discarded unreachable code: IL_001f
			TextButton loginFailureLoginBtn = _loginFailureLoginBtn;
			int num = ((loginFailureLoginBtn.IsHighlighted = false) ? 1 : 0);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D47")]
		[Cpp2IlInjected.Address(RVA = "0x85CA20", Offset = "0x85B420", VA = "0x18085CA20")]
		public void OnResetPasswordSendPressed()
		{
			//Discarded unreachable code: IL_0031, IL_0032
			TextButton sendPasswordBtn = _sendPasswordBtn;
			int num = ((sendPasswordBtn.IsHighlighted = false) ? 1 : 0);
			string text = _emailResetTextInput.m_Text;
			TextButton sendPasswordBtn2 = _sendPasswordBtn;
			ResetPasswordSend(sendPasswordBtn2, text).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D48")]
		[Cpp2IlInjected.Address(RVA = "0x85C310", Offset = "0x85AD10", VA = "0x18085C310")]
		public void OnLoginFailureResetPasswordSendPressed()
		{
			//Discarded unreachable code: IL_0031, IL_0032
			TextButton loginFailureResetPasswordBtn = _loginFailureResetPasswordBtn;
			int num = ((loginFailureResetPasswordBtn.IsHighlighted = false) ? 1 : 0);
			string text = _loginFailureEmailTextInput.m_Text;
			TextButton loginFailureResetPasswordBtn2 = _loginFailureResetPasswordBtn;
			ResetPasswordSend(loginFailureResetPasswordBtn2, text).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D49")]
		[Cpp2IlInjected.Address(RVA = "0x85CAD0", Offset = "0x85B4D0", VA = "0x18085CAD0")]
		private void OnResetPasswordTextChanged(string text)
		{
			//Discarded unreachable code: IL_00bc
			if (string.Equals(_emailResetTextInput.m_Text, "") && string.Equals(text, ""))
			{
				GameObject gameObject = _sendPasswordBtn.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_sendPasswordBtnDisabled.gameObject.SetActive(value: true);
				TextButton sendPasswordBtnDisabled = _sendPasswordBtnDisabled;
				int num = ((sendPasswordBtnDisabled.IsInteractable = false) ? 1 : 0);
				ButtonViewDefault componentInChildren = _sendPasswordBtnDisabled.gameObject.GetComponentInChildren<ButtonViewDefault>();
				componentInChildren.Background.SetColorRGBA(-1296645390);
				componentInChildren.Label.SetColorRGBA(1802801138);
			}
			else
			{
				_sendPasswordBtn.gameObject.SetActive(value: true);
				GameObject gameObject2 = _sendPasswordBtnDisabled.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4A")]
		[Cpp2IlInjected.Address(RVA = "0x85C8C0", Offset = "0x85B2C0", VA = "0x18085C8C0")]
		public void OnResetPasswordPressed()
		{
			//Discarded unreachable code: IL_00a1
			//IL_0024: Expected I4, but got I8
			int num = 0;
			bool hasGameloftIDCredentials = MetaClient.CredentialProvider.HasGameloftIDCredentials;
			if (_resetPasswordState != ResetPasswordState.Step1)
			{
				_resetPasswordState = ResetPasswordState.Step1;
				UpdateVisuals();
			}
			TMP_InputField emailResetTextInput = _emailResetTextInput;
			if (!hasGameloftIDCredentials)
			{
			}
			int num2 = 0;
			string text = (emailResetTextInput.text = MetaClient.CredentialProvider.RememberGameloftIDEmail);
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			FocusNavigation focusNavigation = _focusNavigation;
			if (!flag)
			{
			}
			FocusNavigationElement component = _sendPasswordBtn.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
			string text2 = _emailResetTextInput.m_Text;
			OnResetPasswordTextChanged(text2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4B")]
		[Cpp2IlInjected.Address(RVA = "0x85C8A0", Offset = "0x85B2A0", VA = "0x18085C8A0")]
		public void OnResetPasswordBackPressed()
		{
			//IL_0012: Expected I4, but got I8
			if (_resetPasswordState != 0)
			{
				_resetPasswordState = ResetPasswordState.Hidden;
				UpdateVisuals();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4C")]
		[Cpp2IlInjected.Address(RVA = "0x85B410", Offset = "0x859E10", VA = "0x18085B410")]
		[AsyncStateMachine(typeof(_003CCreateAccount_003Ed__72))]
		private Task CreateAccount()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4D")]
		[Cpp2IlInjected.Address(RVA = "0x85C530", Offset = "0x85AF30", VA = "0x18085C530")]
		public void OnLoginWithVerificationCodePressed()
		{
			//Discarded unreachable code: IL_0015
			TextButton loginWithCodeBtn = _loginWithCodeBtn;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4E")]
		[Cpp2IlInjected.Address(RVA = "0x85C6A0", Offset = "0x85B0A0", VA = "0x18085C6A0")]
		public void OnLogoutPressed()
		{
			//Discarded unreachable code: IL_0021, IL_0022
			TextButton cancelAccountCreationBtn = _cancelAccountCreationBtn;
			CancellationToken token = _cancellationTokenSource.Token;
			Logout(needRelogin: true, token).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4F")]
		[Cpp2IlInjected.Address(RVA = "0x85BD80", Offset = "0x85A780", VA = "0x18085BD80")]
		public void OnAccountConfirmationCancelledPressed()
		{
			//Discarded unreachable code: IL_0023, IL_0024
			TextButton cancelAccountCreationBtn = _cancelAccountCreationBtn;
			CancellationToken token = _cancellationTokenSource.Token;
			int needRelogin = 0;
			Logout((byte)needRelogin != 0, token).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D50")]
		[Cpp2IlInjected.Address(RVA = "0x85B510", Offset = "0x859F10", VA = "0x18085B510")]
		[AsyncStateMachine(typeof(_003CForceProfileAccountInfoAndLayoutRefresh_003Ed__76))]
		private Task ForceProfileAccountInfoAndLayoutRefresh()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D51")]
		[Cpp2IlInjected.Address(RVA = "0x85BC50", Offset = "0x85A650", VA = "0x18085BC50")]
		[AsyncStateMachine(typeof(_003CLogout_003Ed__77))]
		private Task Logout(bool needRelogin, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D52")]
		[Cpp2IlInjected.Address(RVA = "0x85BA50", Offset = "0x85A450", VA = "0x18085BA50")]
		[AsyncStateMachine(typeof(_003CLoginWithVerificationCode_003Ed__78))]
		private Task LoginWithVerificationCode()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D53")]
		[Cpp2IlInjected.Address(RVA = "0x85BB50", Offset = "0x85A550", VA = "0x18085BB50")]
		[AsyncStateMachine(typeof(_003CLogin_003Ed__79))]
		private Task Login()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D54")]
		[Cpp2IlInjected.Address(RVA = "0x85D040", Offset = "0x85BA40", VA = "0x18085D040")]
		[AsyncStateMachine(typeof(_003CRefreshPasswordAndLogin_003Ed__80))]
		private Task RefreshPasswordAndLogin()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D55")]
		[Cpp2IlInjected.Address(RVA = "0x85D340", Offset = "0x85BD40", VA = "0x18085D340")]
		[AsyncStateMachine(typeof(_003CResetPasswordSend_003Ed__81))]
		private Task ResetPasswordSend(TextButton resetBtn, string email)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D56")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA0", Offset = "0x85B6A0", VA = "0x18085CCA0")]
		public void OnSetNewPasswordPressed()
		{
			//Discarded unreachable code: IL_0010
			TextButton setNewPasswordBtn = _setNewPasswordBtn;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D57")]
		[Cpp2IlInjected.Address(RVA = "0x85D480", Offset = "0x85BE80", VA = "0x18085D480")]
		[AsyncStateMachine(typeof(_003CSetNewPassword_003Ed__83))]
		private Task SetNewPassword()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D58")]
		[Cpp2IlInjected.Address(RVA = "0x85CE00", Offset = "0x85B800", VA = "0x18085CE00")]
		public void OnTestConnectionPressed()
		{
			//Discarded unreachable code: IL_001e
			TextButton testConnectionButton = _testConnectionButton;
			int num = 0;
			DebugSettings.Settings.offline_ = false;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D59")]
		[Cpp2IlInjected.Address(RVA = "0x85CFA0", Offset = "0x85B9A0", VA = "0x18085CFA0")]
		public void OnTextEditFinished()
		{
			//Discarded unreachable code: IL_0022
			//IL_0020: Expected O, but got I4
			int num = 0;
			if (!EventSystem.current.m_SelectionGuard)
			{
				int num2 = 0;
				EventSystem current = EventSystem.current;
				int num3 = 0;
				current.SetSelectedGameObject((GameObject)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5A")]
		[Cpp2IlInjected.Address(RVA = "0x85E0D0", Offset = "0x85CAD0", VA = "0x18085E0D0")]
		[AsyncStateMachine(typeof(_003CTestConnection_003Ed__86))]
		private Task TestConnection()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5B")]
		[Cpp2IlInjected.Address(RVA = "0x85BE20", Offset = "0x85A820", VA = "0x18085BE20")]
		private void OnClose()
		{
			//Discarded unreachable code: IL_00c7
			//IL_0069: Expected O, but got I4
			//IL_00b0: Expected I4, but got I8
			//IL_00c0: Expected I4, but got I8
			if (_resetPasswordState == ResetPasswordState.Hidden)
			{
				if (_state != State.ConfirmCreateAccount)
				{
					int num = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
						if (1L == 0L)
						{
						}
						FocusNavigationElement component = StartMenu.Instance._selectedTab.GetComponent<FocusNavigationElement>();
						focusNavigation.SetFocus(component);
					}
					StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
					int num2 = 0;
					_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num2);
					_cancellationTokenSource.Cancel();
					AK.Wwise.Event @event = closeSFX;
					if (@event != null)
					{
						GameObject gameObject = base.gameObject;
						uint num3 = @event.Post(gameObject);
					}
					int num4 = 0;
					UiRoot.Instance._popupStack.Pop();
				}
				else
				{
					_state = State.Unlinked;
					UpdateVisuals();
				}
			}
			else
			{
				_resetPasswordState = ResetPasswordState.Hidden;
				UpdateVisuals();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5C")]
		[Cpp2IlInjected.Address(RVA = "0x85B610", Offset = "0x85A010", VA = "0x18085B610", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			Debug.Log(string.Format("HandleRedirection redirectionType={0}", "HandleRedirection redirectionType={0}"));
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				OnClose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5D")]
		[Cpp2IlInjected.Address(RVA = "0x85E530", Offset = "0x85CF30", VA = "0x18085E530")]
		public StartMenuLinkAccount()
		{
		}
	}
}
