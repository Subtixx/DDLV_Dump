using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000731")]
	public class StoreContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002998")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400299B")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400299C")]
		[SerializeField]
		private RectTransform _mcItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400299D")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400299E")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400299F")]
		[SerializeField]
		private List<FilterItemSelector> _filterSelectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40029A0")]
		[SerializeField]
		private FilterItemSelector _furnitureZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40029A1")]
		private List<Filter> _currentFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40029A2")]
		[SerializeField]
		private ListBase _listSelectedFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40029A3")]
		public bool SelectedFiltersVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40029A4")]
		[SerializeField]
		private GameObject _filterIco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40029A5")]
		public SlidingPanel slidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40029A6")]
		public Transform BackgroundCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40029A7")]
		public RectTransform CloseButtonHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40029A8")]
		public Action<Item, bool> OnDragItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40029A9")]
		public Action<InventoryItem> OnTapItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40029AA")]
		public Action<InventoryItem> OnBuyTap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40029AB")]
		private IItemData _selectedItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40029AC")]
		private StoreMenu.StoreItem[] _storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40029AD")]
		private IItemData[] _allItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40029AE")]
		private ListInventory _inventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40029AF")]
		[SerializeField]
		private FilterItemSelector _clothCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40029B0")]
		[SerializeField]
		private FilterItemSelector _furniturecategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40029B1")]
		[SerializeField]
		private FilterItemSelector _furnitureStyleFilterSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40029B2")]
		[SerializeField]
		private FilterItemSelector _apparelStyleFilterSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40029B3")]
		[SerializeField]
		[Header("Store items list")]
		private StoreList _questList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40029B4")]
		[SerializeField]
		private StoreList _storeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40029B5")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40029B6")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40029B7")]
		public AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40029B8")]
		private bool isDraging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40029B9")]
		private AsyncAtlassedIcon DragTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40029BA")]
		private Vector2 startPosition;

		[Cpp2IlInjected.Token(Token = "0x17000693")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DBC")]
			[Cpp2IlInjected.Address(RVA = "0x86BBB0", Offset = "0x86A5B0", VA = "0x18086BBB0")]
			[CompilerGenerated]
			internal set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000694")]
		public ItemFilterData ItemFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CItemFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DBE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CItemFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000695")]
		public LoopVerticalScrollRect ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _listItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000696")]
		public FilterColorConfig ColorConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return colorConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000697")]
		public List<FilterItemSelector> FilterSelectors
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC1")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _filterSelectors;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000698")]
		public StoreMenu.StoreItem[] StoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC2")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return _storeItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000699")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC3")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			get
			{
				return _avatar;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DC4")]
			[Cpp2IlInjected.Address(RVA = "0x86BB40", Offset = "0x86A540", VA = "0x18086BB40")]
			set
			{
				_avatar = value;
				StoreList questList = _questList;
				AvatarAppearance avatarAppearance = (questList.Avatar = _avatar);
				StoreList storeList = _storeList;
				AvatarAppearance avatarAppearance2 = (storeList.Avatar = _avatar);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC5")]
		[Cpp2IlInjected.Address(RVA = "0x869A00", Offset = "0x868400", VA = "0x180869A00")]
		private void Awake()
		{
			//Discarded unreachable code: IL_011f
			//IL_0030: Expected O, but got I4
			int num = 0;
			StoreList questList = _questList;
			Action<InventoryItem> action = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
			Delegate @delegate = Delegate.Combine(action, action);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questList.OnTapItem = (Action<InventoryItem>)num;
				StoreList storeList = _storeList;
				Action<InventoryItem> onTapItem = storeList.OnTapItem;
				Action<InventoryItem> b = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
				Delegate delegate2 = Delegate.Combine(onTapItem, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					storeList.OnTapItem = (Action<InventoryItem>)delegate2;
					StoreList questList2 = _questList;
					Action<InventoryItem> onBuyTap = questList2.OnBuyTap;
					Action<InventoryItem> b2 = (Action<InventoryItem>)(object)new Action<T>(OnTapBuy);
					Delegate delegate3 = Delegate.Combine(onBuyTap, b2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						questList2.OnBuyTap = (Action<InventoryItem>)delegate3;
						StoreList storeList2 = _storeList;
						Action<InventoryItem> onBuyTap2 = storeList2.OnBuyTap;
						Action<InventoryItem> b3 = (Action<InventoryItem>)(object)new Action<T>(OnTapBuy);
						Delegate delegate4 = Delegate.Combine(onBuyTap2, b3);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							storeList2.OnBuyTap = (Action<InventoryItem>)delegate4;
							ListBase.ListEvents onItemData = _listSelectedFilters.m_OnItemData;
							UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
							((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
							List<FilterItemSelector> filterSelectors = _filterSelectors;
							bool flag = default(bool);
							if (!flag)
							{
							}
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC6")]
		[Cpp2IlInjected.Address(RVA = "0x86AC50", Offset = "0x869650", VA = "0x18086AC50")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_010f
			//IL_0030: Expected O, but got I4
			StoreList questList = _questList;
			Action<InventoryItem> action = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
			Delegate @delegate = Delegate.Remove(action, action);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questList.OnTapItem = (Action<InventoryItem>)num;
				StoreList storeList = _storeList;
				Action<InventoryItem> onTapItem = storeList.OnTapItem;
				Action<InventoryItem> value = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
				Delegate delegate2 = Delegate.Remove(onTapItem, value);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					storeList.OnTapItem = (Action<InventoryItem>)delegate2;
					StoreList questList2 = _questList;
					Action<InventoryItem> onBuyTap = questList2.OnBuyTap;
					Action<InventoryItem> value2 = (Action<InventoryItem>)(object)new Action<T>(OnTapBuy);
					Delegate delegate3 = Delegate.Remove(onBuyTap, value2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						questList2.OnBuyTap = (Action<InventoryItem>)delegate3;
						StoreList storeList2 = _storeList;
						Action<InventoryItem> onBuyTap2 = storeList2.OnBuyTap;
						Action<InventoryItem> value3 = (Action<InventoryItem>)(object)new Action<T>(OnTapBuy);
						Delegate delegate4 = Delegate.Remove(onBuyTap2, value3);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							storeList2.OnBuyTap = (Action<InventoryItem>)delegate4;
							ListBase.ListEvents onItemData = _listSelectedFilters.m_OnItemData;
							UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
							((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC7")]
		[Cpp2IlInjected.Address(RVA = "0x86B2F0", Offset = "0x869CF0", VA = "0x18086B2F0")]
		public void SetFilters(ItemFilterData itemFilters, StoreMenu.StoreItem[] filteredSource)
		{
			//Discarded unreachable code: IL_0219
			//IL_011f: Expected O, but got I4
			//IL_01be: Expected O, but got I4
			ItemFilters = itemFilters;
			_questList.SetFilter(itemFilters);
			_storeList.SetFilter(itemFilters);
			ItemFilterData itemFilterData = ItemFilters;
			FilterItemSelector furnitureZone = _furnitureZone;
			ItemType type_ = itemFilterData.type_;
			GameObject gameObject = furnitureZone.gameObject;
			bool active = type_ != ItemType.Clothing;
			gameObject.SetActive(active);
			_furnitureStyleFilterSelector.gameObject.SetActive(active);
			GameObject gameObject2 = _apparelStyleFilterSelector.gameObject;
			bool active2 = type_ == ItemType.Clothing;
			gameObject2.SetActive(active2);
			if (itemFilters.type_ == ItemType.None)
			{
				StoreMenu.StoreItem[] array = (_storeItems = new StoreMenu.StoreItem[0]);
			}
			((List<T>)(object)_currentFilters)?.Clear();
			List<Filter> list = (_currentFilters = (List<Filter>)(object)new List<T>());
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			Action<FilterItemSelector> action = (Action<FilterItemSelector>)(object)(Action<T>)delegate(FilterItemSelector x)
			{
				//Discarded unreachable code: IL_003d
				List<Filter> currentFilters3 = _currentFilters;
				List<Filter> selectedFilters = x.selectedFilters;
				Func<Filter, bool> _003C_003E9__51_ = _003C_003Ec._003C_003E9__51_1;
				if (_003C_003E9__51_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter y)
					{
						if ((object)y == null)
						{
							return 0 == 0;
						}
						int num5 = 0;
						return (object)y == null;
					};
				}
				IEnumerable<Filter> enumerable = (IEnumerable<Filter>)Enumerable.Where<Filter>((IEnumerable<>)selectedFilters, (Func<, >)(object)_003C_003E9__51_);
				((List<T>)(object)currentFilters3).AddRange((IEnumerable<>)enumerable);
			};
			((List<T>)(object)filterSelectors).ForEach((Action<>)(object)action);
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)this.CurrentFilters();
			int num = 0;
			StoreMenu.StoreItem[] array2 = (_storeItems = (StoreMenu.StoreItem[])(object)((List<T>)(object)FilterUtil.Filter<StoreMenu.StoreItem>((IEnumerable<>)(object)filteredSource, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num)).ToArray());
			List<Filter> currentFilters = _currentFilters;
			RectTransform mcItemContent = _mcItemContent;
			int num2 = 0;
			Vector2 offsetMax = mcItemContent.offsetMax;
			mcItemContent.offsetMax = (Vector2)num2;
			GameObject gameObject3 = _listSelectedFilters.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			GameObject gameObject4 = _listSelectedFilters.gameObject;
			bool selectedFiltersVisible = SelectedFiltersVisible;
			gameObject4.SetActive(selectedFiltersVisible);
			List<Filter> currentFilters2 = _currentFilters;
			ListBase listSelectedFilters = _listSelectedFilters;
			int num3 = (listSelectedFilters.TotalCount = ((List<>)(object)currentFilters2)._size);
			if (_listSelectedFilters.gameObject.activeInHierarchy)
			{
				_filterContainer.DoAdjustment();
				_filterContent.DoAdjustment();
			}
			RectTransform mcItemContent2 = _mcItemContent;
			int num4 = 0;
			Vector2 offsetMax2 = mcItemContent2.offsetMax;
			mcItemContent2.offsetMax = (Vector2)num4;
			StoreList questList = _questList;
			int totalCount = questList._loopScrollRect.totalCount;
			GameObject gameObject5 = questList.gameObject;
			bool active4 = totalCount > 0;
			gameObject5.SetActive(active4);
			GameObject gameObject6 = _storeList.gameObject;
			bool active5 = totalCount <= 0;
			gameObject6.SetActive(active5);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcItemContent);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC8")]
		[Cpp2IlInjected.Address(RVA = "0x86B190", Offset = "0x869B90", VA = "0x18086B190")]
		public void RefreshList(bool isQuestCategory = false)
		{
			//Discarded unreachable code: IL_0071
			StoreMenu.StoreItem[] storeItems = _storeItems;
			if (storeItems != null)
			{
				if (isQuestCategory)
				{
					List<StoreMenu.StoreItem> questItems = (List<StoreMenu.StoreItem>)(object)this.GetQuestItems(storeItems, isQuestCategory);
					StoreList questList = _questList;
					StoreMenu.StoreItem[] data = (StoreMenu.StoreItem[])(object)((List<T>)(object)questItems).ToArray();
					questList.SetData(data);
				}
				StoreMenu.StoreItem[] buyableItems = GetBuyableItems(storeItems);
				_storeList.SetData(buyableItems);
				_questList.gameObject.SetActive(isQuestCategory);
				_storeList.gameObject.SetActive(isQuestCategory);
				LayoutRebuilder.ForceRebuildLayoutImmediate(_mcItemContent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC9")]
		[Cpp2IlInjected.Address(RVA = "0x86AFB0", Offset = "0x8699B0", VA = "0x18086AFB0")]
		private void OnSelectedFilterItemData(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCA")]
		[Cpp2IlInjected.Address(RVA = "0x86A270", Offset = "0x868C70", VA = "0x18086A270")]
		public StoreMenu.StoreItem[] GetBuyableItems(StoreMenu.StoreItem[] storeItems)
		{
			Func<StoreMenu.StoreItem, bool> _003C_003E9__54_ = _003C_003Ec._003C_003E9__54_0;
			if (_003C_003E9__54_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((StoreMenu.StoreItem x) => !IsLocked(x.Item));
			}
			return Enumerable.Where<StoreMenu.StoreItem>((IEnumerable<>)(object)storeItems, (Func<, >)(object)_003C_003E9__54_).ToArray<StoreMenu.StoreItem>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCB")]
		[Cpp2IlInjected.Address(RVA = "0x86A3B0", Offset = "0x868DB0", VA = "0x18086A3B0")]
		public List<StoreMenu.StoreItem> GetQuestItems(StoreMenu.StoreItem[] storeItems, bool hideOwned = true)
		{
			//Discarded unreachable code: IL_00d9
			List<ProfileWorld.FilterInfo> eligibleQuests = (List<ProfileWorld.FilterInfo>)(object)Enumerable.ToList<ProfileWorld.FilterInfo>(SystemRoot.Instance.Client.Profile.world_.GetFiltersPurchaseInfo());
			if (ItemFilters.type_ != ItemType.Clothing)
			{
				ListInventory catalog = SystemRoot.Instance.MetaClient.profile.Catalog;
			}
			ListInventory listInventory = (_inventory = SystemRoot.Instance.Client.Profile.Wardrobe);
			Func<StoreMenu.StoreItem, bool> func = (Func<StoreMenu.StoreItem, bool>)(object)(Func<T, TResult>)delegate(StoreMenu.StoreItem x)
			{
				//Discarded unreachable code: IL_0029
				List<ProfileWorld.FilterInfo> cpp2il__autoParamName__idx_ = eligibleQuests;
				Func<MissionObjective, bool> func3 = default(Func<MissionObjective, bool>);
				Func<ProfileWorld.FilterInfo, bool> cpp2il__autoParamName__idx_2 = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo quest)
				{
					//Discarded unreachable code: IL_002e
					List<MissionObjective> _003CObjectives_003Ek__BackingField = quest.Objectives;
					Func<MissionObjective, bool> func4 = func3;
					if (func4 == null)
					{
						func3 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
						{
							//Discarded unreachable code: IL_0018
							StoreMenu.StoreItem storeItem = x;
							ItemFilter itemFilter_ = obj.itemFilter_;
							IItemData item = storeItem.Item;
							bool result = default(bool);
							return result;
						};
					}
					return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)func4);
				};
				return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<ProfileWorld.FilterInfo>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			};
			List<StoreMenu.StoreItem> list = (List<StoreMenu.StoreItem>)(object)Enumerable.ToList<StoreMenu.StoreItem>(Enumerable.Where<StoreMenu.StoreItem>((IEnumerable<>)(object)storeItems, (Func<, >)(object)func));
			Func<StoreMenu.StoreItem, bool> @object = default(Func<StoreMenu.StoreItem, bool>);
			if (!hideOwned && _003C_003Ec._003C_003E9__55_2 == null)
			{
				@object = (Func<StoreMenu.StoreItem, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((StoreMenu.StoreItem x) => !IsLocked(x.Item)));
			}
			Func<StoreMenu.StoreItem, bool> func2 = (Func<StoreMenu.StoreItem, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass55_0)(object)@object)._003CGetQuestItems_003Eb__1);
			uint num = default(uint);
			return (List<StoreMenu.StoreItem>)(object)Enumerable.ToList<StoreMenu.StoreItem>(Enumerable.Take<StoreMenu.StoreItem>(Enumerable.Where<StoreMenu.StoreItem>((IEnumerable<>)list, (Func<, >)(object)func2), (int)num));
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCC")]
		[Cpp2IlInjected.Address(RVA = "0x86AB30", Offset = "0x869530", VA = "0x18086AB30")]
		private bool IsLowRarity(IItemData item, int minRarity = 2)
		{
			if ((object)typeof(IHasRarity).TypeHandle != null)
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCD")]
		[Cpp2IlInjected.Address(RVA = "0x86A870", Offset = "0x869270", VA = "0x18086A870")]
		private static bool IsLocked(IItemData data)
		{
			//Discarded unreachable code: IL_0056
			//IL_0046: Expected O, but got I4
			IHasUnlockConditions unlockConditions = data.GetUnlockConditions();
			Client metaClient = SystemRoot.Instance.MetaClient;
			int num = 0;
			if (unlockConditions != null)
			{
				int level_ = metaClient.profile.player_.level_;
				bool flag = default(bool);
				if (flag)
				{
				}
			}
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num2 = 0;
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			if (!(character == (UnityEngine.Object)num2))
			{
				return !character.IsUnlocked;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCE")]
		[Cpp2IlInjected.Address(RVA = "0x86ABC0", Offset = "0x8695C0", VA = "0x18086ABC0")]
		private bool IsOwned(ListInventory inventory, IItemData item)
		{
			ulong num = default(ulong);
			bool result = default(bool);
			if (inventory != null && item != null && num != 0)
			{
				return result;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCF")]
		[Cpp2IlInjected.Address(RVA = "0x86B0A0", Offset = "0x869AA0", VA = "0x18086B0A0")]
		private void OnTapBuy(InventoryItem item)
		{
			((Action<T>)(object)OnBuyTap)?.Invoke((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD0")]
		[Cpp2IlInjected.Address(RVA = "0x86AF50", Offset = "0x869950", VA = "0x18086AF50")]
		private void OnItemTap(InventoryItem item)
		{
			((Action<T>)(object)OnTapItem)?.Invoke((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD1")]
		[Cpp2IlInjected.Address(RVA = "0x86B7C0", Offset = "0x86A1C0", VA = "0x18086B7C0")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD2")]
		[Cpp2IlInjected.Address(RVA = "0x869E10", Offset = "0x868810", VA = "0x180869E10")]
		public HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0082, IL_0088, IL_008e
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__65_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
					{
						if ((object)x == null)
						{
							return 0 == 0;
						}
						int num3 = 0;
						return (object)x == null;
					};
				}
				IEnumerable<Filter> enumerable = default(IEnumerable<Filter>);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable);
			}
			if (_003C_003Ec._003C_003E9__65_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
				{
					if ((object)x == null)
					{
						return 0 == 0;
					}
					int num2 = 0;
					return (object)x == null;
				};
			}
			IEnumerable<Filter> enumerable2 = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable2);
			if (_003C_003Ec._003C_003E9__65_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
				{
					if ((object)x == null)
					{
						return 0 == 0;
					}
					int num = 0;
					return (object)x == null;
				};
			}
			IEnumerable<Filter> enumerable3 = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable3);
			return hashSet;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD3")]
		[Cpp2IlInjected.Address(RVA = "0x869DD0", Offset = "0x8687D0", VA = "0x180869DD0")]
		public void ClearCategoryFilters()
		{
			//Discarded unreachable code: IL_0017
			_clothCategorySelector.ClearAllSelected();
			_furniturecategorySelector.ClearAllSelected();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD4")]
		[Cpp2IlInjected.Address(RVA = "0x86B100", Offset = "0x869B00", VA = "0x18086B100")]
		public void RefreshAll()
		{
			//Discarded unreachable code: IL_0017
			_questList.RefreshAll();
			_storeList.RefreshAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD5")]
		[Cpp2IlInjected.Address(RVA = "0x86B140", Offset = "0x869B40", VA = "0x18086B140")]
		public void RefreshCells()
		{
			//Discarded unreachable code: IL_0021
			_questList._loopScrollRect.RefreshCells();
			_storeList._loopScrollRect.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD6")]
		[Cpp2IlInjected.Address(RVA = "0x86B990", Offset = "0x86A390", VA = "0x18086B990")]
		private void SetSizeForFilterContent()
		{
			//Discarded unreachable code: IL_0017
			_filterContainer.DoAdjustment();
			_filterContent.DoAdjustment();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StoreContent()
		{
		}
	}
}
