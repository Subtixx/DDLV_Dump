using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Ftue;
using Mdl.Grid;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Tracking;
using Meta.Util;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200055C")]
	public class HudMenu : Menu, IFtueElement, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001D16")]
		[SerializeField]
		private RadialToolMenu _radialToolMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001D17")]
		[SerializeField]
		private CustomButton _toolButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001D18")]
		[SerializeField]
		private HudQuestTracker _questTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001D19")]
		[SerializeField]
		private ManaBar _manaBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001D1A")]
		[SerializeField]
		private float _holdDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4001D1B")]
		[ItemID]
		[SerializeField]
		private int _currencyCoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001D1C")]
		[SerializeField]
		private HudCollectionReminder _collectionReminder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001D1D")]
		[SerializeField]
		private HudGainItemNotif _hudItemNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001D1E")]
		[SerializeField]
		private CharacterFriendshipBar _characterFriendshipBarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001D1F")]
		[SerializeField]
		private ListBase _currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001D20")]
		[SerializeField]
		private BuffContent _buffContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001D21")]
		[SerializeField]
		private ShortcutIndicator _useToolShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001D22")]
		public UnityEvent OnHide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001D23")]
		public UnityEvent OnShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001D24")]
		private List<Item> _currencyItemsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001D25")]
		private Queue<(Item currencyItem, int amount)> _transactions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001D26")]
		private float _checkVisibleRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4001D27")]
		private bool _isReadyToShowCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001D28")]
		private Coroutine _checkHudVisibleCo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001D29")]
		protected InputAction inputActionToolPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001D2A")]
		protected InputAction inputActionToolRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001D2B")]
		protected InputAction inputActionToolHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001D2C")]
		private bool _justFireHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4001D2D")]
		private CollectionSubMenu _collectionReminderSelectedTab;

		[Cpp2IlInjected.Token(Token = "0x17000564")]
		public bool IsSomethingOpened
		{
			[Cpp2IlInjected.Token(Token = "0x60022DD")]
			[Cpp2IlInjected.Address(RVA = "0xAFC2C0", Offset = "0xAFACC0", VA = "0x180AFC2C0")]
			get
			{
				//Discarded unreachable code: IL_0009, IL_0014, IL_0020, IL_0027
				//IL_001d: Expected O, but got I4
				RadialToolMenu radialToolMenu = _radialToolMenu;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000565")]
		internal ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60022DE")]
			[Cpp2IlInjected.Address(RVA = "0xAFC370", Offset = "0xAFAD70", VA = "0x180AFC370")]
			get
			{
				int num = 0;
				WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
				Type typeFromHandle = typeof(ItemSelector);
				if ((object)worldCanvas.GetGizmoByType(typeFromHandle) == null)
				{
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000566")]
		public ManaBar ManaBar
		{
			[Cpp2IlInjected.Token(Token = "0x60022DF")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return _manaBar;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000567")]
		public RadialToolMenu RadialToolMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60022E0")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return _radialToolMenu;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000568")]
		public ListBase CurrencyItems
		{
			[Cpp2IlInjected.Token(Token = "0x60022E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5C390", Offset = "0xA5AD90", VA = "0x180A5C390")]
			get
			{
				return _currencyItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000569")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xD0"), Cpp2IlInjected.Token(Token = "0x4001D15")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60022E2")]
			[Cpp2IlInjected.Address(RVA = "0xAFC360", Offset = "0xAFAD60", VA = "0x180AFC360")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60022E3")]
			[Cpp2IlInjected.Address(RVA = "0xAFC480", Offset = "0xAFAE80", VA = "0x180AFC480")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700056A")]
		public HudCollectionReminder CollectionReminder
		{
			[Cpp2IlInjected.Token(Token = "0x60022E4")]
			[Cpp2IlInjected.Address(RVA = "0x7389E0", Offset = "0x7373E0", VA = "0x1807389E0")]
			get
			{
				return _collectionReminder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022E5")]
		[Cpp2IlInjected.Address(RVA = "0xAF8B50", Offset = "0xAF7550", VA = "0x180AF8B50")]
		private void OnEnable()
		{
			int _003C_003E1__state = default(int);
			_003CCheckIfHudVisible_003Ed__47 _003CCheckIfHudVisible_003Ed__ = new _003CCheckIfHudVisible_003Ed__47(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCheckIfHudVisible_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_checkHudVisibleCo = StartCoroutine(_003CCheckIfHudVisible_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022E6")]
		[Cpp2IlInjected.Address(RVA = "0xAF8B40", Offset = "0xAF7540", VA = "0x180AF8B40")]
		private void OnDisable()
		{
			Coroutine checkHudVisibleCo = _checkHudVisibleCo;
			StopCoroutine(checkHudVisibleCo);
		}

		[Cpp2IlInjected.Token(Token = "0x60022E7")]
		[Cpp2IlInjected.Address(RVA = "0xAFA670", Offset = "0xAF9070", VA = "0x180AFA670")]
		public void ShowCurrency()
		{
			//Discarded unreachable code: IL_00a1
			//IL_0010: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			ListBase currencyItems = _currencyItems;
			int num = 0;
			if (!(currencyItems != (UnityEngine.Object)num))
			{
				return;
			}
			GameObject gameObject = _currencyItems.gameObject;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				Canvas component = _currencyItems.gameObject.GetComponent<Canvas>();
				int num3 = 0;
				if (component == (UnityEngine.Object)num3)
				{
					_currencyItems.RefreshCells();
					Queue<(Item, int)> transactions = _transactions;
					int num4 = 0;
					(Item, int) tuple = ((Item, int))((Queue<T>)(object)transactions).Dequeue();
					Queue<(Item, int)> transactions2 = _transactions;
					_currencyItems.GetComponent<SlidingPanel>()?.Show(andOpen: true);
					LayoutRebuilder.ForceRebuildLayoutImmediate(_currencyItems.m_Content);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022E8")]
		[Cpp2IlInjected.Address(RVA = "0xAF8390", Offset = "0xAF6D90", VA = "0x180AF8390")]
		public void HideCurrency()
		{
			//Discarded unreachable code: IL_0045
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			ListBase currencyItems = _currencyItems;
			int num = 0;
			if (currencyItems != (UnityEngine.Object)num)
			{
				GameObject gameObject = _currencyItems.gameObject;
				int num2 = 0;
				if (gameObject != (UnityEngine.Object)num2)
				{
					_currencyItems.GetComponent<SlidingPanel>()?.Hide();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022E9")]
		[Cpp2IlInjected.Address(RVA = "0xAF7E10", Offset = "0xAF6810", VA = "0x180AF7E10")]
		public RectTransform GetCurrentCoinPos()
		{
			//IL_0061: Expected O, but got I4
			ListBase currencyItems = _currencyItems;
			int num = 0;
			if ((object)currencyItems != null)
			{
				RectTransform content = currencyItems.m_Content;
				if ((object)content != null)
				{
					int childCount = content.childCount;
				}
				if (num != 0)
				{
					int childCount2 = _currencyItems.m_Content.childCount;
					if (num < childCount2)
					{
						FreemiumCurrencyItem component = _currencyItems.m_Content.GetChild(num).GetComponent<FreemiumCurrencyItem>();
						int num2 = 0;
						if (component != (UnityEngine.Object)num2)
						{
							Item currencyItem = component.CurrencyItem;
							long num3 = Convert.ToInt64((uint)_currencyCoinType);
						}
						ListBase currencyItems2 = _currencyItems;
						num++;
						Transform transform = default(Transform);
						if ((object)transform == null)
						{
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022EA")]
		[Cpp2IlInjected.Address(RVA = "0xAF8710", Offset = "0xAF7110", VA = "0x180AF8710")]
		public void OnCurrencyChanged(Item currencyItem, int gained, bool fromDialog = false)
		{
			//IL_00ae: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num3 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num4 = 0;
				if (top != null)
				{
					ListBase currencyItems = _currencyItems;
					if (num < currencyItems._totalCount)
					{
						FreemiumCurrencyItem component = currencyItems.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
						if ((object)component.CurrencyItem == null)
						{
							ListBase currencyItems2 = _currencyItems;
							num++;
						}
						int amount = component._amount;
						amount = (component.Amount = amount + gained);
					}
					return;
				}
			}
			while (!fromDialog)
			{
			}
			int num6 = 0;
			MenuStack menuStack2 = UiRoot.Instance._menuStack;
			int num7 = 0;
			IMenu top2 = menuStack2.Top;
			if (top2 != null)
			{
				int num8 = 0;
				while (top2 != null)
				{
				}
			}
			((Queue<T>)(object)_transactions).Enqueue((T)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022EB")]
		[Cpp2IlInjected.Address(RVA = "0xAFAFE0", Offset = "0xAF99E0", VA = "0x180AFAFE0")]
		private void ShowQueuedCurrency()
		{
			//Discarded unreachable code: IL_0069
			//IL_0049: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			if (!_isReadyToShowCurrency)
			{
				return;
			}
			if ((long)(IntPtr)((Queue<T>)(object)_transactions).Dequeue() > 0L)
			{
				int num = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				bool flag = default(bool);
				if (!flag)
				{
					int num2 = 0;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
					bool flag2 = default(bool);
					if (!flag2)
					{
						goto IL_0060;
					}
					int num3 = 0;
					UiRoot instance = UiRoot.Instance;
					int num4 = 0;
					instance.GemGainPickup((RectTransform)num4);
				}
				int num5 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int num6 = 0;
				instance2.CoinGainPickup((RectTransform)num6);
			}
			goto IL_0060;
			IL_0060:
			Queue<(Item, int)> transactions = _transactions;
		}

		[Cpp2IlInjected.Token(Token = "0x60022EC")]
		[Cpp2IlInjected.Address(RVA = "0xAF7BA0", Offset = "0xAF65A0", VA = "0x180AF7BA0")]
		[IteratorStateMachine(typeof(_003CCheckIfHudVisible_003Ed__47))]
		private IEnumerator CheckIfHudVisible()
		{
			int _003C_003E1__state = default(int);
			_003CCheckIfHudVisible_003Ed__47 _003CCheckIfHudVisible_003Ed__ = new _003CCheckIfHudVisible_003Ed__47(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCheckIfHudVisible_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022ED")]
		[Cpp2IlInjected.Address(RVA = "0xAFB7E0", Offset = "0xAFA1E0", VA = "0x180AFB7E0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0141
			float deltaTime;
			InputAction[] array;
			InputAction inputAction3;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[3];
				InputAction inputAction = inputActionToolPress;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionToolRelease;
				if (inputAction2 == null || array != null)
				{
					array[1] = inputAction2;
					inputAction3 = inputActionToolHold;
					if (inputAction3 == null || array != null)
					{
						break;
					}
				}
			}
			array[2] = inputAction3;
			InputAction.UpdateAll(deltaTime, array);
			if (!inputActionToolPress.IsTriggered)
			{
				if (!inputActionToolRelease.IsTriggered)
				{
					goto IL_010e;
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				if (flag || _justFireHold == flag)
				{
					int num3 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int useKeyboardAsController2 = 0;
					if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
					{
						goto IL_010e;
					}
				}
				RadialToolMenu radialToolMenu = _radialToolMenu;
			}
			RadialToolMenu radialToolMenu2 = _radialToolMenu;
			int num4 = 0;
			if (!UiRoot.Instance.AreShortcutsBlocked)
			{
				int num5 = 0;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				bool flag5 = default(bool);
				if (!flag2 && flag3 && !flag4 && !flag5)
				{
					RadialToolMenu radialToolMenu3 = _radialToolMenu;
					int resetToolOnHide = 0;
					radialToolMenu3.Toggle((byte)resetToolOnHide != 0);
				}
			}
			goto IL_010e;
			IL_010e:
			if (Input.GetMouseButton(0))
			{
				RadialToolMenu radialToolMenu4 = _radialToolMenu;
				int resetToolOnHide2 = 0;
				radialToolMenu4.Toggle((byte)resetToolOnHide2 != 0);
			}
			bool flag6 = (_justFireHold = inputActionToolHold.IsTriggered);
		}

		[Cpp2IlInjected.Token(Token = "0x60022EE")]
		[Cpp2IlInjected.Address(RVA = "0xAF9BE0", Offset = "0xAF85E0", VA = "0x180AF9BE0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0025
			base.OnPush(stack, param);
			List<Item> currencyItemsData = _currencyItemsData;
			ListBase currencyItems = _currencyItems;
			int num = (currencyItems.TotalCount = ((List<>)(object)currencyItemsData)._size);
		}

		[Cpp2IlInjected.Token(Token = "0x60022EF")]
		[Cpp2IlInjected.Address(RVA = "0xAF8BE0", Offset = "0xAF75E0", VA = "0x180AF8BE0", Slot = "27")]
		public override void OnFocusIn()
		{
			//IL_009b: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			base.OnFocusIn();
			CustomButton toolButton = _toolButton;
			CurrentToolButtonModel currentToolButtonModel = (CurrentToolButtonModel)(toolButton.Model = new CurrentToolButtonModel());
			CustomButton toolButton2 = _toolButton;
			toolButton2.Model.Init(toolButton2);
			base.IsDataUpToDate = true;
			int num = 0;
			if (UiRoot.Instance._menuStack.GetComponent<Canvas>().enabled)
			{
				Show();
			}
			RefreshCurrencies();
			RadialToolMenu radialToolMenu = _radialToolMenu;
			int resetToolOnHide = 0;
			radialToolMenu.Toggle((byte)resetToolOnHide != 0);
			if (_questTracker.isActiveAndEnabled)
			{
				_questTracker.Show();
			}
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num2 = default(int);
			InputActionBool inputActionBool = new InputActionBool("GP - Hud - Toggle Tool", trigger, (InputProvider)num2);
			num2 = 0;
			inputActionToolPress = inputActionBool;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("GP - Hud - Toggle Tool", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionToolRelease = inputActionBool2;
			InputTriggerDownWithDelay trigger3 = new InputTriggerDownWithDelay(_holdDelay);
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("GP - Hud - Toggle Tool", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionToolHold = inputActionBool3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022F0")]
		[Cpp2IlInjected.Address(RVA = "0xAFA070", Offset = "0xAF8A70", VA = "0x180AFA070", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_00e4
			//IL_0053: Expected O, but got I4
			((object)this)._002Ector();
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += OnSceneChanged;
			int num = 0;
			UnityEvent<AddedFriendshipSummary> onFriendshipAdded = UiRoot.Instance.Dispatcher.OnFriendshipAdded;
			UnityAction<AddedFriendshipSummary> unityAction = (UnityAction<AddedFriendshipSummary>)(object)new UnityAction<T0>(OnFriendshipAdded);
			((UnityEvent<T0>)(object)onFriendshipAdded).AddListener((UnityAction<>)(object)unityAction);
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			int num2 = 0;
			if (system != (UnityEngine.Object)num2)
			{
				Mdl.Systems.System.SystemEvent value = OnGridEditModeStarted;
				system.SystemStartedEvent += value;
			}
			int num3 = 0;
			UnityEvent<bool> onItemSelectorOnOff = UiRoot.Instance.Dispatcher.OnItemSelectorOnOff;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnItemSelectorOnOff);
			((UnityEvent<T0>)(object)onItemSelectorOnOff).AddListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData = _currencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction3);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F1")]
		[Cpp2IlInjected.Address(RVA = "0xAFB380", Offset = "0xAF9D80", VA = "0x180AFB380", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_00e4
			//IL_0053: Expected O, but got I4
			((object)this)._002Ector();
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnSceneChanged;
			int num = 0;
			UnityEvent<AddedFriendshipSummary> onFriendshipAdded = UiRoot.Instance.Dispatcher.OnFriendshipAdded;
			UnityAction<AddedFriendshipSummary> unityAction = (UnityAction<AddedFriendshipSummary>)(object)new UnityAction<T0>(OnFriendshipAdded);
			((UnityEvent<T0>)(object)onFriendshipAdded).RemoveListener((UnityAction<>)(object)unityAction);
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			int num2 = 0;
			if (system != (UnityEngine.Object)num2)
			{
				Mdl.Systems.System.SystemEvent value = OnGridEditModeStarted;
				system.SystemStartedEvent -= value;
			}
			int num3 = 0;
			UnityEvent<bool> onItemSelectorOnOff = UiRoot.Instance.Dispatcher.OnItemSelectorOnOff;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnItemSelectorOnOff);
			((UnityEvent<T0>)(object)onItemSelectorOnOff).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData = _currencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction3);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F2")]
		[Cpp2IlInjected.Address(RVA = "0xAF8EC0", Offset = "0xAF78C0", VA = "0x180AF8EC0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0027, IL_0028
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			HideCurrency();
			DestroyWorldGizmoAndPickupInfo();
			RadialToolMenu radialToolMenu = _radialToolMenu;
			int resetToolOnHide = 0;
			radialToolMenu.Toggle((byte)resetToolOnHide != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60022F3")]
		[Cpp2IlInjected.Address(RVA = "0xAFA5B0", Offset = "0xAF8FB0", VA = "0x180AFA5B0", Slot = "38")]
		public bool ShouldActivateFtue(FtueStep step)
		{
			if ((object)step == null)
			{
				return 0 != 0;
			}
			int num = 0;
			return (object)step != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F4")]
		[Cpp2IlInjected.Address(RVA = "0xAF75E0", Offset = "0xAF5FE0", VA = "0x180AF75E0", Slot = "39")]
		[AsyncStateMachine(typeof(_003CActivateFtue_003Ed__55))]
		public Task ActivateFtue(FtueStep step, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F5")]
		[Cpp2IlInjected.Address(RVA = "0xAFB160", Offset = "0xAF9B60", VA = "0x180AFB160")]
		public void Show()
		{
			//IL_00a6: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			do
			{
				if (!IsVisible)
				{
					int num = 0;
					if (UiRoot.Instance.MainMenuBar.gameObject.activeSelf)
					{
						int num2 = 0;
						GameObject gameObject = UiRoot.Instance.MainMenuBar.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
					}
					UnityEvent onShow = OnShow;
					IsVisible = true;
					onShow?.Invoke();
					return;
				}
				while (!_isReadyToShowCurrency)
				{
				}
				if ((long)(IntPtr)((Queue<T>)(object)_transactions).Dequeue() <= 0L)
				{
					continue;
				}
				int num3 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				if (!flag)
				{
					int num4 = 0;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
					if (!flag2)
					{
						continue;
					}
					int num5 = 0;
					UiRoot instance = UiRoot.Instance;
					int num6 = 0;
					instance.GemGainPickup((RectTransform)num6);
				}
				int num7 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int num8 = 0;
				instance2.CoinGainPickup((RectTransform)num8);
			}
			while (_transactions != null);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022F6")]
		[Cpp2IlInjected.Address(RVA = "0xAF8480", Offset = "0xAF6E80", VA = "0x180AF8480")]
		public void Hide()
		{
			if (IsVisible)
			{
				IsVisible = false;
				OnHide?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022F7")]
		[Cpp2IlInjected.Address(RVA = "0xAFA8B0", Offset = "0xAF92B0", VA = "0x180AFA8B0")]
		private void ShowFriendshipBar(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_0138
			//IL_0037: Expected O, but got I4
			Client client = default(Client);
			Client client2 = default(Client);
			while (addedFriendshipSummary.FriendshipGained > 0)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				Item _003CCharacterItem_003Ek__BackingField = addedFriendshipSummary.CharacterItem;
				Mdl.Characters.Character character = system.GetCharacter(_003CCharacterItem_003Ek__BackingField);
				int num = 0;
				if (character == (UnityEngine.Object)num)
				{
					break;
				}
				Meta.Character metaCharacter = character.MetaCharacter;
				Profile profile = client.Profile;
				int _003CPreviousCharacterFriendship_003Ek__BackingField = addedFriendshipSummary.PreviousCharacterFriendship;
				float prevFriendshipProgress = metaCharacter.GetXpProgression(profile, _003CPreviousCharacterFriendship_003Ek__BackingField);
				Meta.Character metaCharacter2 = character.MetaCharacter;
				Profile profile2 = client2.Profile;
				float newFriendshipProgress = metaCharacter2.GetXpProgression(profile2);
				float[] thresholds = _characterFriendshipBarPrefab.Thresholds;
				Func<float, bool> cpp2il__autoParamName__idx_ = (Func<float, bool>)(object)(Func<T, TResult>)delegate(float threshold)
				{
					if (!(threshold > prevFriendshipProgress))
					{
						int num3 = 0;
					}
					float num4 = newFriendshipProgress;
					/*Error: Unexpected end of block*/;
				};
				bool flag = ((IEnumerable<>)(object)thresholds).Any<float>((Func<, >)(object)cpp2il__autoParamName__idx_);
				int _003CFriendshipSource_003Ek__BackingField = (int)addedFriendshipSummary.FriendshipSource;
				if (1 == 0)
				{
					break;
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				CharacterVisualNodes _003CCharacterVisualNodes_003Ek__BackingField = character.CharacterVisualNodes;
				WorldUI worldCanvas = instance._worldCanvas;
				GameObject headIcon = _003CCharacterVisualNodes_003Ek__BackingField.HeadIcon;
				GameObject infoGizmoPrefab = _characterFriendshipBarPrefab.gameObject;
				CancellationToken cancellationToken = base.CancellationToken;
				object[] array = new object[2];
				if (array != null)
				{
					array[0] = addedFriendshipSummary;
					if (array != null)
					{
						array[1] = character;
						InfoGizmo infoGizmo = worldCanvas.InfoGizmoStart(headIcon, infoGizmoPrefab, cancellationToken, array);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022F8")]
		[Cpp2IlInjected.Address(RVA = "0xAFAD50", Offset = "0xAF9750", VA = "0x180AFAD50")]
		private void ShowFrienshipGainedVFX(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_003c
			if (addedFriendshipSummary.FriendshipGained > 0)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				Item _003CCharacterItem_003Ek__BackingField = addedFriendshipSummary.CharacterItem;
				Mdl.Characters.Character character = system.GetCharacter(_003CCharacterItem_003Ek__BackingField);
				if ((object)character != null)
				{
					FriendshipSource _003CFriendshipSource_003Ek__BackingField = addedFriendshipSummary.FriendshipSource;
					character.FriendshipGained(_003CFriendshipSource_003Ek__BackingField).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022F9")]
		[Cpp2IlInjected.Address(RVA = "0xAFA4F0", Offset = "0xAF8EF0", VA = "0x180AFA4F0")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0041
			//IL_0010: Expected O, but got I4
			ItemSelector itemSelector = ItemSelector;
			int num = 0;
			bool flag = itemSelector != (UnityEngine.Object)num;
			if (!flag)
			{
				_isGamepadHoldAllowed = flag;
				return;
			}
			_isGamepadHoldAllowed = true;
			ItemSelector itemSelector2 = ItemSelector;
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			itemSelector2.SetFocus(focusNavigation);
		}

		[Cpp2IlInjected.Token(Token = "0x60022FA")]
		[Cpp2IlInjected.Address(RVA = "0xAF7C40", Offset = "0xAF6640", VA = "0x180AF7C40")]
		private void DestroyWorldGizmoAndPickupInfo()
		{
			//Discarded unreachable code: IL_0090
			//IL_0016: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			int num = 0;
			WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
			int num2 = 0;
			worldCanvas.DestroyInteractionPreview((GameObject)num2);
			GameObject gameObject = worldCanvas.gameObject;
			int num3 = 0;
			int childCount = gameObject.transform.childCount;
			if (num3 < childCount)
			{
				GameObject gameObject2 = worldCanvas.transform.GetChild(num3).gameObject;
				CurrencyGainInfo component = gameObject2.GetComponent<CurrencyGainInfo>();
				int num4 = 0;
				bool flag = component != (UnityEngine.Object)num4;
				GardeningTaskInfo component2 = gameObject2.GetComponent<GardeningTaskInfo>();
				int num5 = 0;
				bool flag2 = component2 != (UnityEngine.Object)num5;
				UnityEngine.Object.Destroy(gameObject2);
				num3++;
			}
			int num6 = 0;
			UiRoot.Instance.ClearHudCraftingNotif();
		}

		[Cpp2IlInjected.Token(Token = "0x60022FB")]
		[Cpp2IlInjected.Address(RVA = "0xAF7C10", Offset = "0xAF6610", VA = "0x180AF7C10")]
		public void ClearHudItemNotif()
		{
			//Discarded unreachable code: IL_000c
			_hudItemNotif.ClearHudItemNotif();
		}

		[Cpp2IlInjected.Token(Token = "0x60022FC")]
		[Cpp2IlInjected.Address(RVA = "0xAFA4D0", Offset = "0xAF8ED0", VA = "0x180AFA4D0")]
		public void SetCritterQueueNotif(bool enabled)
		{
			//Discarded unreachable code: IL_000d
			_hudItemNotif.UseCritterQueue = enabled;
		}

		[Cpp2IlInjected.Token(Token = "0x60022FD")]
		[Cpp2IlInjected.Address(RVA = "0xAFAFB0", Offset = "0xAF99B0", VA = "0x180AFAFB0")]
		public void ShowQueuedCritterNotifs()
		{
			//Discarded unreachable code: IL_000c
			_hudItemNotif.ShowQueuedCritterNotifs();
		}

		[Cpp2IlInjected.Token(Token = "0x60022FE")]
		[Cpp2IlInjected.Address(RVA = "0xAF86D0", Offset = "0xAF70D0", VA = "0x180AF86D0")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_0015
			OnCurrencyChanged(currencyItem, gained, fromDialog: true);
			_currencyItems.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x60022FF")]
		[Cpp2IlInjected.Address(RVA = "0xAF8060", Offset = "0xAF6A60", VA = "0x180AF8060", Slot = "40")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0045, IL_00a0, IL_00a7, IL_00ae
			//IL_001a: Expected O, but got I4
			//IL_004d: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				ItemSelector itemSelector = ItemSelector;
				int num = 0;
				if (!(itemSelector != (UnityEngine.Object)num))
				{
					RadialToolMenu radialToolMenu = _radialToolMenu;
					if (_buffContent.BuffTip.gameObject.activeSelf)
					{
						BuffContent buffContent = _buffContent;
					}
				}
				else
				{
					itemSelector.Cancel();
				}
				return;
			}
			while (redirectionType != RedirectionType.MainMenuGoToCollection)
			{
			}
			CollectionMenu.CollectionMenuParam collectionMenuParam = new CollectionMenu.CollectionMenuParam();
			CollectionSubMenu collectionSubMenu = (collectionMenuParam.SelectedTab = _collectionReminderSelectedTab);
			HudCollectionReminder collectionReminder = _collectionReminder;
			_collectionReminderSelectedTab = CollectionSubMenu.Memories;
			collectionReminder.Hide();
			int num2 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002300")]
		[Cpp2IlInjected.Address(RVA = "0xAF9480", Offset = "0xAF7E80", VA = "0x180AF9480")]
		public void OnInventoryClicked()
		{
			//Discarded unreachable code: IL_0090, IL_00e0
			//IL_0010: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			ItemSelector itemSelector = ItemSelector;
			int num = 0;
			if (!(itemSelector != (UnityEngine.Object)num))
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					HudGainItemNotif hudItemNotif = _hudItemNotif;
					RectTransform containerClothing = hudItemNotif._containerClothing;
					List<IItemData> notificationData = (List<IItemData>)(object)hudItemNotif.GetNotificationData(containerClothing);
					HudGainItemNotif hudItemNotif2 = _hudItemNotif;
					RectTransform containerCritter = hudItemNotif2._containerCritter;
					List<IItemData> notificationData2 = (List<IItemData>)(object)hudItemNotif2.GetNotificationData(containerCritter);
					HudGainItemNotif hudItemNotif3 = _hudItemNotif;
					RectTransform containerFurniture = hudItemNotif3._containerFurniture;
					List<IItemData> notificationData3 = (List<IItemData>)(object)hudItemNotif3.GetNotificationData(containerFurniture);
					int size = ((List<>)(object)notificationData)._size;
					CatalogRedirect();
				}
				else
				{
					int num3 = 0;
					RedirectionManager redirection = UiRoot.Instance.Redirection;
					CancellationToken cancellationToken = base.CancellationToken;
					int num4 = 0;
					int num5 = 0;
					redirection.RedirectTask(cancellationToken, RedirectionType.MenuInventory, (MenuParam)num5, (PlayerTaskCollider)num4, (ItemFilterData)num4, (string)num4, (Action)num4, (byte)num4 != 0, (byte)num4 != 0, (byte)num4 != 0).FireAndForgetTask();
				}
			}
			else
			{
				itemSelector.Cancel();
				itemSelector.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002301")]
		[Cpp2IlInjected.Address(RVA = "0xAFBC40", Offset = "0xAFA640", VA = "0x180AFBC40")]
		private void WardrobeRedirect()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002302")]
		[Cpp2IlInjected.Address(RVA = "0xAF7710", Offset = "0xAF6110", VA = "0x180AF7710")]
		private void CatalogRedirect()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002303")]
		[Cpp2IlInjected.Address(RVA = "0xAF9770", Offset = "0xAF8170", VA = "0x180AF9770")]
		public void OnMainMenuButtonClicked()
		{
			//IL_002e: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (UiRoot.Instance._menuStack.GetComponent<Canvas>().enabled)
			{
				ItemSelector itemSelector = ItemSelector;
				int num3 = 0;
				if (itemSelector != (UnityEngine.Object)num3)
				{
					throw new NullReferenceException();
				}
				RadialToolMenu radialToolMenu = _radialToolMenu;
				if (_buffContent.BuffTip.gameObject.activeSelf)
				{
					BuffContent buffContent = _buffContent;
					int num4 = 0;
					buffContent.HandleRedirection(RedirectionType.HudBuffTooltipClose, (MenuParam)num4);
				}
				if (TrackingManager.Instance != null)
				{
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
					int num5 = 0;
				}
				int num6 = 0;
				MainMenuTabButton selectedTab = UiRoot.Instance.MainMenuBar.SelectedTab;
				if ((object)selectedTab != null)
				{
					ShortcutDefinition shortcutDefinition = selectedTab.ShortcutDefinition;
				}
				bool flag = default(bool);
				if (!flag)
				{
				}
				int num7 = 0;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				CancellationToken cancellationToken = base.CancellationToken;
				int num8 = 0;
				redirection.RedirectTask(cancellationToken, RedirectionType.MenuQuestLog, (MenuParam)num8, (PlayerTaskCollider)num, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002304")]
		[Cpp2IlInjected.Address(RVA = "0xAF82F0", Offset = "0xAF6CF0", VA = "0x180AF82F0")]
		public void HideBuffTip()
		{
			//Discarded unreachable code: IL_0030
			//IL_002e: Expected O, but got I4
			if (_buffContent.BuffTip.gameObject.activeSelf)
			{
				BuffContent buffContent = _buffContent;
				int num = 0;
				buffContent.HandleRedirection(RedirectionType.HudBuffTooltipClose, (MenuParam)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002305")]
		[Cpp2IlInjected.Address(RVA = "0xAFA630", Offset = "0xAF9030", VA = "0x180AFA630")]
		public void ShowCollectionReminder(CollectionSubMenu selectedTab)
		{
			//Discarded unreachable code: IL_0021
			HudCollectionReminder collectionReminder = _collectionReminder;
			_collectionReminderSelectedTab = selectedTab;
			collectionReminder.CollectionReminderSelectedTab = selectedTab;
			_collectionReminder.Show();
		}

		[Cpp2IlInjected.Token(Token = "0x6002306")]
		[Cpp2IlInjected.Address(RVA = "0xAF8360", Offset = "0xAF6D60", VA = "0x180AF8360")]
		public void HideCollectionReminder()
		{
			//Discarded unreachable code: IL_0015
			//IL_0009: Expected I4, but got I8
			_collectionReminderSelectedTab = CollectionSubMenu.Memories;
			_collectionReminder.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6002307")]
		[Cpp2IlInjected.Address(RVA = "0xAF96D0", Offset = "0xAF80D0", VA = "0x180AF96D0")]
		private void OnItemSelectorOnOff(bool isOpened)
		{
			//Discarded unreachable code: IL_0043
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				OnSomethingOpened();
				int num2 = 0;
				if (UiRoot.Instance.IsControllerConnected(useKeyboardAsController: true))
				{
					SetFocus();
				}
				_toolButton.gameObject.SetActive(isOpened);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002308")]
		[Cpp2IlInjected.Address(RVA = "0xAF9D10", Offset = "0xAF8710", VA = "0x180AF9D10")]
		private void OnSomethingOpened()
		{
			//IL_0026: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			RadialToolMenu radialToolMenu = _radialToolMenu;
			ItemSelector itemSelector = ItemSelector;
			if ((object)itemSelector != null)
			{
				int num = 0;
				if (itemSelector != (UnityEngine.Object)num && itemSelector.isActiveAndEnabled)
				{
					bool flag = default(bool);
					while (flag)
					{
					}
					PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = system.OverrideAllScope());
					throw new NullReferenceException();
				}
			}
			int num2 = 0;
			UiRoot.Instance.UpdateCursorBehaviorForGameplay();
			int num3 = 0;
			_overrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002309")]
		[Cpp2IlInjected.Address(RVA = "0xAF8F20", Offset = "0xAF7920", VA = "0x180AF8F20")]
		private void OnFriendshipAdded(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_009e
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				ShowFriendshipBar(addedFriendshipSummary);
			}
			if (addedFriendshipSummary.FriendshipGained > 0)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				Item _003CCharacterItem_003Ek__BackingField = addedFriendshipSummary.CharacterItem;
				Mdl.Characters.Character character = system.GetCharacter(_003CCharacterItem_003Ek__BackingField);
				if ((object)character != null)
				{
					FriendshipSource _003CFriendshipSource_003Ek__BackingField = addedFriendshipSummary.FriendshipSource;
					character.FriendshipGained(_003CFriendshipSource_003Ek__BackingField).FireAndForgetTask();
				}
			}
			if (addedFriendshipSummary.PlayerLevelUp || addedFriendshipSummary.CharacterLevelUp)
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				uint num3 = num3 + 20;
				num3 += num3;
				if ((object)instance2 == null)
				{
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600230A")]
		[Cpp2IlInjected.Address(RVA = "0xAFAE90", Offset = "0xAF9890", VA = "0x180AFAE90")]
		[AsyncStateMachine(typeof(_003CShowLevelUp_003Ed__77))]
		private Task ShowLevelUp(AddedFriendshipSummary addedFriendshipSummary)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600230B")]
		[Cpp2IlInjected.Address(RVA = "0xAF9C60", Offset = "0xAF8660", VA = "0x180AF9C60")]
		private void OnSceneChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0028
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top == null)
				{
				}
			}
			RefreshCurrencies();
		}

		[Cpp2IlInjected.Token(Token = "0x600230C")]
		[Cpp2IlInjected.Address(RVA = "0xAF9EF0", Offset = "0xAF88F0", VA = "0x180AF9EF0")]
		private void RefreshCurrencies()
		{
			//Discarded unreachable code: IL_0044
			//IL_0033: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			StoreEnvironment component = gameObject.GetComponent<StoreEnvironment>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				HideCurrency();
			}
			else
			{
				ShowCurrency();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600230D")]
		[Cpp2IlInjected.Address(RVA = "0xAF9280", Offset = "0xAF7C80", VA = "0x180AF9280")]
		private void OnGridEditModeStarted(Mdl.Systems.System system)
		{
			//IL_002b: Expected O, but got I4
			if ((object)system == null)
			{
			}
			int num = 0;
			if ((object)system != null)
			{
				CatalogMenuParam catalogMenuParam = new CatalogMenuParam();
				if (catalogMenuParam == null)
				{
				}
				int num2 = 0;
				bool forceOpenCatalog = default(bool);
				catalogMenuParam.ForceOpenCatalog = forceOpenCatalog;
				catalogMenuParam.IsInEditMode = true;
				catalogMenuParam.ItemFilterData = (ItemFilterData)num2;
				int num3 = 0;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				int num4 = 0;
				CancellationToken cancellationToken = base.CancellationToken;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600230E")]
		[Cpp2IlInjected.Address(RVA = "0xAF84B0", Offset = "0xAF6EB0", VA = "0x180AF84B0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_00df
			//IL_002c: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ItemSelector itemSelector = ItemSelector;
				int num2 = 0;
				if (itemSelector != (UnityEngine.Object)num2 && ItemSelector.gameObject.activeSelf)
				{
					_isGamepadHoldAllowed = true;
					ItemSelector itemSelector2 = ItemSelector;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					itemSelector2.SetFocus(focusNavigation);
				}
				_isGamepadHoldAllowed = false;
				_radialToolMenu.StopAllCoroutines();
				RadialToolMenu radialToolMenu = _radialToolMenu;
				int num3 = 0;
				ControlType currentController = UiRoot.Instance.GetCurrentController(useKeyboardAsController: true);
			}
			_radialToolMenu.StopAllCoroutines();
			RadialToolMenu radialToolMenu2 = _radialToolMenu;
			int num4 = 0;
			ControlType currentController2 = UiRoot.Instance.GetCurrentController(useKeyboardAsController: true);
			SetFocus();
			if (_questTracker.isActiveAndEnabled)
			{
				_questTracker.Show();
			}
			_useToolShortcut.TransformToPreset();
		}

		[Cpp2IlInjected.Token(Token = "0x600230F")]
		[Cpp2IlInjected.Address(RVA = "0xAF89A0", Offset = "0xAF73A0", VA = "0x180AF89A0")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002310")]
		[Cpp2IlInjected.Address(RVA = "0xAFC190", Offset = "0xAFAB90", VA = "0x180AFC190")]
		public HudMenu()
		{
			//Discarded unreachable code: IL_003d
			//IL_0036: Expected I4, but got I8
			List<Item> currencyItemsData = (List<Item>)(object)new List<T>();
			int num = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			_currencyItemsData = currencyItemsData;
			_transactions = (Queue<(Item currencyItem, int amount)>)(object)new Queue<T>();
			_checkVisibleRate = 0.5f;
			_collectionReminderSelectedTab = CollectionSubMenu.Memories;
			base._002Ector();
		}
	}
}
