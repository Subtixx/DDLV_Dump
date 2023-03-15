using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003DF")]
	[RequiredAllNotNull]
	public class DebugAccountLinkingMenu : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001312")]
		[SerializeField]
		private Button _saveToCloudBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001313")]
		[SerializeField]
		private TMP_Text _cloudSaveStatusText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001314")]
		[SerializeField]
		private Button _openPlayfabGMBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001315")]
		[SerializeField]
		private TMP_Text _fullInfoText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001316")]
		[SerializeField]
		private InputPlayerName _inputPlayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001317")]
		[SerializeField]
		private ButtonTmPro _acceptPlayerNameBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001318")]
		private MenuNavigation _parentMenuNav;

		[Cpp2IlInjected.Token(Token = "0x17000417")]
		private AccountLinkingManager AccLinkMgr
		{
			[Cpp2IlInjected.Token(Token = "0x60018A9")]
			[Cpp2IlInjected.Address(RVA = "0x85E5A0", Offset = "0x85CFA0", VA = "0x18085E5A0")]
			get
			{
				int num = 0;
				return AccountLinkingManager.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		private Profile clientProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60018AA")]
			[Cpp2IlInjected.Address(RVA = "0x11290A0", Offset = "0x1127AA0", VA = "0x1811290A0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
					if ((object)client != null)
					{
						return client.Profile;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		private Profile serverProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60018AB")]
			[Cpp2IlInjected.Address(RVA = "0x1129160", Offset = "0x1127B60", VA = "0x181129160")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						return metaClient.LocalProfileHolder.profile;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018AC")]
		[Cpp2IlInjected.Address(RVA = "0x1128100", Offset = "0x1126B00", VA = "0x181128100")]
		private void Awake()
		{
			//Discarded unreachable code: IL_006a
			Button.ButtonClickedEvent onClick = _saveToCloudBtn.m_OnClick;
			UnityAction call = SaveToCloudClick;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _openPlayfabGMBtn.m_OnClick;
			UnityAction call2 = OpenPlayfabGMClick;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _acceptPlayerNameBtn.ButtonComponent.m_OnClick;
			UnityAction call3 = AcceptPlayerNameClick;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60018AD")]
		[Cpp2IlInjected.Address(RVA = "0x1128AC0", Offset = "0x11274C0", VA = "0x181128AC0")]
		public void SetFocus(MenuNavigation menuNav)
		{
			//Discarded unreachable code: IL_002b
			_parentMenuNav = menuNav;
			MenuNavigation parentMenuNav = _parentMenuNav;
			Button saveToCloudBtn = _saveToCloudBtn;
			FocusNavigation focusNavigation = parentMenuNav.FocusNavigation;
			FocusNavigationElement component = saveToCloudBtn.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60018AE")]
		[Cpp2IlInjected.Address(RVA = "0x1128100", Offset = "0x1126B00", VA = "0x181128100")]
		private void BindLogic()
		{
			//Discarded unreachable code: IL_006a
			Button.ButtonClickedEvent onClick = _saveToCloudBtn.m_OnClick;
			UnityAction call = SaveToCloudClick;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _openPlayfabGMBtn.m_OnClick;
			UnityAction call2 = OpenPlayfabGMClick;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _acceptPlayerNameBtn.ButtonComponent.m_OnClick;
			UnityAction call3 = AcceptPlayerNameClick;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60018AF")]
		[Cpp2IlInjected.Address(RVA = "0x1128D60", Offset = "0x1127760", VA = "0x181128D60")]
		private void UpdateSaveStatus()
		{
			//Discarded unreachable code: IL_008c
			//IL_0080: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			if (serverProfile == null)
			{
				_cloudSaveStatusText.text = "";
				return;
			}
			if ((long)serverProfile.gameInfo_.lastUploadTime_ != 0)
			{
				DateTime dateTime = serverProfile.gameInfo_.modified_.ToDateTime();
				DateTime dateTime2 = serverProfile.gameInfo_.lastUploadTime_.ToDateTime();
				TimeSpan timeSpan = dateTime - dateTime2;
				TMP_Text cloudSaveStatusText = _cloudSaveStatusText;
				int num = default(int);
				if (num == 0)
				{
				}
				int num2 = default(int);
				int num3 = default(int);
				string text2 = (cloudSaveStatusText.text = $"Desync by {num2} minutes, {num3} seconds.");
				return;
			}
			TMP_Text tMP_Text = default(TMP_Text);
			Color color = ((UnityEngine.UI.Graphic)tMP_Text).m_Color;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018B0")]
		[Cpp2IlInjected.Address(RVA = "0x1128BB0", Offset = "0x11275B0", VA = "0x181128BB0")]
		private void UpdateFullInfos()
		{
			//Discarded unreachable code: IL_001c
			TMP_Text fullInfoText = _fullInfoText;
			int num = 0;
			string debugInfos = AccountLinkingManager.Instance.GetDebugInfos();
			string debugName = ((UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation)fullInfoText).DebugName;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B1")]
		[Cpp2IlInjected.Address(RVA = "0x1128B50", Offset = "0x1127550", VA = "0x181128B50")]
		private void UpdateAllInfos()
		{
			//Discarded unreachable code: IL_0022
			UpdateSaveStatus();
			TMP_Text fullInfoText = _fullInfoText;
			int num = 0;
			string debugInfos = AccountLinkingManager.Instance.GetDebugInfos();
			string debugName = ((UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation)fullInfoText).DebugName;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B2")]
		[Cpp2IlInjected.Address(RVA = "0x1128590", Offset = "0x1126F90", VA = "0x181128590")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0111
			//IL_0033: Expected O, but got I4
			UpdateSaveStatus();
			TMP_Text fullInfoText = _fullInfoText;
			int num = 0;
			string text = (fullInfoText.text = AccountLinkingManager.Instance.GetDebugInfos());
			InputPlayerName inputPlayerName = _inputPlayerName;
			int num2 = 0;
			if (inputPlayerName != (UnityEngine.Object)num2)
			{
				InputPlayerName inputPlayerName2 = _inputPlayerName;
				ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
				if (player_ == null || player_.name_ == null)
				{
				}
				inputPlayerName2.SetName("");
				InputPlayerName inputPlayerName3 = _inputPlayerName;
				int enable = 0;
				inputPlayerName3.EnableInput((byte)enable != 0);
				InputPlayerName inputPlayerName4 = _inputPlayerName;
				InputPlayerName.NameChanged value = OnNameChanged;
				inputPlayerName4.OnNameChanged += value;
				int _003C_003E1__state = default(int);
				_003CUpdateNameChangeAvailability_003Ed__25 _003CUpdateNameChangeAvailability_003Ed__ = new _003CUpdateNameChangeAvailability_003Ed__25(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CUpdateNameChangeAvailability_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CUpdateNameChangeAvailability_003Ed__);
			}
			ButtonTmPro acceptPlayerNameBtn = _acceptPlayerNameBtn;
			int num3 = ((acceptPlayerNameBtn.IsActive = false) ? 1 : 0);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.OnlineConnectionChanged value2 = UpdateNameChangeStatus;
				metaOnlineClient.OnOnlineConnectionChanged += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018B3")]
		[Cpp2IlInjected.Address(RVA = "0x1128350", Offset = "0x1126D50", VA = "0x181128350")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0068
			//IL_0010: Expected O, but got I4
			InputPlayerName inputPlayerName = _inputPlayerName;
			int num = 0;
			if (inputPlayerName != (UnityEngine.Object)num)
			{
				InputPlayerName inputPlayerName2 = _inputPlayerName;
				InputPlayerName.NameChanged value = OnNameChanged;
				inputPlayerName2.OnNameChanged -= value;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.OnlineConnectionChanged value2 = UpdateNameChangeStatus;
				metaOnlineClient.OnOnlineConnectionChanged -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018B4")]
		[Cpp2IlInjected.Address(RVA = "0x11289F0", Offset = "0x11273F0", VA = "0x1811289F0")]
		[AsyncStateMachine(typeof(_003CSaveToCloudClick_003Ed__21))]
		private void SaveToCloudClick()
		{
			int num = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B5")]
		[Cpp2IlInjected.Address(RVA = "0x11289C0", Offset = "0x11273C0", VA = "0x1811289C0")]
		private void OpenPlayfabGMClick()
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			AccountLinkingManager.Instance.DebugOpenPlayFabGM();
		}

		[Cpp2IlInjected.Token(Token = "0x60018B6")]
		[Cpp2IlInjected.Address(RVA = "0x1128030", Offset = "0x1126A30", VA = "0x181128030")]
		[AsyncStateMachine(typeof(_003CAcceptPlayerNameClick_003Ed__23))]
		private void AcceptPlayerNameClick()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B7")]
		[Cpp2IlInjected.Address(RVA = "0x1128C70", Offset = "0x1127670", VA = "0x181128C70")]
		[AsyncStateMachine(typeof(_003CUpdateNameChangeStatus_003Ed__24))]
		private void UpdateNameChangeStatus(Profile profile, bool isLoggedIn, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B8")]
		[Cpp2IlInjected.Address(RVA = "0x1128C00", Offset = "0x1127600", VA = "0x181128C00")]
		[IteratorStateMachine(typeof(_003CUpdateNameChangeAvailability_003Ed__25))]
		private IEnumerator UpdateNameChangeAvailability()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateNameChangeAvailability_003Ed__25 _003CUpdateNameChangeAvailability_003Ed__ = new _003CUpdateNameChangeAvailability_003Ed__25(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateNameChangeAvailability_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018B9")]
		[Cpp2IlInjected.Address(RVA = "0x1128260", Offset = "0x1126C60", VA = "0x181128260")]
		[AsyncStateMachine(typeof(_003CCheckNameChangeAvailabilityAsync_003Ed__26))]
		private Task<bool> CheckNameChangeAvailabilityAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60018BA")]
		[Cpp2IlInjected.Address(RVA = "0x1128990", Offset = "0x1127390", VA = "0x181128990")]
		private void OnNameChanged(string newName, bool isValid)
		{
			//Discarded unreachable code: IL_000d
			_acceptPlayerNameBtn.IsActive = isValid;
		}

		[Cpp2IlInjected.Token(Token = "0x60018BB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugAccountLinkingMenu()
		{
		}
	}
}
