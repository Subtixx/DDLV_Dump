using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.InputSystem;
using Mdl.Online;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000618")]
	public class MailboxMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000619")]
		public class MailboxMenuParam : MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x60027F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public MailboxMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40021DD")]
		public GameObject _mailListView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40021DE")]
		public GameObject _mailContentView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40021DF")]
		[SerializeField]
		private ShortcutIndicator _backGamepad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40021E0")]
		[SerializeField]
		private ShortcutIndicator _backKeyboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40021E1")]
		[SerializeField]
		private GameObject _prefabMailItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40021E2")]
		[SerializeField]
		private MailDisplayManager _displayManagers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40021E3")]
		[SerializeField]
		private MailTabButton[] _tabBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40021E4")]
		private List<InboxMessage> _messageData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40021E5")]
		[SerializeField]
		private LoopVerticalScrollRect _listMailItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40021E6")]
		[SerializeField]
		private RectTransform _offlineWarningContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40021E7")]
		[SerializeField]
		private TextBase _offlineTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40021E8")]
		[SerializeField]
		private RectTransform _offlineWarningList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40021E9")]
		[SerializeField]
		private TextBase _offlineWarningMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40021EA")]
		[SerializeField]
		private BaseButton _btnConnect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40021EB")]
		[SerializeField]
		private BaseButton _btnConnectList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40021EC")]
		private MailItem _selectedMail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40021ED")]
		private MailboxObject _mailboxObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40021EE")]
		private bool _inputActionLBPJustPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40021EF")]
		private bool _inputActionRBJustPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40021F0")]
		private InputAction inputActionLBPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40021F1")]
		private InputAction inputActionRBPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40021F2")]
		private InputAction inputActionLBRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40021F3")]
		private InputAction inputActionRBRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40021F4")]
		private CancellationToken ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40021F5")]
		public bool _isDebug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40021F6")]
		public int _numberDebugMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40021F7")]
		public string _dummyDescription;

		[Cpp2IlInjected.Token(Token = "0x17000602")]
		public LoopVerticalScrollRect ListMailItems
		{
			[Cpp2IlInjected.Token(Token = "0x60027D3")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			get
			{
				return _listMailItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027D4")]
		[Cpp2IlInjected.Address(RVA = "0xFA1AA0", Offset = "0xFA04A0", VA = "0x180FA1AA0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_00ae
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listMailItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnMailItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call = OnConnectClicked;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnConnectList.ButtonComponent.m_OnClick;
			UnityAction call2 = OnConnectClicked;
			onClick2.AddListener(call2);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027D5")]
		[Cpp2IlInjected.Address(RVA = "0xFA24C0", Offset = "0xFA0EC0", VA = "0x180FA24C0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_00ae
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listMailItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnMailItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call = OnConnectClicked;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnConnectList.ButtonComponent.m_OnClick;
			UnityAction call2 = OnConnectClicked;
			onClick2.RemoveListener(call2);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027D6")]
		[Cpp2IlInjected.Address(RVA = "0xFA12C0", Offset = "0xF9FCC0", VA = "0x180FA12C0")]
		private void RefreshConnectionStateDisplay(OnlineClient.OnlineStatus currentOnlineStatus)
		{
			//Discarded unreachable code: IL_0175
			//IL_0017: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_006f: Expected F4, but got I4
			//IL_00e6: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			MailItem _003CDisplayedMessage_003Ek__BackingField = _displayManagers.DisplayedMessage;
			int num = 0;
			if (_003CDisplayedMessage_003Ek__BackingField == (UnityEngine.Object)num)
			{
			}
			bool isOnline = _displayManagers.DisplayedMessage.InboxMessageData.IsOnline;
			CanvasGroup component = _displayManagers.GetComponent<CanvasGroup>();
			int num2 = 0;
			bool flag = default(bool);
			if (component != (UnityEngine.Object)num2)
			{
				CanvasGroup component2 = _displayManagers.GetComponent<CanvasGroup>();
				if (!isOnline)
				{
				}
				if (flag)
				{
				}
				int num3 = 0;
				component2.alpha = num3;
				_displayManagers.GetComponent<CanvasGroup>().interactable = true;
			}
			RectTransform offlineWarningContainer = _offlineWarningContainer;
			bool active = !flag;
			offlineWarningContainer.gameObject.SetActive(isOnline);
			_offlineWarningList.gameObject.SetActive(active);
			string onlineStatusSourceNameForLoc = SystemRoot.Instance.MetaOnlineClient.GetOnlineStatusSourceNameForLoc();
			TextBase offlineTitle = _offlineTitle;
			string stringID = "menu.starpath_offline_" + onlineStatusSourceNameForLoc + "_title";
			int num4 = 0;
			string text2 = (offlineTitle.Text = LocalizationManager.FromStringID(stringID, (IResolver)num4));
			TextBase offlineWarningMessage = _offlineWarningMessage;
			string stringID2 = "menu.mailbox_offline_" + onlineStatusSourceNameForLoc;
			int num5 = 0;
			string text4 = (offlineWarningMessage.Text = LocalizationManager.FromStringID(stringID2, (IResolver)num5));
			FocusNavigationElement component3 = _btnConnect.GetComponent<FocusNavigationElement>();
			bool flag2 = (component3.IgnoreThis = !_offlineWarningContainer.gameObject.activeInHierarchy);
			FocusNavigationElement component4 = _btnConnectList.GetComponent<FocusNavigationElement>();
			bool flag3 = (component4.IgnoreThis = !_offlineWarningList.gameObject.activeInHierarchy);
		}

		[Cpp2IlInjected.Token(Token = "0x60027D7")]
		[Cpp2IlInjected.Address(RVA = "0xFA04E0", Offset = "0xF9EEE0", VA = "0x180FA04E0")]
		private void OnConnectionModeChanged(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0023
			RefreshConnectionStateDisplay(currentOnlineStatus);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027D8")]
		[Cpp2IlInjected.Address(RVA = "0xFA0390", Offset = "0xF9ED90", VA = "0x180FA0390")]
		private void OnConnectClicked()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60027D9")]
		[Cpp2IlInjected.Address(RVA = "0xFA1700", Offset = "0xFA0100", VA = "0x180FA1700")]
		[AsyncStateMachine(typeof(_003CRefreshInboxMessagesList_003Ed__35))]
		private Task RefreshInboxMessagesList(bool forceOnlineRefresh)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027DA")]
		[Cpp2IlInjected.Address(RVA = "0xFA1820", Offset = "0xFA0220", VA = "0x180FA1820")]
		private void RefreshNewsRedDot()
		{
			//Discarded unreachable code: IL_0029
			GameObject gameObject = _tabBtn[0]._redDot.gameObject;
			bool active = !IsAllMailClaimed();
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60027DB")]
		[Cpp2IlInjected.Address(RVA = "0xFA10F0", Offset = "0xF9FAF0", VA = "0x180FA10F0")]
		private void PopulateMailItem()
		{
			//Discarded unreachable code: IL_0054
			if (!_isDebug)
			{
				List<InboxMessage> messageData = _messageData;
				if (messageData != null)
				{
					LoopVerticalScrollRect listMailItems = _listMailItems;
					int num = (listMailItems.totalCount = ((List<>)(object)messageData)._size);
					LoopVerticalScrollRect listMailItems2 = _listMailItems;
					int offset = 0;
					listMailItems2.RefillCells(offset);
					RefreshScrollbarVisibility();
				}
				else
				{
					Debug.Log("[Mailbox Debug] No Message Data");
				}
			}
			else
			{
				GenerateFakeMessage();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027DC")]
		[Cpp2IlInjected.Address(RVA = "0xF9F9E0", Offset = "0xF9E3E0", VA = "0x180F9F9E0")]
		private void GenerateFakeMessage()
		{
			//Discarded unreachable code: IL_0042, IL_004f, IL_00e9
			//IL_007b: Expected I4, but got I8
			//IL_0089: Expected I4, but got I8
			if (_numberDebugMessage > 0)
			{
				InboxMessage inboxMessage = new InboxMessage();
				string dummyDescription = _dummyDescription;
				string text = default(string);
				string text3 = (inboxMessage.Message = "Message number " + text + dummyDescription);
				ulong num = default(ulong);
				if ((long)num > 0L)
				{
					Dictionary<int, int> dictionary = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
				if ((long)num > 2L)
				{
					List<InboxItemReward> list = (List<InboxItemReward>)(object)new List<T>();
					InboxItemReward inboxItemReward = new InboxItemReward();
					inboxItemReward.id_ = 80000000;
					num++;
					inboxItemReward.amount_ = (int)num;
					((List<T>)(object)list).Add((T)inboxItemReward);
					inboxMessage.AddRewardAttachment((List<>)(object)list);
				}
				((List<T>)(object)_messageData).Add((T)inboxMessage);
				num++;
			}
			List<InboxMessage> messageData = _messageData;
			LoopVerticalScrollRect listMailItems = _listMailItems;
			int num2 = (listMailItems.totalCount = ((List<>)(object)messageData)._size);
			LoopVerticalScrollRect listMailItems2 = _listMailItems;
			int offset = 0;
			listMailItems2.RefillCells(offset);
			RefreshScrollbarVisibility();
		}

		[Cpp2IlInjected.Token(Token = "0x60027DD")]
		[Cpp2IlInjected.Address(RVA = "0xFA1DC0", Offset = "0xFA07C0", VA = "0x180FA1DC0")]
		public void SelectTab(MailItem item)
		{
			//Discarded unreachable code: IL_0061
			//IL_0020: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				if (flag3)
				{
					int num = 0;
				}
				_selectedMail = item;
			}
			int num2 = 0;
			if (item != (UnityEngine.Object)num2)
			{
				if (!_displayManagers.gameObject.activeInHierarchy)
				{
					_displayManagers.gameObject.SetActive(value: true);
				}
				MailDisplayManager displayManagers = _displayManagers;
				OnlineClient onlineClient = default(OnlineClient);
				OnlineClient.OnlineStatus _003CCurrentOnlineStatus_003Ek__BackingField = onlineClient.CurrentOnlineStatus;
				RefreshConnectionStateDisplay(_003CCurrentOnlineStatus_003Ek__BackingField);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027DE")]
		[Cpp2IlInjected.Address(RVA = "0xFA11C0", Offset = "0xF9FBC0", VA = "0x180FA11C0")]
		[AsyncStateMachine(typeof(_003CReadMessage_003Ed__40))]
		public Task ReadMessage()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027DF")]
		[Cpp2IlInjected.Address(RVA = "0xFA00B0", Offset = "0xF9EAB0", VA = "0x180FA00B0")]
		private bool IsAllMailRead()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Mdl.Online.Client client = SystemRoot.Instance.Client;
			if ((object)client != null)
			{
				GameObject gameObject = client.gameObject;
				if ((object)gameObject != null)
				{
					OnlineProfileComponent component = gameObject.GetComponent<OnlineProfileComponent>();
				}
			}
			int num3 = 0;
			if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
			{
				Inbox inbox = default(Inbox);
				List<InboxMessage> list = (List<InboxMessage>)(object)Enumerable.ToList<InboxMessage>((IEnumerable<>)(object)inbox.inboxMessages_);
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (flag2)
					{
					}
					num2++;
				}
				bool result = default(bool);
				if (num2 + 1 != 0)
				{
					return result;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60027E0")]
		[Cpp2IlInjected.Address(RVA = "0xF9FDD0", Offset = "0xF9E7D0", VA = "0x180F9FDD0")]
		private bool IsAllMailClaimed()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Mdl.Online.Client client = SystemRoot.Instance.Client;
			if ((object)client != null)
			{
				GameObject gameObject = client.gameObject;
				if ((object)gameObject != null)
				{
					OnlineProfileComponent component = gameObject.GetComponent<OnlineProfileComponent>();
				}
			}
			int num3 = 0;
			if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
			{
				Inbox inbox = default(Inbox);
				List<InboxMessage> list = (List<InboxMessage>)(object)Enumerable.ToList<InboxMessage>((IEnumerable<>)(object)inbox.inboxMessages_);
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (flag2)
					{
					}
					num2++;
				}
				bool result = default(bool);
				if (num2 + 1 != 0)
				{
					return result;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60027E1")]
		[Cpp2IlInjected.Address(RVA = "0xFA0E00", Offset = "0xF9F800", VA = "0x180FA0E00", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//IL_0065: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			base.OnPush(stack, param);
			MailboxObject mailboxObject = (_mailboxObject = UnityEngine.Object.FindObjectOfType<MailboxObject>());
			_tabBtn[0].IsSelected = true;
			GameObject gameObject = _displayManagers.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_displayManagers._rewardContainer.gameObject.SetActive(value: true);
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num = default(int);
			InputActionBool inputActionBool = new InputActionBool("[LB]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			inputActionLBPress = inputActionBool;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("[LB]", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionLBRelease = inputActionBool2;
			InputTriggerPressed trigger3 = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("[RB]", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionRBPress = inputActionBool3;
			InputTriggerReleased trigger4 = new InputTriggerReleased();
			int num5 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("[RB]", trigger4, (InputProvider)num5);
			num5 = 0;
			inputActionRBRelease = inputActionBool4;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027E2")]
		[Cpp2IlInjected.Address(RVA = "0xCABD40", Offset = "0xCAA740", VA = "0x180CABD40", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60027E3")]
		[Cpp2IlInjected.Address(RVA = "0xFA0790", Offset = "0xF9F190", VA = "0x180FA0790", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0093
			base.OnFocusIn();
			OnlineClient.OnlineStatus _003CCurrentOnlineStatus_003Ek__BackingField = SystemRoot.Instance.MetaOnlineClient.CurrentOnlineStatus;
			RefreshConnectionStateDisplay(_003CCurrentOnlineStatus_003Ek__BackingField);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			if (SystemRoot.Instance.MetaOnlineClient.IsFullOnline)
			{
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				return;
			}
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			bool flag = instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0);
			if (!flag)
			{
				while (!flag)
				{
				}
				int num4 = 0;
				Transform transform = default(Transform);
				MailItem component = transform.GetComponent<MailItem>();
				component.IsSelected = true;
				component.OnDeHighlightedHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027E4")]
		[Cpp2IlInjected.Address(RVA = "0xFA1FE0", Offset = "0xFA09E0", VA = "0x180FA1FE0")]
		private void SetDefaultFocus()
		{
			//Discarded unreachable code: IL_0053
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (_messageData != null)
				{
					RectTransform content = ((LoopScrollRect)_listMailItems).m_Content;
					int index = 0;
					MailItem component = content.GetChild(index).GetComponent<MailItem>();
					component.IsSelected = true;
					component.OnDeHighlightedHandler();
				}
			}
			else
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027E5")]
		[Cpp2IlInjected.Address(RVA = "0xFA0B00", Offset = "0xF9F500", VA = "0x180FA0B00")]
		private void OnMailItemDataHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60027E6")]
		[Cpp2IlInjected.Address(RVA = "0xFA0D20", Offset = "0xF9F720", VA = "0x180FA0D20", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0035
			if (IsAllMailRead())
			{
				MailboxObject mailboxObject = _mailboxObject;
				CancellationTokenSource infoGizmoCTS = mailboxObject.infoGizmoCTS;
				mailboxObject.hasMarker = false;
				if (infoGizmoCTS != null)
				{
					infoGizmoCTS.Cancel();
					infoGizmoCTS.Dispose();
				}
			}
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x60027E7")]
		[Cpp2IlInjected.Address(RVA = "0xF9FCC0", Offset = "0xF9E6C0", VA = "0x180F9FCC0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			switch (redirectionType)
			{
			case RedirectionType.GameTabLeft:
				Debug.Log("LEFT");
				break;
			case RedirectionType.GameTabRight:
				Debug.Log("RIGHT");
				break;
			case RedirectionType.MenuNavGoBackward:
			case RedirectionType.MainMenuGoToAchievement:
			case RedirectionType.GamePopCurrentMenu:
			{
				bool isStaticMenu = ((IMenu)this).IsStaticMenu;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027E8")]
		[Cpp2IlInjected.Address(RVA = "0xFA18A0", Offset = "0xFA02A0", VA = "0x180FA18A0")]
		private void RefreshScrollbarVisibility()
		{
			//Discarded unreachable code: IL_0070
			//IL_0022: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			Scrollbar verticalScrollbar = ((LoopScrollRect)_listMailItems).m_VerticalScrollbar;
			if ((object)verticalScrollbar != null)
			{
				CanvasGroup component = verticalScrollbar.GetComponent<CanvasGroup>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				((LoopScrollRect)_listMailItems).m_Content.RebuildLayout();
				RectTransform content = ((LoopScrollRect)_listMailItems).m_Content;
				RectTransform viewport = ((LoopScrollRect)_listMailItems).m_Viewport;
				int num3 = 0;
				RectTransform content2 = ((LoopScrollRect)_listMailItems).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_listMailItems).m_Viewport;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027E9")]
		[Cpp2IlInjected.Address(RVA = "0xFA0CC0", Offset = "0xF9F6C0", VA = "0x180FA0CC0")]
		private void OnNextTab()
		{
			Debug.Log("RIGHT");
		}

		[Cpp2IlInjected.Token(Token = "0x60027EA")]
		[Cpp2IlInjected.Address(RVA = "0xFA0DA0", Offset = "0xF9F7A0", VA = "0x180FA0DA0")]
		private void OnPreviousTab()
		{
			Debug.Log("LEFT");
		}

		[Cpp2IlInjected.Token(Token = "0x60027EB")]
		[Cpp2IlInjected.Address(RVA = "0xFA0530", Offset = "0xF9EF30", VA = "0x180FA0530", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069, IL_007b
			int num = 0;
			base.OnControllerChanged();
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			IEnumerator enumerator = ((LoopScrollRect)_listMailItems).m_Content.GetEnumerator();
			MailItem mailItem = default(MailItem);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				mailItem.OnDeHighlightedHandler();
			}
			if ((object)mailItem == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027EC")]
		[Cpp2IlInjected.Address(RVA = "0xF9F800", Offset = "0xF9E200", VA = "0x180F9F800")]
		public void CustomEventsFindNext(FocusDirection direction, int input, FocusNavigationElement element, ISupportsFocusNavigation supportFocusNav)
		{
			//Discarded unreachable code: IL_0061, IL_0066, IL_008e
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && direction == FocusDirection.Left)
			{
				LoopVerticalScrollRect listMailItems = _listMailItems;
				if (_offlineWarningList.gameObject.activeInHierarchy)
				{
					MenuNavigation menuNavigation = base.MenuNavigation;
					BaseButton btnConnectList = _btnConnectList;
					FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
					FocusNavigationElement component = btnConnectList.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027ED")]
		[Cpp2IlInjected.Address(RVA = "0xFA20C0", Offset = "0xFA0AC0", VA = "0x180FA20C0")]
		private void SetFocus()
		{
			//IL_0039: Expected O, but got I4
			if (!_offlineWarningContainer.gameObject.activeInHierarchy)
			{
				if (!_offlineWarningList.gameObject.activeInHierarchy)
				{
					MailItem selectedMail = _selectedMail;
					int num = 0;
					if (!(selectedMail != (UnityEngine.Object)num))
					{
						LoopVerticalScrollRect listMailItems = _listMailItems;
						FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
						RectTransform content = ((LoopScrollRect)_listMailItems).m_Content;
						int index = 0;
						FocusNavigationElement component = content.GetChild(index).GetComponent<FocusNavigationElement>();
						focusNavigation.SetFocus(component);
						return;
					}
					MenuNavigation menuNavigation = base.MenuNavigation;
					FocusNavigationElement component2 = _selectedMail.gameObject.GetComponent<FocusNavigationElement>();
				}
				MenuNavigation menuNavigation2 = base.MenuNavigation;
			}
			MenuNavigation menuNavigation3 = base.MenuNavigation;
			BaseButton btnConnect = _btnConnect;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027EE")]
		[Cpp2IlInjected.Address(RVA = "0xFA27E0", Offset = "0xFA11E0", VA = "0x180FA27E0")]
		public void Update()
		{
			//Discarded unreachable code: IL_00f6
			float deltaTime;
			InputAction[] array;
			InputAction inputAction4;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[4];
				InputAction inputAction = inputActionLBPress;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionRBPress;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputActionLBRelease;
				if (inputAction3 == null || array != null)
				{
					array[2] = inputAction3;
					inputAction4 = inputActionRBRelease;
					if (inputAction4 == null || array != null)
					{
						break;
					}
				}
			}
			array[3] = inputAction4;
			InputAction.UpdateAll(deltaTime, array);
			if (inputActionLBPress.IsTriggered && !_inputActionLBPJustPress)
			{
				_inputActionLBPJustPress = true;
				Debug.Log("LEFT");
			}
			if (inputActionLBRelease.IsTriggered)
			{
				_inputActionLBPJustPress = false;
			}
			if (inputActionRBPress.IsTriggered && !_inputActionRBJustPress)
			{
				_inputActionRBJustPress = true;
				Debug.Log("RIGHT");
			}
			if (inputActionRBRelease.IsTriggered)
			{
				_inputActionRBJustPress = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027EF")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public MailboxMenu()
		{
		}
	}
}
