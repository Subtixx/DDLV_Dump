using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
using Mdl.Audio;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000497")]
	public class EventsMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000498")]
		internal class EventsMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40017D3")]
			public bool ToDuties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40017D4")]
			public string BattlePassLocalName;

			[Cpp2IlInjected.Token(Token = "0x6001DF9")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public EventsMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40017C3")]
		[SerializeField]
		private GameObject _prefabEventItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40017C4")]
		[SerializeField]
		private EventDisplayManager _nextEventDisplayManagers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40017C5")]
		[SerializeField]
		private EventDisplayManager _prevEventDisplayManagers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40017C6")]
		[SerializeField]
		private List<EventDisplayManager> _displayManagers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40017C7")]
		[SerializeField]
		private RectTransform _eventContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40017C8")]
		[SerializeField]
		private RectTransform _emptyEventContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40017C9")]
		[SerializeField]
		private SpriteAtlasImage _eventBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40017CA")]
		[SerializeField]
		private LoopVerticalScrollRect _listEventItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40017CB")]
		[SerializeField]
		private RectTransform _eventListContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40017CC")]
		[SerializeField]
		private bool _enableBuyMoonstoneBtn = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40017CD")]
		internal EventsMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40017CE")]
		private List<BattlePassSeasonData> _eventData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40017CF")]
		private EventDisplayManager _currentEventDisplayManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40017D0")]
		private EventItem _currentEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40017D1")]
		private EventItemSubCategory.SubCategoryType _currentEventSub;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40017D2")]
		private CancellationToken ct;

		[Cpp2IlInjected.Token(Token = "0x170004E1")]
		public static EventsMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6001DDD")]
			[Cpp2IlInjected.Address(RVA = "0x1410260", Offset = "0x140EC60", VA = "0x181410260")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DDE")]
			[Cpp2IlInjected.Address(RVA = "0x14102A0", Offset = "0x140ECA0", VA = "0x1814102A0")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E2")]
		public bool EnableBuyMoonstoneBtn
		{
			[Cpp2IlInjected.Token(Token = "0x6001DDF")]
			[Cpp2IlInjected.Address(RVA = "0x1410250", Offset = "0x140EC50", VA = "0x181410250")]
			get
			{
				return _enableBuyMoonstoneBtn;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E3")]
		public EventDisplayManager CurrentEventDisplayManager
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE0")]
			[Cpp2IlInjected.Address(RVA = "0x1324B60", Offset = "0x1323560", VA = "0x181324B60")]
			get
			{
				return _currentEventDisplayManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E4")]
		public EventDisplayManager NextEventDisplayManager
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE1")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			get
			{
				return _nextEventDisplayManagers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E5")]
		public EventDisplayManager PreviousEventDisplayManager
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE2")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get
			{
				return _prevEventDisplayManagers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E6")]
		public EventItem CurrentEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE3")]
			[Cpp2IlInjected.Address(RVA = "0x1410240", Offset = "0x140EC40", VA = "0x181410240")]
			get
			{
				return _currentEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E7")]
		public EventItemSubCategory.SubCategoryType CurrentEventSub
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE4")]
			[Cpp2IlInjected.Address(RVA = "0x1410230", Offset = "0x140EC30", VA = "0x181410230")]
			get
			{
				return _currentEventSub;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE5")]
		[Cpp2IlInjected.Address(RVA = "0x140D7A0", Offset = "0x140C1A0", VA = "0x18140D7A0")]
		private void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE6")]
		[Cpp2IlInjected.Address(RVA = "0x140F940", Offset = "0x140E340", VA = "0x18140F940", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0081
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listEventItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			SystemRoot systemRoot = SystemRoot.Instance;
			if ((object)systemRoot != null && systemRoot.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged += value;
			}
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE7")]
		[Cpp2IlInjected.Address(RVA = "0x140FF80", Offset = "0x140E980", VA = "0x18140FF80", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0081
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listEventItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			SystemRoot systemRoot = SystemRoot.Instance;
			if ((object)systemRoot != null && systemRoot.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged -= value;
			}
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE8")]
		[Cpp2IlInjected.Address(RVA = "0x140D7F0", Offset = "0x140C1F0", VA = "0x18140D7F0")]
		public void CustomEventsFindNext(FocusDirection direction, int input, FocusNavigationElement element, ISupportsFocusNavigation supportFocusNav)
		{
			//Discarded unreachable code: IL_008e
			//IL_002d: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			EventItem currentEvent = _currentEvent;
			int num2 = 0;
			if (currentEvent == (UnityEngine.Object)num2)
			{
				return;
			}
			EventDisplayManager currentEventDisplayManager = _currentEventDisplayManager;
			int num3 = 0;
			if (!(currentEventDisplayManager == (UnityEngine.Object)num3) && direction == FocusDirection.Left)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				EventItem currentEvent2 = _currentEvent;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				EventItemSubCategory.SubCategoryType currentEventSub = _currentEventSub;
				if (currentEventSub == EventItemSubCategory.SubCategoryType.Description || currentEventSub != 0)
				{
				}
				FocusNavigationElement component = currentEvent2._description.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE9")]
		[Cpp2IlInjected.Address(RVA = "0x140DE50", Offset = "0x140C850", VA = "0x18140DE50")]
		private void OnConnectionModeChanged(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0079, IL_007f
			//IL_001b: Expected O, but got I4
			//IL_003b: Expected F4, but got I4
			int num = 0;
			CanvasGroup component = _eventListContainer.GetComponent<CanvasGroup>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				CanvasGroup component2 = _eventListContainer.GetComponent<CanvasGroup>();
				bool flag = default(bool);
				if (flag)
				{
				}
				int num3 = 0;
				component2.alpha = num3;
				_eventListContainer.GetComponent<CanvasGroup>().interactable = flag;
			}
			List<EventDisplayManager> displayManagers = _displayManagers;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num5 = 0;
				int num6 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEA")]
		[Cpp2IlInjected.Address(RVA = "0x140EE70", Offset = "0x140D870", VA = "0x18140EE70")]
		private Task RefreshEventList()
		{
			//Discarded unreachable code: IL_029d
			//IL_00cb: Expected I4, but got O
			//IL_0163: Expected O, but got I4
			//IL_01a1: Expected O, but got I8
			//IL_0228: Expected O, but got I4
			List<BattlePassSeasonData> list = (_eventData = (List<BattlePassSeasonData>)(object)new List<T>());
			EventItem currentEvent = _currentEvent;
			if ((object)currentEvent != null)
			{
			}
			BattlePassSeasonData currentEventData = (BattlePassSeasonData)(object)currentEvent;
			EventItemSubCategory.SubCategoryType currentEventSub = _currentEventSub;
			List<BattlePassSeasonData> battlePasses = (List<BattlePassSeasonData>)(object)SystemRoot.Instance.MetaOnlineClient.GetBattlePasses();
			Func<BattlePassSeasonData, bool> func = default(Func<BattlePassSeasonData, bool>);
			if (_003C_003Ec._003C_003E9__38_0 == null)
			{
				func = (Func<BattlePassSeasonData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(BattlePassSeasonData x)
				{
					//Discarded unreachable code: IL_0029
					DateTime dateTime = x.endDate_.date_.ToDateTime();
					DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
					return dateTime > serverTime;
				});
			}
			IEnumerable<BattlePassSeasonData> enumerable = (IEnumerable<BattlePassSeasonData>)Enumerable.Where<BattlePassSeasonData>((IEnumerable<>)battlePasses, (Func<, >)(object)func);
			((List<T>)(object)battlePasses).AddRange((IEnumerable<>)enumerable);
			if (_003C_003Ec._003C_003E9__38_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Comparison<T>)delegate(BattlePassSeasonData x, BattlePassSeasonData y)
				{
					//Discarded unreachable code: IL_002a
					DateTime t = y.startDate_.date_.ToDateTime();
					DateTime t2 = x.startDate_.date_.ToDateTime();
					return DateTime.Compare(t, t2);
				};
			}
			bool active = default(bool);
			_emptyEventContainer.gameObject.SetActive(active);
			GameObject gameObject = _eventContainer.gameObject;
			bool active2 = default(bool);
			gameObject.SetActive(active2);
			_listEventItems.totalCount = (int)gameObject;
			LoopVerticalScrollRect listEventItems = _listEventItems;
			int offset = 0;
			listEventItems.RefillCells(offset);
			((LoopScrollRect)_listEventItems).m_Content.RebuildLayout();
			LoopVerticalScrollRect listEventItems2 = _listEventItems;
			RefreshScrollbarVisibility(listEventItems2);
			EventsMenuParam param = _param;
			if (param != null && param.ToDuties)
			{
				EventItem[] componentsInChildren = default(EventItem[]);
				if ((long)currentEventData != 0)
				{
					componentsInChildren = ((LoopScrollRect)_listEventItems).m_Content.GetComponentsInChildren<EventItem>();
					Func<EventItem, bool> func2 = (Func<EventItem, bool>)(object)(Func<T, TResult>)delegate(EventItem x)
					{
						//Discarded unreachable code: IL_0016
						BattlePassSeasonData battlePassData2 = x.battlePassData;
						BattlePassSeasonData other2 = currentEventData;
						return battlePassData2.Equals(other2);
					};
					EventItem eventItem = Enumerable.FirstOrDefault<EventItem>(Enumerable.Where<EventItem>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func2));
					int num = 0;
					if (eventItem != (UnityEngine.Object)num)
					{
						eventItem.Deselect();
					}
				}
				Func<BattlePassSeasonData, bool> func3 = (Func<BattlePassSeasonData, bool>)(object)(Func<T, TResult>)delegate(BattlePassSeasonData x)
				{
					//Discarded unreachable code: IL_002a
					string text = x.onlineId_.ToLower();
					string value = _param.BattlePassLocalName.ToLower();
					return text.Equals(value);
				};
				BattlePassSeasonData battlePassSeasonData = Enumerable.FirstOrDefault<BattlePassSeasonData>(Enumerable.Where<BattlePassSeasonData>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func3));
				if (battlePassSeasonData != null)
				{
					currentEventData = battlePassSeasonData;
				}
				_param = (EventsMenuParam)0;
			}
			if ((long)currentEventData != 0)
			{
				EventItem[] componentsInChildren2 = ((LoopScrollRect)_listEventItems).m_Content.GetComponentsInChildren<EventItem>();
				Func<EventItem, bool> func4 = (Func<EventItem, bool>)(object)(Func<T, TResult>)delegate(EventItem x)
				{
					//Discarded unreachable code: IL_0016
					BattlePassSeasonData battlePassData = x.battlePassData;
					BattlePassSeasonData other = currentEventData;
					return battlePassData.Equals(other);
				};
				EventItem eventItem2 = (_currentEvent = Enumerable.FirstOrDefault<EventItem>(Enumerable.Where<EventItem>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func4)));
			}
			bool flag = default(bool);
			if (!flag)
			{
			}
			if (((LoopScrollRect)_listEventItems).m_Content.childCount > 0)
			{
				RectTransform content = ((LoopScrollRect)_listEventItems).m_Content;
				int index = 0;
				EventItem component = content.GetChild(index).GetComponent<EventItem>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					RectTransform content2 = ((LoopScrollRect)_listEventItems).m_Content;
					int index2 = 0;
					EventItem component2 = content2.GetChild(index2).GetComponent<EventItem>();
					int type = 0;
					component2.SelectDetailsBySubType((EventItemSubCategory.SubCategoryType)type);
				}
			}
			_currentEventDisplayManager?.RetrieveEventCurrencyStatus();
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int focusToContent = 0;
				int ignoreLastFocus = 0;
				SetFocus((byte)ignoreLastFocus != 0, (byte)focusToContent != 0);
			}
			int num4 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEB")]
		[Cpp2IlInjected.Address(RVA = "0x140ECC0", Offset = "0x140D6C0", VA = "0x18140ECC0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0040
			//IL_001d: Expected O, but got I4
			base.OnPush(stack, param);
			int num = 0;
			if (param != null)
			{
				int num2 = 0;
				if (param != null)
				{
					int num3 = 0;
				}
			}
			_param = (EventsMenuParam)num;
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			system.PushGameState(AudioManager.GameState.MainMenu);
			int num4 = 0;
			if ((long)system == 1)
			{
				_enableBuyMoonstoneBtn = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEC")]
		[Cpp2IlInjected.Address(RVA = "0x140EBA0", Offset = "0x140D5A0", VA = "0x18140EBA0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0034
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DED")]
		[Cpp2IlInjected.Address(RVA = "0x140EA60", Offset = "0x140D460", VA = "0x18140EA60", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_002e
			base.OnFocusIn();
			RefreshEventList().FireAndForgetTask();
			OnlineClient.OnlineStatus _003CCurrentOnlineStatus_003Ek__BackingField = SystemRoot.Instance.MetaClient.OnlineClient.CurrentOnlineStatus;
			CancellationToken cancellationToken = base.CancellationToken;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEE")]
		[Cpp2IlInjected.Address(RVA = "0x131E4B0", Offset = "0x131CEB0", VA = "0x18131E4B0")]
		private void OnPopupStackChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			GameObject gameObject = UiRoot.Instance.MainMenuBar.ShortcutBar.gameObject;
			int num2 = 0;
			bool active = UiRoot.Instance._popupStack.Count <= 0;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEF")]
		[Cpp2IlInjected.Address(RVA = "0x140E0F0", Offset = "0x140CAF0", VA = "0x18140E0F0")]
		private void OnEventItemDataHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF0")]
		[Cpp2IlInjected.Address(RVA = "0x140D950", Offset = "0x140C350", VA = "0x18140D950")]
		private EventDisplayManager GetDisplayManagerToUse(EventItem item)
		{
			//Discarded unreachable code: IL_0042, IL_0048, IL_004e, IL_0054, IL_005a
			bool flag = default(bool);
			string value;
			string text = default(string);
			do
			{
				int num = 0;
				if ((item._isNewestEvent ? 1 : 0) != num)
				{
				}
				EventDisplayManager prevEventDisplayManagers = _prevEventDisplayManagers;
				List<EventDisplayManager> displayManagers = _displayManagers;
				if (!flag)
				{
					break;
				}
				value = item.battlePassData.onlineId_.ToLower();
			}
			while (!text.Equals(value));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF1")]
		[Cpp2IlInjected.Address(RVA = "0x140E5C0", Offset = "0x140CFC0", VA = "0x18140E5C0")]
		private void OnEventItemDisplayed(EventItem item, EventItemSubCategory.SubCategoryType type)
		{
			//Discarded unreachable code: IL_00b7, IL_00bd
			int num = 0;
			if (item.type != (EventItem.EventType)num)
			{
				return;
			}
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				GameObject gameObject = default(GameObject);
				if ((flag2 || type != 0) && _currentEventSub == (EventItemSubCategory.SubCategoryType)num && gameObject.activeInHierarchy)
				{
					int num2 = 0;
					int num3 = 0;
					UiRoot.Instance.RedDotHelper.OnRefreshBattlePassNewState();
				}
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
			}
			_currentEvent = item;
			_currentEventSub = type;
			EventDisplayManager eventDisplayManager = (_currentEventDisplayManager = GetDisplayManagerToUse(item));
			List<EventDisplayManager> displayManagers = _displayManagers;
			bool flag4 = default(bool);
			if (flag4)
			{
				GameObject gameObject2 = default(GameObject);
				bool active = default(bool);
				gameObject2.SetActive(active);
			}
			int num4 = 0;
			int num5 = 0;
			EventItem[] array = default(EventItem[]);
			int length = array.Length;
			if (num4 < length)
			{
				EventItem eventItem = array[num4];
				Image hoverBGLeft = eventItem._hoverBGLeft;
				Image hoverBGRight = eventItem._hoverBGRight;
				num4++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF2")]
		[Cpp2IlInjected.Address(RVA = "0xE1A830", Offset = "0xE19230", VA = "0x180E1A830", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF3")]
		[Cpp2IlInjected.Address(RVA = "0x140DB10", Offset = "0x140C510", VA = "0x18140DB10", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_014d
			//IL_008f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if (redirectionType == RedirectionType.MainMenuGoToEvents)
				{
					goto IL_0139;
				}
				if (redirectionType == RedirectionType.MainMenuGoToInGameShop || redirectionType != RedirectionType.GamePopCurrentMenu)
				{
					return;
				}
			}
			if (redirectionType != RedirectionType.MenuEventsToggle)
			{
				if (redirectionType != RedirectionType.MenuNavGoBackward)
				{
					if ((long)typeof(UnityEngine.Object).TypeHandle > 3)
					{
					}
					return;
				}
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
					int num2 = 0;
					if (focusedElement != null)
					{
						int num3 = 0;
						if (focusedElement != null)
						{
							GameObject gameObject = default(GameObject);
							EventItem componentInParent = gameObject.GetComponentInParent<EventItem>();
						}
					}
					int num4 = 0;
					if ((UnityEngine.Object)num2 == (UnityEngine.Object)num4)
					{
						EventItem currentEvent = _currentEvent;
						int num5 = 0;
						if (currentEvent != (UnityEngine.Object)num5 && _currentEvent.gameObject.activeInHierarchy)
						{
							EventDisplayManager currentEventDisplayManager = _currentEventDisplayManager;
							int num6 = 0;
							if (currentEventDisplayManager != (UnityEngine.Object)num6 && !_currentEventDisplayManager._offlineWarningContainer.gameObject.activeInHierarchy)
							{
								EventItem currentEvent2 = _currentEvent;
								FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
								EventItemSubCategory.SubCategoryType currentSelectedSub = currentEvent2._currentSelectedSub;
								if (currentSelectedSub != 0)
								{
									switch (currentSelectedSub)
									{
									}
								}
								FocusNavigationElement component = currentEvent2._description.GetComponent<FocusNavigationElement>();
								focusNavigation.SetFocus(component);
								return;
							}
						}
					}
				}
			}
			goto IL_0139;
			IL_0139:
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF4")]
		[Cpp2IlInjected.Address(RVA = "0x140F790", Offset = "0x140E190", VA = "0x18140F790")]
		private void RefreshScrollbarVisibility(LoopVerticalScrollRect _list)
		{
			//Discarded unreachable code: IL_0052
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			Scrollbar verticalScrollbar = ((LoopScrollRect)_list).m_VerticalScrollbar;
			if ((object)verticalScrollbar != null)
			{
				CanvasGroup component = verticalScrollbar.GetComponent<CanvasGroup>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				((LoopScrollRect)_list).m_Content.RebuildLayout();
				RectTransform content = ((LoopScrollRect)_list).m_Content;
				RectTransform viewport = ((LoopScrollRect)_list).m_Viewport;
				int num3 = 0;
				RectTransform content2 = ((LoopScrollRect)_list).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_list).m_Viewport;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF5")]
		[Cpp2IlInjected.Address(RVA = "0x140E080", Offset = "0x140CA80", VA = "0x18140E080", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_003d
			base.OnControllerChanged();
			_currentEventDisplayManager?.RefreshRewardPreview();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int focusToContent = 0;
				int ignoreLastFocus = 0;
				SetFocus((byte)ignoreLastFocus != 0, (byte)focusToContent != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF6")]
		[Cpp2IlInjected.Address(RVA = "0x140FBE0", Offset = "0x140E5E0", VA = "0x18140FBE0")]
		public void SetFocus(bool ignoreLastFocus = false, bool focusToContent = false)
		{
			//IL_0010: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			EventDisplayManager currentEventDisplayManager = _currentEventDisplayManager;
			int num = 0;
			if (currentEventDisplayManager != (UnityEngine.Object)num && _currentEventDisplayManager._offlineWarningContainer.gameObject.activeInHierarchy)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				FocusNavigationElement component = _currentEventDisplayManager._btnConnect.GetComponent<FocusNavigationElement>();
			}
			FocusNavigationElement focusElement = base.MenuNavigation.GetFocusElement();
			int num2 = 0;
			bool flag = focusElement == (UnityEngine.Object)num2;
			if (base.MenuNavigation.GetFocusElement().gameObject.activeInHierarchy)
			{
				return;
			}
			EventItem currentEvent = _currentEvent;
			int num3 = 0;
			MenuNavigation menuNavigation2 = default(MenuNavigation);
			if (currentEvent != (UnityEngine.Object)num3)
			{
				EventDisplayManager currentEventDisplayManager2 = _currentEventDisplayManager;
				int num4 = 0;
				if (currentEventDisplayManager2 != (UnityEngine.Object)num4)
				{
					if (!focusToContent)
					{
						EventItem currentEvent2 = _currentEvent;
						FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
						EventItemSubCategory.SubCategoryType currentSelectedSub = currentEvent2._currentSelectedSub;
						if (currentSelectedSub != 0)
						{
							switch (currentSelectedSub)
							{
							}
						}
						FocusNavigationElement component2 = currentEvent2._description.GetComponent<FocusNavigationElement>();
						focusNavigation.SetFocus(component2);
					}
					EventDisplayManager currentEventDisplayManager3 = _currentEventDisplayManager;
					menuNavigation2 = base.MenuNavigation;
					FocusNavigation focusNavigation2 = menuNavigation2.FocusNavigation;
					currentEventDisplayManager3.SetFocus(focusNavigation2);
					return;
				}
			}
			while ((menuNavigation2._isInTask ? 1 : 0) <= (false ? 1 : 0))
			{
			}
			MenuNavigation menuNavigation3 = default(MenuNavigation);
			FocusNavigation focusNavigation3 = menuNavigation3.FocusNavigation;
			GameObject tutorialBlocker = menuNavigation3._tutorialBlocker;
			int num5 = 0;
			Transform transform = default(Transform);
			FocusNavigationElement componentInChildren = transform.GetComponentInChildren<FocusNavigationElement>();
			focusNavigation3.SetFocus(componentInChildren);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF7")]
		[Cpp2IlInjected.Address(RVA = "0x1410220", Offset = "0x140EC20", VA = "0x181410220")]
		public EventsMenu()
		{
		}
	}
}
