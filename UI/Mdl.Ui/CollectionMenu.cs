using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F7")]
	public class CollectionMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20002F8")]
		internal class CollectionMenuParam : MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x17000359")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000E9A")]
			public int CurrentIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6001373")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001374")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700035A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4000E9B")]
			public Item Item
			{
				[Cpp2IlInjected.Token(Token = "0x6001375")]
				[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001376")]
				[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700035B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000E9C")]
			public CollectionSubMenu SelectedTab
			{
				[Cpp2IlInjected.Token(Token = "0x6001377")]
				[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001378")]
				[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700035C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4000E9D")]
			public bool OnlyShardPopup
			{
				[Cpp2IlInjected.Token(Token = "0x6001379")]
				[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600137A")]
				[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x600137B")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public CollectionMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20002F9")]
		public class EverywhereExceptionTooltip
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000E9E")]
			[ItemID]
			public int ItemID;

			[Cpp2IlInjected.Token(Token = "0x600137C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EverywhereExceptionTooltip()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20002FA")]
		public class SkinShortcutEvent : UnityEvent<bool, ItemSlot>
		{
			[Cpp2IlInjected.Token(Token = "0x600137D")]
			[Cpp2IlInjected.Address(RVA = "0xA16740", Offset = "0xA15140", VA = "0x180A16740")]
			public SkinShortcutEvent()
			{
				((UnityEvent<T0, T1>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000E73")]
		private CollectionMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000E74")]
		internal CollectionMenuModel Model = new CollectionMenuModel
		{
			CollectionModels = (Dictionary<CollectionSubMenu, CollectionModel>)(object)new Dictionary<TKey, TValue>()
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000E75")]
		private CollectionTabButton _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000E76")]
		private CollectionTooltip _tooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000E77")]
		private MiningDataItemData[] _miningDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000E78")]
		private IRecurringEventData[] _recurringEventDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000E79")]
		private IEnumerable<IVillageAreaLootTableUser> _allAreasWithLootTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000E7A")]
		private SeedItemData[] _seedItemDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000E7B")]
		private RecipeItemData[] _recipeItemDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000E7C")]
		[SerializeField]
		private RectTransform _collections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000E7D")]
		[SerializeField]
		private RectTransform _viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000E7E")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000E7F")]
		[SerializeField]
		private GameObject _tabsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000E80")]
		[SerializeField]
		private CollectionTabButton[] _tabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000E81")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000E82")]
		[SerializeField]
		private GameObject _tooltipShorcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000E83")]
		[SerializeField]
		private TextBase _tootltipShortcutLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000E84")]
		[SerializeField]
		private string _tooltipTypeEverywhere;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000E85")]
		[SerializeField]
		private string _tooltipModelTypeEverywhere;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000E86")]
		[SerializeField]
		private EverywhereExceptionTooltip[] _everywhereItemException;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000E87")]
		[SerializeField]
		private GameObject _tooltipLockPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000E88")]
		[SerializeField]
		private GameObject _skinShortcutContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000E89")]
		[SerializeField]
		private GameObject _mouseBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000E8A")]
		public SkinShortcutEvent SkinEvent = new SkinShortcutEvent();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000E8B")]
		private int _groupIndexToScrollTo = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000E8C")]
		private int _itemIndexToScrollTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000E8D")]
		private Item _itemToScrollTo = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000E8E")]
		public int FocusedElementIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000E8F")]
		public CollectionItemGroup FocusedCollectionItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000E90")]
		public bool IsOnTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000E91")]
		private ItemSlot _currentItemslot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000E92")]
		[SerializeField]
		[Header("Fill the field below to adjust size for Switch")]
		private int _switchFontMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x4000E93")]
		[SerializeField]
		private int _switchFontMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000E94")]
		private InputAction _gamepadY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000E95")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000E96")]
		private bool _coroutineStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000E97")]
		private float _currentScrollValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000E98")]
		private Coroutine _frameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000E99")]
		private Vector2 _oldPosition;

		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public CollectionTabButton SelectedTab
		{
			[Cpp2IlInjected.Token(Token = "0x600133E")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get
			{
				return _selectedTab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x600133F")]
			[Cpp2IlInjected.Address(RVA = "0x11464B0", Offset = "0x1144EB0", VA = "0x1811464B0")]
			get
			{
				if (_switchFontMin == -1)
				{
					int num = 0;
				}
				return _switchFontMax != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001340")]
		[Cpp2IlInjected.Address(RVA = "0x11425E0", Offset = "0x1140FE0", VA = "0x1811425E0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_006c
			((object)this)._002Ector();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CollectionSetUpdated value = OnCollectionSetUpdated;
			_003CDispatcher_003Ek__BackingField.OnCollectionSetUpdated += value;
			SkinShortcutEvent skinEvent = SkinEvent;
			UnityAction<bool, ItemSlot> unityAction = (UnityAction<bool, ItemSlot>)(object)new UnityAction<T0, T1>(ShowSkinShortcut);
			((UnityEvent<T0, T1>)(object)skinEvent).AddListener((UnityAction<, >)(object)unityAction);
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupChange;
			popupStack.OnCurrentMenuChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001341")]
		[Cpp2IlInjected.Address(RVA = "0x1145DF0", Offset = "0x11447F0", VA = "0x181145DF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_006c
			base.UnregisterFocusedListeners();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CollectionSetUpdated value = OnCollectionSetUpdated;
			_003CDispatcher_003Ek__BackingField.OnCollectionSetUpdated -= value;
			SkinShortcutEvent skinEvent = SkinEvent;
			UnityAction<bool, ItemSlot> unityAction = (UnityAction<bool, ItemSlot>)(object)new UnityAction<T0, T1>(ShowSkinShortcut);
			((UnityEvent<T0, T1>)(object)skinEvent).RemoveListener((UnityAction<, >)(object)unityAction);
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupChange;
			popupStack.OnCurrentMenuChanged -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001342")]
		[Cpp2IlInjected.Address(RVA = "0x113EDF0", Offset = "0x113D7F0", VA = "0x18113EDF0")]
		private void OnPopupChange(IMenu menu)
		{
			if (menu == null)
			{
				SetFocus(fromBack: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001343")]
		[Cpp2IlInjected.Address(RVA = "0x113EE60", Offset = "0x113D860", VA = "0x18113EE60", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//IL_0020: Expected I4, but got I8
			//IL_0048: Expected O, but got I4
			//IL_009c: Expected I4, but got I8
			//IL_0193: Expected O, but got I4
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance.UpdateCursorBehaviorForUI();
			ulong num2 = default(ulong);
			_tabsHolder.SetActive((byte)num2 != 0);
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
			if (param != null)
			{
				int num3 = 0;
				if (param != null)
				{
					int num4 = 0;
				}
			}
			int num5 = 0;
			_param = (CollectionMenuParam)num5;
			if (_param == null)
			{
				_canvasGroup.alpha = 1f;
				base.FocusNavigation.IsPaused = false;
				GameObject mouseBlocker = _mouseBlocker;
				int active = 0;
				mouseBlocker.SetActive((byte)active != 0);
				int num6 = 0;
				KeepVisible = false;
				ulong num7 = default(ulong);
				UiRoot.Instance.MainMenuBar.SetVisibility((byte)num7 != 0);
			}
			int setScrollValue = 0;
			bool value = default(bool);
			SetVisibility(value, (byte)setScrollValue != 0);
			CollectionMenuModel model = Model;
			Action<CollectionItem, bool> action = (model.OnTooltip = (Action<CollectionItem, bool>)(object)new Action<T1, T2>(OnTooltipCalled));
			CollectionMenuModel model2 = Model;
			Action action2 = (model2.OnTooltipPart2 = OnToolTipPart2);
			CollectionMenuModel model3 = Model;
			Action action3 = (model3.OnSkinShortcut = OnSkinshortcut);
			CollectionMenuModel model4 = Model;
			Action<CollectionItem> action4 = (model4.OnMemoryShards = (Action<CollectionItem>)(object)new Action<T>(OnMemoryShardsCalled));
			Model.RefreshData();
			((Menu)this).IsDataUpToDate = true;
			base.Background.GetComponent<MainMenuBackground>().SetLeftWidth(496f);
			CollectionTabButton[] tabs = _tabs;
			Action<CollectionTabButton> action5 = default(Action<CollectionTabButton>);
			if (_003C_003Ec._003C_003E9__48_0 == null)
			{
				action5 = (Action<CollectionTabButton>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(CollectionTabButton x)
				{
					//Discarded unreachable code: IL_001c
					RedDot redDot = x.RedDot;
					int refresh = 0;
					redDot.CheckState((byte)refresh != 0);
					x.RedDot.AddToRealTimeUpdate();
				});
			}
			MoreLinq.ForEach<CollectionTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)action5);
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num8 = default(int);
			InputActionBool gamepadY = new InputActionBool("[ Y ]", trigger, (InputProvider)num8);
			num8 = 0;
			_gamepadY = gamepadY;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001344")]
		[Cpp2IlInjected.Address(RVA = "0x113E200", Offset = "0x113CC00", VA = "0x18113E200", Slot = "27")]
		public unsafe override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0218
			//IL_0070: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			//IL_0205: Expected O, but got I4
			//IL_0205: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			int num = 0;
			base.OnFocusIn();
			base.FocusNavigation.IsPaused = (byte)num != 0;
			Model.RefreshData();
			bool flag = TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num, out *(CollectionItemModel*)num);
			((Menu)this).IsDataUpToDate = true;
			GameObject tooltipLockPrefab = _tooltipLockPrefab;
			int active = 0;
			tooltipLockPrefab.SetActive((byte)active != 0);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag2 = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			CollectionTabButton selectedTab = _selectedTab;
			if (flag2)
			{
				int num3 = 0;
				if (selectedTab != (UnityEngine.Object)num3)
				{
					CollectionSubMenu collectionType = selectedTab.CollectionType;
					CollectionTabButton[] tabs = _tabs;
					Func<CollectionTabButton, bool> func = (Func<CollectionTabButton, bool>)(object)(Func<T, TResult>)delegate(CollectionTabButton x)
					{
						//Discarded unreachable code: IL_0016
						CollectionSubMenu _003CSelectedTab_003Ek__BackingField2 = _param.SelectedTab;
						return x.CollectionType == _003CSelectedTab_003Ek__BackingField2;
					};
					int num4 = MoreLinq.FindIndex<CollectionTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
				}
			}
			bool flag3 = default(bool);
			CollectionTabButton collectionTabButton = default(CollectionTabButton);
			if (flag3)
			{
				CollectionTabButton[] tabs2 = _tabs;
				Func<CollectionTabButton, bool> func2 = (Func<CollectionTabButton, bool>)(object)(Func<T, TResult>)delegate(CollectionTabButton x)
				{
					//Discarded unreachable code: IL_0016
					CollectionSubMenu _003CSelectedTab_003Ek__BackingField = _param.SelectedTab;
					return x.CollectionType == _003CSelectedTab_003Ek__BackingField;
				};
				int num5 = MoreLinq.FindIndex<CollectionTabButton>((IEnumerable<>)(object)tabs2, (Func<, >)(object)func2);
				collectionTabButton = tabs2[num5];
			}
			Model.RefreshData();
			int num6 = 0;
			if (collectionTabButton == (UnityEngine.Object)num6)
			{
				CollectionTabButton[] tabs3 = _tabs;
			}
			SelectTab(collectionTabButton, fromMove: true);
			if (flag2)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				FocusNavigationElement component = collectionTabButton.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
			CollectionTabButton[] tabs4 = _tabs;
			int length = tabs4.Length;
			CollectionModel collectionModel = default(CollectionModel);
			if (num < length)
			{
				CollectionTabButton collectionTabButton2 = tabs4[num];
				if (AdjustForSwitch)
				{
					int switchFontMax = _switchFontMax;
					int num7 = (collectionTabButton2._switchFontMin = _switchFontMin);
					collectionTabButton2._switchFontMax = switchFontMax;
				}
				Dictionary<CollectionSubMenu, CollectionModel> collectionModels = Model.CollectionModels;
				CollectionSubMenu collectionType2 = collectionTabButton2.CollectionType;
				collectionModel = (CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels)[(TKey)collectionType2];
				collectionTabButton2.UpdateDisplay(collectionModel);
				num++;
			}
			if (flag2)
			{
				SetFocus(fromBack: true);
			}
			bool flag4 = default(bool);
			if (collectionModel == null || !flag4)
			{
				return;
			}
			_itemToScrollTo = (Item)flag4;
			if (!TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num, out *(CollectionItemModel*)num))
			{
				return;
			}
			if ((long)this != 6)
			{
				if ((long)this != 2)
				{
					goto IL_0210;
				}
				int _003C_003E1__state = default(int);
				_003CSetFocusWithDelay_003Ed__64 _003CSetFocusWithDelay_003Ed__ = new _003CSetFocusWithDelay_003Ed__64(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CSetFocusWithDelay_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CSetFocusWithDelay_003Ed__);
			}
			CancellationToken cancellationToken = base.CancellationToken;
			bool animatePiece = ((Menu)this).IsStaticMenu;
			ShowMemoryShardsPopUp(cancellationToken, (CollectionItemGroupModel)num, (CollectionItemModel)num, animatePiece ? 1 : 0).FireAndForgetTask();
			PopSelf();
			goto IL_0210;
			IL_0210:
			_param = (CollectionMenuParam)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001345")]
		[Cpp2IlInjected.Address(RVA = "0x11425B0", Offset = "0x1140FB0", VA = "0x1811425B0")]
		private unsafe void RefreshItemIndexesToScrollTo()
		{
			int num = 0;
			bool flag = TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num, out *(CollectionItemModel*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001346")]
		[Cpp2IlInjected.Address(RVA = "0x11455B0", Offset = "0x1143FB0", VA = "0x1811455B0")]
		private bool TryRefreshItemIndexesToScrollTo(out CollectionItemGroupModel groupModelToScrollTo, out CollectionItemModel itemModelToScrollTo)
		{
			//IL_0014: Expected O, but got I4
			//IL_0033: Expected I4, but got I8
			//IL_0056: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			CollectionTabButton selectedTab = _selectedTab;
			int num3 = 0;
			bool flag = default(bool);
			if (selectedTab != (UnityEngine.Object)num3 && flag)
			{
				CollectionMenuModel model = Model;
				_groupIndexToScrollTo = -1;
				CollectionTabButton selectedTab2 = _selectedTab;
				Dictionary<CollectionSubMenu, CollectionModel> collectionModels = model.CollectionModels;
				CollectionSubMenu collectionType = selectedTab2.CollectionType;
				List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField = ((CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels)[(TKey)collectionType]).CollectionGroupModels;
				Predicate<CollectionItemGroupModel> predicate = (Predicate<CollectionItemGroupModel>)(object)(Predicate<T>)delegate(CollectionItemGroupModel x)
				{
					//Discarded unreachable code: IL_001c
					List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = x.CollectionItemModels;
					Predicate<CollectionItemModel> predicate3 = (Predicate<CollectionItemModel>)(object)(Predicate<T>)delegate(CollectionItemModel y)
					{
						//Discarded unreachable code: IL_000d
						//IL_000d: Expected I4, but got O
						IItemData _003CItemData_003Ek__BackingField2 = ((ItemSlotModel)y).ItemData;
						return (byte)(int)typeof(Item).TypeHandle != 0;
					};
					return ((List<T>)(object)_003CCollectionItemModels_003Ek__BackingField).Exists((Predicate<>)(object)predicate3);
				};
				CollectionItemGroupModel collectionItemGroupModel = (CollectionItemGroupModel)((List<T>)(object)_003CCollectionGroupModels_003Ek__BackingField).Find((Predicate<>)(object)predicate);
				CollectionMenuModel model2 = Model;
				CollectionTabButton selectedTab3 = _selectedTab;
				Dictionary<CollectionSubMenu, CollectionModel> collectionModels2 = model2.CollectionModels;
				CollectionSubMenu collectionType2 = selectedTab3.CollectionType;
				List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField2 = ((CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels2)[(TKey)collectionType2]).CollectionGroupModels;
				Predicate<CollectionItemModel> predicate2 = (Predicate<CollectionItemModel>)(object)(Predicate<T>)delegate(CollectionItemModel x)
				{
					//Discarded unreachable code: IL_000d
					//IL_000d: Expected I4, but got O
					IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)x).ItemData;
					return (byte)(int)typeof(Item).TypeHandle != 0;
				};
				int groupIndexToScrollTo = default(int);
				_groupIndexToScrollTo = groupIndexToScrollTo;
				int itemIndexToScrollTo = default(int);
				_itemIndexToScrollTo = itemIndexToScrollTo;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001347")]
		[Cpp2IlInjected.Address(RVA = "0x1146060", Offset = "0x1144A60", VA = "0x181146060")]
		private void Update()
		{
			//Discarded unreachable code: IL_00a1
			float deltaTime;
			InputAction[] array;
			InputAction gamepadY;
			do
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[1];
				gamepadY = _gamepadY;
			}
			while (gamepadY != null && array == null);
			array[0] = gamepadY;
			InputAction.UpdateAll(deltaTime, array);
			if (!_gamepadY.IsTriggered || IsOnTab)
			{
				return;
			}
			CollectionTooltip tooltip = _tooltip;
			if ((object)tooltip != null)
			{
				int num2 = 0;
				if ((object)tooltip != null && (long)_frameDelay == 0)
				{
					int _003C_003E1__state = default(int);
					_003CFrameDelay_003Ed__82 _003CFrameDelay_003Ed__ = new _003CFrameDelay_003Ed__82(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CFrameDelay_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = (_frameDelay = StartCoroutine(_003CFrameDelay_003Ed__));
					bool flag = 0 == 0;
					_tootltipShortcutLabel.StringID = "menu.less_details";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001348")]
		[Cpp2IlInjected.Address(RVA = "0x113E160", Offset = "0x113CB60", VA = "0x18113E160")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0032
			//IL_0010: Expected O, but got I4
			CollectionTooltip tooltip = _tooltip;
			int num = 0;
			if (tooltip != (UnityEngine.Object)num)
			{
				CollectionTooltip tooltip2 = _tooltip;
				RecycleBin recycleBin = _recycleBin;
				GameObject trash = tooltip2.gameObject;
				recycleBin.SendToBin(trash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001349")]
		[Cpp2IlInjected.Address(RVA = "0x113E880", Offset = "0x113D280", VA = "0x18113E880", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_003d
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			base.MenuNavigation.FocusNavigation.IsPaused = true;
			Coroutine frameDelay = _frameDelay;
			if (frameDelay != null)
			{
				StopCoroutine(frameDelay);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600134A")]
		[Cpp2IlInjected.Address(RVA = "0x11452F0", Offset = "0x1143CF0", VA = "0x1811452F0")]
		public void SetMouseBlock(bool value)
		{
			//Discarded unreachable code: IL_000d
			_mouseBlocker.SetActive(value);
		}

		[Cpp2IlInjected.Token(Token = "0x600134B")]
		[Cpp2IlInjected.Address(RVA = "0x113EAD0", Offset = "0x113D4D0", VA = "0x18113EAD0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_00e9
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			ClearRedDot();
			int num = 0;
			_selectedTab = (CollectionTabButton)num;
			FocusNavigation focusNavigation = base.FocusNavigation;
			int num2 = 0;
			focusNavigation.RemoveFocus((ISupportsFocusNavigation)num2);
			CollectionTooltip tooltip = _tooltip;
			int num3 = 0;
			if (tooltip != (UnityEngine.Object)num3)
			{
				CollectionTooltip tooltip2 = _tooltip;
				RecycleBin recycleBin = _recycleBin;
				GameObject trash = tooltip2.gameObject;
				recycleBin.SendToBin(trash);
			}
			_tooltip = (CollectionTooltip)num;
			CollectionTabButton[] tabs = _tabs;
			Action<CollectionTabButton> action = default(Action<CollectionTabButton>);
			if (_003C_003Ec._003C_003E9__56_0 == null)
			{
				action = (Action<CollectionTabButton>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(CollectionTabButton x)
				{
					//Discarded unreachable code: IL_000c
					x.RedDot.RemoveFromRealTimeUpdate();
				});
			}
			MoreLinq.ForEach<CollectionTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)action);
			base.OnPop();
			((Dictionary<TKey, TValue>)(object)Model.CollectionModels).Clear();
			_recipeItemDataList = (RecipeItemData[])num;
			_seedItemDataList = (SeedItemData[])num;
			_recurringEventDataList = (IRecurringEventData[])num;
			_miningDataList = (MiningDataItemData[])num;
			RecycleBin recycleBin2 = _recycleBin;
			RectTransform collections = _collections;
			Type typeFromHandle = typeof(CollectionItemGroup);
			recycleBin2.SendChildrenToBin(collections, typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600134C")]
		[Cpp2IlInjected.Address(RVA = "0x1146000", Offset = "0x1144A00", VA = "0x181146000")]
		private unsafe void UpdateDataIfNeeded()
		{
			//Discarded unreachable code: IL_001e
			Model.RefreshData();
			int num = 0;
			bool flag = TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num, out *(CollectionItemModel*)num);
			((Menu)this).IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600134D")]
		[Cpp2IlInjected.Address(RVA = "0x1145900", Offset = "0x1144300", VA = "0x181145900")]
		private bool TryUpdateAllGroups(out CollectionItemGroup groupToScrollTo)
		{
			//Discarded unreachable code: IL_0056, IL_005c, IL_006e
			int num = 0;
			int num2 = 0;
			IEnumerator enumerator = _collections.GetEnumerator();
			if (enumerator != null)
			{
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				if (flag)
				{
					if (num == _groupIndexToScrollTo)
					{
					}
					num++;
				}
				Debug.LogError("Cannot retrieve CollectionItemGroup component from Transform");
				int num5 = 0;
				num++;
			}
			num++;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600134E")]
		[Cpp2IlInjected.Address(RVA = "0x113D6C0", Offset = "0x113C0C0", VA = "0x18113D6C0")]
		private void ClearRedDot()
		{
			//Discarded unreachable code: IL_004b
			//IL_0010: Expected O, but got I4
			CollectionTabButton selectedTab = _selectedTab;
			int num = 0;
			if (!(selectedTab != (UnityEngine.Object)num))
			{
				return;
			}
			List<RedDotDataType> dataTypes = _selectedTab.RedDot.DataTypes;
			Action<RedDotDataType> _003C_003E9__59_ = _003C_003Ec._003C_003E9__59_0;
			if (_003C_003E9__59_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_000e
					int num2 = 0;
					RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
				};
			}
			((List<T>)(object)dataTypes).ForEach((Action<>)(object)_003C_003E9__59_);
		}

		[Cpp2IlInjected.Token(Token = "0x600134F")]
		[Cpp2IlInjected.Address(RVA = "0x1144A50", Offset = "0x1143450", VA = "0x181144A50")]
		public void SelectTab(CollectionTabButton tab)
		{
			int fromMove = 0;
			SelectTab(tab, (byte)fromMove != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001350")]
		[Cpp2IlInjected.Address(RVA = "0x1144560", Offset = "0x1142F60", VA = "0x181144560")]
		public unsafe void SelectTab(CollectionTabButton tab, bool fromMove = false)
		{
			//Discarded unreachable code: IL_00da
			//IL_0028: Expected O, but got I4
			//IL_004c: Expected I4, but got I8
			//IL_00a6: Expected O, but got I4
			//IL_00c0: Expected I4, but got I8
			//IL_00c0: Expected I4, but got I8
			//IL_00cf: Expected I4, but got I8
			//IL_00cf: Expected I4, but got I8
			CollectionTabButton tab2 = tab;
			int num = 0;
			Model.RefreshData();
			((Menu)this).IsDataUpToDate = true;
			_003C_003Ec _003C_003E = default(_003C_003Ec);
			if ((UnityEngine.Object)num != tab)
			{
				ClearRedDot();
				CollectionTabButton[] tabs = _tabs;
				FocusedElementIndex = -1;
				Func<CollectionTabButton, bool> func = (Func<CollectionTabButton, bool>)(object)(Func<T, TResult>)delegate(CollectionTabButton x)
				{
					CollectionTabButton collectionTabButton = tab2;
					return x != collectionTabButton;
				};
				IEnumerable<CollectionTabButton> enumerable = (IEnumerable<CollectionTabButton>)Enumerable.Where<CollectionTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
				Action<CollectionTabButton> action = default(Action<CollectionTabButton>);
				if (_003C_003Ec._003C_003E9__61_1 == null)
				{
					_003C_003E = _003C_003Ec._003C_003E9;
					action = (Action<CollectionTabButton>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)new Action<T>(_003C_003E._003CSelectTab_003Eb__61_1));
				}
				MoreLinq.ForEach<CollectionTabButton>((IEnumerable<>)enumerable, (Action<>)(object)action);
				bool flag = default(bool);
				int num2 = default(int);
				int num3 = default(int);
				if (flag)
				{
					num2 = 0;
					num3 = 0;
				}
				_selectedTab = (CollectionTabButton)num3;
				bool flag2 = TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num3, out *(CollectionItemModel*)num2);
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				ulong num4 = default(ulong);
				ulong num5 = default(ulong);
				RefreshDisplay((byte)num4 != 0, (byte)num5 != 0);
			}
			if (_003C_003E != null)
			{
				ulong num6 = default(ulong);
				RefreshDisplay((byte)num6 != 0, (byte)num6 != 0);
				int num7 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001351")]
		[Cpp2IlInjected.Address(RVA = "0x113DEC0", Offset = "0x113C8C0", VA = "0x18113DEC0")]
		[AsyncStateMachine(typeof(_003CMoveTask_003Ed__62))]
		private Task MoveTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001352")]
		[Cpp2IlInjected.Address(RVA = "0x1141EB0", Offset = "0x11408B0", VA = "0x181141EB0")]
		public void RefreshDisplay(bool fromMove = false, bool hasChange = true)
		{
			//Discarded unreachable code: IL_0162, IL_0168, IL_016e, IL_0174, IL_017a, IL_0180, IL_0186, IL_018c, IL_0192, IL_0198, IL_019e, IL_01a4
			//IL_002c: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			Vector2 anchoredPosition;
			bool flag = default(bool);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (!hasChange)
				{
					break;
				}
				RectTransform content = _scrollRect.m_Content;
				int num4 = 0;
				anchoredPosition = content.anchoredPosition;
				content.anchoredPosition = (Vector2)num4;
				ClearContent();
				_scrollRect.m_Content.gameObject.SetActive(value: true);
				Dictionary<CollectionSubMenu, CollectionModel> collectionModels = Model.CollectionModels;
				CollectionSubMenu collectionType = _selectedTab.CollectionType;
				List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField = ((CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels)[(TKey)collectionType]).CollectionGroupModels;
				if (flag)
				{
					int childCount = _collections.childCount;
					RecycleBin recycleBin = _recycleBin;
					Type typeFromHandle = typeof(CollectionItemGroup);
					RectTransform collections = _collections;
					GameObject gameObject = recycleBin.FindReusableOrNew(typeFromHandle, collections);
					Type typeFromHandle2 = typeof(CollectionShardsGroup);
					RectTransform collections2 = _collections;
					recycleBin.FindReusableOrNew(typeFromHandle2, collections2).SetActive(value: true);
					if (num3 == 0)
					{
					}
					int size = ((List<>)(object)_003CCollectionGroupModels_003Ek__BackingField)._size;
					if (num3 == size)
					{
					}
					CollectionItemGroup component = _collections.GetChild(num3).GetComponent<CollectionItemGroup>();
					RectTransform rectTransform = (component.ViewPort = _viewport);
					RecycleBin recycleBin2 = (component.RecycleBin = _recycleBin);
					component.Model = (CollectionItemGroupModel)num2;
					component.RefreshDisplay();
					num3++;
				}
			}
			while ((object)anchoredPosition != null);
			OnRefreshDisplay?.Invoke();
			if (!fromMove)
			{
				IEnumerator routine = SetFocusWithDelay();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001353")]
		[Cpp2IlInjected.Address(RVA = "0x1144C50", Offset = "0x1143650", VA = "0x181144C50")]
		[IteratorStateMachine(typeof(_003CSetFocusWithDelay_003Ed__64))]
		private IEnumerator SetFocusWithDelay()
		{
			int _003C_003E1__state = default(int);
			_003CSetFocusWithDelay_003Ed__64 _003CSetFocusWithDelay_003Ed__ = new _003CSetFocusWithDelay_003Ed__64(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetFocusWithDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001354")]
		[Cpp2IlInjected.Address(RVA = "0x113D1F0", Offset = "0x113BBF0", VA = "0x18113D1F0")]
		private void ClearContent()
		{
			//Discarded unreachable code: IL_01f8
			//IL_0010: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_0197: Expected O, but got I4
			CollectionTooltip tooltip = _tooltip;
			int num = 0;
			if (tooltip != (UnityEngine.Object)num)
			{
				GameObject gameObject = _tooltip.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject tooltipShorcutIndicator = _tooltipShorcutIndicator;
				int active2 = 0;
				tooltipShorcutIndicator.SetActive((byte)active2 != 0);
			}
			GameObject gameObject2 = _scrollRect.m_Content.gameObject;
			int active3 = 0;
			gameObject2.SetActive((byte)active3 != 0);
			int childCount = _collections.childCount;
			CollectionTabButton selectedTab = _selectedTab;
			int num2 = 0;
			if (selectedTab == (UnityEngine.Object)num2)
			{
				return;
			}
			CollectionMenuModel model = Model;
			CollectionTabButton selectedTab2 = _selectedTab;
			Dictionary<CollectionSubMenu, CollectionModel> collectionModels = model.CollectionModels;
			CollectionSubMenu collectionType = selectedTab2.CollectionType;
			if (((CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels)[(TKey)collectionType]).CollectionItemTab != CollectionSubMenu.Memories)
			{
				RectTransform collections = _collections;
				int index = collections.childCount - 1;
				CollectionShardsGroup component = collections.GetChild(index).GetComponent<CollectionShardsGroup>();
				int num3 = 0;
				if (component != (UnityEngine.Object)num3)
				{
					component.Dispose();
					RecycleBin recycleBin = _recycleBin;
					GameObject trash = component.gameObject;
					recycleBin.SendToBin(trash);
				}
			}
			RectTransform collections2 = _collections;
			int index2 = collections2.childCount - 1;
			CollectionItemGroup component2 = collections2.GetChild(index2).GetComponent<CollectionItemGroup>();
			Type type = component2.GetType();
			Type typeFromHandle = typeof(CollectionItemGroup);
			if (((object)type).Equals((object)typeFromHandle))
			{
				component2.Dispose();
				RecycleBin recycleBin2 = _recycleBin;
				GameObject trash2 = component2.gameObject;
				recycleBin2.SendToBin(trash2);
			}
			CollectionMenuModel model2 = Model;
			CollectionTabButton selectedTab3 = _selectedTab;
			Dictionary<CollectionSubMenu, CollectionModel> collectionModels2 = model2.CollectionModels;
			CollectionSubMenu collectionType2 = selectedTab3.CollectionType;
			CollectionModel collectionModel = (CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels2)[(TKey)collectionType2];
			RectTransform collections3 = _collections;
			List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField = collectionModel.CollectionGroupModels;
			childCount = collections3.childCount;
			RectTransform collections4 = _collections;
			int index3 = collections4.childCount - 1;
			CollectionItemGroup component3 = collections4.GetChild(index3).GetComponent<CollectionItemGroup>();
			component3.Dispose();
			RecycleBin recycleBin3 = _recycleBin;
			GameObject trash3 = component3.gameObject;
			recycleBin3.SendToBin(trash3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001355")]
		[Cpp2IlInjected.Address(RVA = "0x113D8D0", Offset = "0x113C2D0", VA = "0x18113D8D0")]
		internal CollectionItem GetAnyFirstGroupItem()
		{
			//Discarded unreachable code: IL_0058, IL_006a
			//IL_0037: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = _collections.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				CollectionItemGroup collectionItemGroup = default(CollectionItemGroup);
				if ((object)collectionItemGroup != null)
				{
					CollectionItem anyVisibleItem = collectionItemGroup.GetAnyVisibleItem();
				}
				int num4 = 0;
				flag = (UnityEngine.Object)num != (UnityEngine.Object)num4;
				while (!flag)
				{
				}
				num++;
			}
			num++;
			if (flag)
			{
			}
			if (num != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001356")]
		[Cpp2IlInjected.Address(RVA = "0x1144CC0", Offset = "0x11436C0", VA = "0x181144CC0")]
		private void SetFocus(bool fromBack = false)
		{
			//Discarded unreachable code: IL_0202
			//IL_0014: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_0116: Expected O, but got I4
			//IL_0116: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			if (!fromBack)
			{
				CollectionItemGroup focusedCollectionItemGroup = FocusedCollectionItemGroup;
				int num = 0;
				if (focusedCollectionItemGroup != (UnityEngine.Object)num && FocusedElementIndex != -1 && FocusedCollectionItemGroup._items.childCount > FocusedElementIndex)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					RectTransform items = FocusedCollectionItemGroup._items;
					int focusedElementIndex = FocusedElementIndex;
					FocusNavigationElement component = items.GetChild(focusedElementIndex).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement != 0 || fromBack || !_scrollRect.m_Content.gameObject.activeSelf || _collections.childCount <= 0)
			{
				goto IL_0131;
			}
			int num2 = 0;
			int childCount = _collections.childCount;
			if (num2 < childCount)
			{
				CollectionItemGroup component2 = _collections.GetChild(num2).GetComponent<CollectionItemGroup>();
				int num3 = 0;
				if (component2 != (UnityEngine.Object)num3)
				{
					CollectionItem anyVisibleItem = component2.GetAnyVisibleItem();
					if ((object)anyVisibleItem != null)
					{
						FocusNavigationElement component3 = anyVisibleItem.GetComponent<FocusNavigationElement>();
					}
					int num4 = 0;
					if ((UnityEngine.Object)num2 != (UnityEngine.Object)num4)
					{
						goto IL_011f;
					}
				}
				num2++;
				goto IL_011f;
			}
			goto IL_0134;
			IL_011f:
			base.MenuNavigation.FocusNavigation.SetFocus((FocusNavigationElement)num2);
			goto IL_0131;
			IL_0131:
			int num5 = 0;
			goto IL_0134;
			IL_01a1:
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num6 = 0;
			bool flag = (IsOnTab = focusedElement == null);
			if (focusedElement != null && (long)base.FocusNavigation._focusedElement != 0)
			{
				ISupportsFocusNavigation focusedElement2 = base.MenuNavigation.FocusNavigation._focusedElement;
				int num7 = 0;
				int num8 = 0;
				Debug.LogError("CollectionMenu - Failed to call Highlight on item while IsOnTab is false");
			}
			return;
			IL_0134:
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement == 0)
			{
				CollectionTabButton selectedTab = _selectedTab;
				int num9 = 0;
				if (!(selectedTab != (UnityEngine.Object)num9))
				{
					if (_tabs.Length == 0)
					{
						goto IL_01a1;
					}
					MenuNavigation menuNavigation = base.MenuNavigation;
					CollectionTabButton[] tabs = _tabs;
				}
				FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
				FocusNavigationElement component4 = _selectedTab.GetComponent<FocusNavigationElement>();
				focusNavigation2.SetFocus(component4);
			}
			goto IL_01a1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001357")]
		[Cpp2IlInjected.Address(RVA = "0x1143FF0", Offset = "0x11429F0", VA = "0x181143FF0")]
		private IRecurringEventData SearchGetRecurringEventItemData(Item item)
		{
			//IL_0016: Expected O, but got I4
			RecurringEventType recurringEventType = default(RecurringEventType);
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = default(ItemSpawningInVillageRecurringEventItemData);
			Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate = default(Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate3 = default(Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			WildCropsSpawningInVillageRecurringEventItemData wildCropsSpawningInVillageRecurringEventItemData = default(WildCropsSpawningInVillageRecurringEventItemData);
			SeedItemData seedItemData = default(SeedItemData);
			FlowerSpawningInVillageRecurringEventItemData flowerSpawningInVillageRecurringEventItemData = default(FlowerSpawningInVillageRecurringEventItemData);
			bool flag = default(bool);
			while (true)
			{
				int itemID = item.ItemID;
				int num = 0;
				Item item2 = (Item)itemID;
				IRecurringEventData[] recurringEventDataList = _recurringEventDataList;
				if (recurringEventDataList == null)
				{
					IRecurringEventData[] array = (_recurringEventDataList = ItemDatabase.Instance.GetAllByType<IRecurringEventData>(ItemType.RecurringEvent).ToArray<IRecurringEventData>());
				}
				int length = recurringEventDataList.Length;
				if (num >= length)
				{
					break;
				}
				IRecurringEventData result = recurringEventDataList[num];
				if (recurringEventType != 0)
				{
					continue;
				}
				if (itemSpawningInVillageRecurringEventItemData.ItemList != null)
				{
					ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeightList itemList = itemSpawningInVillageRecurringEventItemData.ItemList;
					Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate2 = predicate;
					RepeatedField<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> items_ = itemList.items_;
					if (predicate2 == null)
					{
						predicate3 = (predicate = (Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>)(object)(Predicate<T>)delegate(ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight x)
						{
							//Discarded unreachable code: IL_0011
							Item item3 = item2;
							return (IntPtr)x.itemID_ == (IntPtr)item3;
						});
					}
					if (!ProtoExtensions.Exists<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>((RepeatedField<>)(object)items_, (Predicate<>)(object)predicate3))
					{
						continue;
					}
					int itemID_ = Enumerable.FirstOrDefault<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>((IEnumerable<>)(object)wildCropsSpawningInVillageRecurringEventItemData.possibleItems_).itemID_;
					if ((long)seedItemData.ProducedItem == 5 && flowerSpawningInVillageRecurringEventItemData.possibleFlowers_ != null && flag)
					{
						goto IL_00de;
					}
				}
				num++;
				goto IL_00de;
				IL_00de:
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001358")]
		[Cpp2IlInjected.Address(RVA = "0x1143940", Offset = "0x1142340", VA = "0x181143940")]
		private LootTableItemData SearchGetLootTableItemData(Item item)
		{
			//Discarded unreachable code: IL_00be, IL_00c4, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if ((IntPtr)_allAreasWithLootTables == (IntPtr)num2)
			{
				IEnumerable<> enumerable = (IEnumerable<>)(_allAreasWithLootTables = (IEnumerable<IVillageAreaLootTableUser>)ProtoDatabase.Instance.Enumerate<IVillageAreaLootTableUser>());
			}
			RepeatedField<VillageAreaType> repeatedField = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();
			IEnumerable<IVillageAreaLootTableUser> allAreasWithLootTables = _allAreasWithLootTables;
			int num7 = default(int);
			if (repeatedField != null)
			{
				if (repeatedField != null)
				{
					LootTableItemData lootTableItemData = default(LootTableItemData);
					RepeatedField<SubLootTable> subLootTables_ = lootTableItemData.rewards_.subLootTables_;
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = default(bool);
						if (flag2)
						{
							num4++;
						}
						num4++;
						while (num4 == 0)
						{
						}
					}
					num4++;
					while (num4 == 0)
					{
					}
				}
				int num5 = num5 + 1;
				int num6 = default(int);
				if (repeatedField != null)
				{
					num6 = 0;
				}
				while (num5 == 0)
				{
				}
				num7 = num5 - 1;
				if (num6 == 259)
				{
				}
				while (num6 != 234)
				{
				}
			}
			num7++;
			if (repeatedField != null)
			{
			}
			if (num7 != 0)
			{
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001359")]
		[Cpp2IlInjected.Address(RVA = "0x1143240", Offset = "0x1141C40", VA = "0x181143240")]
		private RepeatedField<VillageAreaType> SearchAvailableAreasOfRecurringEvent(Item item)
		{
			//Discarded unreachable code: IL_0150
			//IL_0014: Expected O, but got I4
			RecurringEventType recurringEventType = default(RecurringEventType);
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = default(ItemSpawningInVillageRecurringEventItemData);
			Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate = default(Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate3 = default(Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			SpawnRecurringEventAreaSpecification.Types.AreaList areaList = default(SpawnRecurringEventAreaSpecification.Types.AreaList);
			bool flag = default(bool);
			VillageAreaType villageAreaType2 = default(VillageAreaType);
			SpawnRecurringEventAreaSpecification.Types.AreaList areaList2 = default(SpawnRecurringEventAreaSpecification.Types.AreaList);
			WildCropsSpawningInVillageRecurringEventItemData wildCropsSpawningInVillageRecurringEventItemData = default(WildCropsSpawningInVillageRecurringEventItemData);
			SeedItemData seedItemData = default(SeedItemData);
			SpawnRecurringEventAreaSpecification.Types.AreaList areaList3 = default(SpawnRecurringEventAreaSpecification.Types.AreaList);
			bool flag2 = default(bool);
			SpawnRecurringEventAreaSpecification.Types.AreaList areaList4 = default(SpawnRecurringEventAreaSpecification.Types.AreaList);
			while (true)
			{
				int itemID = item.ItemID;
				Item item2 = (Item)itemID;
				if ((long)_recurringEventDataList == 0)
				{
					IRecurringEventData[] array = (_recurringEventDataList = ItemDatabase.Instance.GetAllByType<IRecurringEventData>(ItemType.RecurringEvent).ToArray<IRecurringEventData>());
				}
				RepeatedField<VillageAreaType> result = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();
				IRecurringEventData[] recurringEventDataList = _recurringEventDataList;
				int num = 0;
				int num2 = 0;
				int length = recurringEventDataList.Length;
				if (num < length)
				{
					IRecurringEventData recurringEventData = recurringEventDataList[num2];
					if (recurringEventType == RecurringEventType.ItemSpawningInVillage)
					{
						if (itemSpawningInVillageRecurringEventItemData.ItemList != null)
						{
							ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeightList itemList = itemSpawningInVillageRecurringEventItemData.ItemList;
							Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate2 = predicate;
							RepeatedField<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> items_ = itemList.items_;
							if (predicate2 == null)
							{
								predicate3 = (predicate = (Predicate<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>)(object)(Predicate<T>)delegate(ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight x)
								{
									//Discarded unreachable code: IL_0011
									Item item3 = item2;
									return (IntPtr)x.itemID_ == (IntPtr)item3;
								});
							}
							if (ProtoExtensions.Exists<ItemSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>((RepeatedField<>)(object)items_, (Predicate<>)(object)predicate3))
							{
								if (recurringEventData == null)
								{
									goto IL_0156;
								}
								VillageAreaType villageAreaType = Enumerable.First<VillageAreaType>((IEnumerable<>)(object)areaList.areas_);
								if (!flag)
								{
									if (recurringEventData == null)
									{
										goto IL_0156;
									}
									villageAreaType2 = Enumerable.First<VillageAreaType>((IEnumerable<>)(object)areaList2.areas_);
								}
							}
						}
						num2++;
					}
					while (villageAreaType2 != VillageAreaType.Savannah)
					{
					}
					int itemID_ = Enumerable.FirstOrDefault<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>((IEnumerable<>)(object)wildCropsSpawningInVillageRecurringEventItemData.possibleItems_).itemID_;
					if ((object)seedItemData.ProducedItem == null)
					{
						continue;
					}
					if (recurringEventData == null)
					{
						break;
					}
					VillageAreaType villageAreaType3 = Enumerable.First<VillageAreaType>((IEnumerable<>)(object)areaList3.areas_);
					while (flag2)
					{
					}
					if (recurringEventData == null)
					{
						break;
					}
					VillageAreaType villageAreaType4 = Enumerable.First<VillageAreaType>((IEnumerable<>)(object)areaList4.areas_);
					num2++;
				}
				return result;
				IL_0156:
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600135A")]
		[Cpp2IlInjected.Address(RVA = "0x1142920", Offset = "0x1141320", VA = "0x181142920")]
		private RepeatedField<VillageAreaType> SearchAvailableAreasOfLootTableItem(Item item)
		{
			//Discarded unreachable code: IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00ac, IL_00b2, IL_00b8
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if ((IntPtr)_allAreasWithLootTables == (IntPtr)num2)
			{
				IEnumerable<> enumerable = (IEnumerable<>)(_allAreasWithLootTables = (IEnumerable<IVillageAreaLootTableUser>)ProtoDatabase.Instance.Enumerate<IVillageAreaLootTableUser>());
			}
			RepeatedField<VillageAreaType> repeatedField = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();
			IEnumerable<IVillageAreaLootTableUser> allAreasWithLootTables = _allAreasWithLootTables;
			if (repeatedField != null)
			{
				if (repeatedField != null)
				{
					LootTableItemData lootTableItemData = default(LootTableItemData);
					RepeatedField<SubLootTable> subLootTables_ = lootTableItemData.rewards_.subLootTables_;
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (flag && flag2)
					{
						bool flag3 = default(bool);
						while (flag3)
						{
						}
					}
				}
				if (repeatedField == null)
				{
				}
			}
			if (repeatedField != null)
			{
			}
			return repeatedField;
		}

		[Cpp2IlInjected.Token(Token = "0x600135B")]
		[Cpp2IlInjected.Address(RVA = "0x1142EF0", Offset = "0x11418F0", VA = "0x181142EF0")]
		private List<ActivityDataLocationFilter> SearchAvailableAreasOfMiningItem(Item item)
		{
			if ((long)_miningDataList == 0)
			{
				MiningDataItemData[] array = (_miningDataList = ItemDatabase.Instance.GetAllByType<MiningDataItemData>(ItemType.ActivityData).ToArray<MiningDataItemData>());
			}
			List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)new List<T>();
			MiningDataItemData[] miningDataList = _miningDataList;
			int num = 0;
			int num2 = 0;
			if (num < miningDataList.Length)
			{
				MiningDataItemData miningDataItemData = miningDataList[num2];
				if ((object)miningDataItemData.result_.Item != null)
				{
					if (miningDataItemData.location_.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.None)
					{
						goto IL_00c9;
					}
					Func<ActivityDataLocationFilter, bool> cpp2il__autoParamName__idx_ = (Func<ActivityDataLocationFilter, bool>)(object)(Func<T, TResult>)delegate(ActivityDataLocationFilter x)
					{
						//Discarded unreachable code: IL_0014
						ActivityDataLocationFilter location_ = miningDataItemData.location_;
						return x.Equals(location_);
					};
					if (!((IEnumerable<>)list).Any<ActivityDataLocationFilter>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						ActivityDataLocationFilter item2 = miningDataItemData.location_.Clone();
						((List<T>)(object)list).Add((T)item2);
					}
				}
				num2++;
				num = num2;
				goto IL_00c9;
			}
			goto IL_00cc;
			IL_00cc:
			throw new NullReferenceException();
			IL_00c9:
			int num3 = 0;
			goto IL_00cc;
		}

		[Cpp2IlInjected.Token(Token = "0x600135C")]
		[Cpp2IlInjected.Address(RVA = "0x1145400", Offset = "0x1143E00", VA = "0x181145400")]
		[AsyncStateMachine(typeof(_003CShowMemoryShardsPopUp_003Ed__73))]
		private Task ShowMemoryShardsPopUp(CancellationToken ct, CollectionItemGroupModel collectionItemGroupModel, CollectionItemModel collectionItemModel, int animatePiece = -1)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600135D")]
		[Cpp2IlInjected.Address(RVA = "0x113EE10", Offset = "0x113D810", VA = "0x18113EE10")]
		private void OnPopupClose()
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			UiRoot.Instance.MainMenuBar.ShortcutBar.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600135E")]
		[Cpp2IlInjected.Address(RVA = "0x11427F0", Offset = "0x11411F0", VA = "0x1811427F0")]
		public void Release()
		{
			//Discarded unreachable code: IL_0050
			//IL_0019: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			((Dictionary<TKey, TValue>)(object)Model.CollectionModels).Clear();
			int num = 0;
			_recipeItemDataList = (RecipeItemData[])num;
			_seedItemDataList = (SeedItemData[])num;
			_recurringEventDataList = (IRecurringEventData[])num;
			_miningDataList = (MiningDataItemData[])num;
			RecycleBin recycleBin = _recycleBin;
			RectTransform collections = _collections;
			Type typeFromHandle = typeof(CollectionItemGroup);
			recycleBin.SendChildrenToBin(collections, typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600135F")]
		[Cpp2IlInjected.Address(RVA = "0x113DFC0", Offset = "0x113C9C0", VA = "0x18113DFC0")]
		private unsafe void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
		{
			//Discarded unreachable code: IL_00ab
			//IL_009b: Expected O, but got I4
			CollectionMenuModel model = Model;
			((Menu)this).IsDataUpToDate = false;
			model.RefreshData();
			int num = 0;
			bool flag = TryRefreshItemIndexesToScrollTo(out *(CollectionItemGroupModel*)num, out *(CollectionItemModel*)num);
			((Menu)this).IsDataUpToDate = true;
			int fromMove = 0;
			RefreshDisplay((byte)fromMove != 0);
			CollectionTabButton[] tabs = _tabs;
			int length = tabs.Length;
			if (num >= length)
			{
				return;
			}
			int switchFontMin = _switchFontMin;
			CollectionTabButton collectionTabButton = tabs[num];
			if (switchFontMin != -1)
			{
				int switchFontMax = _switchFontMax;
				if (switchFontMax != -1)
				{
					collectionTabButton._switchFontMin = switchFontMin;
					collectionTabButton._switchFontMax = switchFontMax;
				}
			}
			Dictionary<CollectionSubMenu, CollectionModel> collectionModels = Model.CollectionModels;
			CollectionSubMenu collectionType = collectionTabButton.CollectionType;
			CollectionModel collectionModel = (CollectionModel)((Dictionary<TKey, TValue>)(object)collectionModels)[(TKey)collectionType];
			collectionTabButton.UpdateDisplay(collectionModel);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001360")]
		[Cpp2IlInjected.Address(RVA = "0x113DCF0", Offset = "0x113C6F0", VA = "0x18113DCF0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_009f
			//IL_0065: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_009d: Expected I4, but got I8
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if ((long)typeof(UnityEngine.Object).TypeHandle > 1 && redirectionType == RedirectionType.GamePopCurrentMenu)
				{
					PopSelf();
				}
				return;
			}
			while (redirectionType == RedirectionType.MenuCollectionToggle)
			{
			}
			while ((long)typeof(UnityEngine.Object).TypeHandle > 6)
			{
			}
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			while (focusedElement == null)
			{
			}
			int num = 0;
			while (focusedElement == null)
			{
			}
			CollectionTabButton selectedTab = _selectedTab;
			int num2 = 0;
			if (selectedTab != (UnityEngine.Object)num2)
			{
				CollectionTabButton selectedTab2 = _selectedTab;
				int num3 = ((selectedTab2.IsSelected = false) ? 1 : 0);
			}
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num4 = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num4);
			ulong num5 = default(ulong);
			SetFocus((byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001361")]
		[Cpp2IlInjected.Address(RVA = "0x113E110", Offset = "0x113CB10", VA = "0x18113E110", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0025
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int focus = 0;
				SetFocus((byte)focus != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001362")]
		[Cpp2IlInjected.Address(RVA = "0x113E9C0", Offset = "0x113D3C0", VA = "0x18113E9C0")]
		private void OnMemoryShardsCalled(CollectionItem item)
		{
			//Discarded unreachable code: IL_003b
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected I4, but got I8
			CollectionItemGroup componentInParent = item.GetComponentInParent<CollectionItemGroup>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				CollectionItemModel _003CModel_003Ek__BackingField = item.Model;
				CollectionItemGroupModel _003CModel_003Ek__BackingField2 = componentInParent.Model;
				ulong num2 = default(ulong);
				ShowMemoryShardsPopUp(cancellationToken, _003CModel_003Ek__BackingField2, _003CModel_003Ek__BackingField, (int)num2).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001363")]
		[Cpp2IlInjected.Address(RVA = "0x113F500", Offset = "0x113DF00", VA = "0x18113F500")]
		private void OnSkinshortcut()
		{
			//Discarded unreachable code: IL_008a
			//IL_0010: Expected O, but got I4
			//IL_0089: Expected I4, but got I8
			//IL_0089: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			ItemSlot currentItemslot = _currentItemslot;
			int num = 0;
			if (currentItemslot != (UnityEngine.Object)num)
			{
				SkinPopup.SkinPopupParam skinPopupParam = new SkinPopup.SkinPopupParam();
				CharacterSkinItemData[] array = (skinPopupParam.Skins = _currentItemslot._skins);
				CharacterManager.CharacterInstance characterInstance = (skinPopupParam.CharacterInstance = _currentItemslot.GetCharacterInstance());
				CharacterItemData characterItemData = (skinPopupParam.CharacterItemData = _currentItemslot._characterItemData);
				int num2 = 0;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				int num3 = 0;
				int num4 = 0;
				ulong num5 = default(ulong);
				redirection.Redirect(RedirectionType.SkinPopup, skinPopupParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001364")]
		[Cpp2IlInjected.Address(RVA = "0x113F660", Offset = "0x113E060", VA = "0x18113F660")]
		private void OnToolTipPart2()
		{
			//Discarded unreachable code: IL_0054
			CollectionTooltip tooltip = _tooltip;
			if ((object)tooltip != null)
			{
				int num = 0;
				if ((object)tooltip != null && (long)_frameDelay == 0)
				{
					int _003C_003E1__state = default(int);
					_003CFrameDelay_003Ed__82 _003CFrameDelay_003Ed__ = new _003CFrameDelay_003Ed__82(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CFrameDelay_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = (_frameDelay = StartCoroutine(_003CFrameDelay_003Ed__));
					bool flag = 0 == 0;
					_tootltipShortcutLabel.StringID = "menu.less_details";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001365")]
		[Cpp2IlInjected.Address(RVA = "0x113D860", Offset = "0x113C260", VA = "0x18113D860")]
		[IteratorStateMachine(typeof(_003CFrameDelay_003Ed__82))]
		private IEnumerator FrameDelay()
		{
			int _003C_003E1__state = default(int);
			_003CFrameDelay_003Ed__82 _003CFrameDelay_003Ed__ = new _003CFrameDelay_003Ed__82(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFrameDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001366")]
		[Cpp2IlInjected.Address(RVA = "0x113F810", Offset = "0x113E210", VA = "0x18113F810")]
		private void OnTooltipCalled(CollectionItem item, bool show)
		{
			//IL_0023: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_0305: Expected O, but got I4
			//IL_0385: Expected O, but got I4
			//IL_04b8: Expected O, but got I4
			EverywhereExceptionTooltip everywhereExceptionTooltip = default(EverywhereExceptionTooltip);
			ItemType itemType = default(ItemType);
			CollectionTooltip tooltip2 = default(CollectionTooltip);
			CraftingRecipeItemData craftingRecipeItemData = default(CraftingRecipeItemData);
			IEnumerable<> enumerable = default(IEnumerable<>);
			CollectionTooltipCraftingModel collectionTooltipCraftingModel = default(CollectionTooltipCraftingModel);
			ActivityItemType activityItemType = default(ActivityItemType);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			CollectionTooltip tooltip4 = default(CollectionTooltip);
			CollectionTooltipCraftingModel collectionTooltipCraftingModel2 = default(CollectionTooltipCraftingModel);
			IEnumerable<> cpp2il__autoParamName__idx_ = default(IEnumerable<>);
			MiningDataItemData[] miningDataList = default(MiningDataItemData[]);
			int num6 = default(int);
			List<ActivityDataLocationFilter> list = default(List<ActivityDataLocationFilter>);
			IRecurringEventData recurringEventData = default(IRecurringEventData);
			RecurringEventType recurringEventType = default(RecurringEventType);
			CollectionTooltipSpawningItemModel collectionTooltipSpawningItemModel = default(CollectionTooltipSpawningItemModel);
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = default(ItemSpawningInVillageRecurringEventItemData);
			List<VillageAreaType> list3 = default(List<VillageAreaType>);
			RepeatedField<VillageAreaType> repeatedField = default(RepeatedField<VillageAreaType>);
			IRecurringEventData recurringEventData2 = default(IRecurringEventData);
			IEnumerable<> cpp2il__autoParamName__idx_2 = default(IEnumerable<>);
			SeedItemData[] seedItemDataList = default(SeedItemData[]);
			IEnumerable<> cpp2il__autoParamName__idx_3 = default(IEnumerable<>);
			MiningDataItemData[] miningDataList2 = default(MiningDataItemData[]);
			Func<CraftingRecipeItemData, bool> func6;
			IEnumerable<> enumerable3 = default(IEnumerable<>);
			do
			{
				IL_0000:
				int displayPrice = 0;
				if (!show)
				{
					CollectionTooltip tooltip = _tooltip;
					int num = 0;
					if (tooltip != (UnityEngine.Object)num)
					{
						GameObject gameObject = _tooltip.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						GameObject tooltipShorcutIndicator = _tooltipShorcutIndicator;
						int active2 = 0;
						tooltipShorcutIndicator.SetActive((byte)active2 != 0);
						int num2 = 0;
						if (tooltip != (UnityEngine.Object)num2)
						{
							int num3 = 0;
						}
						return;
					}
				}
				if (_selectedTab.CollectionType != CollectionSubMenu.Crafting)
				{
					EverywhereExceptionTooltip[] everywhereItemException = _everywhereItemException;
					Predicate<EverywhereExceptionTooltip> predicate = (Predicate<EverywhereExceptionTooltip>)(object)(Predicate<T>)delegate(EverywhereExceptionTooltip element)
					{
						//Discarded unreachable code: IL_0021
						CollectionItem collectionItem = item;
						int itemID = element.ItemID;
						CollectionItemModel _003CModel_003Ek__BackingField = collectionItem.Model;
						IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)_003CModel_003Ek__BackingField).ItemData;
						return (IntPtr)itemID == (IntPtr)_003CModel_003Ek__BackingField;
					};
					if (everywhereExceptionTooltip == null)
					{
					}
				}
				IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
				int num4 = 0;
				if (num4 == 0)
				{
					goto IL_0000;
				}
				while (num4 == 0)
				{
				}
				if (num4 != 0)
				{
					if (num4 != 1)
					{
						while (itemType != ItemType.Companion)
						{
						}
						Type typeFromHandle = typeof(CollectionTooltipCritter);
						int lockTooltip = 0;
						CollectionTooltip collectionTooltip = (_tooltip = GetTooltipInstance(typeFromHandle, (byte)lockTooltip != 0));
						tooltip2 = _tooltip;
						CollectionTooltipCritterModel collectionTooltipCritterModel = new CollectionTooltipCritterModel();
						int num5 = 0;
						((CollectionTooltipModel)collectionTooltipCritterModel).ItemData = (IItemData)num5;
						tooltip2.Model = collectionTooltipCritterModel;
						_tooltip.RefreshDisplay();
					}
					if (_selectedTab.CollectionType != CollectionSubMenu.Crafting)
					{
						goto IL_0000;
					}
					Func<CraftingRecipeItemData, bool> func = (Func<CraftingRecipeItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)tooltip2)._003COnTooltipCalled_003Eb__1);
					craftingRecipeItemData = Enumerable.FirstOrDefault<CraftingRecipeItemData>(enumerable, (Func<, >)(object)func);
					while (craftingRecipeItemData == null)
					{
					}
					Type typeFromHandle2 = typeof(CollectionTooltipCrafting);
					int lockTooltip2 = 0;
					CollectionTooltip collectionTooltip2 = (_tooltip = GetTooltipInstance(typeFromHandle2, (byte)lockTooltip2 != 0));
					CollectionTooltip tooltip3 = _tooltip;
					collectionTooltipCraftingModel._craftingRecipeData = craftingRecipeItemData;
					collectionTooltipCraftingModel._displayPrice = (byte)displayPrice != 0;
					int iD_ = craftingRecipeItemData.iD_;
					((CollectionTooltipModel)collectionTooltipCraftingModel).ItemData = (IItemData)iD_;
				}
				UnknownFieldSet unknownFields = collectionTooltipCraftingModel._craftingRecipeData._unknownFields;
				if (activityItemType > ActivityItemType.Meal)
				{
					if (activityItemType == ActivityItemType.Fish)
					{
						if (_selectedTab.CollectionType != CollectionSubMenu.Crafting)
						{
							Type typeFromHandle3 = typeof(CollectionTooltipFishing);
							int lockTooltip3 = 0;
							CollectionTooltip collectionTooltip3 = (_tooltip = GetTooltipInstance(typeFromHandle3, (byte)lockTooltip3 != 0));
						}
						Func<CraftingRecipeItemData, bool> func2 = (Func<CraftingRecipeItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)craftingRecipeItemData)._003COnTooltipCalled_003Eb__5);
						CraftingRecipeItemData craftingRecipeItemData2 = Enumerable.FirstOrDefault<CraftingRecipeItemData>(enumerable2, (Func<, >)(object)func2);
						Type typeFromHandle4 = typeof(CollectionTooltipCrafting);
						int lockTooltip4 = 0;
						CollectionTooltip collectionTooltip4 = (_tooltip = GetTooltipInstance(typeFromHandle4, (byte)lockTooltip4 != 0));
						tooltip4 = _tooltip;
						collectionTooltipCraftingModel2._craftingRecipeData = craftingRecipeItemData2;
						collectionTooltipCraftingModel2._displayPrice = true;
						int iD_2 = craftingRecipeItemData2.iD_;
					}
					if ((long)collectionTooltipCraftingModel2 == 16)
					{
						if (_miningDataList == null)
						{
							MiningDataItemData[] array = (_miningDataList = cpp2il__autoParamName__idx_.ToArray<MiningDataItemData>());
							miningDataList = _miningDataList;
						}
						Func<MiningDataItemData, bool> func3 = (Func<MiningDataItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)tooltip4)._003COnTooltipCalled_003Eb__3);
						num6 = MoreLinq.FindIndex<MiningDataItemData>((IEnumerable<>)(object)miningDataList, (Func<, >)(object)func3);
						Type typeFromHandle5 = typeof(CollectionTooltipSellPrice);
						int lockTooltip5 = 0;
						CollectionTooltip collectionTooltip5 = (_tooltip = GetTooltipInstance(typeFromHandle5, (byte)lockTooltip5 != 0));
						Type typeFromHandle6 = typeof(CollectionTooltipFlower);
						int lockTooltip6 = 0;
						IntPtr cachedPtr2 = ((UnityEngine.Object)(_tooltip = GetTooltipInstance(typeFromHandle6, (byte)lockTooltip6 != 0)).CollectionItem).m_CachedPtr;
						int num7 = 0;
						List<ActivityDataLocationFilter> list2 = (List<ActivityDataLocationFilter>)(object)Enumerable.ToList<ActivityDataLocationFilter>((IEnumerable<>)list);
						if (list2 == null)
						{
							goto IL_0000;
						}
						CollectionTooltip tooltip5 = _tooltip;
						CollectionTooltipMiningDataItemModel collectionTooltipMiningDataItemModel = new CollectionTooltipMiningDataItemModel();
						int num8 = 0;
						((CollectionTooltipModel)collectionTooltipMiningDataItemModel).ItemData = (IItemData)num8;
						MiningDataItemData miningDataItemData = (collectionTooltipMiningDataItemModel.MiningDataItemData = _miningDataList[num6]);
						collectionTooltipMiningDataItemModel.Areas = list2;
					}
					if (num6 == 17)
					{
						goto IL_03c7;
					}
					if (recurringEventData == null || recurringEventType != 0 || recurringEventType != 0)
					{
						goto IL_0000;
					}
					Type typeFromHandle7 = typeof(CollectionTooltipFlower);
					int lockTooltip7 = 0;
					CollectionTooltip collectionTooltip6 = (_tooltip = GetTooltipInstance(typeFromHandle7, (byte)lockTooltip7 != 0));
					CollectionTooltip tooltip6 = _tooltip;
					collectionTooltipSpawningItemModel = new CollectionTooltipSpawningItemModel();
					int num9 = 0;
					((CollectionTooltipModel)collectionTooltipSpawningItemModel).ItemData = (IItemData)num9;
					collectionTooltipSpawningItemModel.RecurringEventItemData = itemSpawningInVillageRecurringEventItemData;
					int iD_3 = itemSpawningInVillageRecurringEventItemData.iD_;
					int num10 = 0;
					list3 = (collectionTooltipSpawningItemModel.Areas = (List<VillageAreaType>)(object)Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)repeatedField));
					tooltip6.Model = collectionTooltipSpawningItemModel;
					CollectionTooltip tooltip7 = _tooltip;
				}
				if ((long)list3 != 2)
				{
					goto IL_0000;
				}
				goto IL_03c7;
				IL_03c7:
				int size = ((List<>)(object)list3)._size;
				while (recurringEventData2 != null)
				{
				}
				if (_seedItemDataList == null)
				{
					SeedItemData[] array2 = (_seedItemDataList = cpp2il__autoParamName__idx_2.ToArray<SeedItemData>());
					seedItemDataList = _seedItemDataList;
				}
				Func<SeedItemData, bool> func4 = (Func<SeedItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)collectionTooltipSpawningItemModel)._003COnTooltipCalled_003Eb__4);
				int num11 = MoreLinq.FindIndex<SeedItemData>((IEnumerable<>)(object)seedItemDataList, (Func<, >)(object)func4);
				if (_miningDataList == null)
				{
					MiningDataItemData[] array3 = (_miningDataList = cpp2il__autoParamName__idx_3.ToArray<MiningDataItemData>());
					miningDataList2 = _miningDataList;
				}
				Func<MiningDataItemData, bool> func5 = (Func<MiningDataItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)collectionTooltipSpawningItemModel)._003COnTooltipCalled_003Eb__6);
				int num12 = MoreLinq.FindIndex<MiningDataItemData>((IEnumerable<>)(object)miningDataList2, (Func<, >)(object)func5);
				func6 = (Func<CraftingRecipeItemData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass83_0)(object)collectionTooltipSpawningItemModel)._003COnTooltipCalled_003Eb__10);
			}
			while (Enumerable.FirstOrDefault<CraftingRecipeItemData>(enumerable3, (Func<, >)(object)func6) == null || _selectedTab.CollectionType == CollectionSubMenu.Crafting);
			RepeatedField<VillageAreaType> repeatedField2 = default(RepeatedField<VillageAreaType>);
			while (repeatedField2 == null)
			{
			}
			Type typeFromHandle8 = typeof(CollectionTooltipFlower);
			int lockTooltip8 = 0;
			CollectionTooltip collectionTooltip7 = (_tooltip = GetTooltipInstance(typeFromHandle8, (byte)lockTooltip8 != 0));
			CollectionTooltipLootingItemModel collectionTooltipLootingItemModel = new CollectionTooltipLootingItemModel();
			int num13 = 0;
			((CollectionTooltipModel)collectionTooltipLootingItemModel).ItemData = (IItemData)num13;
			int num14 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001367")]
		[Cpp2IlInjected.Address(RVA = "0x1144A60", Offset = "0x1143460", VA = "0x181144A60")]
		private void SetEverywhereTooltip(IItemData data)
		{
			//Discarded unreachable code: IL_0038
			//IL_0037: Expected I4, but got I8
			CollectionTooltip collectionTooltip = default(CollectionTooltip);
			_tooltip = collectionTooltip;
			object obj = default(object);
			if (obj == null)
			{
			}
			int num = 0;
			if (obj != null)
			{
				collectionTooltip.Model.ItemData = data;
				if (_oldLayout == null || ((Menu)this)._matchWidthOrHeightValues != null)
				{
				}
				GameObject gameObject = default(GameObject);
				ulong num2 = default(ulong);
				gameObject.SetActive((byte)num2 != 0);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001368")]
		[Cpp2IlInjected.Address(RVA = "0x113DB40", Offset = "0x113C540", VA = "0x18113DB40")]
		private CollectionTooltip GetTooltipInstance(Type type, bool lockTooltip = false)
		{
			Type type2 = default(Type);
			if (!((object)type2).Equals((object)type))
			{
				GameObject trash = default(GameObject);
				_recycleBin.SendToBin(trash);
				_tooltipLockPrefab.SetActive(lockTooltip);
				if (!lockTooltip)
				{
					RecycleBin recycleBin = _recycleBin;
					Transform container = base.transform;
					CollectionTooltip collectionTooltip = (_tooltip = recycleBin.FindReusableOrNew(type, container).GetComponent<CollectionTooltip>());
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001369")]
		[Cpp2IlInjected.Address(RVA = "0x113F460", Offset = "0x113DE60", VA = "0x18113F460")]
		public unsafe void OnScroll(Vector2 delta)
		{
			//Discarded unreachable code: IL_0043
			//IL_0015: Expected O, but got I4
			//IL_003b: Expected F4, but got I4
			//IL_0036: Expected native int or pointer, but got O
			RectTransform collections = _collections;
			int num = 0;
			if (!(Vector2.Distance(collections.anchoredPosition, (Vector2)num) <= 1f))
			{
				Vector2 vector = (_oldPosition = _collections.anchoredPosition);
				((Vector2*)(IntPtr)_oldPosition)->y = 0f;
				RefreshFromScrollChange();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600136A")]
		[Cpp2IlInjected.Address(RVA = "0x1142330", Offset = "0x1140D30", VA = "0x181142330")]
		private void RefreshFromScrollChange()
		{
			//Discarded unreachable code: IL_0056, IL_005c, IL_0062, IL_006e
			int num = 0;
			IEnumerator enumerator = _collections.GetEnumerator();
			if (enumerator == null)
			{
				return;
			}
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if (enumerator == null)
			{
			}
			int num3 = 0;
			if (enumerator != null)
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				RectTransform viewport = _viewport;
				bool flag2 = default(bool);
				CollectionItemGroup collectionItemGroup = default(CollectionItemGroup);
				if (!flag2)
				{
					while (collectionItemGroup.IsVisible == flag2)
					{
					}
				}
				collectionItemGroup.IsVisible = flag2;
				collectionItemGroup.UpdateItemView();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600136B")]
		[Cpp2IlInjected.Address(RVA = "0x1145550", Offset = "0x1143F50", VA = "0x181145550")]
		private void ShowSkinShortcut(bool shouldShow, ItemSlot itemSlot)
		{
			//Discarded unreachable code: IL_0016
			//IL_0009: Expected O, but got I4
			int num = 0;
			_currentItemslot = (ItemSlot)num;
			_skinShortcutContainer.SetActive(shouldShow);
		}

		[Cpp2IlInjected.Token(Token = "0x600136C")]
		[Cpp2IlInjected.Address(RVA = "0x1145320", Offset = "0x1143D20", VA = "0x181145320")]
		public void SetVisibility(bool value, bool setScrollValue = true)
		{
			//Discarded unreachable code: IL_0062
			//IL_0030: Expected F4, but got I4
			if (setScrollValue)
			{
				float num = (_currentScrollValue = _scrollRect.m_VerticalScrollbar.value);
			}
			CanvasGroup canvasGroup = _canvasGroup;
			if (value)
			{
			}
			int num2 = 0;
			canvasGroup.alpha = num2;
			base.FocusNavigation.IsPaused = value;
			_mouseBlocker.SetActive(value);
			int num3 = 0;
			KeepVisible = value;
			UiRoot.Instance.MainMenuBar.SetVisibility(value);
		}

		[Cpp2IlInjected.Token(Token = "0x600136D")]
		[Cpp2IlInjected.Address(RVA = "0x1146310", Offset = "0x1144D10", VA = "0x181146310")]
		public unsafe CollectionMenu()
		{
			//IL_0030: Expected I4, but got I8
			//IL_0050: Expected I4, but got I8
			//IL_0060: Expected I4, but got I8
			//IL_0086: Expected F4, but got I4
			//IL_0081: Expected native int or pointer, but got O
			int num = 0;
			FocusedElementIndex = -1;
			IsOnTab = true;
			_switchFontMin = -1;
			_currentScrollValue = -1f;
			_oldPosition = Vector2.zero;
			((Vector2*)(IntPtr)_oldPosition)->y = 0f;
			base._002Ector();
		}
	}
}
