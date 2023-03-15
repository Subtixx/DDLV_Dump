using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B3")]
	public class FTUEWardrobePanel : MonoBehaviour, IStartFTUEPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018B2")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018B3")]
		public RectTransform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018B4")]
		public BaseButton NextButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018B5")]
		public BaseButton BackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40018B6")]
		[SerializeField]
		private DynamicFilterSelector _mcWardrobeCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40018B7")]
		public FtueClothingItem clothingItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40018B8")]
		[SerializeField]
		private RectTransform _mcWardrobeCategoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40018B9")]
		[SerializeField]
		private RectTransform _mcClothingItemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40018BA")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40018BB")]
		[SerializeField]
		private TextBase _tfItemsTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40018BC")]
		[SerializeField]
		private FilterColorConfig _colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40018BD")]
		[SerializeField]
		[NotNull]
		private GameObject _mcBackKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40018BE")]
		public Mdl.Avatar.AvatarCustomization AvatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40018BF")]
		private ClothingItemData[] _allClothes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40018C0")]
		private ClothingItemData[] _Clothes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40018C1")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40018C2")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40018C5")]
		private ISupportsFocusNavigation _focusedCategoryItem;

		[Cpp2IlInjected.Token(Token = "0x170004F6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x99"), Cpp2IlInjected.Token(Token = "0x40018C3")]
		public bool IsInAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA0")]
			[Cpp2IlInjected.Address(RVA = "0x1525170", Offset = "0x1523B70", VA = "0x181525170", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EA1")]
			[Cpp2IlInjected.Address(RVA = "0x15251B0", Offset = "0x1523BB0", VA = "0x1815251B0", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004F7")]
		public bool IsInCategoryDepth
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA2")]
			[Cpp2IlInjected.Address(RVA = "0x1525180", Offset = "0x1523B80", VA = "0x181525180")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcWardrobeCategoryContent.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F8")]
		public Filter CurrentFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA3")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EA4")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			set
			{
				_003CCurrentFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA5")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "6")]
		public Transform GetContent()
		{
			RectTransform animatedContent = AnimatedContent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA6")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
		public BaseButton GetBackButton()
		{
			return BackButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA7")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "8")]
		public BaseButton GetNextButton()
		{
			return NextButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA8")]
		[Cpp2IlInjected.Address(RVA = "0x88E390", Offset = "0x88CD90", VA = "0x18088E390")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = AnimatedContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA9")]
		[Cpp2IlInjected.Address(RVA = "0x15238C0", Offset = "0x15222C0", VA = "0x1815238C0")]
		public void Init(AvatarAppearance avatar)
		{
			//IL_009a: Expected O, but got I4
			if (!_constructed)
			{
				DynamicFilterSelector mcWardrobeCategorySelector = _mcWardrobeCategorySelector;
				_constructed = true;
				FilterSelector.FilterSelectedByUser value = SelectWardrobeCategory;
				mcWardrobeCategorySelector.OnFilterSelectedByUser += value;
				LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
				UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemdataHandler);
				((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
				LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listItems).m_OnItemTap;
				UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
				((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			}
			ScrollRect component = _mcWardrobeCategorySelector.GetComponent<ScrollRect>();
			RectTransform content = component.m_Content;
			int num = 0;
			Vector2 anchoredPosition = content.anchoredPosition;
			content.anchoredPosition = (Vector2)num;
			int num2 = ((component.enabled = false) ? 1 : 0);
			_avatar = avatar;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory wardrobe = SystemRoot.Instance.MetaClient.profile.Wardrobe;
			ClothingItemData[] array = (_allClothes = ItemDatabaseExtensions.GetOwnedClothes(_003CInstance_003Ek__BackingField, wardrobe).ToArray<ClothingItemData>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAA")]
		[Cpp2IlInjected.Address(RVA = "0x15235E0", Offset = "0x1521FE0", VA = "0x1815235E0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0067
			DynamicFilterSelector mcWardrobeCategorySelector = _mcWardrobeCategorySelector;
			_constructed = true;
			FilterSelector.FilterSelectedByUser value = SelectWardrobeCategory;
			mcWardrobeCategorySelector.OnFilterSelectedByUser += value;
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemdataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAB")]
		[Cpp2IlInjected.Address(RVA = "0x1523C60", Offset = "0x1522660", VA = "0x181523C60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0060
			DynamicFilterSelector mcWardrobeCategorySelector = _mcWardrobeCategorySelector;
			FilterSelector.FilterSelectedByUser value = SelectWardrobeCategory;
			mcWardrobeCategorySelector.OnFilterSelectedByUser += value;
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemdataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAC")]
		[Cpp2IlInjected.Address(RVA = "0x1524B90", Offset = "0x1523590", VA = "0x181524B90", Slot = "10")]
		public void Show()
		{
			RectTransform animatedContent = AnimatedContent;
			IsInAnimation = true;
			float z = Vector3.zero.z;
			AnimatedContent.gameObject.SetActive(value: true);
			AnimateIn();
			_mcBackKey.SetActive(value: true);
			Transform transform = AnimatedContent.transform;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_003a
				//IL_0015: Expected O, but got I4
				ScrollRect component = _mcWardrobeCategorySelector.GetComponent<ScrollRect>();
				int num = 0;
				if (component != (UnityEngine.Object)num)
				{
					RectTransform content = component.m_Content;
					Transform transform2 = component.transform;
					int num2 = ((component.enabled = false) ? 1 : 0);
				}
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAD")]
		[Cpp2IlInjected.Address(RVA = "0x1523760", Offset = "0x1522160", VA = "0x181523760", Slot = "11")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0064
			GameObject mcBackKey = _mcBackKey;
			IsInAnimation = true;
			int active = 0;
			mcBackKey.SetActive((byte)active != 0);
			RectTransform animatedContent = AnimatedContent;
			float z = Vector3.zero.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.InExpo);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_001d
				GameObject gameObject = AnimatedContent.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				AvatarCustomization.ResetZoomTarget();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAE")]
		[Cpp2IlInjected.Address(RVA = "0x1523DD0", Offset = "0x15227D0", VA = "0x181523DD0")]
		private void OnItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			FtueClothingItem component = args.DisplayObject.GetComponent<FtueClothingItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAF")]
		[Cpp2IlInjected.Address(RVA = "0x1523FB0", Offset = "0x15229B0", VA = "0x181523FB0")]
		private void OnItemdataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_007a
			//IL_0015: Expected O, but got I4
			FtueClothingItem component = args.DisplayObject.GetComponent<FtueClothingItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				ClothingItemData[] clothes = _Clothes;
				int itemIndex = args.ItemIndex;
				ClothingItemData clothingItemData = (component.ClothingItem = clothes[itemIndex]);
				bool flag = (component.IsMale = _avatar.IsMale);
				component.Refresh();
				ClothingItemData clothingItem = component.ClothingItem;
				AvatarAppearance avatar = _avatar;
				int iD = clothingItem.ID;
				bool isSelected = default(bool);
				component.IsSelected = isSelected;
				component.RefreshSelected();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB0")]
		[Cpp2IlInjected.Address(RVA = "0x15232D0", Offset = "0x1521CD0", VA = "0x1815232D0")]
		public void AnimateIn()
		{
			//Discarded unreachable code: IL_007e, IL_0084, IL_0090
			//IL_0059: Expected F4, but got I4
			int num = 0;
			_mcWardrobeCategorySelector.Init();
			IEnumerator enumerator = _mcWardrobeCategorySelector.filtersAnchor.GetEnumerator();
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			if (enumerator != null)
			{
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
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				float z = Vector3.zero.z;
				float z2 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				uint num4 = default(uint);
				tweenerCore = t.SetDelay((int)num4);
				num++;
			}
			if (tweenerCore != null)
			{
			}
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB1")]
		[Cpp2IlInjected.Address(RVA = "0x15246D0", Offset = "0x15230D0", VA = "0x1815246D0")]
		private void SelectWardrobeCategory()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB2")]
		[Cpp2IlInjected.Address(RVA = "0x1523120", Offset = "0x1521B20", VA = "0x181523120")]
		[IteratorStateMachine(typeof(_003CActivateItemsScrollRect_003Ed__41))]
		private IEnumerator ActivateItemsScrollRect()
		{
			int _003C_003E1__state = default(int);
			_003CActivateItemsScrollRect_003Ed__41 _003CActivateItemsScrollRect_003Ed__ = new _003CActivateItemsScrollRect_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CActivateItemsScrollRect_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB3")]
		[Cpp2IlInjected.Address(RVA = "0x1524120", Offset = "0x1522B20", VA = "0x181524120")]
		public void Populate(Filter selectedFilter)
		{
			//Discarded unreachable code: IL_00e9
			//IL_0096: Expected O, but got I4
			CurrentFilter = selectedFilter;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			string text = selectedFilter.Name;
			FilterColorConfig colorConfig = _colorConfig;
			int order = 0;
			Filter item = FilterUtil.BuildFilter(text, colorConfig, order);
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)item);
			int num = 0;
			ClothingItemData[] array = (_Clothes = (ClothingItemData[])(object)((List<T>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)(object)_allClothes, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num)).ToArray());
			ClothingItemData[] clothes = _Clothes;
			LoopVerticalScrollRect listItems = _listItems;
			int num2 = (listItems.totalCount = clothes.Length);
			RectTransform content = ((LoopScrollRect)_listItems).m_Content;
			int num3 = 0;
			Vector2 anchoredPosition = content.anchoredPosition;
			content.anchoredPosition = (Vector2)num3;
			LoopVerticalScrollRect listItems2 = _listItems;
			int offset = 0;
			listItems2.RefillCells(offset);
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_focusedCategoryItem = _focusNavigation._focusedElement);
				FocusNavigation focusNavigation = _focusNavigation;
				SetFocus(focusNavigation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB4")]
		[Cpp2IlInjected.Address(RVA = "0x1523190", Offset = "0x1521B90", VA = "0x181523190")]
		internal void ActivateScroller()
		{
			//Discarded unreachable code: IL_0033
			//IL_0015: Expected O, but got I4
			ScrollRect component = _mcWardrobeCategorySelector.GetComponent<ScrollRect>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				RectTransform content = component.m_Content;
				Transform transform = component.transform;
				int num2 = ((component.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB5")]
		[Cpp2IlInjected.Address(RVA = "0x15245B0", Offset = "0x1522FB0", VA = "0x1815245B0")]
		[AsyncStateMachine(typeof(_003CSelectCloth_003Ed__44))]
		private Task SelectCloth(FtueClothingItem instance)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB6")]
		[Cpp2IlInjected.Address(RVA = "0x1524330", Offset = "0x1522D30", VA = "0x181524330")]
		public void RefreshSelectedItems()
		{
			//Discarded unreachable code: IL_0040, IL_0052
			//IL_002c: Expected O, but got I4
			IEnumerator enumerator = ((LoopScrollRect)_listItems).m_Content.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				FtueClothingItem ftueClothingItem = default(FtueClothingItem);
				flag = ftueClothingItem != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				RefreshSelected(ftueClothingItem);
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB7")]
		[Cpp2IlInjected.Address(RVA = "0x1524530", Offset = "0x1522F30", VA = "0x181524530")]
		private void RefreshSelected(FtueClothingItem item)
		{
			//Discarded unreachable code: IL_0022
			AvatarAppearance avatar = _avatar;
			int iD = item.ClothingItem.ID;
			bool isSelected = default(bool);
			item.IsSelected = isSelected;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)item).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB8")]
		[Cpp2IlInjected.Address(RVA = "0x1524F10", Offset = "0x1523910", VA = "0x181524F10")]
		public void WardrobeCategoryClicked()
		{
			//Discarded unreachable code: IL_009b, IL_00a1, IL_00a7, IL_00b3
			AvatarCustomization.ZoomOut();
			_mcWardrobeCategoryContent.gameObject.SetActive(value: true);
			GameObject gameObject = _mcClothingItemsContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IEnumerator enumerator = _mcWardrobeCategorySelector.filtersAnchor.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				FilterItem filterItem = default(FilterItem);
				Filter _003CFilter_003Ek__BackingField = filterItem.Filter;
				Filter filter = CurrentFilter;
				if ((object)_003CFilter_003Ek__BackingField != null)
				{
					flag = _003CFilter_003Ek__BackingField.Equals(filter);
					while (!flag)
					{
					}
				}
				while ((object)filter != null)
				{
				}
			}
			if (flag)
			{
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB9")]
		[Cpp2IlInjected.Address(RVA = "0x1524A10", Offset = "0x1523410", VA = "0x181524A10", Slot = "9")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_00b0
			do
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					if (_mcClothingItemsContent.gameObject.activeSelf && ((LoopScrollRect)_listItems).m_Content.childCount > 0)
					{
						LoopVerticalScrollRect listItems = _listItems;
						FocusNavigation focusNavigation2 = _focusNavigation;
						RectTransform content = ((LoopScrollRect)listItems).m_Content;
						int index = 0;
						FocusNavigationElement component = content.GetChild(index).GetComponent<FocusNavigationElement>();
						focusNavigation2.SetFocus(component);
						return;
					}
					continue;
				}
				return;
			}
			while (!_mcWardrobeCategoryContent.gameObject.activeSelf);
			if (_focusedCategoryItem == null)
			{
				DynamicFilterSelector mcWardrobeCategorySelector = _mcWardrobeCategorySelector;
				FocusNavigation focusNavigation3 = _focusNavigation;
				mcWardrobeCategorySelector.SetFocus(focusNavigation3);
			}
			else
			{
				FocusNavigation focusNavigation4 = _focusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EBA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FTUEWardrobePanel()
		{
		}
	}
}
