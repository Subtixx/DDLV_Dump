using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000517")]
	public class GiftMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000518")]
		public enum GiftMenuTabs
		{
			[Cpp2IlInjected.Token(Token = "0x4001B93")]
			Backpack,
			[Cpp2IlInjected.Token(Token = "0x4001B94")]
			Catalog,
			[Cpp2IlInjected.Token(Token = "0x4001B95")]
			Clothing
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B76")]
		private GiftMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B77")]
		private GiftMenuTabs _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B78")]
		private Dictionary<int, int> _selectedItemsAndAmount = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001B79")]
		private FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001B7A")]
		[SerializeField]
		private LoopVerticalScrollRect _listGiftItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001B7B")]
		[SerializeField]
		private ButtonTmPro _btnGive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001B7C")]
		[NotNull]
		[SerializeField]
		private NpcFavoritePanel _mcFavorites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001B7D")]
		[SerializeField]
		private Sprite _buyButtonBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001B7E")]
		[SerializeField]
		private Sprite _giveButtonBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001B7F")]
		[SerializeField]
		private BackpackItemInfo _itemInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001B80")]
		[SerializeField]
		private SlidingPanel _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001B81")]
		[SerializeField]
		private ListBase _listCurrencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001B82")]
		private List<Item> _currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001B83")]
		private (Item item, ItemState state, int amount, bool canGift)[] _inventoryItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001B84")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001B85")]
		[SerializeField]
		private TextBase _tfEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001B86")]
		[SerializeField]
		private ItemAmountSelector _amountSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001B87")]
		[SerializeField]
		private GameObject _selectedCountHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001B88")]
		[SerializeField]
		private TextBase _selectedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001B89")]
		[SerializeField]
		private AsyncMenu _favoritesPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001B8A")]
		[SerializeField]
		internal GridLayoutGroup _layoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001B8B")]
		[SerializeField]
		private float cooldownBetweenActionInSec = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001B8C")]
		[SerializeField]
		[Header("Critter feeding")]
		private GameObject _fedInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001B8D")]
		[SerializeField]
		private GameObject _fedComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001B8E")]
		[SerializeField]
		private GameObject _fedIncomplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001B8F")]
		private Coroutine cooldownCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001B90")]
		private float _favoritesRectTransformX = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4001B91")]
		private float _favoritesRectTransformY = -1f;

		[Cpp2IlInjected.Token(Token = "0x6002130")]
		[Cpp2IlInjected.Address(RVA = "0xE5AD80", Offset = "0xE59780", VA = "0x180E5AD80", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_005b
			//IL_0024: Expected O, but got I4
			base.OnPush(stack, param);
			if (param == null)
			{
				return;
			}
			int num = 0;
			if (param != null)
			{
				int num2 = 0;
				_param = (GiftMenuParam)param;
				int num3 = 0;
				bool flag = stack != (UnityEngine.Object)num3;
				_fedInfo.SetActive(flag);
				if (flag)
				{
					bool active = default(bool);
					_fedComplete.SetActive(active);
					GameObject fedIncomplete = _fedIncomplete;
					bool flag2 = default(bool);
					bool active2 = !flag2;
					fedIncomplete.SetActive(active2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002131")]
		[Cpp2IlInjected.Address(RVA = "0xE5AD40", Offset = "0xE59740", VA = "0x180E5AD40", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
			Coroutine coroutine = cooldownCoroutine;
			if (coroutine != null)
			{
				StopCoroutine(coroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002132")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B80", Offset = "0xAEF580", VA = "0x180AF0B80", Slot = "28")]
		public override void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterPreFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002133")]
		[Cpp2IlInjected.Address(RVA = "0xE58E60", Offset = "0xE57860", VA = "0x180E58E60", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0170
			//IL_00f1: Expected F4, but got O
			//IL_0106: Expected F4, but got I4
			base.OnFocusIn();
			_slider.Show(andOpen: true);
			GiftMenuParam param = _param;
			if (param != null)
			{
				ItemFilterData _003CItemfilter_003Ek__BackingField = param.Itemfilter;
				if (_003CItemfilter_003Ek__BackingField != null && _003CItemfilter_003Ek__BackingField.type_ != ItemType.Furniture)
				{
				}
			}
			_selectedTab = GiftMenuTabs.Clothing;
			LoopVerticalScrollRect listGiftItems = _listGiftItems;
			bool flag = (listGiftItems.DeselectWhenSelected = param.MaxSelectableItems == 1);
			GiftMenuParam param2 = _param;
			LoopVerticalScrollRect listGiftItems2 = _listGiftItems;
			bool flag2 = (listGiftItems2.DeselectOldest = param2.MaxSelectableItems == 1);
			GiftMenuParam param3 = _param;
			LoopVerticalScrollRect listGiftItems3 = _listGiftItems;
			int _003CMaxSelectableItems_003Ek__BackingField = default(int);
			if (param3 != null)
			{
				_003CMaxSelectableItems_003Ek__BackingField = param3.MaxSelectableItems;
			}
			listGiftItems3.MaxSelectableItems = _003CMaxSelectableItems_003Ek__BackingField;
			GameObject gameObject = _btnGive.gameObject;
			LoopVerticalScrollRect listGiftItems4 = _listGiftItems;
			bool active = default(bool);
			gameObject.SetActive(active);
			RefreshData(GiftMenuTabs.Clothing);
			RefreshDisplay();
			RefreshGiveButton();
			Vector2 anchoredPosition = _mcFavorites.GetComponent<RectTransform>().anchoredPosition;
			NpcFavoritePanel mcFavorites = _mcFavorites;
			_favoritesRectTransformX = (float)anchoredPosition;
			Vector2 anchoredPosition2 = mcFavorites.GetComponent<RectTransform>().anchoredPosition;
			_favoritesRectTransformY = 0f;
			ShowFavorites();
			base.IsDataUpToDate = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			_itemInfo.Hide();
			if ((long)cooldownCoroutine == 0)
			{
				int _003C_003E1__state = default(int);
				_003CCooldownBetweenAction_003Ed__52 _003CCooldownBetweenAction_003Ed__ = new _003CCooldownBetweenAction_003Ed__52(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CCooldownBetweenAction_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (cooldownCoroutine = StartCoroutine(_003CCooldownBetweenAction_003Ed__));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002134")]
		[Cpp2IlInjected.Address(RVA = "0xE5AF40", Offset = "0xE59940", VA = "0x180E5AF40", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__33))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__33 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__33(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002135")]
		[Cpp2IlInjected.Address(RVA = "0xE5C790", Offset = "0xE5B190", VA = "0x180E5C790", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0097
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listGiftItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listGiftItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectedHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterPreferredItemDiscover value2 = OnCharacterFavoriteChanged;
			_003CDispatcher_003Ek__BackingField2.OnCharacterPreferredItemDiscover += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002136")]
		[Cpp2IlInjected.Address(RVA = "0xE5D040", Offset = "0xE5BA40", VA = "0x180E5D040", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0097
			base.UnregisterFocusedListeners();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listGiftItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listGiftItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectedHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterPreferredItemDiscover value2 = OnCharacterFavoriteChanged;
			_003CDispatcher_003Ek__BackingField2.OnCharacterPreferredItemDiscover -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002137")]
		[Cpp2IlInjected.Address(RVA = "0xE5AFC0", Offset = "0xE599C0", VA = "0x180E5AFC0")]
		private void RefreshData(GiftMenuTabs menuTab)
		{
			Mdl.Online.Client client = default(Mdl.Online.Client);
			Mdl.Online.Client client2 = default(Mdl.Online.Client);
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<> enumerable3 = default(IEnumerable<>);
			Mdl.Online.Client client3 = default(Mdl.Online.Client);
			IEnumerable<> enumerable4 = default(IEnumerable<>);
			IEnumerable<> enumerable6 = default(IEnumerable<>);
			ContainerInventory backpack;
			Mdl.Online.Client client4 = default(Mdl.Online.Client);
			_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_;
			do
			{
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				if (menuTab != 0)
				{
					ListInventory catalog;
					IEnumerable<(Item item, ItemState state)> _allItems;
					if (menuTab != 0)
					{
						if (menuTab != GiftMenuTabs.Catalog)
						{
							RepeatedField<ContainerInventory.Types.Slot> inventory_ = client.Profile.Backpack.inventory_;
							Func<ContainerInventory.Types.Slot, (Item, ItemState, int, bool)> _003C_003E9__36_ = _003C_003Ec._003C_003E9__36_7;
							if (_003C_003E9__36_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
								{
									int num23 = 0;
									int num24 = 0;
									throw new NullReferenceException();
								};
							}
							(Item, ItemState, int, bool)[] array = Enumerable.Select<ContainerInventory.Types.Slot, (Item, ItemState, int, bool)>((IEnumerable<>)(object)inventory_, (Func<, >)(object)_003C_003E9__36_).ToArray<(Item, ItemState, int, bool)>();
						}
						ListInventory wardrobe = client2.Profile.Wardrobe;
						if ((long)_param.Itemfilter == 0)
						{
							ItemDatabase itemDatabase2 = itemDatabase;
							Func<ClothingItemData, (Item, ItemState, int, bool)> func = (Func<ClothingItemData, (Item, ItemState, int, bool)>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
							{
								//IL_0015: Expected O, but got I4
								//IL_002a: Expected O, but got I4
								int num17 = 0;
								int iD_ = x.iD_;
								int num18 = 0;
								bool flag6 = default(bool);
								if (flag6)
								{
									int num19 = isWearingOffset((Item)num17);
									num17 += num19;
								}
								int num20 = 0;
								int num21 = 0;
								catalog = (ListInventory)num20;
								int num22 = 0;
								throw new NullReferenceException();
							};
							IEnumerable<ClothingItemData> enumerable2 = (IEnumerable<ClothingItemData>)Enumerable.Select<ClothingItemData, (Item, ItemState, int, bool)>(enumerable, (Func<, >)(object)func);
						}
						ItemDatabase itemDatabase3 = itemDatabase;
						Func<ClothingItemData, (Item, ItemState)> _003C_003E9__36_2 = _003C_003Ec._003C_003E9__36_14;
						if (_003C_003E9__36_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								int num14 = 0;
								int num15 = 0;
								int num16 = 0;
								throw new NullReferenceException();
							};
						}
						_allItems = Enumerable.Select<ClothingItemData, (Item, ItemState)>(enumerable3, (Func<, >)(object)_003C_003E9__36_2).ToArray<(Item, ItemState)>();
						Func<(Item, ItemState), bool> func2 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_0023
							ItemDatabase itemDatabase6 = itemDatabase;
							ClothingItemData clothingItemData = default(ClothingItemData);
							if (!clothingItemData.isHidden_)
							{
							}
							bool flag5 = default(bool);
							int num13 = default(int);
							return (!flag5) ? flag5 : (num13 > 0);
						};
						ItemFilter itemFilter = new ItemFilter();
						RepeatedField<int> itemList_ = (itemFilter.data_ = _param.Itemfilter).itemList_;
						(Item, ItemState)[] array2 = ((Item, ItemState)[])(object)((List<T>)(object)itemFilter.ApplyFilter((IEnumerable<>)(object)itemList_)).ToArray();
					}
					catalog = client3.Profile.Catalog;
					if ((long)_param.Itemfilter == 0)
					{
						ItemDatabase itemDatabase4 = itemDatabase;
						Func<FurnitureItemData, (Item, ItemState, int, bool)> func3 = (Func<FurnitureItemData, (Item, ItemState, int, bool)>)(object)(Func<T, TResult>)delegate(FurnitureItemData x)
						{
							//IL_001d: Expected O, but got I4
							int num8 = 0;
							UnknownFieldSet unknownFields = x._unknownFields;
							int num9 = 0;
							bool flag4 = default(bool);
							if (flag4)
							{
							}
							int num10 = 0;
							int num11 = 0;
							catalog = (ListInventory)num10;
							int num12 = 0;
							throw new NullReferenceException();
						};
						IEnumerable<FurnitureItemData> enumerable5 = (IEnumerable<FurnitureItemData>)Enumerable.Select<FurnitureItemData, (Item, ItemState, int, bool)>(enumerable4, (Func<, >)(object)func3);
					}
					ItemDatabase itemDatabase5 = itemDatabase;
					Func<FurnitureItemData, (Item, ItemState)> _003C_003E9__36_3 = _003C_003Ec._003C_003E9__36_11;
					if (_003C_003E9__36_3 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							int num5 = 0;
							int num6 = 0;
							int num7 = 0;
							throw new NullReferenceException();
						};
					}
					_allItems = Enumerable.Select<FurnitureItemData, (Item, ItemState)>(enumerable6, (Func<, >)(object)_003C_003E9__36_3).ToArray<(Item, ItemState)>();
					Func<(Item, ItemState), bool> func4 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000f
						ListInventory listInventory = catalog;
						bool flag2 = default(bool);
						bool flag3 = default(bool);
						return (!flag2) ? flag2 : flag3;
					};
					ItemFilter itemFilter2 = new ItemFilter();
					RepeatedField<int> itemList_2 = (itemFilter2.data_ = _param.Itemfilter).itemList_;
					(Item, ItemState)[] array3 = ((Item, ItemState)[])(object)((List<T>)(object)itemFilter2.ApplyFilter((IEnumerable<>)(object)itemList_2)).ToArray();
					Func<(Item, ItemState), (Item, ItemState, int, bool)> func5 = (Func<(Item, ItemState), (Item, ItemState, int, bool)>)(object)(Func<T, TResult>)delegate
					{
						//IL_0011: Expected O, but got I4
						int num2 = 0;
						bool flag = default(bool);
						if (flag)
						{
						}
						int num3 = 0;
						int num4 = 0;
						catalog = (ListInventory)num3;
						throw new NullReferenceException();
					};
					IEnumerable<(Item, ItemState)> enumerable7 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), (Item, ItemState, int, bool)>((IEnumerable<>)(object)array3, (Func<, >)(object)func5);
				}
				backpack = client4.Profile.Backpack;
				RepeatedField<ContainerInventory.Types.Slot> inventory_2 = backpack.inventory_;
				Func<ContainerInventory.Types.Slot, (Item, ItemState)> _003C_003E9__36_4 = _003C_003Ec._003C_003E9__36_0;
				if (_003C_003E9__36_4 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						int num = 0;
						throw new NullReferenceException();
					};
				}
				_003C_003Ec__DisplayClass36_ = (_003C_003Ec__DisplayClass36_0)(object)Enumerable.Select<ContainerInventory.Types.Slot, (Item, ItemState)>((IEnumerable<>)(object)inventory_2, (Func<, >)(object)_003C_003E9__36_4);
			}
			while (_param.MissionGift);
			_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_2 = _003C_003Ec__DisplayClass36_;
			bool result = default(bool);
			Func<(Item, ItemState), bool> CS_0024_003C_003E8__locals1 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)(((Item item, ItemState state) x) => result);
			IEnumerable<(Item, ItemState)> enumerable8 = default(IEnumerable<(Item, ItemState)>);
			_003C_003Ec__DisplayClass36_ = (_003C_003Ec__DisplayClass36_0)(object)enumerable8;
			if ((long)_param.Itemfilter == 0)
			{
				IEnumerable<(Item, ItemState, int, bool)> itemsToDisplay = (IEnumerable<(Item, ItemState, int, bool)>)ContainerInventoryExtension.GetItemsToDisplay(backpack);
				Func<(Item, ItemState, int, bool), (Item, ItemState, int, bool)> func6 = (Func<(Item, ItemState, int, bool), (Item, ItemState, int, bool)>)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				(Item, ItemState, int, bool)[] array4 = (_inventoryItems = Enumerable.Select<(Item, ItemState, int, bool), (Item, ItemState, int, bool)>((IEnumerable<>)itemsToDisplay, (Func<, >)(object)func6).ToArray<(Item, ItemState, int, bool)>());
			}
			ItemFilter itemFilter3 = new ItemFilter();
			RepeatedField<int> itemList_3 = (itemFilter3.data_ = _param.Itemfilter).itemList_;
			(Item item, ItemState state)[] filteredItems = ((Item item, ItemState state)[])(object)((List<T>)(object)itemFilter3.ApplyFilter((IEnumerable<>)(object)itemList_3)).ToArray();
			Func<(Item, ItemState, int, bool), (Item, ItemState, int, bool)> func7 = (Func<(Item, ItemState, int, bool), (Item, ItemState, int, bool)>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x600214B")]
			[Cpp2IlInjected.Address(RVA = "0xE5CF60", Offset = "0xE5B960", VA = "0x180E5CF60")]
			static int isWearingOffset(Item _item)
			{
				ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002138")]
		[Cpp2IlInjected.Address(RVA = "0xE5BDB0", Offset = "0xE5A7B0", VA = "0x180E5BDB0")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_009d
			int num = _inventoryItems.Length;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<UpgradeBackpackItemData, int> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_0;
			if (_003C_003E9__37_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeBackpackItemData x) => x.backpackExpansionSize_);
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			UpgradeBackpackItemData upgradeBackpackItemData = Enumerable.FirstOrDefault<UpgradeBackpackItemData>((IEnumerable<>)Enumerable.OrderByDescending<UpgradeBackpackItemData, int>(enumerable, (Func<, >)(object)_003C_003E9__37_));
			if (upgradeBackpackItemData != null)
			{
				int backpackExpansionSize_ = upgradeBackpackItemData.backpackExpansionSize_;
				if (backpackExpansionSize_ > num)
				{
					num = backpackExpansionSize_;
				}
			}
			_listGiftItems.totalCount = num;
			LoopVerticalScrollRect listGiftItems = _listGiftItems;
			int offset = 0;
			listGiftItems.RefillCells(offset);
			GameObject gameObject = _tfEmpty.gameObject;
			bool active = _inventoryItems.Length == 0;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002139")]
		[Cpp2IlInjected.Address(RVA = "0xE5CA70", Offset = "0xE5B470", VA = "0x180E5CA70")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_003c, IL_0053, IL_0081, IL_008b, IL_0096
			//IL_0015: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				if (!_amountSelector.gameObject.activeSelf)
				{
					LoopVerticalScrollRect listGiftItems = _listGiftItems;
					int num2 = 0;
					focusNavigation.SetFocus((FocusNavigationElement)num2);
				}
				else
				{
					MenuNavigation menuNavigation = default(MenuNavigation);
					FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600213A")]
		[Cpp2IlInjected.Address(RVA = "0xE5C6C0", Offset = "0xE5B0C0", VA = "0x180E5C6C0")]
		private void RefreshTabs(GiftMenuTabs selectedTab)
		{
			//Discarded unreachable code: IL_0086
			GiftMenuParam param = _param;
			_selectedTab = selectedTab;
			LoopVerticalScrollRect listGiftItems = _listGiftItems;
			bool flag = (listGiftItems.DeselectWhenSelected = param.MaxSelectableItems == 1);
			GiftMenuParam param2 = _param;
			LoopVerticalScrollRect listGiftItems2 = _listGiftItems;
			bool flag2 = (listGiftItems2.DeselectOldest = param2.MaxSelectableItems == 1);
			GiftMenuParam param3 = _param;
			LoopVerticalScrollRect listGiftItems3 = _listGiftItems;
			if (param3 != null)
			{
			}
			listGiftItems3.MaxSelectableItems = 1;
			GameObject gameObject = _btnGive.gameObject;
			LoopVerticalScrollRect listGiftItems4 = _listGiftItems;
			bool active = default(bool);
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x600213B")]
		[Cpp2IlInjected.Address(RVA = "0xE589A0", Offset = "0xE573A0", VA = "0x180E589A0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0095
			//IL_0066: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			int[] selectedIndexes = _listGiftItems.SelectedIndexes;
			int num2 = 0;
			int length = selectedIndexes.Length;
			if (num2 < length)
			{
				LoopVerticalScrollRect listGiftItems = _listGiftItems;
				int index = selectedIndexes[num2];
				Transform itemByDataIndex = listGiftItems.GetItemByDataIndex(index);
				int num3 = 0;
				if (itemByDataIndex != (UnityEngine.Object)num3)
				{
					itemByDataIndex.GetComponentInChildren<TemplateComponent>()?.OnEnabled.Invoke();
				}
				num2++;
			}
			int isFirstShow = 0;
			ShowFavorites((byte)isFirstShow != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600213C")]
		[Cpp2IlInjected.Address(RVA = "0xE588E0", Offset = "0xE572E0", VA = "0x180E588E0")]
		private void OnCharacterFavoriteChanged(Character character, int preferredIndex, PreferredItemStatus newStatus)
		{
			//Discarded unreachable code: IL_0017
			if (_param.Character == character)
			{
				NpcFavoritePanel mcFavorites = _mcFavorites;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600213D")]
		[Cpp2IlInjected.Address(RVA = "0xE58CB0", Offset = "0xE576B0", VA = "0x180E58CB0")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600213E")]
		[Cpp2IlInjected.Address(RVA = "0xE58B20", Offset = "0xE57520", VA = "0x180E58B20")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_004a
			ListBase listCurrencyItems = _listCurrencyItems;
			int num = 0;
			if (num < listCurrencyItems._totalCount)
			{
				FreemiumCurrencyItem component = listCurrencyItems.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
				if ((object)component.CurrencyItem == null)
				{
					ListBase listCurrencyItems2 = _listCurrencyItems;
					num++;
				}
				Mdl.Online.Client client = default(Mdl.Online.Client);
				ProfilePlayer player_ = client.Profile.player_;
				int animatedAmount = default(int);
				component.AnimatedAmount = animatedAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600213F")]
		[Cpp2IlInjected.Address(RVA = "0xE59960", Offset = "0xE58360", VA = "0x180E59960")]
		private void OnItemDataHandler(ListEventData arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002140")]
		[Cpp2IlInjected.Address(RVA = "0xE5A2E0", Offset = "0xE58CE0", VA = "0x180E5A2E0")]
		private unsafe void OnItemSelect((Item item, ItemState state, int amount, bool canGift) item, bool select, int stars)
		{
			//IL_0054: Expected I4, but got O
			//IL_007c: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			while (true)
			{
				if (select && _selectedTab != GiftMenuTabs.Catalog)
				{
					BackpackItemInfo itemInfo = _itemInfo;
					return;
				}
				_itemInfo.Hide();
				if (Enumerable.Any<KeyValuePair<int, int>>((IEnumerable<>)_selectedItemsAndAmount))
				{
					KeyValuePair<int, int> keyValuePair = ((IEnumerable<>)_selectedItemsAndAmount).Last<KeyValuePair<int, int>>();
					Transform transform = ((LoopScrollRect)_listGiftItems).m_Content.transform;
					int index = (int)((KeyValuePair<, >*)(&keyValuePair))->key;
					Transform child = transform.GetChild(index);
					if ((object)child != null)
					{
						BackpackSlotInventoryItem component = child.GetComponent<BackpackSlotInventoryItem>();
					}
					int num = 0;
					int num2 = 0;
					if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
					{
						break;
					}
				}
			}
			BackpackItemInfo itemInfo2 = _itemInfo;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002141")]
		[Cpp2IlInjected.Address(RVA = "0xE596D0", Offset = "0xE580D0", VA = "0x180E596D0")]
		private void OnItemAmountChangeHandler(BackpackSlotInventoryItem item, int? amount)
		{
			//Discarded unreachable code: IL_009e
			//IL_0018: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			int num = default(int);
			Debug.LogError($"Amount changed={num}");
			Dictionary<int, int> selectedItemsAndAmount = _selectedItemsAndAmount;
			Func<KeyValuePair<int, int>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<int, int>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				BackpackSlotInventoryItem backpackSlotInventoryItem3 = item;
				bool result = default(bool);
				return result;
			};
			if (((IEnumerable<>)selectedItemsAndAmount).Any<KeyValuePair<int, int>>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				BackpackSlotInventoryItem backpackSlotInventoryItem = item;
				int num2 = default(int);
				bool flag = ((Dictionary<TKey, TValue>)(object)_selectedItemsAndAmount).Remove((TKey)num2);
			}
			int num3 = default(int);
			if (num3 > 0)
			{
				BackpackSlotInventoryItem backpackSlotInventoryItem2 = item;
				Dictionary<int, int> selectedItemsAndAmount2 = _selectedItemsAndAmount;
				throw new NullReferenceException();
			}
			RefreshGiveButton();
			_listGiftItems.RefreshCells();
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002142")]
		[Cpp2IlInjected.Address(RVA = "0xE5A500", Offset = "0xE58F00", VA = "0x180E5A500")]
		private void OnItemSelectedHandler(ListEventData arg0)
		{
			//Discarded unreachable code: IL_00e7, IL_00ec, IL_010e, IL_015a, IL_0160, IL_01df
			//IL_0036: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_010e: Expected I4, but got O
			//IL_013a: Expected I4, but got I8
			//IL_0141: Expected O, but got I4
			if ((long)cooldownCoroutine != 0)
			{
				return;
			}
			GameObject displayObject = arg0.DisplayObject;
			int num = 0;
			if ((object)displayObject != null)
			{
				BackpackSlotInventoryItem component = displayObject.GetComponent<BackpackSlotInventoryItem>();
			}
			BackpackSlotInventoryItem item = (BackpackSlotInventoryItem)num;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag || flag2)
			{
				return;
			}
			Dictionary<int, int> selectedItemsAndAmount = _selectedItemsAndAmount;
			Func<KeyValuePair<int, int>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<int, int>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				BackpackSlotInventoryItem backpackSlotInventoryItem = item;
				bool result = default(bool);
				return result;
			};
			MissionSlot quest;
			if (!((IEnumerable<>)selectedItemsAndAmount).Any<KeyValuePair<int, int>>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				if (_param != null)
				{
				}
				Dictionary<int, int> selectedItemsAndAmount2 = _selectedItemsAndAmount;
				Func<KeyValuePair<int, int>, int> func = default(Func<KeyValuePair<int, int>, int>);
				if (_003C_003Ec._003C_003E9__47_1 == null)
				{
					func = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				int num2 = Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)selectedItemsAndAmount2, (Func<, >)(object)func);
				if (_param != null)
				{
				}
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					if (num != 0 && (int)num3 > (int)num3)
					{
						Dictionary<int, int> selectedItemsAndAmount3 = _selectedItemsAndAmount;
						Transform child = default(Transform);
						int indexOf = _listGiftItems.GetIndexOf(child);
						throw new NullReferenceException();
					}
					Mdl.Online.Client client = default(Mdl.Online.Client);
					ProfileWorld world_ = client.Profile.world_;
					Func<MissionObjective, bool> func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
					{
						if (obj.Data.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.GiftToCharacter)
						{
							Item targetCharacterItem = obj.TargetCharacterItem;
							Character _003CCharacter_003Ek__BackingField = _param.Character;
							if (_003CCharacter_003Ek__BackingField != null)
							{
								int iD = _003CCharacter_003Ek__BackingField.Data.ID;
								int num10 = 0;
							}
							if (_003CCharacter_003Ek__BackingField != null && _003CCharacter_003Ek__BackingField != null)
							{
								return IsAnItemToGive(obj);
							}
						}
						int num11 = 0;
						throw new NullReferenceException();
					};
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(world_.GetOnGoingMissionObjectives((Func<, >)(object)func2));
					MissionSlot missionSlot = default(MissionSlot);
					if (missionObjective != null)
					{
						missionSlot = missionObjective.MissionSlot;
					}
					quest = missionSlot;
					if ((long)quest != 0)
					{
						int num4 = ItemToGiveSum();
					}
					((Dictionary<TKey, TValue>)(object)_selectedItemsAndAmount).Clear();
					Dictionary<int, int> selectedItemsAndAmount4 = _selectedItemsAndAmount;
					throw new NullReferenceException();
				}
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
			}
			Dictionary<int, int> selectedItemsAndAmount5 = _selectedItemsAndAmount;
			RefreshGiveButton();
			_listGiftItems.RefreshCells();
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002177")]
			[Cpp2IlInjected.Address(RVA = "0xC37A50", Offset = "0xC36450", VA = "0x180C37A50")]
			bool IsAnItemToGive(MissionObjective obj)
			{
				//Discarded unreachable code: IL_0066, IL_006c, IL_0072, IL_0078
				//IL_0024: Expected O, but got I4
				int num9;
				bool flag4 = default(bool);
				while (true)
				{
					int num8 = 0;
					num9 = 0;
					RepeatedField<ItemFilterData> itemsToGive_2 = obj.MissionSlot.itemsToGive_;
					if (!flag4)
					{
						break;
					}
					ItemFilter itemFilter2 = new ItemFilter
					{
						data_ = (ItemFilterData)0
					};
					Item[] array2 = new Item[1];
					Item item3 = (array2[0] = ((BackpackInventoryItem)item).Item);
					if (Enumerable.Any<Item>((IEnumerable<>)itemFilter2.ApplyFilter((IEnumerable<>)(object)array2)))
					{
						num9++;
						break;
					}
				}
				if (num9 + 1 != 0)
				{
				}
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002179")]
			[Cpp2IlInjected.Address(RVA = "0xC37CB0", Offset = "0xC366B0", VA = "0x180C37CB0")]
			int ItemToGiveSum()
			{
				//Discarded unreachable code: IL_006f, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d, IL_0093
				//IL_0021: Expected O, but got I4
				//IL_0064: Expected I4, but got O
				int num6 = 0;
				RepeatedField<ItemFilterData> itemsToGive_ = quest.itemsToGive_;
				bool flag3 = default(bool);
				if (flag3)
				{
					ItemFilter itemFilter = new ItemFilter
					{
						data_ = (ItemFilterData)0
					};
					Item[] array = new Item[1];
					Item item2 = (array[0] = ((BackpackInventoryItem)item).Item);
					if (Enumerable.Any<Item>((IEnumerable<>)itemFilter.ApplyFilter((IEnumerable<>)(object)array)))
					{
						int num7 = (int)((RepeatedField<T>)(object)quest.itemsToGiveAmount_)[num6];
						num6 += num7;
					}
					num6++;
				}
				return num6;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002143")]
		[Cpp2IlInjected.Address(RVA = "0xE5C040", Offset = "0xE5AA40", VA = "0x180E5C040")]
		private void RefreshGiveButton()
		{
			//Discarded unreachable code: IL_0131, IL_0137, IL_013d, IL_014f
			//IL_00b9: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			int num = 0;
			if (_param != null)
			{
			}
			Dictionary<int, int> selectedItemsAndAmount = _selectedItemsAndAmount;
			Func<KeyValuePair<int, int>, bool> func = default(Func<KeyValuePair<int, int>, bool>);
			if (_003C_003Ec._003C_003E9__48_0 == null)
			{
				bool result = default(bool);
				func = (Func<KeyValuePair<int, int>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> x) => result));
			}
			IEnumerable<KeyValuePair<int, int>> enumerable = (IEnumerable<KeyValuePair<int, int>>)Enumerable.Where<KeyValuePair<int, int>>((IEnumerable<>)selectedItemsAndAmount, (Func<, >)(object)func);
			Func<KeyValuePair<int, int>, int> func2 = default(Func<KeyValuePair<int, int>, int>);
			if (_003C_003Ec._003C_003E9__48_1 == null)
			{
				func2 = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			int num2 = Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			int num3 = Enumerable.Count<KeyValuePair<int, int>>((IEnumerable<>)enumerable);
			num2 -= num3;
			_listGiftItems.MaxSelectableItems = num3;
			IEnumerator enumerator = ((LoopScrollRect)_listGiftItems).m_Content.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
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
				int num6 = 0;
				GiftListItem giftListItem = default(GiftListItem);
				flag = giftListItem != (UnityEngine.Object)num6;
				while (!flag)
				{
				}
				Dictionary<int, int> dictionary = (giftListItem.SelectedItemsAndAmount = _selectedItemsAndAmount);
				giftListItem.RefreshAddButton();
			}
			int num7 = 0;
			if (flag)
			{
			}
			if (flag)
			{
			}
			Func<KeyValuePair<int, int>, int> func3 = default(Func<KeyValuePair<int, int>, int>);
			if (_003C_003Ec._003C_003E9__48_2 == null)
			{
				func3 = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			int num8 = Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)enumerable, (Func<, >)(object)func3);
			if (enumerable != null)
			{
			}
			bool flag2 = num8 == 1;
			if (num7 != 0)
			{
			}
			int num9 = default(int);
			string text = $"{num8}/{num9}";
		}

		[Cpp2IlInjected.Token(Token = "0x6002144")]
		[Cpp2IlInjected.Address(RVA = "0xE58930", Offset = "0xE57330", VA = "0x180E58930")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_0023
			//IL_0021: Expected O, but got I4
			PopSelf();
			GiftMenuParam param = _param;
			if (param != null)
			{
				Action<List<GiveItemsToCharacter.Types.ItemGiven>> _003CResultAction_003Ek__BackingField = param.ResultAction;
				int num = 0;
				_003CResultAction_003Ek__BackingField((T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002145")]
		[Cpp2IlInjected.Address(RVA = "0xE59140", Offset = "0xE57B40", VA = "0x180E59140")]
		public void OnGiveClicked()
		{
			//Discarded unreachable code: IL_016c, IL_0172, IL_0178, IL_017e, IL_0184, IL_018a, IL_0190, IL_0196, IL_019c, IL_01a2
			//IL_0022: Expected O, but got I4
			//IL_00f4: Expected I4, but got O
			//IL_011e: Expected I4, but got O
			//IL_0148: Expected I4, but got O
			uint iD_;
			Mdl.Online.Client client = default(Mdl.Online.Client);
			Mdl.Online.Client client2 = default(Mdl.Online.Client);
			Mdl.Online.Client client3 = default(Mdl.Online.Client);
			bool flag = default(bool);
			(Item, ItemState, int, bool) tuple = default((Item, ItemState, int, bool));
			GiveItemsToCharacter.Types.ListInventoryItemGiven listInventoryItemGiven2 = default(GiveItemsToCharacter.Types.ListInventoryItemGiven);
			do
			{
				ButtonTmPro btnGive = _btnGive;
				int num = 0;
				DialogueMenu menu = UiRoot.Instance._menuStack.GetMenu<DialogueMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					int num3 = 0;
					VibrationsManager.TriggerSelection();
					menu.HasGiftGiven = true;
				}
				int num4 = 0;
				UiRoot.Instance._menuStack.Pop();
				if ((long)_param == 0 || ((Dictionary<TKey, TValue>)(object)_selectedItemsAndAmount).Count <= 0)
				{
					break;
				}
				List<GiveItemsToCharacter.Types.ItemGiven> list = (List<GiveItemsToCharacter.Types.ItemGiven>)(object)new List<T>();
				iD_ = client.Profile.Catalog.iD_;
				uint iD_2 = client2.Profile.Wardrobe.iD_;
				uint iD_3 = client3.Profile.Backpack.iD_;
				Dictionary<int, int> selectedItemsAndAmount = _selectedItemsAndAmount;
				if (!flag)
				{
					continue;
				}
				GiveItemsToCharacter.Types.ItemGiven itemGiven = new GiveItemsToCharacter.Types.ItemGiven();
				(Item, ItemState, int, bool)[] inventoryItems = _inventoryItems;
				GiftMenuTabs selectedTab = _selectedTab;
				if (selectedTab != 0)
				{
					if (selectedTab != 0)
					{
						if (selectedTab != GiftMenuTabs.Catalog)
						{
							goto IL_0159;
						}
						GiveItemsToCharacter.Types.ListInventoryItemGiven listInventoryItemGiven = new GiveItemsToCharacter.Types.ListInventoryItemGiven();
						listInventoryItemGiven.inventoryID_ = iD_2;
						listInventoryItemGiven.itemID_ = (int)tuple;
						listInventoryItemGiven.amount_ = 0;
						itemGiven.ListInventoryItemGiven = listInventoryItemGiven;
					}
					listInventoryItemGiven2 = new GiveItemsToCharacter.Types.ListInventoryItemGiven();
					listInventoryItemGiven2.inventoryID_ = iD_;
					listInventoryItemGiven2.itemID_ = (int)tuple;
					listInventoryItemGiven2.amount_ = 0;
					itemGiven.ListInventoryItemGiven = listInventoryItemGiven2;
				}
				GiveItemsToCharacter.Types.ContainerInventoryItemGiven containerInventoryItemGiven = new GiveItemsToCharacter.Types.ContainerInventoryItemGiven();
				containerInventoryItemGiven.inventoryID_ = iD_3;
				containerInventoryItemGiven.inventoryPosition_ = (int)listInventoryItemGiven2;
				containerInventoryItemGiven.amount_ = 0;
				itemGiven.ContainerInventoryItemGiven = containerInventoryItemGiven;
				goto IL_0159;
				IL_0159:
				((List<T>)(object)list).Add((T)itemGiven);
			}
			while (iD_ != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002146")]
		[Cpp2IlInjected.Address(RVA = "0xE58510", Offset = "0xE56F10", VA = "0x180E58510", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0136
			//IL_0041: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			GiftListItem giftListItem = default(GiftListItem);
			GiftListItem giftListItem2 = default(GiftListItem);
			Button buttonComponent2 = default(Button);
			BaseButton btnSubtract2 = default(BaseButton);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				if (redirectionType > RedirectionType.GamePopCurrentMenu)
				{
					if (redirectionType == RedirectionType.GameClickButtonPlus)
					{
						if ((object)focusNavigation == null || focusNavigation._focusedElement == null)
						{
							break;
						}
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						if (giftListItem != (UnityEngine.Object)num4)
						{
							BaseButton btnAdd = ((InventorySellItem)giftListItem)._btnAdd;
							if (btnAdd._isActive)
							{
								Button buttonComponent = btnAdd.ButtonComponent;
								((InventorySellItem)giftListItem)._btnAdd?.ButtonComponent.m_OnClick?.Invoke();
							}
						}
						break;
					}
					while (redirectionType != RedirectionType.GameClickButtonMinus)
					{
					}
					while ((object)focusNavigation == null)
					{
					}
					if (focusNavigation._focusedElement == null)
					{
						continue;
					}
					int num5 = 0;
					int num6 = 0;
					int num7 = 0;
					if (!(giftListItem2 != (UnityEngine.Object)num7))
					{
						continue;
					}
					BaseButton btnSubtract = ((InventorySellItem)giftListItem2)._btnSubtract;
					while (!btnSubtract._isActive)
					{
					}
					buttonComponent2 = btnSubtract.ButtonComponent;
					btnSubtract2 = ((InventorySellItem)giftListItem2)._btnSubtract;
				}
				if ((long)buttonComponent2 > 1)
				{
					while (redirectionType != RedirectionType.GamePopCurrentMenu)
					{
					}
				}
				if (!btnSubtract2.gameObject.activeSelf)
				{
					if (giftListItem2.MaxSelectableItems != 0)
					{
						int num8 = 0;
						break;
					}
					continue;
				}
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				int num9 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002147")]
		[Cpp2IlInjected.Address(RVA = "0xE584A0", Offset = "0xE56EA0", VA = "0x180E584A0")]
		[IteratorStateMachine(typeof(_003CCooldownBetweenAction_003Ed__52))]
		private IEnumerator CooldownBetweenAction()
		{
			int _003C_003E1__state = default(int);
			_003CCooldownBetweenAction_003Ed__52 _003CCooldownBetweenAction_003Ed__ = new _003CCooldownBetweenAction_003Ed__52(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCooldownBetweenAction_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002148")]
		[Cpp2IlInjected.Address(RVA = "0xE5CCA0", Offset = "0xE5B6A0", VA = "0x180E5CCA0")]
		private void ShowFavorites(bool isFirstShow = true)
		{
			//Discarded unreachable code: IL_00c2
			//IL_008a: Expected O, but got I4
			GiftMenuParam param = _param;
			if (param != null && (long)param.Character != 0)
			{
				_mcFavorites.gameObject.SetActive(value: true);
				GiftMenuParam param2 = _param;
				NpcFavoritePanel mcFavorites = _mcFavorites;
				Character _003CCharacter_003Ek__BackingField = param2.Character;
				mcFavorites.RefreshDisplay(_003CCharacter_003Ek__BackingField);
				Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
				SetCharacterPreferredItemsAsSeen.Types.Request request = new SetCharacterPreferredItemsAsSeen.Types.Request();
				int num = (request.characterItemID_ = _param.Character.base_.id_);
				int num2 = 0;
				metaClient.SetCharacterPreferredItemsAsSeen(request, (CancellationToken)num2).FireAndForgetTask();
				RectTransform component = _mcFavorites.GetComponent<RectTransform>();
				float favoritesRectTransformX = _favoritesRectTransformX;
				float favoritesRectTransformY = _favoritesRectTransformY;
				if (isFirstShow)
				{
					_mcFavorites.GetComponent<SlidingPanel>().Show(andOpen: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002149")]
		[Cpp2IlInjected.Address(RVA = "0xE5D320", Offset = "0xE5BD20", VA = "0x180E5D320")]
		public GiftMenu()
		{
		}
	}
}
