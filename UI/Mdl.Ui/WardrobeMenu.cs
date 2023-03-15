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
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200078F")]
	[RequiredAllNotNull]
	public class WardrobeMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000790")]
		public enum WardrobeMenuPhase
		{
			[Cpp2IlInjected.Token(Token = "0x4002C3F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002C40")]
			CategoryPhase,
			[Cpp2IlInjected.Token(Token = "0x4002C41")]
			FilterPhase,
			[Cpp2IlInjected.Token(Token = "0x4002C42")]
			ClothContentPhase,
			[Cpp2IlInjected.Token(Token = "0x4002C43")]
			AvatarContentPhase,
			[Cpp2IlInjected.Token(Token = "0x4002C44")]
			Quest,
			[Cpp2IlInjected.Token(Token = "0x4002C45")]
			HistoryChange
		}

		[Cpp2IlInjected.Token(Token = "0x2000791")]
		public enum ToMState
		{
			[Cpp2IlInjected.Token(Token = "0x4002C47")]
			EditingNew,
			[Cpp2IlInjected.Token(Token = "0x4002C48")]
			EditingExisting,
			[Cpp2IlInjected.Token(Token = "0x4002C49")]
			None
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002BF6")]
		public ToMState ToMCurrentState = ToMState.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002BF7")]
		private List<int> _tempToMList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002BF8")]
		private int _currentToMIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4002BF9")]
		[Range(0f, 15f)]
		public int TweakAnimationCooldown = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002BFA")]
		private float _cooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002BFB")]
		[Space]
		[SerializeField]
		private WardrobeAppearanceContent _mcAppearanceContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002BFC")]
		[SerializeField]
		private LoopVerticalScrollRect _listClothItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002BFD")]
		[SerializeField]
		private DecalDesignContent _mcDecalDesignContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002BFE")]
		[SerializeField]
		private DecalBaseItemsContent _mcBaseItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002BFF")]
		[SerializeField]
		private PetsContent _petsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002C00")]
		[SerializeField]
		private ListBase _listSelectedFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002C01")]
		[SerializeField]
		private RectTransform _mcItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002C02")]
		[SerializeField]
		private RectTransform _mcCategoriesContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002C03")]
		[SerializeField]
		private RectTransform _mcFilterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002C04")]
		[SerializeField]
		private GameObject _filterFooter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002C05")]
		[SerializeField]
		private ButtonTmProIcon _btnFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002C06")]
		[SerializeField]
		private HorizontalLayoutGroup _btnFiltersLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002C07")]
		[SerializeField]
		private BaseButton _btnBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002C08")]
		[SerializeField]
		private Button _btnExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002C09")]
		[SerializeField]
		private NotificationButton _btnUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002C0A")]
		[SerializeField]
		private NotificationButton _btnUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002C0B")]
		[SerializeField]
		private GameObject _emptyMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002C0C")]
		[SerializeField]
		private SlidingPanel _contentSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002C0D")]
		[SerializeField]
		private TextBase _tfSelectedCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002C0E")]
		[SerializeField]
		private List<FilterItemSelector> _filterSelectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002C0F")]
		[SerializeField]
		private FilterItemSelector _clothCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002C10")]
		[SerializeField]
		private DynamicFilterSelector _avatarCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4002C11")]
		[SerializeField]
		private QuestFilterSelector _questSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4002C12")]
		[SerializeField]
		private SelectGenderPanel _mcGenderPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4002C13")]
		[SerializeField]
		private WardrobeMakeupContent _mcMakeupPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4002C14")]
		[SerializeField]
		private GameObject _mcFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4002C15")]
		[SerializeField]
		private GameObject _filterIco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4002C16")]
		[SerializeField]
		private TextBase _tfFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4002C17")]
		[SerializeField]
		private Button _btnFilterReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002C18")]
		[SerializeField]
		private Button _btnFilterApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4002C19")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4002C1A")]
		[SerializeField]
		private Sprite _spriteCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4002C1B")]
		[SerializeField]
		private Sprite _spriteCustomizationBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4002C1C")]
		[SerializeField]
		private Sprite _spritePets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4002C1D")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4002C1E")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4002C1F")]
		[SerializeField]
		private Image _highlightImageUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4002C20")]
		[SerializeField]
		private SimpleSlide _simpleSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4002C21")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4002C22")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4002C23")]
		[SerializeField]
		private FilterHelper _filterHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4002C24")]
		private ClothingItemData[] _allClothesDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4002C25")]
		private ClothingItemData[] _allClothes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4002C26")]
		private ClothingItemData[] _Clothes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4002C27")]
		private Mdl.Avatar.AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4002C28")]
		private MissionSlot _missionFilterSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4002C29")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4002C2A")]
		private WardrobeMenuParam _wardrobeMenuParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4002C2B")]
		private bool _isFilteringLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4002C2C")]
		private List<Filter> _currentFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4002C2D")]
		private ISupportsFocusNavigation _focusedCategoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4002C2E")]
		private WardrobeMenuPhase _currentPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4002C2F")]
		[ItemID]
		public int Barefeet = 50200103;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4002C30")]
		[ItemID]
		public int DefaultBottomInner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4002C31")]
		protected InputAction inputActionUndoPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4002C32")]
		protected InputAction inputActionUndoRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4002C33")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4002C34")]
		private bool _justFiredPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B1")]
		[Cpp2IlInjected.Token(Token = "0x4002C35")]
		private bool _showNewItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B2")]
		[Cpp2IlInjected.Token(Token = "0x4002C36")]
		private bool _showNewCritter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4002C37")]
		private FocusNavigationElement _lastFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4002C38")]
		private InputAction resetFilterActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4002C39")]
		private InputAction resetFilterActionRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4002C3A")]
		public int ToMIndexToFocus = -1;

		[Cpp2IlInjected.Token(Token = "0x4002C3B")]
		private const int sortFactorLevel = 1;

		[Cpp2IlInjected.Token(Token = "0x4002C3C")]
		private const int sortFactorUnlocked = 100;

		[Cpp2IlInjected.Token(Token = "0x4002C3D")]
		private const int sortFactorOwned = 1000000;

		[Cpp2IlInjected.Token(Token = "0x170006D0")]
		public new FocusNavigation FocusNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6003045")]
			[Cpp2IlInjected.Address(RVA = "0xA4C8F0", Offset = "0xA4B2F0", VA = "0x180A4C8F0")]
			get
			{
				return _focusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003046")]
		[Cpp2IlInjected.Address(RVA = "0x14EBD40", Offset = "0x14EA740", VA = "0x1814EBD40", Slot = "30")]
		protected unsafe override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0286
			//IL_01d7: Expected O, but got I4
			//IL_0254: Expected O, but got I4
			((object)this)._002Ector();
			FilterItemSelector clothCategorySelector = _clothCategorySelector;
			FilterSelector.FilterSelectedByUser value = OnClothCategorySelected;
			clothCategorySelector.OnFilterSelectedByUser += value;
			DynamicFilterSelector avatarCategorySelector = _avatarCategorySelector;
			FilterSelector.FilterSelectedByUser value2 = OnAvatarCategorySelected;
			avatarCategorySelector.OnFilterSelectedByUser += value2;
			Button.ButtonClickedEvent onClick = _btnExit.m_OnClick;
			UnityAction call = OnCloseClicked;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnBack.ButtonComponent.m_OnClick;
			UnityAction call2 = OnBackClicked;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnFilters.ButtonComponent.m_OnClick;
			UnityAction call3 = OnFilterClicked;
			onClick3.AddListener(call3);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listClothItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnClothItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listClothItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnClothItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData2 = _listSelectedFilters.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick4 = _btnFilterApply.m_OnClick;
			UnityAction call4 = OnApplyClickHandler;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnUndo.ButtonComponent.m_OnClick;
			UnityAction call5 = OnUndoClickHandler;
			onClick5.AddListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call6 = OnUndoAllClickHandler;
			onClick6.AddListener(call6);
			QuestFilterSelector questSelector = _questSelector;
			Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
			Action<ProfileWorld.FilterInfo> b = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
			Delegate @delegate = Delegate.Combine(_003COnQuestSelected_003Ek__BackingField, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)num;
				SelectGenderPanel mcGenderPanel = _mcGenderPanel;
				Action onChangeGender = mcGenderPanel.OnChangeGender;
				Action b2 = OnGenderChangeHandler;
				Delegate delegate2 = Delegate.Combine(onChangeGender, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcGenderPanel.OnChangeGender = (Action)delegate2;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigation.FocusChanged value3 = OnFocusChanged;
					focusNavigation.OnFocusChanged += value3;
					ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
					int num2 = 0;
					if (component != (UnityEngine.Object)num2)
					{
						BaseButton.OnBaseButtonPress value4 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(WardrobeMenu.OnResetPressHandler));
						component.OnPress += value4;
						BaseButton.OnBaseButtonRelease value5 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(WardrobeMenu.OnResetReleaseHandler));
						component.OnRelease += value5;
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003047")]
		[Cpp2IlInjected.Address(RVA = "0x14EE370", Offset = "0x14ECD70", VA = "0x1814EE370", Slot = "31")]
		protected unsafe override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_02e3
			//IL_01d7: Expected O, but got I4
			//IL_0273: Expected O, but got I4
			((object)this)._002Ector();
			FilterItemSelector clothCategorySelector = _clothCategorySelector;
			FilterSelector.FilterSelectedByUser value = OnClothCategorySelected;
			clothCategorySelector.OnFilterSelectedByUser -= value;
			DynamicFilterSelector avatarCategorySelector = _avatarCategorySelector;
			FilterSelector.FilterSelectedByUser value2 = OnAvatarCategorySelected;
			avatarCategorySelector.OnFilterSelectedByUser -= value2;
			Button.ButtonClickedEvent onClick = _btnExit.m_OnClick;
			UnityAction call = OnCloseClicked;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnBack.ButtonComponent.m_OnClick;
			UnityAction call2 = OnBackClicked;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnFilters.ButtonComponent.m_OnClick;
			UnityAction call3 = OnFilterClicked;
			onClick3.RemoveListener(call3);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listClothItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnClothItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listClothItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnClothItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData2 = _listSelectedFilters.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick4 = _btnFilterApply.m_OnClick;
			UnityAction call4 = OnApplyClickHandler;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnUndo.ButtonComponent.m_OnClick;
			UnityAction call5 = OnUndoClickHandler;
			onClick5.RemoveListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call6 = OnUndoAllClickHandler;
			onClick6.RemoveListener(call6);
			QuestFilterSelector questSelector = _questSelector;
			Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
			Action<ProfileWorld.FilterInfo> value3 = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
			Delegate @delegate = Delegate.Remove(_003COnQuestSelected_003Ek__BackingField, value3);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)num;
				SelectGenderPanel mcGenderPanel = _mcGenderPanel;
				Action onChangeGender = mcGenderPanel.OnChangeGender;
				Action value4 = OnGenderChangeHandler;
				Delegate delegate2 = Delegate.Remove(onChangeGender, value4);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcGenderPanel.OnChangeGender = (Action)delegate2;
					Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
					Mdl.Avatar.AvatarCustomization.AvatarReady value5 = OnAvatarReady;
					avatarCustomization.OnAvatarReady -= value5;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigation.FocusChanged value6 = OnFocusChanged;
					focusNavigation.OnFocusChanged -= value6;
					ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
					int num2 = 0;
					if (component != (UnityEngine.Object)num2)
					{
						BaseButton.OnBaseButtonPress value7 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(WardrobeMenu.OnResetPressHandler));
						component.OnPress -= value7;
						BaseButton.OnBaseButtonRelease value8 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(WardrobeMenu.OnResetReleaseHandler));
						component.OnRelease -= value8;
					}
					InputAction inputAction = resetFilterActionPress;
					EventHandler value9 = OnResetPressHandler;
					inputAction.OnTriggered -= value9;
					InputAction inputAction2 = resetFilterActionRelease;
					EventHandler value10 = OnResetReleaseHandler;
					inputAction2.OnTriggered -= value10;
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003048")]
		[Cpp2IlInjected.Address(RVA = "0x14E84A0", Offset = "0x14E6EA0", VA = "0x1814E84A0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_01f1
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			int num = 0;
			_wardrobeMenuParam = (WardrobeMenuParam)num;
			_isFilteringLocked = (byte)num != 0;
			_lastFocusedElement = (FocusNavigationElement)num;
			_focusedCategoryItem = (ISupportsFocusNavigation)num;
			List<Filter> list = (_currentFilters = (List<Filter>)(object)new List<T>());
			_clothCategorySelector.ClearAllSelected();
			ResetFilters();
			base.OnPush(stack, param);
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			int num2 = 0;
			bool shouldShowNewItem = UiRoot.Instance.ShouldShowNewItem;
			int num3 = 0;
			_showNewItem = shouldShowNewItem;
			UiRoot instance = UiRoot.Instance;
			int num4 = 0;
			instance.ShouldShowNewItem = (byte)num != 0;
			bool shouldShowNewCritter = UiRoot.Instance.ShouldShowNewCritter;
			int num5 = 0;
			_showNewCritter = shouldShowNewCritter;
			UiRoot.Instance.ShouldShowNewCritter = (byte)num != 0;
			PetsContent petsContent = _petsContent;
			int num6 = (petsContent.PetBeforeChange = profile.player_.currentPet_);
			PetsContent petsContent2 = _petsContent;
			RepeatedField<Pet> repeatedField = (petsContent2._allPets = SystemRoot.Instance.MetaClient.profile.player_.pets_);
			if (param != null)
			{
				int num7 = 0;
				if (param != null)
				{
					_wardrobeMenuParam = (WardrobeMenuParam)param;
					ItemFilterData itemFilters = _wardrobeMenuParam.ItemFilters;
					if (itemFilters != null)
					{
						int count = ((RepeatedField<T>)(object)itemFilters.itemList_).Count;
					}
					_isFilteringLocked = (byte)num != 0;
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory wardrobe = profile.Wardrobe;
			_allClothesDefault = (_allClothes = ItemDatabaseExtensions.GetOwnedClothes(_003CInstance_003Ek__BackingField, wardrobe).ToArray<ClothingItemData>());
			_tfSelectedCategory.StringID = "menu.hud_btn_wardrobe";
			PetsContent petsContent3 = _petsContent;
			CancellationToken cancellationToken = (petsContent3.CancellationToken = base.CancellationToken);
			SystemRoot.Instance.PauseSystem<PlayerNavigation>();
			Mdl.Avatar.AvatarCustomization avatarCustomization = (_avatarCustomization = SystemRoot.Instance.GetSystem<Mdl.Avatar.AvatarCustomization>());
			DecalDesignContent mcDecalDesignContent = _mcDecalDesignContent;
			DecalBaseItemsContent decalBaseItemsContent = (mcDecalDesignContent.mcBaseItemContent = _mcBaseItemContent);
			DecalDesignContent mcDecalDesignContent2 = _mcDecalDesignContent;
			Mdl.Avatar.AvatarCustomization avatarCustomization2 = (mcDecalDesignContent2.AvatarCustomization = _avatarCustomization);
			DecalBaseItemsContent mcBaseItemContent = _mcBaseItemContent;
			Mdl.Avatar.AvatarCustomization avatarCustomization3 = (mcBaseItemContent.AvatarCustomization = _avatarCustomization);
			_mcBaseItemContent.Init();
		}

		[Cpp2IlInjected.Token(Token = "0x6003049")]
		[Cpp2IlInjected.Address(RVA = "0x14EC730", Offset = "0x14EB130", VA = "0x1814EC730")]
		public void SetCustomizationRedirection()
		{
			_wardrobeMenuParam.CategoryFilter = "Customization";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600304A")]
		[Cpp2IlInjected.Address(RVA = "0x14E77A0", Offset = "0x14E61A0", VA = "0x1814E77A0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_01db, IL_01e1
			//IL_0135: Expected O, but got I4
			//IL_014d: Expected O, but got I4
			//IL_0167: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			//IL_01b2: Expected O, but got I4
			//IL_01cc: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			base.OnFocusIn();
			WardrobeMenuParam wardrobeMenuParam = _wardrobeMenuParam;
			if (wardrobeMenuParam != null)
			{
				ItemFilterData itemFilters = wardrobeMenuParam.ItemFilters;
				if (itemFilters != null)
				{
					SetDefaultFilters(itemFilters);
				}
			}
			if (_mcDecalDesignContent.gameObject.activeSelf || _mcBaseItemContent.gameObject.activeSelf)
			{
				if (_mcDecalDesignContent.gameObject.activeSelf)
				{
					DecalDesignContent mcDecalDesignContent = _mcDecalDesignContent;
					bool shouldUpdateWardrobe = ToMCurrentState == ToMState.None;
					int contentReady = 0;
					mcDecalDesignContent.RefreshDecalList(shouldUpdateWardrobe, (byte)contentReady != 0);
					DecalDesignContent mcDecalDesignContent2 = _mcDecalDesignContent;
					FocusNavigation focusNavigation = _focusNavigation;
					mcDecalDesignContent2.SetFocus(focusNavigation);
				}
				RefreshContent(WardrobeMenuPhase.ClothContentPhase);
				List<FilterItemSelector> filterSelectors = _filterSelectors;
				bool flag = default(bool);
				if (flag)
				{
				}
				int num4 = 0;
				int num5 = 0;
				ExtraFilter extraFilter = default(ExtraFilter);
				float g = extraFilter._color.g;
				int num6 = 0;
				ExtraFilter extraFilter2 = default(ExtraFilter);
				float g2 = extraFilter2._color.g;
				int num7 = 0;
				ExtraFilter extraFilter3 = default(ExtraFilter);
				float g3 = extraFilter3._color.g;
				int num8 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				Sprite filterBackground = extraFilter3.filterBackground;
				int num9 = 0;
			}
			bool active = Enumerable.Any<ProfileWorld.FilterInfo>(SystemRoot.Instance.Client.Profile.world_.GetFiltersWardrobeInfo());
			GameObject gameObject = default(GameObject);
			gameObject.SetActive(active);
			int num10 = 0;
			if (gameObject != (UnityEngine.Object)num10)
			{
			}
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num11 = default(int);
			InputActionBool inputActionBool = new InputActionBool("AvatarCustomization_Undo", trigger, (InputProvider)num11);
			num11 = 0;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num12 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("AvatarCustomization_Undo", trigger2, (InputProvider)num12);
			num12 = 0;
			InputTriggerDownWithDelay trigger3 = new InputTriggerDownWithDelay(1f);
			int num13 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("AvatarCustomization_Undo", trigger3, (InputProvider)num13);
			num13 = 0;
			int num14 = 0;
			UiRoot.Instance._worldCanvas.RemoveNotEnoughMana();
			InputTriggerPressed trigger4 = new InputTriggerPressed();
			int num15 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("[Back]", trigger4, (InputProvider)num15);
			num15 = 0;
			InputTriggerReleased trigger5 = new InputTriggerReleased();
			int num16 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("[Back]", trigger5, (InputProvider)num16);
			num16 = 0;
			EventHandler value = default(EventHandler);
			inputActionBool5.OnTriggered += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600304B")]
		[Cpp2IlInjected.Address(RVA = "0x14E9290", Offset = "0x14E7C90", VA = "0x1814E9290", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__78))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__78 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__78(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600304C")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B80", Offset = "0xAEF580", VA = "0x180AF0B80", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600304D")]
		[Cpp2IlInjected.Address(RVA = "0x14E82D0", Offset = "0x14E6CD0", VA = "0x1814E82D0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0047
			base.OnPop();
			SystemRoot.Instance.StopSystem<Mdl.Avatar.AvatarCustomization>();
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			IMenu menu = base.NextMenu;
			if (menu != null)
			{
				int num = 0;
				if (menu != null)
				{
					return;
				}
			}
			if (system.IsPaused)
			{
				system.ResumeSystem();
			}
			_simpleSlide.ResetPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x600304E")]
		[Cpp2IlInjected.Address(RVA = "0x14EEC20", Offset = "0x14ED620", VA = "0x1814EEC20")]
		private void Update()
		{
			//Discarded unreachable code: IL_03a6
			//IL_0010: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_0228: Expected F4, but got I4
			float deltaTime;
			InputAction[] array;
			InputAction inputAction5;
			while (true)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
				int num = 0;
				if (!(avatarCustomization != (UnityEngine.Object)num))
				{
				}
				bool historyIsEnabled = _avatarCustomization.HistoryIsEnabled;
				Mdl.Avatar.AvatarCustomization avatarCustomization2 = _avatarCustomization;
				int num2 = 0;
				if (!(avatarCustomization2 != (UnityEngine.Object)num2) || _avatarCustomization.CanUndo())
				{
				}
				bool flag = _petsContent.IsPetChanged();
				_btnUndo.gameObject.SetActive(historyIsEnabled);
				_btnUndoAll.gameObject.SetActive(historyIsEnabled);
				Selectable selectable = _btnUndo.Selectable;
				_btnUndoAll.Selectable.interactable = flag;
				selectable.interactable = flag;
				NotificationButton btnUndoAll = _btnUndoAll;
				NotificationButton btnUndo = _btnUndo;
				btnUndoAll.IsActive = flag;
				btnUndo.IsActive = flag;
				CanvasGroup component = _btnUndo.GetComponent<CanvasGroup>();
				CanvasGroup component2 = _btnUndoAll.GetComponent<CanvasGroup>();
				if (flag)
				{
				}
				component2.alpha = 0.5f;
				component.alpha = 0.5f;
				int num3 = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[5];
				InputAction inputAction = inputActionUndoRelease;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionUndoAll;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputActionUndoPress;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = resetFilterActionPress;
				if (inputAction4 == null || array != null)
				{
					array[3] = inputAction4;
					inputAction5 = resetFilterActionRelease;
					if (inputAction5 == null || array != null)
					{
						break;
					}
				}
			}
			array[4] = inputAction5;
			InputAction.UpdateAll(deltaTime, array);
			if (_avatarCustomization.CanUndo())
			{
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					if (!inputActionUndoRelease.IsTriggered && !inputActionUndoAll.IsTriggered)
					{
						if (!inputActionUndoPress.IsTriggered)
						{
							goto IL_0377;
						}
						_highlightImageUndoAll.gameObject.SetActive(value: true);
						Image highlightImageUndoAll = _highlightImageUndoAll;
						int num5 = 0;
						highlightImageUndoAll.fillAmount = num5;
						float undoAllPressDelay = _avatarCustomization._undoAllPressDelay;
						TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
					}
					InputAction inputAction6 = inputActionUndoAll;
					int num6 = 0;
					bool flag2 = default(bool);
					if ((inputAction6.IsTriggered ? 1 : 0) != num6)
					{
						flag2 = (_justFiredPress ? 1 : 0) == num6;
					}
					GameObject gameObject = _highlightImageUndoAll.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					_highlightImageUndoAll.fillAmount = 1f;
					Image highlightImageUndoAll2 = _highlightImageUndoAll;
					int complete = 0;
					int num7 = DOTween.Kill(highlightImageUndoAll2, (byte)complete != 0);
					if (flag2)
					{
						NotificationButton btnUndoAll2 = _btnUndoAll;
						BumpButton(btnUndoAll2);
					}
					bool _003CIsTriggered_003Ek__BackingField = inputActionUndoAll.IsTriggered;
					if (!_003CIsTriggered_003Ek__BackingField)
					{
						if (_justFiredPress == _003CIsTriggered_003Ek__BackingField)
						{
							NotificationButton btnUndo2 = _btnUndo;
							BumpButton(btnUndo2);
							NotificationButton btnUndo3 = _btnUndo;
							int num8 = 0;
							UiRoot instance2 = UiRoot.Instance;
							int ignoreThrobber2 = 0;
							if (!instance2.IsOnTop(this, (byte)ignoreThrobber2 != 0))
							{
								goto IL_0362;
							}
							CancellationToken cancellationToken = base.CancellationToken;
							int num9 = 0;
						}
						if ((object)typeof(AsyncTaskMethodBuilder).TypeHandle == null)
						{
							goto IL_0362;
						}
					}
					if (!_justFiredPress)
					{
						NotificationButton btnUndoAll3 = _btnUndoAll;
						int num10 = 0;
						UiRoot instance3 = UiRoot.Instance;
						int ignoreThrobber3 = 0;
						if (instance3.IsOnTop(this, (byte)ignoreThrobber3 != 0))
						{
							CancellationToken cancellationToken2 = base.CancellationToken;
							int num11 = 0;
							Task asyncTask = default(Task);
							asyncTask.FireAndForgetTask();
						}
					}
					goto IL_0362;
				}
			}
			goto IL_0377;
			IL_0362:
			bool flag3 = (_justFiredPress = inputActionUndoAll.IsTriggered);
			goto IL_0377;
			IL_0377:
			if (_mcDecalDesignContent.gameObject.activeInHierarchy)
			{
				DecalDesignContent mcDecalDesignContent = _mcDecalDesignContent;
				int num12 = 0;
				float deltaTime2 = Time.deltaTime;
				mcDecalDesignContent.UpdateState(deltaTime2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600304F")]
		[Cpp2IlInjected.Address(RVA = "0x14E59D0", Offset = "0x14E43D0", VA = "0x1814E59D0")]
		private void BumpButton(BaseButton btn)
		{
			//Discarded unreachable code: IL_002e
			Transform transform = btn.transform;
			int num = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(btn.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6003050")]
		[Cpp2IlInjected.Address(RVA = "0x14EDDE0", Offset = "0x14EC7E0", VA = "0x1814EDDE0")]
		private void StartUndoAllButtonAnim()
		{
			//Discarded unreachable code: IL_0045
			//IL_0021: Expected F4, but got I4
			_highlightImageUndoAll.gameObject.SetActive(value: true);
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int num = 0;
			highlightImageUndoAll.fillAmount = num;
			float undoAllPressDelay = _avatarCustomization._undoAllPressDelay;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6003051")]
		[Cpp2IlInjected.Address(RVA = "0x14EDE90", Offset = "0x14EC890", VA = "0x1814EDE90")]
		private void StopUndoAllButtonAnim(bool playBumpAnim)
		{
			//Discarded unreachable code: IL_004c
			GameObject gameObject = _highlightImageUndoAll.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_highlightImageUndoAll.fillAmount = 1f;
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int complete = 0;
			int num = DOTween.Kill(highlightImageUndoAll, (byte)complete != 0);
			if (playBumpAnim)
			{
				NotificationButton btnUndoAll = _btnUndoAll;
				BumpButton(btnUndoAll);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003052")]
		[Cpp2IlInjected.Address(RVA = "0x14EAA90", Offset = "0x14E9490", VA = "0x1814EAA90")]
		private void RefreshContent(WardrobeMenuPhase phase)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003053")]
		[Cpp2IlInjected.Address(RVA = "0x14E9310", Offset = "0x14E7D10", VA = "0x1814E9310")]
		private void RefreshClothContentDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003054")]
		[Cpp2IlInjected.Address(RVA = "0x14EB980", Offset = "0x14EA380", VA = "0x1814EB980")]
		private void RefreshPetsContent(bool showNewPetsOnly)
		{
			//Discarded unreachable code: IL_005f, IL_0065, IL_006b
			//IL_0011: Expected I4, but got I8
			ulong num = default(ulong);
			_petsContent.gameObject.SetActive((byte)num != 0);
			GameObject gameObject = _listClothItems.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__87_0 == null)
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
			IEnumerable<Filter> enumerable = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable);
		}

		[Cpp2IlInjected.Token(Token = "0x6003055")]
		[Cpp2IlInjected.Address(RVA = "0x14E67B0", Offset = "0x14E51B0", VA = "0x1814E67B0")]
		private bool IsOwned(ListInventory wardrobeInventory, ClothingItemData item)
		{
			int iD = item.ID;
			ulong num = default(ulong);
			bool result = default(bool);
			if (num != 0)
			{
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003056")]
		[Cpp2IlInjected.Address(RVA = "0x14E5BB0", Offset = "0x14E45B0", VA = "0x1814E5BB0")]
		private HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__89_1 == null)
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
				IEnumerable<Filter> enumerable = default(IEnumerable<Filter>);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable);
			}
			if (_003C_003Ec._003C_003E9__89_0 == null)
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
			IEnumerable<Filter> enumerable2 = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable2);
			return hashSet;
		}

		[Cpp2IlInjected.Token(Token = "0x6003057")]
		[Cpp2IlInjected.Address(RVA = "0x14E68D0", Offset = "0x14E52D0", VA = "0x1814E68D0")]
		private void OnAvatarReady(AvatarAppearance avatar)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003058")]
		[Cpp2IlInjected.Address(RVA = "0x14EBCB0", Offset = "0x14EA6B0", VA = "0x1814EBCB0")]
		private void RefreshSelected(InventoryItem item)
		{
			//Discarded unreachable code: IL_0016
			AvatarAppearance avatar = _avatar;
			IItemData itemData = item.ItemData;
			bool isSelected = default(bool);
			item.IsSelected = isSelected;
		}

		[Cpp2IlInjected.Token(Token = "0x6003059")]
		[Cpp2IlInjected.Address(RVA = "0x14EC780", Offset = "0x14EB180", VA = "0x1814EC780")]
		private void SetDefaultFilters(ItemFilterData itemFilters)
		{
			//Discarded unreachable code: IL_030b, IL_0311, IL_0317, IL_031d, IL_0323, IL_0329, IL_032f, IL_0335, IL_033b, IL_0341, IL_0347, IL_034d, IL_0353, IL_0359, IL_035f, IL_0365, IL_036b, IL_0371, IL_0377
			//IL_00dd: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_01ea: Expected O, but got I4
			//IL_0237: Expected O, but got I4
			//IL_0284: Expected O, but got I4
			//IL_02d2: Expected O, but got I4
			//IL_0305: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int item_ = itemFilters.item_;
			bool flag = default(bool);
			if (flag)
			{
				goto IL_00dd;
			}
			if (((RepeatedField<T>)(object)itemFilters.itemList_).Count > 0)
			{
				ClothingItemData[] allClothes = _allClothes;
				Func<ClothingItemData, bool> func = (Func<ClothingItemData, bool>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
				{
					//Discarded unreachable code: IL_001b
					//IL_001a: Expected O, but got I4
					RepeatedField<int> itemList_2 = itemFilters.itemList_;
					int iD2 = x.ID;
					return ((RepeatedField<T>)(object)itemList_2).Contains((T)iD2);
				};
				ClothingItemData[] array = (_allClothes = Enumerable.Where<ClothingItemData>((IEnumerable<>)(object)allClothes, (Func<, >)(object)func).ToArray<ClothingItemData>());
				if (_allClothes.Length == num4)
				{
					RepeatedField<Pet> allPets = _petsContent._allPets;
					Func<Pet, bool> func2 = (Func<Pet, bool>)(object)(Func<T, TResult>)delegate(Pet x)
					{
						//Discarded unreachable code: IL_001b
						//IL_001a: Expected O, but got I4
						RepeatedField<int> itemList_ = itemFilters.itemList_;
						int petItemID_ = x.petItemID_;
						return ((RepeatedField<T>)(object)itemList_).Contains((T)petItemID_);
					};
					List<Pet> list = (List<Pet>)(object)Enumerable.ToList<Pet>(Enumerable.Where<Pet>((IEnumerable<>)(object)allPets, (Func<, >)(object)func2));
					((RepeatedField<T>)(object)_petsContent.FilteredNewPets).Clear();
					bool flag2 = default(bool);
					if (flag2)
					{
						((RepeatedField<T>)(object)_petsContent.FilteredNewPets).Add((T)num2);
					}
					goto IL_00dd;
				}
			}
			goto IL_010c;
			IL_00dd:
			ClothingItemData[] allClothes2 = _allClothes;
			Func<ClothingItemData, bool> func3 = (Func<ClothingItemData, bool>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
			{
				//Discarded unreachable code: IL_0018
				int iD = x.ID;
				ItemFilterData itemFilterData3 = itemFilters;
				return iD == itemFilterData3.item_;
			};
			ClothingItemData[] array2 = (_allClothes = Enumerable.Where<ClothingItemData>((IEnumerable<>)(object)allClothes2, (Func<, >)(object)func3).ToArray<ClothingItemData>());
			goto IL_010c;
			IL_010c:
			RepeatedField<int> tags_ = itemFilters.tags_;
			bool flag3 = default(bool);
			Filter item = default(Filter);
			if (flag3 && !((List<T>)(object)_clothCategorySelector.allFilters).Contains((T)item))
			{
				List<FilterItemSelector> filterSelectors = _filterSelectors;
				bool flag4 = default(bool);
				if (flag4)
				{
					bool flag5 = default(bool);
					while (!flag5)
					{
					}
				}
			}
			if (_003C_003Ec._003C_003E9__92_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((FilterItemSelector x) => x.filterType == FilterItemSelector.FilterType.Trait);
			}
			int num5 = 0;
			FilterItemSelector filterItemSelector = default(FilterItemSelector);
			if (filterItemSelector != (UnityEngine.Object)num5)
			{
				OptionalField complexity_ = itemFilters.complexity_;
				if (complexity_.useField_)
				{
					Complexity complexity = complexity_.Complexity;
					string text = ((Enum)complexity).ToString();
					Complexity complexity2 = complexity;
					Filter item2 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item2))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item2);
					}
				}
				OptionalField mood_ = itemFilters.mood_;
				if (mood_.useField_)
				{
					Mood mood = mood_.Mood;
					string text2 = ((Enum)mood).ToString();
					Mood mood2 = mood;
					Filter item3 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item3))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item3);
					}
				}
				OptionalField normality_ = itemFilters.normality_;
				if (normality_.useField_)
				{
					Normality normality = normality_.Normality;
					string text3 = ((Enum)normality).ToString();
					Normality normality2 = normality;
					Filter item4 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item4))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item4);
					}
				}
				OptionalField sturdiness_ = itemFilters.sturdiness_;
				if (sturdiness_.useField_)
				{
					Sturdiness sturdiness = sturdiness_.Sturdiness;
					string text4 = ((Enum)sturdiness).ToString();
					Sturdiness sturdiness2 = sturdiness;
					Filter item5 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item5))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item5);
					}
				}
			}
			if (_003C_003Ec._003C_003E9__92_3 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((FilterItemSelector x) => x.filterType == FilterItemSelector.FilterType.Tier);
			}
			int num6 = 0;
			FilterItemSelector filterItemSelector2 = default(FilterItemSelector);
			if (filterItemSelector2 != (UnityEngine.Object)num6)
			{
				List<Filter> allFilters = filterItemSelector2.allFilters;
				bool flag6 = default(bool);
				if (flag6)
				{
					int num7 = 0;
					ItemFilterData itemFilterData = itemFilters;
					ItemFilterData itemFilterData2 = itemFilters;
					((List<T>)(object)filterItemSelector2.selectedFilters).Add((T)num2);
				}
			}
			int num8 = default(int);
			if (num8 != 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600305A")]
		[Cpp2IlInjected.Address(RVA = "0x14E61A0", Offset = "0x14E4BA0", VA = "0x1814E61A0")]
		private int GetPriority(IItemData itemData)
		{
			//Discarded unreachable code: IL_007a
			int num = 0;
			ListInventory wardrobe = SystemRoot.Instance.Client.Profile.Wardrobe;
			bool flag = default(bool);
			if (flag)
			{
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			IHasUnlockConditions unlockConditions = itemData.GetUnlockConditions();
			if (unlockConditions == null)
			{
				int maxLevel = profile.player_.GetMaxLevel();
				num += 100;
				num += maxLevel;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				num += 100;
			}
			int maxLevel2 = profile.player_.GetMaxLevel();
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return num + maxLevel2;
		}

		[Cpp2IlInjected.Token(Token = "0x600305B")]
		[Cpp2IlInjected.Address(RVA = "0x14ED7E0", Offset = "0x14EC1E0", VA = "0x1814ED7E0")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_010c
			//IL_0010: Expected O, but got I4
			//IL_0049: Expected O, but got I8
			//IL_0084: Expected O, but got I4
			FocusNavigation focusNavigation = default(FocusNavigation);
			WardrobeAppearanceContent mcAppearanceContent = default(WardrobeAppearanceContent);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			GameObject gameObject3 = default(GameObject);
			int num3 = default(int);
			Transform transform = default(Transform);
			BaseButton baseButton = default(BaseButton);
			FocusNavigationElement component = default(FocusNavigationElement);
			GameObject gameObject4 = default(GameObject);
			GameObject gameObject5 = default(GameObject);
			do
			{
				IL_0000:
				FocusNavigationElement lastFocusedElement = _lastFocusedElement;
				int num = 0;
				if (lastFocusedElement != (UnityEngine.Object)num && _lastFocusedElement.gameObject.activeInHierarchy)
				{
					focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigationElement lastFocusedElement2 = _lastFocusedElement;
					focusNavigation.SetFocus(lastFocusedElement2);
					_lastFocusedElement = (FocusNavigationElement)0;
					break;
				}
				WardrobeMenuPhase currentPhase = _currentPhase;
				if ((object)focusNavigation != null)
				{
					if ((object)focusNavigation != null)
					{
						if ((object)focusNavigation != null)
						{
							while (currentPhase != WardrobeMenuPhase.CategoryPhase)
							{
							}
							mcAppearanceContent = _mcAppearanceContent;
							FocusNavigation focusNavigation2 = _focusNavigation;
							int num2 = 0;
							mcAppearanceContent.SetFocus(focusNavigation2, (FocusNavigationElement)num2);
							break;
						}
						if (mcAppearanceContent.gameObject.activeSelf || gameObject.activeSelf || gameObject2.activeSelf)
						{
							break;
						}
						if (gameObject3.activeSelf)
						{
							while (num3 <= 0)
							{
							}
							int num4 = 0;
							component = transform.GetComponent<FocusNavigationElement>();
							break;
						}
						goto IL_0000;
					}
					int num5 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					baseButton = component.BaseButton;
				}
				if ((object)component == null && !baseButton.gameObject.activeSelf && !gameObject4.activeSelf)
				{
					int num6 = 0;
					continue;
				}
				break;
			}
			while (!gameObject5.activeSelf);
		}

		[Cpp2IlInjected.Token(Token = "0x600305C")]
		[Cpp2IlInjected.Address(RVA = "0x14EC4F0", Offset = "0x14EAEF0", VA = "0x1814EC4F0")]
		private void ResetFilters()
		{
			//Discarded unreachable code: IL_000c
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600305D")]
		[Cpp2IlInjected.Address(RVA = "0x14EC5F0", Offset = "0x14EAFF0", VA = "0x1814EC5F0")]
		public void ResetLastSelected()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600305E")]
		[Cpp2IlInjected.Address(RVA = "0x14E8AF0", Offset = "0x14E74F0", VA = "0x1814E8AF0")]
		private void OnQuestFilterSelected(ProfileWorld.FilterInfo filter)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600305F")]
		[Cpp2IlInjected.Address(RVA = "0x14E6DB0", Offset = "0x14E57B0", VA = "0x1814E6DB0")]
		private void OnClothCategorySelected()
		{
			//Discarded unreachable code: IL_002e
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatar = _avatar;
			int num = 0;
			if (!(avatar == (UnityEngine.Object)num))
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_focusedCategoryItem = _focusNavigation._focusedElement);
				RefreshContent(WardrobeMenuPhase.ClothContentPhase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003060")]
		[Cpp2IlInjected.Address(RVA = "0x14E6820", Offset = "0x14E5220", VA = "0x1814E6820")]
		private void OnAvatarCategorySelected()
		{
			//Discarded unreachable code: IL_002e
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatar = _avatar;
			int num = 0;
			if (!(avatar == (UnityEngine.Object)num))
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_focusedCategoryItem = _focusNavigation._focusedElement);
				RefreshContent(WardrobeMenuPhase.AvatarContentPhase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003061")]
		[Cpp2IlInjected.Address(RVA = "0x14E8E00", Offset = "0x14E7800", VA = "0x1814E8E00")]
		private void OnSelectedFilterItemData(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003062")]
		[Cpp2IlInjected.Address(RVA = "0x14E8D10", Offset = "0x14E7710", VA = "0x1814E8D10")]
		private void OnResetPressHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6003063")]
		[Cpp2IlInjected.Address(RVA = "0x14E8D10", Offset = "0x14E7710", VA = "0x1814E8D10")]
		private void OnResetPressHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6003064")]
		[Cpp2IlInjected.Address(RVA = "0x14E8D80", Offset = "0x14E7780", VA = "0x1814E8D80")]
		private void OnResetReleaseHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6003065")]
		[Cpp2IlInjected.Address(RVA = "0x14E8D80", Offset = "0x14E7780", VA = "0x1814E8D80")]
		private void OnResetReleaseHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6003066")]
		[Cpp2IlInjected.Address(RVA = "0x14E6810", Offset = "0x14E5210", VA = "0x1814E6810")]
		private void OnApplyClickHandler()
		{
			RefreshContent(WardrobeMenuPhase.ClothContentPhase);
		}

		[Cpp2IlInjected.Token(Token = "0x6003067")]
		[Cpp2IlInjected.Address(RVA = "0x14E90C0", Offset = "0x14E7AC0", VA = "0x1814E90C0")]
		private void OnUndoClickHandler()
		{
			//Discarded unreachable code: IL_0035
			NotificationButton btnUndo = _btnUndo;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				CancellationToken cancellationToken = base.CancellationToken;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003068")]
		[Cpp2IlInjected.Address(RVA = "0x14EE240", Offset = "0x14ECC40", VA = "0x1814EE240")]
		[AsyncStateMachine(typeof(_003CUndoTask_003Ed__110))]
		private Task UndoTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003069")]
		[Cpp2IlInjected.Address(RVA = "0x14E8EF0", Offset = "0x14E78F0", VA = "0x1814E8EF0")]
		private void OnUndoAllClickHandler()
		{
			//Discarded unreachable code: IL_0032
			NotificationButton btnUndoAll = _btnUndoAll;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				CancellationToken cancellationToken = base.CancellationToken;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600306A")]
		[Cpp2IlInjected.Address(RVA = "0x14EE110", Offset = "0x14ECB10", VA = "0x1814EE110")]
		[AsyncStateMachine(typeof(_003CUndoAllTask_003Ed__112))]
		private Task UndoAllTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600306B")]
		[Cpp2IlInjected.Address(RVA = "0x14EA8F0", Offset = "0x14E92F0", VA = "0x1814EA8F0")]
		private void RefreshContent()
		{
			//Discarded unreachable code: IL_00be
			_listClothItems.RefreshCells();
			_mcDecalDesignContent.RefreshCells();
			_mcGenderPanel.RefreshToggles();
			_mcMakeupPanel.RefreshSelected();
			WardrobeAppearanceContent mcAppearanceContent = _mcAppearanceContent;
			mcAppearanceContent.RefreshSelectedSubItems();
			mcAppearanceContent.RefreshSelectedItems();
			mcAppearanceContent.RefreshSelectedFacePresets();
			mcAppearanceContent.RefreshSelectedEyeColor();
			mcAppearanceContent.RefreshSelectedSkinColor();
			mcAppearanceContent.RefreshSelectedHairColor();
			mcAppearanceContent.RefreshSelectedHighlightColor();
			Transform mcPresetItems = mcAppearanceContent._mcPresetItems;
			int num = 0;
			int childCount = mcPresetItems.childCount;
			if (num < childCount)
			{
				BaseWardrobeItem component = mcAppearanceContent._mcPresetItems.GetChild(num).transform.GetComponent<BaseWardrobeItem>();
				int currentBodyTypeIndex = mcAppearanceContent.Avatar.GetCurrentBodyTypeIndex();
				bool flag2 = (component.IsSelected = num == currentBodyTypeIndex);
				Transform mcPresetItems2 = mcAppearanceContent._mcPresetItems;
				num++;
			}
			mcAppearanceContent._genderPanel.RefreshToggles();
		}

		[Cpp2IlInjected.Token(Token = "0x600306C")]
		[Cpp2IlInjected.Address(RVA = "0x14E6E60", Offset = "0x14E5860", VA = "0x1814E6E60")]
		private void OnClothItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_009f
			//IL_0015: Expected O, but got I4
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				ClothingItemData[] clothes = _Clothes;
				int itemIndex = args.ItemIndex;
				ClothingItemData clothingItemData = (ClothingItemData)(component.ItemData = clothes[itemIndex]);
				RectTransform amountAsset = component.AmountAsset;
				component.IsBuyable = false;
				component.IsOwned = false;
				GameObject gameObject = amountAsset.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				bool flag = (component.IsMale = _avatar.IsMale);
				component.RefreshDisplay();
				component.HideLocked();
				IItemData itemData = component.ItemData;
				AvatarAppearance avatar = _avatar;
				bool isSelected = default(bool);
				component.IsSelected = isSelected;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600306D")]
		[Cpp2IlInjected.Address(RVA = "0x14E7030", Offset = "0x14E5A30", VA = "0x1814E7030")]
		private void OnClothItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_00cf, IL_00e1
			//IL_0017: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			int num = 0;
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			int num2 = 0;
			if (component == (UnityEngine.Object)num2)
			{
				return;
			}
			IItemData itemData = component.ItemData;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			float cooldown = _cooldown;
			int num3 = 0;
			if (!(Time.realtimeSinceStartup <= cooldown))
			{
				int num4 = 0;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
			}
			ClothingItemType clothingItemType = default(ClothingItemType);
			if (clothingItemType != ClothingItemType.CloFeet)
			{
				ClothingItemType clothingItemType2 = default(ClothingItemType);
				if (clothingItemType2 == ClothingItemType.CloBottomInner)
				{
					int defaultBottomInner = DefaultBottomInner;
					Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
				}
				ClothingItemType clothingItemType3 = default(ClothingItemType);
				int num5 = (int)clothingItemType3;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_0087;
				}
				int num6 = 0;
			}
			int barefeet = Barefeet;
			Mdl.Avatar.AvatarCustomization avatarCustomization2 = _avatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			goto IL_0087;
			IL_0087:
			IEnumerator enumerator = ((LoopScrollRect)_listClothItems).m_Content.GetEnumerator();
			bool flag3 = default(bool);
			if (enumerator != null)
			{
				int num7 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num8 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num9 = 0;
				InventoryItem inventoryItem = default(InventoryItem);
				flag3 = inventoryItem != (UnityEngine.Object)num9;
				while (!flag3)
				{
				}
				RefreshSelected(inventoryItem);
			}
			if (!flag3)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600306E")]
		[Cpp2IlInjected.Address(RVA = "0x14E6CE0", Offset = "0x14E56E0", VA = "0x1814E6CE0")]
		[AsyncStateMachine(typeof(_003COnCloseClicked_003Ed__116))]
		private void OnCloseClicked()
		{
			int num = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x600306F")]
		[Cpp2IlInjected.Address(RVA = "0x14E6C00", Offset = "0x14E5600", VA = "0x1814E6C00")]
		private void OnBackClicked()
		{
			//Discarded unreachable code: IL_0069
			while (_btnBack._isActive)
			{
				switch (_currentPhase)
				{
				default:
					RefreshContent(WardrobeMenuPhase.CategoryPhase);
					return;
				case WardrobeMenuPhase.ClothContentPhase:
					break;
				case WardrobeMenuPhase.AvatarContentPhase:
				{
					bool flag = _mcAppearanceContent.TryCloseColorPopup();
					RefreshContent(WardrobeMenuPhase.CategoryPhase);
					return;
				}
				case WardrobeMenuPhase.FilterPhase:
					RefreshContent(WardrobeMenuPhase.ClothContentPhase);
					RefreshContent(WardrobeMenuPhase.ClothContentPhase);
					return;
				}
				if (_mcBaseItemContent.gameObject.activeInHierarchy)
				{
					RefreshContent(WardrobeMenuPhase.ClothContentPhase);
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003070")]
		[Cpp2IlInjected.Address(RVA = "0x14E75A0", Offset = "0x14E5FA0", VA = "0x1814E75A0")]
		private void OnFilterClicked()
		{
			//Discarded unreachable code: IL_003d
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatar = _avatar;
			int num = 0;
			if (!(avatar == (UnityEngine.Object)num))
			{
				ButtonTmProIcon btnFilters = _btnFilters;
				List<Filter> currentFilters = _currentFilters;
				Button btnFilterReset = _btnFilterReset;
				int num2 = ((btnFilterReset.interactable = false) ? 1 : 0);
				RefreshContent(WardrobeMenuPhase.FilterPhase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003071")]
		[Cpp2IlInjected.Address(RVA = "0x14E5F60", Offset = "0x14E4960", VA = "0x1814E5F60")]
		[AsyncStateMachine(typeof(_003CExitWardrobeTask_003Ed__119))]
		public Task<bool> ExitWardrobeTask(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003072")]
		[Cpp2IlInjected.Address(RVA = "0x14E5AA0", Offset = "0x14E44A0", VA = "0x1814E5AA0")]
		[AsyncStateMachine(typeof(_003CConfirmAndExitWardrobeTask_003Ed__120))]
		private Task ConfirmAndExitWardrobeTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003073")]
		[Cpp2IlInjected.Address(RVA = "0x14E60A0", Offset = "0x14E4AA0", VA = "0x1814E60A0")]
		public void ForceUpdateList()
		{
			//Discarded unreachable code: IL_001b
			if (base.gameObject.activeInHierarchy)
			{
				_listClothItems.RefreshCells();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003074")]
		[Cpp2IlInjected.Address(RVA = "0x14E6820", Offset = "0x14E5220", VA = "0x1814E6820")]
		private void OnGenderChangeHandler()
		{
			//Discarded unreachable code: IL_002e
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatar = _avatar;
			int num = 0;
			if (!(avatar == (UnityEngine.Object)num))
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_focusedCategoryItem = _focusNavigation._focusedElement);
				RefreshContent(WardrobeMenuPhase.AvatarContentPhase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003075")]
		[Cpp2IlInjected.Address(RVA = "0x14E64F0", Offset = "0x14E4EF0", VA = "0x1814E64F0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_002b, IL_003b, IL_004e, IL_0062, IL_0070, IL_008b, IL_0092, IL_00a3, IL_0116
			//IL_00e4: Expected O, but got I4
			uint num3 = default(uint);
			AvatarAppearance avatar;
			int num4;
			do
			{
				if (redirectionType > RedirectionType.ToFilter)
				{
					if ((redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.MenuNavClose) && _currentPhase <= WardrobeMenuPhase.Quest)
					{
						OnCloseClicked();
					}
					return;
				}
				if (redirectionType == RedirectionType.InventoryToHud)
				{
					int num = 0;
					RedirectionManager redirection = UiRoot.Instance.Redirection;
					int num2 = 0;
					return;
				}
				while (num3 != 80278)
				{
				}
				avatar = _avatar;
				num4 = 0;
			}
			while (avatar == (UnityEngine.Object)num4);
			ButtonTmProIcon btnFilters = _btnFilters;
			List<Filter> currentFilters = _currentFilters;
			Button btnFilterReset = _btnFilterReset;
			int num5 = ((btnFilterReset.interactable = false) ? 1 : 0);
			RefreshContent(WardrobeMenuPhase.FilterPhase);
		}

		[Cpp2IlInjected.Token(Token = "0x6003076")]
		[Cpp2IlInjected.Address(RVA = "0x14E7550", Offset = "0x14E5F50", VA = "0x1814E7550", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003077")]
		[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
		public WardrobeAppearanceContent GetAppearanceContent()
		{
			return _mcAppearanceContent;
		}

		[Cpp2IlInjected.Token(Token = "0x6003078")]
		[Cpp2IlInjected.Address(RVA = "0x14EDC80", Offset = "0x14EC680", VA = "0x1814EDC80")]
		private void SetSizeForFilterContent()
		{
			//Discarded unreachable code: IL_0017
			_filterContainer.DoAdjustment();
			_filterContent.DoAdjustment();
		}

		[Cpp2IlInjected.Token(Token = "0x6003079")]
		[Cpp2IlInjected.Address(RVA = "0x14EC610", Offset = "0x14EB010", VA = "0x1814EC610")]
		public void SendFocusToInventoryTabs(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_004b
			//IL_001f: Expected O, but got I4
			if (direction == FocusDirection.Left)
			{
				int num = 0;
				InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					_lastFocusedElement = currentElement;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigationElement component = menu.CurrentSelection.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307A")]
		[Cpp2IlInjected.Address(RVA = "0x14E7670", Offset = "0x14E6070", VA = "0x1814E7670")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0036
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Transform parent = base.transform;
				Transform transform = default(Transform);
				if (transform.IsChildOf(parent))
				{
					_lastFocusedElement = (FocusNavigationElement)focusedElement;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307B")]
		[Cpp2IlInjected.Address(RVA = "0x14E5F50", Offset = "0x14E4950", VA = "0x1814E5F50")]
		public void EditingNewToM()
		{
			//IL_0009: Expected I4, but got I8
			ToMCurrentState = ToMState.EditingNew;
		}

		[Cpp2IlInjected.Token(Token = "0x600307C")]
		[Cpp2IlInjected.Address(RVA = "0x14EDCC0", Offset = "0x14EC6C0", VA = "0x1814EDCC0")]
		[AsyncStateMachine(typeof(_003CSetTempToM_003Ed__130))]
		public Task SetTempToM([System.Runtime.InteropServices.Optional] LoopVerticalScrollRect listDecalItems)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600307D")]
		[Cpp2IlInjected.Address(RVA = "0x14E5F30", Offset = "0x14E4930", VA = "0x1814E5F30")]
		public void EditExistingToM(int index)
		{
			//IL_0009: Expected I4, but got I8
			ToMCurrentState = ToMState.EditingExisting;
			_currentToMIndex = index;
		}

		[Cpp2IlInjected.Token(Token = "0x600307E")]
		[Cpp2IlInjected.Address(RVA = "0x14E67A0", Offset = "0x14E51A0", VA = "0x1814E67A0")]
		public bool IsBackFromNewToM()
		{
			return ToMCurrentState == ToMState.EditingNew;
		}

		[Cpp2IlInjected.Token(Token = "0x600307F")]
		[Cpp2IlInjected.Address(RVA = "0x14E6110", Offset = "0x14E4B10", VA = "0x1814E6110")]
		[IteratorStateMachine(typeof(_003CGetFocusAfterEditNewToM_003Ed__133))]
		public IEnumerator GetFocusAfterEditNewToM(LoopVerticalScrollRect listDecalItems)
		{
			int _003C_003E1__state = default(int);
			_003CGetFocusAfterEditNewToM_003Ed__133 _003CGetFocusAfterEditNewToM_003Ed__ = new _003CGetFocusAfterEditNewToM_003Ed__133(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CGetFocusAfterEditNewToM_003Ed__._003C_003E4__this = this;
			_003CGetFocusAfterEditNewToM_003Ed__.listDecalItems = listDecalItems;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003080")]
		[Cpp2IlInjected.Address(RVA = "0x14E60F0", Offset = "0x14E4AF0", VA = "0x1814E60F0")]
		public int GetFocusAfterEditExisting()
		{
			//IL_0017: Expected I4, but got I8
			//IL_0020: Expected I4, but got I8
			int currentToMIndex = _currentToMIndex;
			_currentToMIndex = -1;
			ToMCurrentState = ToMState.None;
			return currentToMIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x6003081")]
		[Cpp2IlInjected.Address(RVA = "0x14EF6B0", Offset = "0x14EE0B0", VA = "0x1814EF6B0")]
		public WardrobeMenu()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0013: Expected I4, but got I8
		//IL_0020: Expected I4, but got I8
		//IL_0030: Expected I4, but got I8

	}
}
