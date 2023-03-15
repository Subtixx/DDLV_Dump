using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Mdl.Activities;
using Mdl.Avatar;
using Mdl.Cameras;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.RewiredConsts;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using Rewired;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005B8")]
	public class BackpackContent : InventoryContent, IHasSFX
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20005B9")]
		public class RealmItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FE8")]
			[SerializeField]
			[ItemID]
			private int _sceneItemID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FE9")]
			public UnityEngine.AddressableAssets.AssetReferenceTexture Icon;

			[Cpp2IlInjected.Token(Token = "0x170005CF")]
			public Item SceneItem
			{
				[Cpp2IlInjected.Token(Token = "0x60025C1")]
				[Cpp2IlInjected.Address(RVA = "0x8D7F50", Offset = "0x8D6950", VA = "0x1808D7F50")]
				get
				{
					long num = Convert.ToInt64((uint)_sceneItemID);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60025C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RealmItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20005BA")]
		public enum ActionType
		{
			[Cpp2IlInjected.Token(Token = "0x4001FEB")]
			eat,
			[Cpp2IlInjected.Token(Token = "0x4001FEC")]
			open,
			[Cpp2IlInjected.Token(Token = "0x4001FED")]
			use,
			[Cpp2IlInjected.Token(Token = "0x4001FEE")]
			drop,
			[Cpp2IlInjected.Token(Token = "0x4001FEF")]
			split,
			[Cpp2IlInjected.Token(Token = "0x4001FF0")]
			transfer,
			[Cpp2IlInjected.Token(Token = "0x4001FF1")]
			expand
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001FB5")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 144;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4001FB6")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 145;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001FB7")]
		[SerializeField]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredActionIdGP = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001FB8")]
		public RedDot openButtonNotification;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001FB9")]
		public Transform BackgroundCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001FBA")]
		public ItemFilterData TransferItemFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001FBB")]
		private List<(Item item, ItemState state, int amount, bool canSell)> listBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001FBC")]
		[SerializeField]
		private TextBase tf_emptyBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001FBD")]
		[SerializeField]
		private ListBase _listCurrencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001FBE")]
		[SerializeField]
		private ActionType[] _allowedActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001FBF")]
		[SerializeField]
		[FormerlySerializedAs("_eatMealTask")]
		private PlayerTaskDefinition _eatItemTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001FC0")]
		[SerializeField]
		private PlayerTaskDefinition _consumeConsummableTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001FC1")]
		[SerializeField]
		private PlayerTaskDefinition _consumeBuffElixirTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001FC2")]
		[SerializeField]
		private RectTransform _expandButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001FC3")]
		public GridEditMode _gridEditModeSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001FC4")]
		private List<BackpackActionList.ActionItemData> _selectedItemActions = (List<BackpackActionList.ActionItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001FC5")]
		public Dictionary<ActionType, System.Action> CustomActions = (Dictionary<ActionType, System.Action>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001FC6")]
		public List<int> ShowEmptyIndexes = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001FC9")]
		public IEnumerable<int> UnavailablePositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001FCA")]
		[Header("Audio")]
		public AK.Wwise.Event openBackpackSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001FCB")]
		public AK.Wwise.Event closeBackpackSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001FCC")]
		public AK.Wwise.Event eatOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001FCD")]
		public AK.Wwise.Event dropOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001FCE")]
		public AK.Wwise.Event failDropOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001FCF")]
		public AK.Wwise.Event useMemoryShardOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001FD0")]
		public AK.Wwise.Event splitOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001FD1")]
		public AK.Wwise.Event transferOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001FD2")]
		public AK.Wwise.Event openOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001FD3")]
		public AK.Wwise.Event itemOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001FD4")]
		public AK.Wwise.Event purchaseSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001FD5")]
		public Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001FD6")]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001FD7")]
		[SerializeField]
		[Space]
		private RewardSpawnAnimationData _dropItemSpawnAnimationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001FD8")]
		[SerializeField]
		private AssetReference _purchaseConfirmationPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001FD9")]
		[SerializeField]
		private bool _isInventoryFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001FDA")]
		public UnityEvent OnUpgradeSuccess;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001FDB")]
		[SerializeField]
		[Header("Realm")]
		private List<RealmItem> _realmItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001FDC")]
		private CancellationTokenSource cameraMovementCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001FDD")]
		private UpgradeBackpackItemData _nextBackpackUpgrade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001FDE")]
		private NotEnoughCurrencyArgs _notEnoughCurrencyArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001FDF")]
		private List<Item> _currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001FE0")]
		private Toolbox.TemporarySwitchToolScope removeToolScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4001FE1")]
		private Coroutine _waitForSlidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4001FE2")]
		private bool _doneSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
		[Cpp2IlInjected.Token(Token = "0x4001FE3")]
		private bool _expandButtonSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4001FE4")]
		private CameraModifierCollection cameraModifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4001FE5")]
		private Coroutine _instantiateSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4001FE6")]
		private InventoryMenu _inventoryMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4001FE7")]
		private BackpackSlotInventoryItem _inventoryItem;

		[Cpp2IlInjected.Token(Token = "0x170005CC")]
		public GridEditMode GridEditModeSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6002578")]
			[Cpp2IlInjected.Address(RVA = "0x738AB0", Offset = "0x7374B0", VA = "0x180738AB0")]
			get
			{
				return _gridEditModeSystem;
			}
			[Cpp2IlInjected.Token(Token = "0x6002579")]
			[Cpp2IlInjected.Address(RVA = "0x8987C0", Offset = "0x8971C0", VA = "0x1808987C0")]
			set
			{
				//Discarded unreachable code: IL_0023
				_gridEditModeSystem = value;
				GridEditMode gridEditModeSystem = _gridEditModeSystem;
				EventHandler value2 = FakeBackpackInventoryChanged;
				gridEditModeSystem.CommandStackChangedEvent += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x128"), Cpp2IlInjected.Token(Token = "0x4001FC7")]
		private bool ForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600257A")]
			[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896900", VA = "0x180897F00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600257B")]
			[Cpp2IlInjected.Address(RVA = "0x8987B0", Offset = "0x8971B0", VA = "0x1808987B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005CE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x129"), Cpp2IlInjected.Token(Token = "0x4001FC8")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x600257C")]
			[Cpp2IlInjected.Address(RVA = "0x897F10", Offset = "0x896910", VA = "0x180897F10", Slot = "21")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600257D")]
			[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860", Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600257E")]
		[Cpp2IlInjected.Address(RVA = "0x8958A0", Offset = "0x8942A0", VA = "0x1808958A0")]
		private void RegisterEditModeListener()
		{
			//Discarded unreachable code: IL_001c
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			EventHandler value = FakeBackpackInventoryChanged;
			gridEditModeSystem.CommandStackChangedEvent += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600257F")]
		[Cpp2IlInjected.Address(RVA = "0x896730", Offset = "0x895130", VA = "0x180896730")]
		private void Start()
		{
			//Discarded unreachable code: IL_00a7
			//IL_0034: Expected O, but got I4
			LoopScrollRect list = _list;
			int num = 0;
			base.DoneWithSlotInstance = false;
			PoolManager poolManager = (list.ExternalPool = UiRoot.Instance.InventorySlotPool);
			InventoryDragAndDrop inventoryDragAndDrop = _inventoryDragAndDrop;
			int num2 = 0;
			if (inventoryDragAndDrop != (UnityEngine.Object)num2)
			{
				InventoryDragAndDrop inventoryDragAndDrop2 = _inventoryDragAndDrop;
				int num3 = (inventoryDragAndDrop2.RewiredAxisX = RewiredAxisX);
				InventoryDragAndDrop inventoryDragAndDrop3 = _inventoryDragAndDrop;
				int num4 = (inventoryDragAndDrop3.RewiredAxisY = RewiredAxisY);
				InventoryDragAndDrop inventoryDragAndDrop4 = _inventoryDragAndDrop;
				int num5 = (inventoryDragAndDrop4.actionID = RewiredActionIdGP);
			}
			if (SlidingPanel.isOpened)
			{
				BackgroundCenter.parent.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002580")]
		[Cpp2IlInjected.Address(RVA = "0x88E6D0", Offset = "0x88D0D0", VA = "0x18088E6D0", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_0129
			//IL_0016: Expected O, but got I4
			base.Awake();
			ItemAmountSelector itemAmountSelector = ItemAmountSelector;
			int num = 0;
			if (itemAmountSelector == (UnityEngine.Object)num)
			{
				_isInventoryFull = true;
			}
			List<(Item, ItemState, int, bool)> list = (listBackpack = (List<(Item item, ItemState state, int amount, bool canSell)>)(object)Enumerable.ToList<(Item, ItemState, int, bool)>(ContainerInventoryExtension.GetItemsToDisplay(SystemRoot.Instance.Client.Profile.Backpack)));
			RefreshNotification();
			ProfileEventDispatcher dispatcher = base.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value = OnMissionSlotUpdated;
			dispatcher.OnMissionSlotUpdated += value;
			ListBase.ListEvents onItemData = _listCurrencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			SlidingPanel slidingPanel = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value2 = onBackPackShow;
			slidingPanel.OnOpen += value2;
			SlidingPanel slidingPanel2 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value3 = OnOverShootFinished;
			slidingPanel2.OnOvershootFinished += value3;
			SlidingPanel slidingPanel3 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value4 = OnBackpackEnabled;
			slidingPanel3.OnActivateOpenContent += value4;
			SlidingPanel slidingPanel4 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value5 = onBackPackHide;
			slidingPanel4.OnClose += value5;
			UnityEvent onUpgradeSuccess = OnUpgradeSuccess;
			UnityAction call = SetExpandButtonPos;
			onUpgradeSuccess.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002581")]
		[Cpp2IlInjected.Address(RVA = "0x890B50", Offset = "0x88F550", VA = "0x180890B50", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_00e5
			//IL_0016: Expected O, but got I4
			base.OnDestroy();
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			int num = 0;
			if (gridEditModeSystem != (UnityEngine.Object)num)
			{
				GridEditMode gridEditModeSystem2 = _gridEditModeSystem;
				EventHandler value = FakeBackpackInventoryChanged;
				gridEditModeSystem2.CommandStackChangedEvent -= value;
			}
			SlidingPanel slidingPanel = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value2 = onBackPackShow;
			slidingPanel.OnOpen -= value2;
			SlidingPanel slidingPanel2 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value3 = OnOverShootFinished;
			slidingPanel2.OnOvershootFinished -= value3;
			SlidingPanel slidingPanel3 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value4 = OnBackpackEnabled;
			slidingPanel3.OnActivateOpenContent -= value4;
			SlidingPanel slidingPanel4 = SlidingPanel;
			SlidingPanel.SlidingPanelEvent value5 = onBackPackHide;
			slidingPanel4.OnClose -= value5;
			UnityEvent onUpgradeSuccess = OnUpgradeSuccess;
			UnityAction call = SetExpandButtonPos;
			onUpgradeSuccess.RemoveListener(call);
			Coroutine instantiateSlot = _instantiateSlot;
			if (instantiateSlot != null)
			{
				StopCoroutine(instantiateSlot);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002582")]
		[Cpp2IlInjected.Address(RVA = "0x891060", Offset = "0x88FA60", VA = "0x180891060")]
		private void OnEnable()
		{
			_expandButtonSetup = false;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
			_itemInfo.Hide();
			int _003C_003E1__state = default(int);
			_003CWaitForSlidingPanel_003Ed__120 _003CWaitForSlidingPanel_003Ed__ = new _003CWaitForSlidingPanel_003Ed__120(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForSlidingPanel_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_waitForSlidingPanel = StartCoroutine(_003CWaitForSlidingPanel_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002583")]
		[Cpp2IlInjected.Address(RVA = "0x890DD0", Offset = "0x88F7D0", VA = "0x180890DD0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0052
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num && SystemRoot.Instance.MetaClient != null)
			{
				Client client = default(Client);
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
				_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value;
			}
			Coroutine waitForSlidingPanel = _waitForSlidingPanel;
			if (waitForSlidingPanel != null)
			{
				StopCoroutine(waitForSlidingPanel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002584")]
		[Cpp2IlInjected.Address(RVA = "0x8907B0", Offset = "0x88F1B0", VA = "0x1808907B0")]
		public void OnCloseShortcutTriggered()
		{
			//IL_0026: Expected O, but got I4
			if (!ItemActionList.gameObject.activeSelf)
			{
				InventorySortPanel inventorySortPanel = InventorySortPanel;
				int num = 0;
				if (inventorySortPanel != (UnityEngine.Object)num)
				{
					InventorySortPanel inventorySortPanel2 = InventorySortPanel;
					if (inventorySortPanel2.IsOpen)
					{
						inventorySortPanel2.Close();
						return;
					}
				}
				if (!_isInventoryFull && ItemAmountSelector.gameObject.activeSelf)
				{
					GameObject gameObject = ItemAmountSelector.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					_itemInfo.Hide();
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						SetFocus();
					}
				}
				else
				{
					SlidingPanel.Close();
				}
				return;
			}
			GameObject gameObject2 = ItemActionList.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_itemInfo.Hide();
			ItemActionList.ResetButtonClickedOn();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002585")]
		[Cpp2IlInjected.Address(RVA = "0x8909B0", Offset = "0x88F3B0", VA = "0x1808909B0")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002586")]
		[Cpp2IlInjected.Address(RVA = "0x894C50", Offset = "0x893650", VA = "0x180894C50")]
		private void OnMissionSlotUpdated(MissionSlotClass SlotClass, int SlotId, MissionItemData missionData, SlotUpdatedReason reason, List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0025
			Item invalid = Item.Invalid;
			if (!SlidingPanel.isOpened)
			{
				ForceUpdate = true;
			}
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002587")]
		[Cpp2IlInjected.Address(RVA = "0x890980", Offset = "0x88F380", VA = "0x180890980")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_000c
			_listCurrencyItems.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002588")]
		[Cpp2IlInjected.Address(RVA = "0x8905F0", Offset = "0x88EFF0", VA = "0x1808905F0")]
		public void OnCatalogButtonClicked()
		{
			//Discarded unreachable code: IL_0061
			//IL_0039: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top == null)
			{
				return;
			}
			int num3 = 0;
			if (top != null)
			{
				GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
				int num4 = 0;
				if (system != (UnityEngine.Object)num4 && system.CanStartEditMode)
				{
					OnCloseShortcutTriggered();
					int num5 = 0;
					VibrationsManager.TriggerSelection();
					int num6 = 0;
					system.StartSystem((ISystemData)num6);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002589")]
		[Cpp2IlInjected.Address(RVA = "0x895070", Offset = "0x893A70", VA = "0x180895070")]
		public void OnWardrobeButtonClicked()
		{
			//Discarded unreachable code: IL_00bb
			//IL_0052: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top == null)
			{
				return;
			}
			int num3 = 0;
			int num4 = 0;
			if (top != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					Toolbox.TemporarySwitchToolScope scope = removeToolScope;
					int num5 = 0;
					removeToolScope = (Toolbox.TemporarySwitchToolScope)num5;
					MenuParam menuParam = new MenuParam();
					System.Action action = (menuParam.OnPopAction = delegate
					{
					});
				}
				int num6 = 0;
				VibrationsManager.TriggerSelection();
				OnCloseShortcutTriggered();
				int num7 = 0;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				CancellationToken cancellationToken = CancellationToken;
				redirection.RedirectTask(cancellationToken, RedirectionType.MenuWardrobe, (MenuParam)num4, (PlayerTaskCollider)num4, (ItemFilterData)num4, (string)num4, (System.Action)num4, (byte)num4 != 0, (byte)num4 != 0, (byte)num4 != 0).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600258A")]
		[Cpp2IlInjected.Address(RVA = "0x894E40", Offset = "0x893840", VA = "0x180894E40")]
		public void OnPhoneButtonClicked()
		{
			//Discarded unreachable code: IL_006b
			//IL_0065: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				int num4 = 0;
				if (top != null)
				{
					int num5 = 0;
					VibrationsManager.TriggerSelection();
					int num6 = 0;
					RedirectionManager redirection = UiRoot.Instance.Redirection;
					CancellationToken cancellationToken = CancellationToken;
					int num7 = 0;
					redirection.RedirectTask(cancellationToken, RedirectionType.MenuPhone, (MenuParam)num7, (PlayerTaskCollider)num4, (ItemFilterData)num4, (string)num4, (System.Action)num4, (byte)num4 != 0, (byte)num4 != 0, (byte)num4 != 0).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600258B")]
		[Cpp2IlInjected.Address(RVA = "0x895730", Offset = "0x894130", VA = "0x180895730")]
		private void RefreshNotification()
		{
			//Discarded unreachable code: IL_004a
			RedDot redDot = openButtonNotification;
			if ((object)redDot == null)
			{
				return;
			}
			GameObject gameObject = redDot.gameObject;
			List<(Item, ItemState, int, bool)> cpp2il__autoParamName__idx_ = listBackpack;
			Func<(Item, ItemState, int, bool), bool> _003C_003E9__75_ = _003C_003Ec._003C_003E9__75_0;
			if (_003C_003E9__75_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000e
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					LootPresentItemData lootPresentItemData = default(LootPresentItemData);
					return lootPresentItemData != null;
				};
			}
			bool active = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<(Item, ItemState, int, bool)>((Func<, >)(object)_003C_003E9__75_);
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x600258C")]
		[Cpp2IlInjected.Address(RVA = "0x890550", Offset = "0x88EF50", VA = "0x180890550")]
		private void OnBackpackEnabled()
		{
			LoopScrollRect list = _list;
			if (!ForceUpdate && list.totalCount > 0)
			{
				list.RefreshCells();
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				return;
			}
			IEnumerator routine = InstanciateSlot();
			Coroutine coroutine = (_instantiateSlot = StartCoroutine(routine));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600258D")]
		[Cpp2IlInjected.Address(RVA = "0x898340", Offset = "0x896D40", VA = "0x180898340")]
		private void onBackPackShow()
		{
			//Discarded unreachable code: IL_00e7
			//IL_0066: Expected O, but got I4
			int num = 0;
			InventoryMenu inventoryMenu = (_inventoryMenu = UiRoot.Instance._menuStack.GetMenu<InventoryMenu>());
			AK.Wwise.Event @event = openBackpackSfx;
			GameObject gameObject = base.gameObject;
			uint num2 = @event.Post(gameObject);
			TemporaryCameraTransition component = SystemRoot.Instance._playerCamera.GetComponent<TemporaryCameraTransition>();
			if ((object)component != null)
			{
				int force = 0;
				component.StartTransition((byte)force != 0);
			}
			InventoryMenu componentInParent = GetComponentInParent<InventoryMenu>();
			int num3 = 0;
			if (componentInParent != (UnityEngine.Object)num3)
			{
				CancellationToken token = cameraMovementCTS.Token;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			if ((long)_currencyItems == 0)
			{
				List<Item> currencyItems = (List<Item>)(object)new List<T>();
				int num7 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				int num8 = 0;
				Item dreamDustCurrencyItem = CurrencyItem.DreamDustCurrencyItem;
				_currencyItems = currencyItems;
				List<Item> currencyItems2 = _currencyItems;
				ListBase listCurrencyItems = _listCurrencyItems;
				int num9 = (listCurrencyItems.TotalCount = ((List<>)(object)currencyItems2)._size);
				LayoutRebuilder.ForceRebuildLayoutImmediate(_listCurrencyItems.m_Content);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600258E")]
		[Cpp2IlInjected.Address(RVA = "0x894DB0", Offset = "0x8937B0", VA = "0x180894DB0")]
		private void OnOverShootFinished()
		{
			int _003C_003E1__state = default(int);
			_003CInstanciateSlot_003Ed__79 _003CInstanciateSlot_003Ed__ = new _003CInstanciateSlot_003Ed__79(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInstanciateSlot_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_instantiateSlot = StartCoroutine(_003CInstanciateSlot_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600258F")]
		[Cpp2IlInjected.Address(RVA = "0x8903B0", Offset = "0x88EDB0", VA = "0x1808903B0")]
		[IteratorStateMachine(typeof(_003CInstanciateSlot_003Ed__79))]
		private IEnumerator InstanciateSlot()
		{
			int _003C_003E1__state = default(int);
			_003CInstanciateSlot_003Ed__79 _003CInstanciateSlot_003Ed__ = new _003CInstanciateSlot_003Ed__79(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInstanciateSlot_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002590")]
		[Cpp2IlInjected.Address(RVA = "0x897F20", Offset = "0x896920", VA = "0x180897F20")]
		private void onBackPackHide()
		{
			//Discarded unreachable code: IL_0174
			//IL_0030: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			//IL_0173: Expected O, but got I4
			AK.Wwise.Event @event = closeBackpackSfx;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			ItemAmountSelector itemAmountSelector = ItemAmountSelector;
			int num2 = 0;
			if (itemAmountSelector != (UnityEngine.Object)num2)
			{
				GameObject gameObject2 = ItemAmountSelector.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
			}
			BackpackActionList itemActionList = ItemActionList;
			int num3 = 0;
			if (itemActionList != (UnityEngine.Object)num3)
			{
				GameObject gameObject3 = ItemActionList.gameObject;
				int active2 = 0;
				gameObject3.SetActive((byte)active2 != 0);
				ItemActionList.ResetButtonClickedOn();
			}
			InventorySortPanel inventorySortPanel = InventorySortPanel;
			int num4 = 0;
			if (inventorySortPanel != (UnityEngine.Object)num4)
			{
				InventorySortPanel.Close();
			}
			_inventoryDragAndDrop?.Kill();
			if (MenuNavigation.FocusNavigation._focusedElement != null)
			{
				FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
				int num5 = 0;
				focusNavigation.FocusedElement = (ISupportsFocusNavigation)num5;
			}
			int num6 = 0;
			base.FocusedElement = (FocusNavigationElement)num6;
			TemporaryCameraTransition cameraTransition = SystemRoot.Instance._playerCamera.GetComponent<TemporaryCameraTransition>();
			int num7 = 0;
			InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
			int num8 = 0;
			if (!(menu == (UnityEngine.Object)num8))
			{
				TemporaryCameraTransition temporaryCameraTransition = cameraTransition;
				if ((object)temporaryCameraTransition == null)
				{
					goto IL_0163;
				}
				temporaryCameraTransition.EndTransition(1f);
			}
			CancellationToken token = cameraMovementCTS.Token;
			ResetCamera(token).FireAndForgetTask();
			goto IL_0163;
			IL_0163:
			bool flag = default(bool);
			if (flag)
			{
				int num9 = 0;
				removeToolScope = (Toolbox.TemporarySwitchToolScope)num9;
			}
			[Cpp2IlInjected.Token(Token = "0x60025D7")]
			[Cpp2IlInjected.Address(RVA = "0x8E52B0", Offset = "0x8E3CB0", VA = "0x1808E52B0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass80_0._003C_003ConBackPackHide_003Eg__ResetCamera_007C0_003Ed))]
			Task ResetCamera(CancellationToken ct)
			{
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002591")]
		[Cpp2IlInjected.Address(RVA = "0x896A60", Offset = "0x895460", VA = "0x180896A60")]
		private void UpdateBackpack(IInventory inventory, Item item, int amount, bool moved = false, int index = -1)
		{
			//Discarded unreachable code: IL_0034
			do
			{
				int[] array = new int[1];
				if (!SlidingPanel.isOpened)
				{
					ForceUpdate = true;
				}
			}
			while (!SlidingPanel.isOpened);
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002592")]
		[Cpp2IlInjected.Address(RVA = "0x896B90", Offset = "0x895590", VA = "0x180896B90")]
		private void UpdateBackpack(IInventory inventory, Item item, int amount, bool moved, int[] indexes)
		{
			//Discarded unreachable code: IL_001e
			if (!SlidingPanel.isOpened)
			{
				ForceUpdate = true;
			}
			else
			{
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002593")]
		[Cpp2IlInjected.Address(RVA = "0x890290", Offset = "0x88EC90", VA = "0x180890290")]
		[AsyncStateMachine(typeof(_003CInitializeBackpackCamera_003Ed__83))]
		private Task InitializeBackpackCamera(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002594")]
		[Cpp2IlInjected.Address(RVA = "0x8965E0", Offset = "0x894FE0", VA = "0x1808965E0")]
		private void StartHidingObstructors()
		{
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			GameObject _003CgameObject_003Ek__BackingField = SystemRoot.Instance._avatar.gameObject;
			CameraModifierCollection cameraModifierCollection = (cameraModifiers = playerCamera.StartModifier<HideObstructorsForCutscene>(_003CgameObject_003Ek__BackingField));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002595")]
		[Cpp2IlInjected.Address(RVA = "0x896850", Offset = "0x895250", VA = "0x180896850")]
		private void StopHidingObstructors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002596")]
		[Cpp2IlInjected.Address(RVA = "0x88F840", Offset = "0x88E240", VA = "0x18088F840", Slot = "7")]
		protected override void DoSetFocus()
		{
			//Discarded unreachable code: IL_010d
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			MenuNavigation menuNavigation = MenuNavigation;
			int num = 0;
			if (menuNavigation == (UnityEngine.Object)num)
			{
				return;
			}
			FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
			int num2 = 0;
			bool flag = focusNavigation == (UnityEngine.Object)num2;
			if (flag)
			{
				return;
			}
			if (_isInventoryFull == flag && ItemAmountSelector.gameObject.activeSelf)
			{
				MenuNavigation menuNavigation2 = MenuNavigation;
				ItemAmountSelector itemAmountSelector = ItemAmountSelector;
				FocusNavigation focusNavigation2 = menuNavigation2.FocusNavigation;
				itemAmountSelector.SetFocus(focusNavigation2);
				return;
			}
			if (ItemActionList.gameObject.activeSelf && ItemActionList._actionList.m_Content.childCount > 0)
			{
				MenuNavigation menuNavigation3 = MenuNavigation;
				BackpackActionList itemActionList = ItemActionList;
				FocusNavigation focusNavigation3 = menuNavigation3.FocusNavigation;
				itemActionList.SetFocus(focusNavigation3);
				return;
			}
			int num3 = 0;
			if (focusNavigation != (UnityEngine.Object)num3 && focusNavigation.MinInterval != 0f)
			{
				return;
			}
			int num4 = 0;
			int num5 = default(int);
			while (num5 <= 0)
			{
			}
			int num6 = 0;
			bool flag2 = default(bool);
			if (focusNavigation != (UnityEngine.Object)num6 && flag2)
			{
				int num7 = 0;
				BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
				if (backpackSlotInventoryItem != (UnityEngine.Object)num7)
				{
					int _003CItemIndex_003Ek__BackingField = ((BackpackInventoryItem)backpackSlotInventoryItem).ItemIndex;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002597")]
		[Cpp2IlInjected.Address(RVA = "0x894A10", Offset = "0x893410", VA = "0x180894A10", Slot = "12")]
		protected override void OnKeyholeChanged(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			//Discarded unreachable code: IL_002b
			Item invalid = Item.Invalid;
			if (!SlidingPanel.isOpened)
			{
				ForceUpdate = true;
			}
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
			ClearFocusedElement();
		}

		[Cpp2IlInjected.Token(Token = "0x6002598")]
		[Cpp2IlInjected.Address(RVA = "0x894B00", Offset = "0x893500", VA = "0x180894B00", Slot = "13")]
		protected override void OnKeyholeItemMoved(Keyhole keyhole)
		{
			//Discarded unreachable code: IL_002b
			Item invalid = Item.Invalid;
			if (!SlidingPanel.isOpened)
			{
				ForceUpdate = true;
			}
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
			ClearFocusedElement();
		}

		[Cpp2IlInjected.Token(Token = "0x6002599")]
		[Cpp2IlInjected.Address(RVA = "0x891000", Offset = "0x88FA00", VA = "0x180891000", Slot = "19")]
		public override void OnDropFailed()
		{
			//IL_001b: Expected O, but got I4
			BackpackSlotInventoryItem inventoryItem = _inventoryItem;
			if ((object)inventoryItem != null)
			{
				FocusNavigationElement component = inventoryItem.GetComponent<FocusNavigationElement>();
			}
			int num = 0;
			RefreshFocusedItem((FocusNavigationElement)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600259A")]
		[Cpp2IlInjected.Address(RVA = "0x891A20", Offset = "0x890420", VA = "0x180891A20", Slot = "14")]
		protected override void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_002d
			if (inventory != null && inventory != null)
			{
				if (!SlidingPanel.isOpened)
				{
					ForceUpdate = true;
				}
				int ignoreSelected = 0;
				RefreshAllSelectedState((byte)ignoreSelected != 0);
			}
			ClearFocusedElement();
		}

		[Cpp2IlInjected.Token(Token = "0x600259B")]
		[Cpp2IlInjected.Address(RVA = "0x892FE0", Offset = "0x8919E0", VA = "0x180892FE0", Slot = "15")]
		protected override void OnItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_002d
			if (inventory != null && inventory != null)
			{
				if (!SlidingPanel.isOpened)
				{
					ForceUpdate = true;
				}
				int ignoreSelected = 0;
				RefreshAllSelectedState((byte)ignoreSelected != 0);
			}
			ClearFocusedElement();
		}

		[Cpp2IlInjected.Token(Token = "0x600259C")]
		[Cpp2IlInjected.Address(RVA = "0x892B00", Offset = "0x891500", VA = "0x180892B00", Slot = "16")]
		protected override void OnItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0086: Expected I4, but got I8
			//IL_00b5: Expected I4, but got I8
			ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.Backpack;
			bool flag = source == backpack;
			ContainerInventory backpack2 = SystemRoot.Instance.MetaClient.profile.Backpack;
			bool flag2 = destination == backpack2;
			if (flag == flag2)
			{
				if (!flag)
				{
					if (!flag2)
					{
						goto IL_00e0;
					}
					Client client = default(Client);
					ContainerInventory backpack3 = client.profile.Backpack;
					if (!SlidingPanel.isOpened)
					{
						goto IL_00d9;
					}
				}
				Client client2 = default(Client);
				ContainerInventory backpack4 = client2.profile.Backpack;
				int amount = 0;
				Item invalid = Item.Invalid;
				ulong num = default(ulong);
				UpdateBackpack(backpack4, invalid, amount, (byte)num != 0, sourcePosition);
			}
			ContainerInventory backpack5 = SystemRoot.Instance.MetaClient.profile.Backpack;
			int amount2 = 0;
			Item invalid2 = Item.Invalid;
			ulong num2 = default(ulong);
			UpdateBackpack(backpack5, invalid2, amount2, (byte)num2 != 0, sourcePosition);
			ContainerInventory backpack6 = SystemRoot.Instance.MetaClient.profile.Backpack;
			if (!SlidingPanel.isOpened)
			{
				goto IL_00d9;
			}
			goto IL_00e0;
			IL_00e0:
			ClearFocusedElement();
			return;
			IL_00d9:
			ForceUpdate = true;
			goto IL_00e0;
		}

		[Cpp2IlInjected.Token(Token = "0x600259D")]
		[Cpp2IlInjected.Address(RVA = "0x891290", Offset = "0x88FC90", VA = "0x180891290", Slot = "18")]
		protected override void OnInventoryChanged(IInventory inventory, Item item, int amount, bool moved = false, [System.Runtime.InteropServices.Optional] int[] indexes)
		{
			//Discarded unreachable code: IL_01a9
			//IL_0182: Expected O, but got I4
			ForceUpdate = false;
			if (inventory != null)
			{
				ContainerInventory backpack = SystemRoot.Instance.Client.Profile.Backpack;
				if (inventory != backpack)
				{
					return;
				}
			}
			List<(Item, ItemState, int, bool)> list = (listBackpack = (List<(Item item, ItemState state, int amount, bool canSell)>)(object)Enumerable.ToList<(Item, ItemState, int, bool)>(ContainerInventoryExtension.GetItemsToDisplay(SystemRoot.Instance.Client.Profile.Backpack)));
			int num = ((List<>)(object)listBackpack)._size;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<UpgradeBackpackItemData, int> func = default(Func<UpgradeBackpackItemData, int>);
			if (_003C_003Ec._003C_003E9__93_0 == null)
			{
				func = (Func<UpgradeBackpackItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeBackpackItemData x) => x.backpackExpansionSize_));
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			UpgradeBackpackItemData upgradeBackpackItemData = Enumerable.FirstOrDefault<UpgradeBackpackItemData>((IEnumerable<>)Enumerable.OrderByDescending<UpgradeBackpackItemData, int>(enumerable, (Func<, >)(object)func));
			if (upgradeBackpackItemData != null)
			{
				int backpackExpansionSize_ = upgradeBackpackItemData.backpackExpansionSize_;
				if (backpackExpansionSize_ > num)
				{
					num = backpackExpansionSize_;
				}
			}
			LoopScrollRect list2 = _list;
			if (list2.totalCount == num)
			{
				int num2 = 0;
				if ((long)num2 >= (long)(IntPtr)list2)
				{
					goto IL_00e4;
				}
				LoopScrollRect list3 = _list;
				num2++;
			}
			LoopScrollRect list4 = _list;
			int offset = 0;
			list4.RefillCells(offset);
			goto IL_00e4;
			IL_00e4:
			RefreshNotification();
			ActionType[] allowedActions = _allowedActions;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Func<UpgradeBackpackItemData, int> func2 = default(Func<UpgradeBackpackItemData, int>);
				if (_003C_003Ec._003C_003E9__93_1 == null)
				{
					func2 = (Func<UpgradeBackpackItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeBackpackItemData x) => x.backpackExpansionSize_));
				}
				IEnumerable<> enumerable2 = default(IEnumerable<>);
				IOrderedEnumerable<UpgradeBackpackItemData> orderedEnumerable = (IOrderedEnumerable<UpgradeBackpackItemData>)Enumerable.OrderBy<UpgradeBackpackItemData, int>(enumerable2, (Func<, >)(object)func2);
				Func<UpgradeBackpackItemData, bool> func3 = default(Func<UpgradeBackpackItemData, bool>);
				if (_003C_003Ec._003C_003E9__93_2 == null)
				{
					func3 = (Func<UpgradeBackpackItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(UpgradeBackpackItemData x)
					{
						//Discarded unreachable code: IL_0019
						Profile profile = SystemRoot.Instance.MetaClient.profile;
						Item item2 = x.Item;
						bool result = default(bool);
						return result;
					});
				}
				UpgradeBackpackItemData upgradeBackpackItemData2 = (_nextBackpackUpgrade = Enumerable.FirstOrDefault<UpgradeBackpackItemData>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func3));
			}
			RectTransform expandButton = _expandButton;
			int active = 0;
			expandButton.gameObject.SetActive((byte)active != 0);
			int num3 = 0;
			RefreshFocusedItem((FocusNavigationElement)num3);
			GameObject gameObject = tf_emptyBackpack.gameObject;
			bool active2 = _list.totalCount == 0;
			gameObject.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x600259E")]
		[Cpp2IlInjected.Address(RVA = "0x891220", Offset = "0x88FC20", VA = "0x180891220")]
		public void OnExpandButtonClicked()
		{
			UpgradeBackpack(showConfirmationPopup: true).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600259F")]
		[Cpp2IlInjected.Address(RVA = "0x897C10", Offset = "0x896610", VA = "0x180897C10")]
		[AsyncStateMachine(typeof(_003CUpgradeBackpack_003Ed__95))]
		private Task UpgradeBackpack(bool showConfirmationPopup)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025A0")]
		[Cpp2IlInjected.Address(RVA = "0x894D30", Offset = "0x893730", VA = "0x180894D30")]
		private void OnNotEnoughCurrencyPopupClosed(bool boughtCurrency)
		{
			if (boughtCurrency)
			{
				int showConfirmationPopup = 0;
				UpgradeBackpack((byte)showConfirmationPopup != 0).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A1")]
		[Cpp2IlInjected.Address(RVA = "0x894F80", Offset = "0x893980", VA = "0x180894F80")]
		private void OnPopupChanged(string menuName)
		{
			//Discarded unreachable code: IL_0058
			//IL_0057: Expected I4, but got I8
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			BaseUiRoot.MenuChanged value = OnPopupChanged;
			instance.OnPopupChanged -= value;
			int num2 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			NotEnoughCurrencyArgs notEnoughCurrencyArgs = _notEnoughCurrencyArgs;
			int num3 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuNotEnoughCurrency, notEnoughCurrencyArgs, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (System.Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60025A2")]
		[Cpp2IlInjected.Address(RVA = "0x891B10", Offset = "0x890510", VA = "0x180891B10", Slot = "8")]
		protected override void OnItemDataHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60025A3")]
		[Cpp2IlInjected.Address(RVA = "0x893650", Offset = "0x892050", VA = "0x180893650")]
		private void OnItemSelect((Item item, ItemState state, int amount, bool canSell) item, bool select, int stars)
		{
			//IL_0026: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			if (ItemActionList.gameObject.activeSelf)
			{
				return;
			}
			InventoryDragAndDrop inventoryDragAndDrop = _inventoryDragAndDrop;
			int num = 0;
			if (inventoryDragAndDrop != (UnityEngine.Object)num && _inventoryDragAndDrop.IsDragging)
			{
				return;
			}
			InventorySortPanel inventorySortPanel = InventorySortPanel;
			int num2 = 0;
			if ((!(inventorySortPanel != (UnityEngine.Object)num2) || !InventorySortPanel.IsOpen) && (_isInventoryFull || !ItemAmountSelector.gameObject.activeSelf))
			{
				BackpackItemInfo itemInfo = _itemInfo;
				if (select)
				{
					throw new NullReferenceException();
				}
				itemInfo.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A4")]
		[Cpp2IlInjected.Address(RVA = "0x896300", Offset = "0x894D00", VA = "0x180896300")]
		public void ShowEmpty(int index)
		{
			//Discarded unreachable code: IL_0018
			//IL_000c: Expected O, but got I4
			((List<T>)(object)ShowEmptyIndexes).Add((T)index);
			_list.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A5")]
		[Cpp2IlInjected.Address(RVA = "0x896BE0", Offset = "0x8955E0", VA = "0x180896BE0")]
		private void Update()
		{
			//Discarded unreachable code: IL_04d5, IL_04db, IL_04e1, IL_04e7, IL_04ed, IL_04f3, IL_04ff
			//IL_0014: Expected O, but got I4
			//IL_00c2: Expected I4, but got I8
			//IL_011b: Expected F4, but got I4
			//IL_01e3: Expected O, but got I4
			//IL_02c1: Expected O, but got I4
			//IL_0302: Expected O, but got I4
			//IL_0340: Expected O, but got I4
			//IL_035f: Expected O, but got I4
			//IL_0387: Expected O, but got I4
			//IL_0396: Expected O, but got I4
			//IL_03a1: Expected O, but got I4
			//IL_0410: Expected O, but got I4
			//IL_0440: Expected O, but got I4
			//IL_04b3: Expected O, but got I4
			Func<UpgradeBackpackItemData, int> func = default(Func<UpgradeBackpackItemData, int>);
			IEnumerable<> enumerable = default(IEnumerable<>);
			Func<UpgradeBackpackItemData, bool> func2 = default(Func<UpgradeBackpackItemData, bool>);
			ulong num4 = default(ulong);
			Vector3 vector = default(Vector3);
			bool flag = default(bool);
			Vector3 vector2 = default(Vector3);
			bool flag2 = default(bool);
			Transform transform = default(Transform);
			Vector3 vector3 = default(Vector3);
			bool flag3 = default(bool);
			BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				SlidingPanel slidingPanel = SlidingPanel;
				int num3 = 0;
				if (slidingPanel != (UnityEngine.Object)num3 && (SlidingPanel.isOpened ? 1 : 0) == num2)
				{
					return;
				}
				if ((_expandButtonSetup ? 1 : 0) == num2)
				{
					_expandButtonSetup = true;
					if ((_isInventoryFull ? 1 : 0) != num2 && (IntPtr)_nextBackpackUpgrade == (IntPtr)num2)
					{
						if (_003C_003Ec._003C_003E9__101_0 == null)
						{
							func = (Func<UpgradeBackpackItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeBackpackItemData x) => x.backpackExpansionSize_));
						}
						IOrderedEnumerable<UpgradeBackpackItemData> orderedEnumerable = (IOrderedEnumerable<UpgradeBackpackItemData>)Enumerable.OrderBy<UpgradeBackpackItemData, int>(enumerable, (Func<, >)(object)func);
						if (_003C_003Ec._003C_003E9__101_1 == null)
						{
							func2 = (Func<UpgradeBackpackItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(UpgradeBackpackItemData x)
							{
								//Discarded unreachable code: IL_0019
								Profile profile = SystemRoot.Instance.MetaClient.profile;
								Item item = x.Item;
								bool result = default(bool);
								return result;
							});
						}
						UpgradeBackpackItemData upgradeBackpackItemData = (_nextBackpackUpgrade = Enumerable.FirstOrDefault<UpgradeBackpackItemData>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func2));
						_expandButton.gameObject.SetActive((byte)num4 != 0);
					}
					GameObject gameObject = _expandButton.gameObject;
					int num5 = 0;
					if (gameObject.activeInHierarchy)
					{
						int constraintCount = _gridLayout.m_ConstraintCount;
						UpgradeBackpackItemData nextBackpackUpgrade = _nextBackpackUpgrade;
						if (nextBackpackUpgrade != null)
						{
							int backpackExpansionSize_ = nextBackpackUpgrade.backpackExpansionSize_;
							backpackExpansionSize_ -= constraintCount;
						}
						LoopScrollRect list = _list;
						_expandButton.SetTop(num5);
					}
				}
				if (ItemActionList.gameObject.activeSelf)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RectTransform background = ItemActionList._background;
						int num6 = 0;
						float z = vector.z;
						RectTransform background2 = ItemActionList._background;
						if (!flag)
						{
							GameObject gameObject2 = ItemActionList.gameObject;
							int active = 0;
							gameObject2.SetActive((byte)active != 0);
							_itemInfo.Hide();
							ItemActionList.ResetButtonClickedOn();
						}
					}
					int childCount = ItemActionList._actionList.m_Content.childCount;
					GameObject gameObject3 = ItemActionList.gameObject;
					int active2 = 0;
					gameObject3.SetActive((byte)active2 != 0);
					ItemActionList.ResetButtonClickedOn();
				}
				InventorySortPanel inventorySortPanel = InventorySortPanel;
				int num7 = 0;
				if (inventorySortPanel != (UnityEngine.Object)num7 && (InventorySortPanel.IsOpen ? 1 : 0) != num2 && Input.GetMouseButtonDown(0))
				{
					RectTransform rectTransform = InventorySortPanel._rectTransform;
					int num8 = 0;
					Vector2 mousePosition = Input.mousePosition;
					float z2 = vector2.z;
					RectTransform rectTransform2 = InventorySortPanel._rectTransform;
					if (!flag2)
					{
						InventorySortPanel.Close();
					}
				}
				if ((_isInventoryFull ? 1 : 0) == num2 && ItemAmountSelector.gameObject.activeSelf && Input.GetMouseButtonDown(0))
				{
					transform = ItemAmountSelector.transform;
					if ((object)transform != null)
					{
					}
					int num9 = 0;
					Vector2 mousePosition2 = Input.mousePosition;
					float z3 = vector3.z;
					if (!flag3)
					{
						GameObject gameObject4 = ItemAmountSelector.gameObject;
						int active3 = 0;
						gameObject4.SetActive((byte)active3 != 0);
						_itemInfo.Hide();
					}
				}
				InventoryDragAndDrop inventoryDragAndDrop = _inventoryDragAndDrop;
				int num10 = 0;
				if (!(inventoryDragAndDrop != (UnityEngine.Object)num10))
				{
					return;
				}
				if ((_inventoryDragAndDrop.IsDragging ? 1 : 0) == num2 && !ItemActionList.gameObject.activeSelf)
				{
					InventorySortPanel inventorySortPanel2 = InventorySortPanel;
					int num11 = 0;
					if ((!(inventorySortPanel2 != (UnityEngine.Object)num11) || (InventorySortPanel.IsOpen ? 1 : 0) == num2) && !ItemAmountSelector.gameObject.activeSelf)
					{
						MenuNavigation menuNavigation = MenuNavigation;
						int num12 = 0;
						if (menuNavigation != (UnityEngine.Object)num12)
						{
							FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
							int num13 = 0;
							if (focusNavigation != (UnityEngine.Object)num13 && (IntPtr)MenuNavigation.FocusNavigation._focusedElement != (IntPtr)num2)
							{
								int num14 = 0;
								if (!(transform == (UnityEngine.Object)num14))
								{
									int num15 = 0;
									if (transform != (UnityEngine.Object)num15)
									{
										ProcessDrag((BackpackSlotInventoryItem)num15);
										int num16 = 0;
										if (UiRoot.Instance._popupStack.Count == 0)
										{
											FocusNavigation focusNavigation2 = MenuNavigation.FocusNavigation;
											bool _003CIsDragging_003Ek__BackingField = _inventoryDragAndDrop.IsDragging;
											if (focusNavigation2.IsPaused != _003CIsDragging_003Ek__BackingField)
											{
												focusNavigation2.IsPaused = _003CIsDragging_003Ek__BackingField;
											}
										}
										return;
									}
								}
								ISupportsFocusNavigation focusedElement = MenuNavigation.FocusNavigation._focusedElement;
								if (focusedElement != null)
								{
									int num17 = 0;
									if (focusedElement == null)
									{
									}
								}
								int num18 = 0;
								if (!(backpackSlotInventoryItem != (UnityEngine.Object)num18))
								{
									continue;
								}
							}
						}
					}
				}
				if (_inventoryDragAndDrop.IsJoystickDragging)
				{
					RectTransform dragTarget = _inventoryDragAndDrop.DragTarget;
					int num19 = 0;
					if (dragTarget != (UnityEngine.Object)num19)
					{
						break;
					}
				}
			}
			IEnumerator enumerator = _list.m_Content.GetEnumerator();
			FocusNavigationElement focusNavigationElement2 = default(FocusNavigationElement);
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				int num20 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RectTransform dragTarget2 = _inventoryDragAndDrop.DragTarget;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				if (MenuNavigation.FocusNavigation._focusedElement != null)
				{
					int num21 = 0;
				}
				int num22 = 0;
				FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
				if (backpackSlotInventoryItem == (UnityEngine.Object)num22 || backpackSlotInventoryItem != focusNavigationElement)
				{
					RefreshFocusedItem(focusNavigationElement2);
				}
			}
			if ((object)focusNavigationElement2 != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A6")]
		[Cpp2IlInjected.Address(RVA = "0x895590", Offset = "0x893F90", VA = "0x180895590")]
		private void ProcessDrag(BackpackSlotInventoryItem inventoryItem)
		{
			//Discarded unreachable code: IL_0087
			if (!inventoryItem.IsPressedByGamepad)
			{
				if (Input.GetButton(RewiredActionIdGP))
				{
					inventoryItem.IsPressedByGamepad = true;
				}
				if (!inventoryItem.IsPressedByGamepad)
				{
					goto IL_0071;
				}
			}
			if (Input.GetButton(RewiredActionIdGP))
			{
				int num = 0;
				ReInput.PlayerHelper players = ReInput.players;
				int playerId = 0;
				Rewired.Player player = players.GetPlayer(playerId);
				if (!(player.GetAxis(144) > 0.1f) && player.GetAxis(145) <= 0.1f)
				{
					goto IL_0078;
				}
				inventoryItem.OnBeginDrag();
			}
			goto IL_0071;
			IL_0071:
			inventoryItem.IsPressedByGamepad = false;
			goto IL_0078;
			IL_0078:
			RefreshAllSelectedState(ignoreSelected: true);
			base.SelectedSlotId = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60025A7")]
		[Cpp2IlInjected.Address(RVA = "0x893830", Offset = "0x892230", VA = "0x180893830", Slot = "9")]
		protected override void OnItemTapHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60025A8")]
		[Cpp2IlInjected.Address(RVA = "0x8930D0", Offset = "0x891AD0", VA = "0x1808930D0", Slot = "10")]
		protected override void OnItemRightClickHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60025A9")]
		[Cpp2IlInjected.Address(RVA = "0x8960A0", Offset = "0x894AA0", VA = "0x1808960A0")]
		private Task<int?> ShowAmountSelector(BackpackSlotInventoryItem item, int amount)
		{
			//Discarded unreachable code: IL_0081
			TaskCompletionSource<int?> taskCompletionSource = (TaskCompletionSource<int?>)(object)new TaskCompletionSource<TResult>();
			ItemAmountSelector itemAmountSelector = ItemAmountSelector;
			Action<int?> action = (Action<int?>)(object)(Action<T>)delegate(int? result)
			{
				//Discarded unreachable code: IL_002e
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)result);
				int num3 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					SetFocus();
				}
			};
			ItemAmountSelector.gameObject.SetActive(value: true);
			int size = ((List<>)(object)listBackpack)._size;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			return (Task<int?>)(object)((TaskCompletionSource<>)(object)taskCompletionSource).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x60025AA")]
		[Cpp2IlInjected.Address(RVA = "0x88FCA0", Offset = "0x88E6A0", VA = "0x18088FCA0")]
		private void EatItem(int inventoryPosition, CancellationToken ct)
		{
			//Discarded unreachable code: IL_009a
			Vector3 vector = default(Vector3);
			IPlayerTaskData[] array;
			EatItemTaskData eatItemTaskData;
			uint num2;
			do
			{
				AK.Wwise.Event @event = eatOnClickSfx;
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				float z = vector.z;
				array = new IPlayerTaskData[1];
				eatItemTaskData = new EatItemTaskData();
				EatItem.Types.Request request = new EatItem.Types.Request();
				num2 = (request.containerInventoryID_ = SystemRoot.Instance.MetaClient.profile.Backpack.iD_);
				request.containerInventoryPosition_ = inventoryPosition;
				eatItemTaskData.Request = request;
			}
			while (num2 == 0);
			array[0] = eatItemTaskData;
		}

		[Cpp2IlInjected.Token(Token = "0x60025AB")]
		[Cpp2IlInjected.Address(RVA = "0x88F700", Offset = "0x88E100", VA = "0x18088F700")]
		[AsyncStateMachine(typeof(_003CConsumeLootPresent_003Ed__107))]
		private Task ConsumeLootPresent(int position, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025AC")]
		[Cpp2IlInjected.Address(RVA = "0x88EE10", Offset = "0x88D810", VA = "0x18088EE10")]
		private unsafe void ConsumeConsummable(int position)
		{
			//Discarded unreachable code: IL_0210
			//IL_0156: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			//IL_01a4: Expected O, but got I4
			int num = 0;
			int itemID = SystemRoot.Instance.MetaClient.profile.Backpack.GetSlot(position).ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ConsummableItemData consummableItemData = default(ConsummableItemData);
			if (consummableItemData != null && consummableItemData.ContentIsItemType(ItemType.MemoryShard))
			{
				AK.Wwise.Event @event = useMemoryShardOnClickSfx;
				GameObject gameObject = base.gameObject;
				uint num2 = @event.Post(gameObject);
			}
			PlayerNavigation playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			PlayerTaskDefinition consumeConsummableTask = _consumeConsummableTask;
			PlayerNavigation playerNavigation2 = playerNavigation;
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			IPlayerTaskData[] array = new IPlayerTaskData[1];
			ConsumeConsummableTaskData consumeConsummableTaskData = new ConsumeConsummableTaskData();
			ConsumeItem.Types.Request request = new ConsumeItem.Types.Request();
			uint num3 = (request.containerInventoryID_ = SystemRoot.Instance.MetaClient.profile.Backpack.iD_);
			request.inventoryPosition_ = 0;
			consumeConsummableTaskData.Request = request;
			array[0] = consumeConsummableTaskData;
			ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.Backpack;
			ContainerInventory.Types.Slot slot = default(ContainerInventory.Types.Slot);
			ItemState state_ = slot.state_;
			ItemInstance defaultItem = default(ItemInstance);
			if (state_ == null || state_.ConsummableData == null)
			{
				defaultItem = consummableItemData.DefaultItem;
			}
			Toolbox.TemporarySwitchToolScope scope;
			if (defaultItem != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Item item = defaultItem.Item;
				bool flag = default(bool);
				if (flag)
				{
					int num4 = 0;
					scope = (Toolbox.TemporarySwitchToolScope)num4;
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_0189;
					}
					int num5 = 0;
					if (UiRoot.Instance._menuStack.TryGetMenu<InventorySideMenu>(out *(InventorySideMenu*)num))
					{
						num += 360;
						bool flag3 = default(bool);
						if (flag3)
						{
							scope = (Toolbox.TemporarySwitchToolScope)num4;
							int num6 = 0;
							goto IL_0189;
						}
					}
					goto IL_01a4;
				}
			}
			goto IL_01ef;
			IL_01ef:
			int num7 = 0;
			UiRoot.Instance.Dispatcher.OnSomethingConsumed?.Invoke();
			return;
			IL_01a4:
			bool flag4 = default(bool);
			if (flag4)
			{
				PlayerNavigation playerNavigation3 = playerNavigation;
				PlayerNavigation.TaskCompleted value = OnTaskCompletedOrCancelled;
				playerNavigation3.OnTaskCompleted += value;
				PlayerNavigation playerNavigation4 = playerNavigation;
				PlayerNavigation.TaskCancelled value2 = OnTaskCompletedOrCancelled;
				playerNavigation4.OnTaskCancelled += value2;
			}
			InventoryMenu inventoryMenu = _inventoryMenu;
			goto IL_01ef;
			IL_0189:
			scope = removeToolScope;
			int num8 = 0;
			removeToolScope = (Toolbox.TemporarySwitchToolScope)num8;
			goto IL_01a4;
			[Cpp2IlInjected.Token(Token = "0x60025F5")]
			[Cpp2IlInjected.Address(RVA = "0x8E4650", Offset = "0x8E3050", VA = "0x1808E4650")]
			void OnTaskCompletedOrCancelled(PlayerTask task, int index)
			{
				//Discarded unreachable code: IL_005c
				BackpackContent backpackContent = this;
				PlayerTaskDefinition _003CDefinition_003Ek__BackingField = task.Definition;
				PlayerTaskDefinition consumeConsummableTask2 = backpackContent._consumeConsummableTask;
				if (_003CDefinition_003Ek__BackingField == consumeConsummableTask2)
				{
					PlayerNavigation playerNavigation5 = playerNavigation;
					PlayerNavigation.TaskCompleted value3 = OnTaskCompletedOrCancelled;
					playerNavigation5.OnTaskCompleted -= value3;
					PlayerNavigation playerNavigation6 = playerNavigation;
					PlayerNavigation.TaskCancelled value4 = OnTaskCompletedOrCancelled;
					playerNavigation6.OnTaskCancelled -= value4;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025AD")]
		[Cpp2IlInjected.Address(RVA = "0x88EAD0", Offset = "0x88D4D0", VA = "0x18088EAD0")]
		private void ConsumeBuffElixir(int position)
		{
			//Discarded unreachable code: IL_007e
			Vector3 vector = default(Vector3);
			IPlayerTaskData[] array;
			ConsumeBuffElixirTaskData consumeBuffElixirTaskData;
			uint num;
			do
			{
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				float z = vector.z;
				array = new IPlayerTaskData[1];
				consumeBuffElixirTaskData = new ConsumeBuffElixirTaskData();
				ConsumeItem.Types.Request request = new ConsumeItem.Types.Request();
				num = (request.containerInventoryID_ = SystemRoot.Instance.MetaClient.profile.Backpack.iD_);
				request.inventoryPosition_ = position;
				consumeBuffElixirTaskData.Request = request;
			}
			while (num == 0);
			array[0] = consumeBuffElixirTaskData;
		}

		[Cpp2IlInjected.Token(Token = "0x60025AE")]
		[Cpp2IlInjected.Address(RVA = "0x896910", Offset = "0x895310", VA = "0x180896910")]
		public void TriggerDrop()
		{
			//Discarded unreachable code: IL_0053
			LoopScrollRect list = _list;
			int num = 0;
			int num2 = 0;
			if (num2 < list.totalCount)
			{
				num2 = num;
				if (list.GetItemByDataIndex(num).GetComponent<BackpackSlotInventoryItem>().HasQuestMarker)
				{
					LoopScrollRect list2 = _list;
					num++;
					num2 = num;
				}
				CancellationToken cancellationToken = CancellationToken;
				int num3 = 0;
				this.DropItem(num, (byte)num3 != 0, cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025AF")]
		[Cpp2IlInjected.Address(RVA = "0x896370", Offset = "0x894D70", VA = "0x180896370")]
		[AsyncStateMachine(typeof(_003CSimulateDropItem_003Ed__111))]
		public Task<bool> SimulateDropItem(int inventoryPosition)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025B0")]
		[Cpp2IlInjected.Address(RVA = "0x88FB60", Offset = "0x88E560", VA = "0x18088FB60")]
		[AsyncStateMachine(typeof(_003CDropItem_003Ed__112))]
		private Task<bool> DropItem(int inventoryPosition, bool simulated, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025B1")]
		[Cpp2IlInjected.Address(RVA = "0x890000", Offset = "0x88EA00", VA = "0x180890000")]
		[AsyncStateMachine(typeof(_003CExecuteTransfer_003Ed__113))]
		private Task ExecuteTransfer(int itemIndex)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025B2")]
		[Cpp2IlInjected.Address(RVA = "0x8964A0", Offset = "0x894EA0", VA = "0x1808964A0")]
		[AsyncStateMachine(typeof(_003CSplitStack_003Ed__114))]
		private Task SplitStack(BackpackSlotInventoryItem inventoryItem, int initialPosition, Item item, int amount, ItemState state, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025B3")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88EB10", VA = "0x180890110")]
		private void FakeBackpackInventoryChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0025
			Item invalid = Item.Invalid;
			if (!SlidingPanel.isOpened)
			{
				ForceUpdate = true;
			}
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60025B4")]
		[Cpp2IlInjected.Address(RVA = "0x894BF0", Offset = "0x8935F0", VA = "0x180894BF0")]
		public void OnLayoutChange()
		{
			//Discarded unreachable code: IL_0026
			if (SlidingPanel.isOpened)
			{
				BackgroundCenter.parent.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025B5")]
		[Cpp2IlInjected.Address(RVA = "0x8952D0", Offset = "0x893CD0", VA = "0x1808952D0")]
		private void OnWishTokenClickedHandler()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60025B6")]
		[Cpp2IlInjected.Address(RVA = "0x8953F0", Offset = "0x893DF0", VA = "0x1808953F0")]
		[AsyncStateMachine(typeof(_003COnWishTokenClickedTask_003Ed__118))]
		private Task OnWishTokenClickedTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025B7")]
		[Cpp2IlInjected.Address(RVA = "0x8954D0", Offset = "0x893ED0", VA = "0x1808954D0", Slot = "23")]
		public void PostSfx(int index)
		{
			//Discarded unreachable code: IL_0045
			if (!IsMuted)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025B8")]
		[Cpp2IlInjected.Address(RVA = "0x897D30", Offset = "0x896730", VA = "0x180897D30")]
		[IteratorStateMachine(typeof(_003CWaitForSlidingPanel_003Ed__120))]
		private IEnumerator WaitForSlidingPanel()
		{
			int _003C_003E1__state = default(int);
			_003CWaitForSlidingPanel_003Ed__120 _003CWaitForSlidingPanel_003Ed__ = new _003CWaitForSlidingPanel_003Ed__120(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForSlidingPanel_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025B9")]
		[Cpp2IlInjected.Address(RVA = "0x8901F0", Offset = "0x88EBF0", VA = "0x1808901F0")]
		private int GetNbOfUnlockedSlots()
		{
			//Discarded unreachable code: IL_0025
			GridLayoutGroup gridLayout = _gridLayout;
			return _nextBackpackUpgrade?.backpackExpansionSize_ ?? _list.totalCount;
		}

		[Cpp2IlInjected.Token(Token = "0x60025BA")]
		[Cpp2IlInjected.Address(RVA = "0x890230", Offset = "0x88EC30", VA = "0x180890230")]
		private float GetYForExpandButton()
		{
			GridLayoutGroup gridLayout = _gridLayout;
			UpgradeBackpackItemData nextBackpackUpgrade = _nextBackpackUpgrade;
			int constraintCount = gridLayout.m_ConstraintCount;
			if (nextBackpackUpgrade != null)
			{
				int backpackExpansionSize_ = nextBackpackUpgrade.backpackExpansionSize_;
				backpackExpansionSize_ -= constraintCount;
			}
			LoopScrollRect list = _list;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025BB")]
		[Cpp2IlInjected.Address(RVA = "0x890420", Offset = "0x88EE20", VA = "0x180890420")]
		private bool IsExpandButtonVisible()
		{
			//IL_0010: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			RectTransform expandButton = _expandButton;
			int num = 0;
			if (expandButton != (UnityEngine.Object)num && _expandButton.gameObject.activeInHierarchy)
			{
				CanvasGroup component = _expandButton.GetComponent<CanvasGroup>();
				int num2 = 0;
				bool flag = component != (UnityEngine.Object)num2;
				if (!flag)
				{
					return true;
				}
				float alpha = component.alpha;
				int num3 = 0;
				return flag;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025BC")]
		[Cpp2IlInjected.Address(RVA = "0x895930", Offset = "0x894330", VA = "0x180895930")]
		private void SetExpandButtonPos()
		{
			//Discarded unreachable code: IL_003c
			GridLayoutGroup gridLayout = _gridLayout;
			RectTransform expandButton = _expandButton;
			UpgradeBackpackItemData nextBackpackUpgrade = _nextBackpackUpgrade;
			int constraintCount = gridLayout.m_ConstraintCount;
			if (nextBackpackUpgrade != null)
			{
				int backpackExpansionSize_ = nextBackpackUpgrade.backpackExpansionSize_;
				backpackExpansionSize_ -= constraintCount;
			}
			int totalCount = _list.totalCount;
		}

		[Cpp2IlInjected.Token(Token = "0x60025BD")]
		[Cpp2IlInjected.Address(RVA = "0x8959A0", Offset = "0x8943A0", VA = "0x1808959A0", Slot = "20")]
		protected override void SetupSlotNavigationElement()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60025BE")]
		[Cpp2IlInjected.Address(RVA = "0x896860", Offset = "0x895260", VA = "0x180896860")]
		public void TriggerActionList(BackpackActionItem actionItem)
		{
			//Discarded unreachable code: IL_002f
			BackpackActionList itemActionList = ItemActionList;
			int index = default(int);
			ListBase.ListEventData data = new ListBase.ListEventData(actionItem.gameObject, index);
			index = 0;
			itemActionList.OnActionItemData(data);
			actionItem._action?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60025BF")]
		[Cpp2IlInjected.Address(RVA = "0x896A10", Offset = "0x895410", VA = "0x180896A10")]
		public void TriggerItemTap(BackpackSlotInventoryItem item)
		{
			//Discarded unreachable code: IL_001e
			LoopScrollRect list = _list;
			GameObject item2 = item.gameObject;
			int _003CItemIndex_003Ek__BackingField = ((BackpackInventoryItem)item).ItemIndex;
			list.TriggerItemClickHandler(item2, _003CItemIndex_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x60025C0")]
		[Cpp2IlInjected.Address(RVA = "0x897DA0", Offset = "0x8967A0", VA = "0x180897DA0")]
		public BackpackContent()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8
		//IL_002a: Expected I4, but got I8

	}
}
