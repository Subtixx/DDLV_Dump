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
using Definitions;
using Definitions.Items;
using Definitions.Store;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.InputSystem;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Customization;
using Meta.Util;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000736")]
	public class StoreMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000737")]
		public enum CatalogStorePhase
		{
			[Cpp2IlInjected.Token(Token = "0x4002A26")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002A27")]
			Category,
			[Cpp2IlInjected.Token(Token = "0x4002A28")]
			Selection,
			[Cpp2IlInjected.Token(Token = "0x4002A29")]
			Filter,
			[Cpp2IlInjected.Token(Token = "0x4002A2A")]
			PurchasePopup,
			[Cpp2IlInjected.Token(Token = "0x4002A2B")]
			Quest,
			[Cpp2IlInjected.Token(Token = "0x4002A2C")]
			HistoryChange
		}

		[Cpp2IlInjected.Token(Token = "0x2000738")]
		public class StoreItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002A2D")]
			public IItemData Item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002A2E")]
			public int? Amount;

			[Cpp2IlInjected.Token(Token = "0x6002E4F")]
			[Cpp2IlInjected.Address(RVA = "0x134FFB0", Offset = "0x134E9B0", VA = "0x18134FFB0")]
			public StoreItem(IItemData Item, int? Amount)
			{
				this.Item = Item;
				this.Amount = Amount;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40029D2")]
		[SerializeField]
		private StoreContent _availableContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40029D3")]
		[SerializeField]
		private GameObject _itemsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40029D4")]
		[SerializeField]
		private BaseButton _btnExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40029D5")]
		[SerializeField]
		private CurrencyContent _currencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40029D6")]
		[SerializeField]
		private GameObject _categoryContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40029D7")]
		[SerializeField]
		private TextBase _headerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40029D8")]
		[SerializeField]
		private GameObject _purchaseLimitAmountContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40029D9")]
		[SerializeField]
		private TextBase _purchaseLimitAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40029DA")]
		[SerializeField]
		private BaseButton _backButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40029DB")]
		[SerializeField]
		private BaseButton _readyButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40029DC")]
		[SerializeField]
		private Image _readyButtonLeftBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40029DD")]
		[SerializeField]
		private Image _readyButtonRightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40029DE")]
		[SerializeField]
		private FurniturePurchaseWindow _furniturePurchaseWindow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40029DF")]
		[SerializeField]
		private HistoryChangeWindow _historyChangeWindow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40029E0")]
		[SerializeField]
		private GameObject _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40029E1")]
		[SerializeField]
		private ItemPreview _itemPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40029E2")]
		[SerializeField]
		private bool displayItemOnHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40029E3")]
		[SerializeField]
		private GameObject _priceBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40029E4")]
		[SerializeField]
		private AsyncAtlassedIcon _currencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40029E5")]
		[SerializeField]
		private TextBase _price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40029E6")]
		[SerializeField]
		private List<GameObject> _zoomIndicators;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40029E7")]
		[SerializeField]
		private GameObject _mcCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40029E8")]
		[SerializeField]
		private Transform _mcCameraDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40029E9")]
		[SerializeField]
		[Header("Filters config")]
		private BaseButton _filterButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40029EA")]
		[SerializeField]
		private Button _btnFilterReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40029EB")]
		[SerializeField]
		private Button _btnFilterApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40029EC")]
		[SerializeField]
		private GameObject _filterContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40029ED")]
		[SerializeField]
		private GameObject _filterFooter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40029EE")]
		[SerializeField]
		private GameObject _mcFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40029EF")]
		[SerializeField]
		private TextBase _tfFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40029F0")]
		[SerializeField]
		private GameObject _filterIco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40029F1")]
		[SerializeField]
		private HorizontalLayoutGroup _btnFiltersLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40029F2")]
		[SerializeField]
		private ListBase _listSelectedFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40029F3")]
		[SerializeField]
		private FilterItemSelector _clothCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40029F4")]
		[SerializeField]
		private FilterItemSelector _furniturecategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40029F5")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40029F6")]
		[SerializeField]
		private QuestFilterSelector _questSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40029F7")]
		[SerializeField]
		[Header("Undo config")]
		private Image _highlightImageUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40029F8")]
		[SerializeField]
		private NotificationButton _btnUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40029F9")]
		[SerializeField]
		private NotificationButton _btnUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40029FA")]
		[SerializeField]
		[Header("Text config")]
		private string _purchaseLimitReachedTitleId = "menu.scrooge_store_limit_reached_title";

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40029FB")]
		[SerializeField]
		private string _purchaseLimitReachedDescId = "menu.scrooge_store_limit_reached_desc";

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40029FC")]
		[SerializeField]
		[Header("Sound")]
		private AK.Wwise.Event _sfxPurchaseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40029FD")]
		[SerializeField]
		private Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4002A03")]
		private WardrobeMenu.WardrobeMenuPhase _currentClothePhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4002A04")]
		[SerializeField]
		private CatalogStorePhase _currentFurniturePhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4002A05")]
		private Mdl.Avatar.AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4002A06")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4002A07")]
		private ISupportsFocusNavigation _focusedCategoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4002A08")]
		[SerializeField]
		private FilterHelper _filterHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4002A09")]
		[Range(0f, 15f)]
		public int TweakAnimationCooldown = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4002A0A")]
		private float _cooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4002A0B")]
		private float _planeDistanceOriginal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4002A0C")]
		private Canvas _mainCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4002A0D")]
		private Color _lightColorOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4002A0E")]
		private float _lightShadowStrengthOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
		[Cpp2IlInjected.Token(Token = "0x4002A0F")]
		private float _lightShadowIntensityOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4002A10")]
		private Quaternion _lightRotationOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4002A11")]
		private UnityEngine.Vector3 _lightPositionOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4002A12")]
		private Light _mainLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4002A13")]
		private bool _tabsScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C1")]
		[Cpp2IlInjected.Token(Token = "0x4002A14")]
		private bool _isAnimationShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4002A15")]
		private InventoryItem _selectedInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4002A16")]
		private ProfileWorld.FilterInfo _currentQuest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4002A17")]
		private List<Filter> _currentFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4002A18")]
		private CanvasGroup _btnUndoCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4002A19")]
		private CanvasGroup _btnUndoAllCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4002A1A")]
		private bool _justFiredPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4002A1B")]
		protected InputAction inputActionUndoPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4002A1C")]
		protected InputAction inputActionUndoRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4002A1D")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4002A1E")]
		private Profile _profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4002A1F")]
		private UnityEngine.Vector3 avatarForwardOnPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4002A20")]
		private (UnityEngine.Vector3 pos, Quaternion rot) cameraOnPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4002A21")]
		private bool _isItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4002A22")]
		private InventoryItem _itemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4002A23")]
		private InputAction resetFilterActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4002A24")]
		private InputAction resetFilterActionRelease;

		[Cpp2IlInjected.Token(Token = "0x1700069E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x230"), Cpp2IlInjected.Token(Token = "0x40029FE")]
		public ItemType ItemTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFB")]
			[Cpp2IlInjected.Address(RVA = "0x877230", Offset = "0x875C30", VA = "0x180877230")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002DFC")]
			[Cpp2IlInjected.Address(RVA = "0x877280", Offset = "0x875C80", VA = "0x180877280")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700069F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x234"), Cpp2IlInjected.Token(Token = "0x40029FF")]
		public bool ShowBasicCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFD")]
			[Cpp2IlInjected.Address(RVA = "0x877240", Offset = "0x875C40", VA = "0x180877240")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002DFE")]
			[Cpp2IlInjected.Address(RVA = "0x877290", Offset = "0x875C90", VA = "0x180877290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x235"), Cpp2IlInjected.Token(Token = "0x4002A00")]
		public bool ShowOwnedItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFF")]
			[Cpp2IlInjected.Address(RVA = "0x877260", Offset = "0x875C60", VA = "0x180877260")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002E00")]
			[Cpp2IlInjected.Address(RVA = "0x8772B0", Offset = "0x875CB0", VA = "0x1808772B0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x236"), Cpp2IlInjected.Token(Token = "0x4002A01")]
		public bool ShowOngoingMissionItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002E01")]
			[Cpp2IlInjected.Address(RVA = "0x877250", Offset = "0x875C50", VA = "0x180877250")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002E02")]
			[Cpp2IlInjected.Address(RVA = "0x8772A0", Offset = "0x875CA0", VA = "0x1808772A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006A2")]
		public Mdl.Characters.Character CharacterSeller
		{
			[Cpp2IlInjected.Token(Token = "0x6002E03")]
			[Cpp2IlInjected.Address(RVA = "0x877220", Offset = "0x875C20", VA = "0x180877220")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterSeller_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E04")]
			[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
			[CompilerGenerated]
			private set
			{
				_003CCharacterSeller_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E05")]
		[Cpp2IlInjected.Address(RVA = "0x870AF0", Offset = "0x86F4F0", VA = "0x180870AF0", Slot = "25")]
		public unsafe override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_01a2
			//IL_007e: Expected I4, but got O
			//IL_00d1: Expected I4, but got O
			//IL_00e7: Expected I4, but got O
			//IL_00fd: Expected I4, but got O
			//IL_0122: Expected O, but got I4
			//IL_0144: Expected native int or pointer, but got O
			//IL_0182: Expected O, but got I4
			int num;
			int _003C_003E1__state = default(int);
			while (true)
			{
				num = 0;
				base.OnPush(stack, param);
				int num2 = 0;
				UiRoot.Instance.UpdateCursorBehaviorForUI();
				StoreContent availableContent = _availableContent;
				CancellationToken cancellationToken = (availableContent.CancellationToken = base.CancellationToken);
				_currencyContent.Show();
				_003CForceAlign_003Ed__101 _003CForceAlign_003Ed__ = new _003CForceAlign_003Ed__101(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CForceAlign_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CForceAlign_003Ed__);
				if (param == null)
				{
					break;
				}
				object[] @params = param.Params;
				int length = @params.Length;
				object obj = @params[0];
				ItemTypeFilter = (ItemType)obj;
				ItemFilterData itemFilterData = new ItemFilterData();
				ItemType itemType = (itemFilterData.type_ = ItemTypeFilter);
				ItemType itemType2 = ItemTypeFilter;
				StoreContent availableContent2 = _availableContent;
				StoreItem[] items = GetItems(itemType2);
				availableContent2.SetFilters(itemFilterData, items);
				object obj2 = param.Params[1];
				ShowBasicCollection = (byte)(int)obj2 != 0;
				object obj3 = param.Params[2];
				ShowOwnedItems = (byte)(int)obj3 != 0;
				object obj4 = param.Params[3];
				ShowOngoingMissionItems = (byte)(int)obj4 != 0;
				object obj5 = param.Params[4];
				if (obj5 != null)
				{
					int num3 = 0;
					if (obj5 == null)
					{
						continue;
					}
				}
				CharacterSeller = (Mdl.Characters.Character)num;
				break;
			}
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			((UnityEngine.Vector3*)(IntPtr)avatarForwardOnPush)->z = z;
			Transform transform = SystemRoot.Instance._playerCamera.transform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			Transform transform2 = SystemRoot.Instance._playerCamera.transform;
			int num4 = 0;
			int num5 = 0;
			cameraOnPush = ((UnityEngine.Vector3 pos, Quaternion rot))num4;
			if (SystemRoot.Instance.GetSystem<PlayerNavigation>().CurrentTask.TryGetComponent<TalkAction>(out *(TalkAction*)num))
			{
			}
			_isItemSelected = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E06")]
		[Cpp2IlInjected.Address(RVA = "0x86D910", Offset = "0x86C310", VA = "0x18086D910")]
		[IteratorStateMachine(typeof(_003CForceAlign_003Ed__101))]
		private IEnumerator ForceAlign()
		{
			int _003C_003E1__state = default(int);
			_003CForceAlign_003Ed__101 _003CForceAlign_003Ed__ = new _003CForceAlign_003Ed__101(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CForceAlign_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E07")]
		[Cpp2IlInjected.Address(RVA = "0x870600", Offset = "0x86F000", VA = "0x180870600", Slot = "26")]
		public unsafe override void OnPop()
		{
			//Discarded unreachable code: IL_00a7
			int num = 0;
			base.OnPop();
			ItemType itemType = ItemTypeFilter;
			if (itemType == ItemType.Clothing)
			{
				goto IL_0034;
			}
			if (itemType == ItemType.Furniture)
			{
				_itemPreview.ResetTarget();
				Mdl.Characters.Character character = CharacterSeller;
				if ((object)character != null)
				{
					character.EnableAI(enabled: true);
					goto IL_0034;
				}
			}
			goto IL_005c;
			IL_005c:
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			int num2 = 0;
			if (system.CurrentTask.TryGetComponent<TalkAction>(out *(TalkAction*)num2))
			{
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				bool flag = default(bool);
				if (flag)
				{
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				int num4 = 0;
				Task asyncTask2 = default(Task);
				asyncTask2.FireAndForgetTask();
			}
			return;
			IL_0034:
			Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
			Mdl.Avatar.AvatarCustomization.AvatarReady value = OnAvatarReady;
			avatarCustomization.OnAvatarReady -= value;
			((Mdl.Systems.System)_avatarCustomization).OnDestroy();
			goto IL_005c;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E08")]
		[Cpp2IlInjected.Address(RVA = "0x873A30", Offset = "0x872430", VA = "0x180873A30")]
		private void RefreshPurchaseLimit()
		{
			LimitedAction deliverItem_ = SystemRoot.Instance.MetaClient.profile.player_.limitedActions_.deliverItem_;
			GameObject purchaseLimitAmountContainer = _purchaseLimitAmountContainer;
			if (deliverItem_ == null)
			{
				int active = 0;
				purchaseLimitAmountContainer.SetActive((byte)active != 0);
				return;
			}
			purchaseLimitAmountContainer.SetActive(value: true);
			int cartItemCount = GetCartItemCount();
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			if (deliverItem_.IsExpired(serverTime))
			{
			}
			TextBase purchaseLimitAmount = _purchaseLimitAmount;
			int maxCount_ = deliverItem_.maxCount_;
			string text = default(string);
			string text2 = default(string);
			string text4 = (purchaseLimitAmount.Text = text + "/" + text2);
			FurniturePurchaseWindow furniturePurchaseWindow = _furniturePurchaseWindow;
			int num = (furniturePurchaseWindow.CurrentLimitMax = deliverItem_.maxCount_);
			FurniturePurchaseWindow furniturePurchaseWindow2 = _furniturePurchaseWindow;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E09")]
		[Cpp2IlInjected.Address(RVA = "0x86D980", Offset = "0x86C380", VA = "0x18086D980")]
		private int GetCartItemCount()
		{
			//Discarded unreachable code: IL_0057
			//IL_001b: Expected O, but got I4
			int result = 0;
			if (ItemTypeFilter == ItemType.Clothing)
			{
				AvatarAppearance avatar = _avatar;
				int num = 0;
				if (avatar != (UnityEngine.Object)num)
				{
					Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractClothes((IAvatar)_avatar.CurrentAvatar.Data);
					ListInventory wardrobe = _avatar.CurrentProfile.Wardrobe;
					int count = ((Dictionary<TKey, TValue>)(object)InventoryUtil.MissingFromInventory((Dictionary<, >)(object)dictionary, wardrobe)).Count;
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0A")]
		[Cpp2IlInjected.Address(RVA = "0x86D1D0", Offset = "0x86BBD0", VA = "0x18086D1D0")]
		[IteratorStateMachine(typeof(_003CCheckLimitExpiration_003Ed__105))]
		private IEnumerator CheckLimitExpiration(LimitedAction limitedAction)
		{
			int _003C_003E1__state = default(int);
			_003CCheckLimitExpiration_003Ed__105 _003CCheckLimitExpiration_003Ed__ = new _003CCheckLimitExpiration_003Ed__105(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCheckLimitExpiration_003Ed__._003C_003E4__this = this;
			_003CCheckLimitExpiration_003Ed__.limitedAction = limitedAction;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void InitItemPreview()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0C")]
		[Cpp2IlInjected.Address(RVA = "0x86D7E0", Offset = "0x86C1E0", VA = "0x18086D7E0")]
		private void FinalizeItemPreview()
		{
			//Discarded unreachable code: IL_001f
			_itemPreview.ResetTarget();
			CharacterSeller?.EnableAI(enabled: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0D")]
		[Cpp2IlInjected.Address(RVA = "0x86E8F0", Offset = "0x86D2F0", VA = "0x18086E8F0")]
		private void OnAvatarReady(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_0048
			_avatar = avatar;
			StoreContent availableContent = _availableContent;
			availableContent._avatar = avatar;
			StoreList questList = availableContent._questList;
			AvatarAppearance avatarAppearance = (questList.Avatar = availableContent._avatar);
			StoreList storeList = availableContent._storeList;
			AvatarAppearance avatarAppearance2 = (storeList.Avatar = availableContent._avatar);
			RefreshPurchaseLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0E")]
		[Cpp2IlInjected.Address(RVA = "0x873E30", Offset = "0x872830", VA = "0x180873E30", Slot = "32")]
		protected unsafe override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_039f
			//IL_00b7: Expected O, but got I4
			//IL_036d: Expected O, but got I4
			HistoryChangeWindow historyChangeWindow;
			Delegate delegate3;
			while (true)
			{
				InitItemPreview();
				Button.ButtonClickedEvent onClick = _backButton.ButtonComponent.m_OnClick;
				UnityAction call = OnBackClicked;
				onClick.AddListener(call);
				Button.ButtonClickedEvent onClick2 = _btnExit.ButtonComponent.m_OnClick;
				UnityAction call2 = ExitStore;
				onClick2.AddListener(call2);
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				FocusNavigation.FocusChanged value = OnFocusChanged;
				focusNavigation.OnFocusChanged += value;
				FurniturePurchaseWindow furniturePurchaseWindow = _furniturePurchaseWindow;
				FurniturePurchaseWindow.InventoryGridItemPurchased onItemPurchased = furniturePurchaseWindow.OnItemPurchased;
				FurniturePurchaseWindow.InventoryGridItemPurchased b = OnItemPurchased;
				Delegate @delegate = Delegate.Combine(onItemPurchased, b);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				furniturePurchaseWindow.OnItemPurchased = (FurniturePurchaseWindow.InventoryGridItemPurchased)num;
				FurniturePurchaseWindow furniturePurchaseWindow2 = _furniturePurchaseWindow;
				Action onClose = furniturePurchaseWindow2.OnClose;
				Action b2 = OnFurnitureClose;
				Delegate delegate2 = Delegate.Combine(onClose, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					furniturePurchaseWindow2.OnClose = (Action)delegate2;
					historyChangeWindow = _historyChangeWindow;
					Action onClose2 = historyChangeWindow.OnClose;
					Action b3 = OnHistoryChangeClose;
					delegate3 = Delegate.Combine(onClose2, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						break;
					}
				}
			}
			historyChangeWindow.OnClose = (Action)delegate3;
			FilterItemSelector furniturecategorySelector = _furniturecategorySelector;
			Action onReady = furniturecategorySelector.OnReady;
			Action b4 = OnFilterReady;
			Delegate delegate4 = Delegate.Combine(onReady, b4);
			if ((object)delegate4 == null || (object)delegate4 != null)
			{
				furniturecategorySelector.OnReady = (Action)delegate4;
				FilterItemSelector furniturecategorySelector2 = _furniturecategorySelector;
				FilterSelector.FilterSelectedByUser value2 = UpdateFilters;
				furniturecategorySelector2.OnFilterSelectedByUser += value2;
				FilterItemSelector clothCategorySelector = _clothCategorySelector;
				Action onReady2 = clothCategorySelector.OnReady;
				Action b5 = OnFilterReady;
				Delegate delegate5 = Delegate.Combine(onReady2, b5);
				if ((object)delegate5 == null || (object)delegate5 != null)
				{
					clothCategorySelector.OnReady = (Action)delegate5;
					FilterItemSelector clothCategorySelector2 = _clothCategorySelector;
					FilterSelector.FilterSelectedByUser value3 = OnClothCategorySelected;
					clothCategorySelector2.OnFilterSelectedByUser += value3;
					StoreContent availableContent = _availableContent;
					Action<InventoryItem> onTapItem = availableContent.OnTapItem;
					Action<InventoryItem> b6 = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
					Delegate delegate6 = Delegate.Combine(onTapItem, b6);
					if ((object)delegate6 == null || (object)delegate6 != null)
					{
						availableContent.OnTapItem = (Action<InventoryItem>)delegate6;
						StoreContent availableContent2 = _availableContent;
						Action<InventoryItem> onBuyTap = availableContent2.OnBuyTap;
						Action<InventoryItem> b7 = (Action<InventoryItem>)(object)new Action<T>(OnBuyTap);
						Delegate delegate7 = Delegate.Combine(onBuyTap, b7);
						if ((object)delegate7 == null || (object)delegate7 != null)
						{
							availableContent2.OnBuyTap = (Action<InventoryItem>)delegate7;
							Button.ButtonClickedEvent onClick3 = _btnUndo.ButtonComponent.m_OnClick;
							UnityAction call3 = OnUndoClickHandler;
							onClick3.AddListener(call3);
							Button.ButtonClickedEvent onClick4 = _btnUndoAll.ButtonComponent.m_OnClick;
							UnityAction call4 = OnUndoAllClickHandler;
							onClick4.AddListener(call4);
							QuestFilterSelector questSelector = _questSelector;
							Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
							Action<ProfileWorld.FilterInfo> b8 = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
							Delegate delegate8 = Delegate.Combine(_003COnQuestSelected_003Ek__BackingField, b8);
							if ((object)delegate8 == null || (object)delegate8 != null)
							{
								questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)delegate8;
								Button.ButtonClickedEvent onClick5 = _filterButton.ButtonComponent.m_OnClick;
								UnityAction call5 = OnFiltersClicked;
								onClick5.AddListener(call5);
								Button.ButtonClickedEvent onClick6 = _btnFilterApply.m_OnClick;
								UnityAction call6 = OnApplyClickHandler;
								onClick6.AddListener(call6);
								ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
								int num2 = 0;
								if (component != (UnityEngine.Object)num2)
								{
									BaseButton.OnBaseButtonPress value4 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(StoreMenu.OnResetPressHandler));
									component.OnPress += value4;
									BaseButton.OnBaseButtonRelease value5 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(StoreMenu.OnResetReleaseHandler));
									component.OnRelease += value5;
								}
								return;
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0F")]
		[Cpp2IlInjected.Address(RVA = "0x875E10", Offset = "0x874810", VA = "0x180875E10", Slot = "33")]
		protected unsafe override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_03dd
			//IL_00b7: Expected O, but got I4
			//IL_036d: Expected O, but got I4
			FurniturePurchaseWindow furniturePurchaseWindow;
			Delegate delegate3;
			while (true)
			{
				base.UnregisterFocusedListeners();
				Button.ButtonClickedEvent onClick = _backButton.ButtonComponent.m_OnClick;
				UnityAction call = OnBackClicked;
				onClick.RemoveListener(call);
				Button.ButtonClickedEvent onClick2 = _btnExit.ButtonComponent.m_OnClick;
				UnityAction call2 = ExitStore;
				onClick2.RemoveListener(call2);
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				FocusNavigation.FocusChanged value = OnFocusChanged;
				focusNavigation.OnFocusChanged -= value;
				StoreContent availableContent = _availableContent;
				Action<InventoryItem> onTapItem = availableContent.OnTapItem;
				Action<InventoryItem> value2 = (Action<InventoryItem>)(object)new Action<T>(OnItemTap);
				Delegate @delegate = Delegate.Remove(onTapItem, value2);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				availableContent.OnTapItem = (Action<InventoryItem>)num;
				StoreContent availableContent2 = _availableContent;
				Action<InventoryItem> onBuyTap = availableContent2.OnBuyTap;
				Action<InventoryItem> value3 = (Action<InventoryItem>)(object)new Action<T>(OnBuyTap);
				Delegate delegate2 = Delegate.Remove(onBuyTap, value3);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					availableContent2.OnBuyTap = (Action<InventoryItem>)delegate2;
					furniturePurchaseWindow = _furniturePurchaseWindow;
					FurniturePurchaseWindow.InventoryGridItemPurchased onItemPurchased = furniturePurchaseWindow.OnItemPurchased;
					FurniturePurchaseWindow.InventoryGridItemPurchased value4 = OnItemPurchased;
					delegate3 = Delegate.Remove(onItemPurchased, value4);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						break;
					}
				}
			}
			furniturePurchaseWindow.OnItemPurchased = (FurniturePurchaseWindow.InventoryGridItemPurchased)delegate3;
			FurniturePurchaseWindow furniturePurchaseWindow2 = _furniturePurchaseWindow;
			Action onClose = furniturePurchaseWindow2.OnClose;
			Action value5 = OnFurnitureClose;
			Delegate delegate4 = Delegate.Remove(onClose, value5);
			if ((object)delegate4 == null || (object)delegate4 != null)
			{
				furniturePurchaseWindow2.OnClose = (Action)delegate4;
				HistoryChangeWindow historyChangeWindow = _historyChangeWindow;
				Action onClose2 = historyChangeWindow.OnClose;
				Action value6 = OnHistoryChangeClose;
				Delegate delegate5 = Delegate.Remove(onClose2, value6);
				if ((object)delegate5 == null || (object)delegate5 != null)
				{
					historyChangeWindow.OnClose = (Action)delegate5;
					FilterItemSelector clothCategorySelector = _clothCategorySelector;
					Action onReady = clothCategorySelector.OnReady;
					Action value7 = OnFilterReady;
					Delegate delegate6 = Delegate.Remove(onReady, value7);
					if ((object)delegate6 == null || (object)delegate6 != null)
					{
						clothCategorySelector.OnReady = (Action)delegate6;
						FilterItemSelector furniturecategorySelector = _furniturecategorySelector;
						FilterSelector.FilterSelectedByUser value8 = UpdateFilters;
						furniturecategorySelector.OnFilterSelectedByUser -= value8;
						FilterItemSelector furniturecategorySelector2 = _furniturecategorySelector;
						Action onReady2 = furniturecategorySelector2.OnReady;
						Action value9 = OnFilterReady;
						Delegate delegate7 = Delegate.Remove(onReady2, value9);
						if ((object)delegate7 == null || (object)delegate7 != null)
						{
							furniturecategorySelector2.OnReady = (Action)delegate7;
							FilterItemSelector clothCategorySelector2 = _clothCategorySelector;
							FilterSelector.FilterSelectedByUser value10 = OnClothCategorySelected;
							clothCategorySelector2.OnFilterSelectedByUser -= value10;
							Button.ButtonClickedEvent onClick3 = _btnUndo.ButtonComponent.m_OnClick;
							UnityAction call3 = OnUndoClickHandler;
							onClick3.RemoveListener(call3);
							Button.ButtonClickedEvent onClick4 = _btnUndoAll.ButtonComponent.m_OnClick;
							UnityAction call4 = OnUndoAllClickHandler;
							onClick4.RemoveListener(call4);
							QuestFilterSelector questSelector = _questSelector;
							Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
							Action<ProfileWorld.FilterInfo> value11 = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
							Delegate delegate8 = Delegate.Remove(_003COnQuestSelected_003Ek__BackingField, value11);
							if ((object)delegate8 == null || (object)delegate8 != null)
							{
								questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)delegate8;
								Button.ButtonClickedEvent onClick5 = _filterButton.ButtonComponent.m_OnClick;
								UnityAction call5 = OnFiltersClicked;
								onClick5.RemoveListener(call5);
								Button.ButtonClickedEvent onClick6 = _btnFilterApply.m_OnClick;
								UnityAction call6 = OnApplyClickHandler;
								onClick6.RemoveListener(call6);
								ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
								int num2 = 0;
								if (component != (UnityEngine.Object)num2)
								{
									BaseButton.OnBaseButtonPress value12 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(StoreMenu.OnResetPressHandler));
									component.OnPress -= value12;
									BaseButton.OnBaseButtonRelease value13 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(StoreMenu.OnResetReleaseHandler));
									component.OnRelease -= value13;
								}
								InputAction inputAction = resetFilterActionPress;
								EventHandler value14 = OnResetPressHandler;
								inputAction.OnTriggered -= value14;
								InputAction inputAction2 = resetFilterActionRelease;
								EventHandler value15 = OnResetReleaseHandler;
								inputAction2.OnTriggered -= value15;
								return;
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E10")]
		[Cpp2IlInjected.Address(RVA = "0x86F5E0", Offset = "0x86DFE0", VA = "0x18086F5E0", Slot = "27")]
		public override void OnFocusIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E11")]
		[Cpp2IlInjected.Address(RVA = "0x86F370", Offset = "0x86DD70", VA = "0x18086F370")]
		private void OnFilterReady()
		{
			//Discarded unreachable code: IL_002e
			if (ItemTypeFilter != ItemType.Clothing)
			{
				HideEmptyFurnitureCategory();
			}
			HideEmptyClothesCategory();
			int _003C_003E1__state = default(int);
			_003CDelaySetFocus_003Ed__136 _003CDelaySetFocus_003Ed__ = new _003CDelaySetFocus_003Ed__136(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelaySetFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDelaySetFocus_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E12")]
		[Cpp2IlInjected.Address(RVA = "0x871340", Offset = "0x86FD40", VA = "0x180871340")]
		private void OnSelectedFilterItemData(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E13")]
		[Cpp2IlInjected.Address(RVA = "0x8734D0", Offset = "0x871ED0", VA = "0x1808734D0")]
		private void RefreshPrice()
		{
			//Discarded unreachable code: IL_0158, IL_015e, IL_0164
			//IL_0018: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00af: Expected I4, but got I8
			//IL_00af: Expected F8, but got I4
			//IL_00de: Expected I4, but got I8
			//IL_010d: Expected O, but got I4
			//IL_013f: Expected I4, but got I8
			//IL_013f: Expected F8, but got I4
			//IL_0157: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			AvatarAppearance avatar = _avatar;
			int num3 = 0;
			int num4 = 0;
			if (avatar != (UnityEngine.Object)num4)
			{
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractClothes((IAvatar)_avatar.CurrentAvatar.Data);
				ListInventory wardrobe = _avatar.CurrentProfile.Wardrobe;
				Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)InventoryUtil.MissingFromInventory((Dictionary<, >)(object)dictionary, wardrobe);
				Item invalid = Item.Invalid;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					CurrencyCost currencyCost = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num2);
					while (currencyCost == null)
					{
					}
					Item item = currencyCost.Item;
					Item item2 = currencyCost.Item;
				}
				if (num2 != 0)
				{
					goto IL_008e;
				}
			}
			GameObject priceBox = _priceBox;
			int amount = 0;
			goto IL_008e;
			IL_008e:
			int childMaxDecimals = 0;
			RefreshBuyButton(amount, (Item)num3);
			TextBase price = _price;
			uint maxDigits = default(uint);
			ulong num5 = default(ulong);
			string text2 = (price.Text = TextUtilities.FormatNumber(num, (int)maxDigits, num3, childMaxDecimals, (byte)num5 != 0));
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = _currencyIcon.SetIcon("");
			}
			ulong num6 = default(ulong);
			_priceBox.SetActive((byte)num6 != 0);
			if (!_isItemSelected || _priceBox.activeInHierarchy)
			{
				return;
			}
			IItemData itemData = _itemSelected.ItemData;
			bool flag5 = default(bool);
			if (flag5)
			{
				CurrencyCost currencyCost2 = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num2);
				if (currencyCost2 != null)
				{
					Item item3 = currencyCost2.Item;
					int childMaxDecimals2 = 0;
					int itemID = item3.ItemID;
					TextBase price2 = _price;
					uint maxDigits2 = default(uint);
					ulong num7 = default(ulong);
					string text4 = (price2.Text = TextUtilities.FormatNumber(num, (int)maxDigits2, itemID, childMaxDecimals2, (byte)num7 != 0));
					ulong num8 = default(ulong);
					_priceBox.SetActive((byte)num8 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E14")]
		[Cpp2IlInjected.Address(RVA = "0x86E070", Offset = "0x86CA70", VA = "0x18086E070")]
		private void HideEmptyClothesCategory()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E15")]
		[Cpp2IlInjected.Address(RVA = "0x86E460", Offset = "0x86CE60", VA = "0x18086E460")]
		private void HideEmptyFurnitureCategory()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E16")]
		[Cpp2IlInjected.Address(RVA = "0x86CF60", Offset = "0x86B960", VA = "0x18086CF60")]
		private void AddFunitureAllCategory()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E17")]
		[Cpp2IlInjected.Address(RVA = "0x871740", Offset = "0x870140", VA = "0x180871740", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__118))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__118 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__118(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E18")]
		[Cpp2IlInjected.Address(RVA = "0x86D410", Offset = "0x86BE10", VA = "0x18086D410")]
		private void ExitStore()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E19")]
		[Cpp2IlInjected.Address(RVA = "0x8758A0", Offset = "0x8742A0", VA = "0x1808758A0")]
		[AsyncStateMachine(typeof(_003CTryExit_003Ed__120))]
		private Task TryExit()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1A")]
		[Cpp2IlInjected.Address(RVA = "0x86D550", Offset = "0x86BF50", VA = "0x18086D550")]
		[AsyncStateMachine(typeof(_003CExitStore_003Ed__121))]
		public Task<bool> ExitStore(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF70", Offset = "0x86D970", VA = "0x18086EF70")]
		public void OnBuyClickHandler()
		{
			if (_currentClothePhase != WardrobeMenu.WardrobeMenuPhase.HistoryChange)
			{
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1C")]
		[Cpp2IlInjected.Address(RVA = "0x8757A0", Offset = "0x8741A0", VA = "0x1808757A0")]
		[AsyncStateMachine(typeof(_003CTryBuy_003Ed__123))]
		private Task TryBuy()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1D")]
		[Cpp2IlInjected.Address(RVA = "0x86D690", Offset = "0x86C090", VA = "0x18086D690")]
		[AsyncStateMachine(typeof(_003CExitWardrobeTask_003Ed__124))]
		public Task<bool> ExitWardrobeTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1E")]
		[Cpp2IlInjected.Address(RVA = "0x86E710", Offset = "0x86D110", VA = "0x18086E710")]
		private bool IsPurchaseLimitReached()
		{
			//Discarded unreachable code: IL_0056
			LimitedAction deliverItem_ = SystemRoot.Instance.MetaClient.profile.player_.limitedActions_.deliverItem_;
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			if (deliverItem_.IsExpired(serverTime))
			{
				int num = 0;
				return deliverItem_.maxCount_ == num;
			}
			int count_ = deliverItem_.count_;
			return deliverItem_.maxCount_ == count_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1F")]
		[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86BC60", VA = "0x18086D260")]
		[AsyncStateMachine(typeof(_003CConfirmAndExitWardrobeTask_003Ed__126))]
		private Task<bool> ConfirmAndExitWardrobeTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E20")]
		[Cpp2IlInjected.Address(RVA = "0x875C10", Offset = "0x874610", VA = "0x180875C10")]
		[AsyncStateMachine(typeof(_003CUndoAll_003Ed__127))]
		private Task UndoAll()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E21")]
		[Cpp2IlInjected.Address(RVA = "0x86F400", Offset = "0x86DE00", VA = "0x18086F400")]
		public void OnFiltersClicked()
		{
			int num = 0;
			if (_currentClothePhase == (WardrobeMenu.WardrobeMenuPhase)num)
			{
				RefreshContent(CatalogStorePhase.Filter);
			}
			else
			{
				RefreshContent(WardrobeMenu.WardrobeMenuPhase.FilterPhase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E22")]
		[Cpp2IlInjected.Address(RVA = "0x86E9A0", Offset = "0x86D3A0", VA = "0x18086E9A0")]
		public void OnBackClicked()
		{
			//IL_005b: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_0171: Expected O, but got I4
			Task asyncTask = default(Task);
			Action<GameObject> action = default(Action<GameObject>);
			FocusNavigation focusNavigation = default(FocusNavigation);
			while (true)
			{
				int num = 0;
				if (_currentClothePhase != (WardrobeMenu.WardrobeMenuPhase)num)
				{
					List<GameObject> zoomIndicators = _zoomIndicators;
					Action<GameObject> _003C_003E9__129_ = _003C_003Ec._003C_003E9__129_0;
					if (_003C_003E9__129_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(GameObject x)
						{
							//Discarded unreachable code: IL_0008
							x.SetActive(value: true);
						};
					}
					((List<T>)(object)zoomIndicators).ForEach((Action<>)(object)_003C_003E9__129_);
					if (_currentClothePhase <= WardrobeMenu.WardrobeMenuPhase.Quest)
					{
						int num2 = 0;
						int num3 = 0;
						asyncTask.FireAndForgetTask();
						RefreshContent(WardrobeMenu.WardrobeMenuPhase.Quest);
						_currentQuest = (ProfileWorld.FilterInfo)num;
						_avatarCustomization.ZoomOut();
						RefreshContent(WardrobeMenu.WardrobeMenuPhase.CategoryPhase);
						_historyChangeWindow.OnClickOk();
					}
				}
				if (_currentFurniturePhase == (CatalogStorePhase)num)
				{
					return;
				}
				List<GameObject> zoomIndicators2 = _zoomIndicators;
				if (_003C_003Ec._003C_003E9__129_1 == null)
				{
					action = (Action<GameObject>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(GameObject x)
					{
						//Discarded unreachable code: IL_000a
						int active = 0;
						x.SetActive((byte)active != 0);
					});
				}
				((List<T>)(object)zoomIndicators2).ForEach((Action<>)(object)action);
				if (zoomIndicators2 == null)
				{
					break;
				}
				if (zoomIndicators2 != null)
				{
					if (zoomIndicators2 == null)
					{
						break;
					}
					if (zoomIndicators2 == null)
					{
						ItemPreview itemPreview = _itemPreview;
						_currentFurniturePhase = CatalogStorePhase.Selection;
						itemPreview.Hide();
						int num4 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							continue;
						}
						InventoryItem selectedInventoryItem = _selectedInventoryItem;
						int num5 = 0;
						if (!(selectedInventoryItem != (UnityEngine.Object)num5))
						{
							return;
						}
						InventoryItem selectedInventoryItem2 = _selectedInventoryItem;
						int num6 = ((selectedInventoryItem2.IsSelected = false) ? 1 : 0);
						MenuNavigation menuNavigation = base.MenuNavigation;
						InventoryItem selectedInventoryItem3 = _selectedInventoryItem;
						focusNavigation = menuNavigation.FocusNavigation;
						FocusNavigationElement component = selectedInventoryItem3.GetComponent<FocusNavigationElement>();
						focusNavigation.SetFocus(component);
					}
					if ((long)focusNavigation != 1)
					{
						return;
					}
				}
				_currentQuest = (ProfileWorld.FilterInfo)num;
				RefreshContent(CatalogStorePhase.Category);
				return;
			}
			OnBuyClickHandler();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E23")]
		[Cpp2IlInjected.Address(RVA = "0x86F0D0", Offset = "0x86DAD0", VA = "0x18086F0D0")]
		private void OnClothCategorySelected()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E24")]
		[Cpp2IlInjected.Address(RVA = "0x876880", Offset = "0x875280", VA = "0x180876880")]
		private void UpdateFilters()
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_focusedCategoryItem = base.MenuNavigation.FocusNavigation._focusedElement);
			}
			RefreshContent(CatalogStorePhase.Quest);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E25")]
		[Cpp2IlInjected.Address(RVA = "0x871BE0", Offset = "0x8705E0", VA = "0x180871BE0")]
		private void RefreshContent(CatalogStorePhase phase)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E26")]
		[Cpp2IlInjected.Address(RVA = "0x8727B0", Offset = "0x8711B0", VA = "0x1808727B0")]
		private void RefreshContent(WardrobeMenu.WardrobeMenuPhase phase)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E27")]
		[Cpp2IlInjected.Address(RVA = "0x86DA80", Offset = "0x86C480", VA = "0x18086DA80")]
		public StoreItem[] GetItems(ItemType itemType)
		{
			Debug.Log(" storemenu Get Item");
			StoreData storeData = ProtoDatabase.Instance.Get<StoreData>("Store_Default");
			if (itemType != ItemType.Clothing)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				List<(Item, int?)> furnitureItemsInDeliverySystem = (List<(Item, int?)>)(object)DeliverySystemExtensions.GetFurnitureItemsInDeliverySystem(storeData, profile);
				Func<(Item, int?), StoreItem> _003C_003E9__134_ = _003C_003Ec._003C_003E9__134_1;
				if (_003C_003E9__134_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return Enumerable.Select<(Item, int?), StoreItem>((IEnumerable<>)furnitureItemsInDeliverySystem, (Func<, >)(object)_003C_003E9__134_).ToArray<StoreItem>();
			}
			Profile profile2 = SystemRoot.Instance.MetaClient.profile;
			List<Item> clothingItemsInDeliverySystem = (List<Item>)(object)DeliverySystemExtensions.GetClothingItemsInDeliverySystem(storeData, profile2);
			Func<Item, StoreItem> func = default(Func<Item, StoreItem>);
			if (_003C_003Ec._003C_003E9__134_0 == null)
			{
				func = (Func<Item, StoreItem>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0012
					//IL_000d: Expected O, but got I4
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					IItemData itemData = default(IItemData);
					int num = default(int);
					StoreItem result = new StoreItem(itemData, (Nullable<>)num);
					num = 0;
					return result;
				});
			}
			IEnumerable<Item> enumerable = (IEnumerable<Item>)Enumerable.Select<Item, StoreItem>((IEnumerable<>)clothingItemsInDeliverySystem, (Func<, >)(object)func);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E28")]
		[Cpp2IlInjected.Address(RVA = "0x873CD0", Offset = "0x8726D0", VA = "0x180873CD0")]
		public void RefreshQuestCategory()
		{
			//Discarded unreachable code: IL_0043
			IEnumerable<ProfileWorld.FilterInfo> filtersPurchaseInfo = (IEnumerable<ProfileWorld.FilterInfo>)SystemRoot.Instance.Client.Profile.world_.GetFiltersPurchaseInfo();
			bool flag = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)filtersPurchaseInfo);
			_questSelector.gameObject.SetActive(flag);
			if (flag)
			{
				_questSelector.Init((IEnumerable<>)filtersPurchaseInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E29")]
		[Cpp2IlInjected.Address(RVA = "0x86D3A0", Offset = "0x86BDA0", VA = "0x18086D3A0")]
		[IteratorStateMachine(typeof(_003CDelaySetFocus_003Ed__136))]
		public IEnumerator DelaySetFocus()
		{
			int _003C_003E1__state = default(int);
			_003CDelaySetFocus_003Ed__136 _003CDelaySetFocus_003Ed__ = new _003CDelaySetFocus_003Ed__136(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelaySetFocus_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2A")]
		[Cpp2IlInjected.Address(RVA = "0x86E020", Offset = "0x86CA20", VA = "0x18086E020", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			switch (redirectionType)
			{
			case RedirectionType.ToFilter:
			{
				int num2 = 0;
				if (_currentClothePhase == (WardrobeMenu.WardrobeMenuPhase)num2)
				{
					RefreshContent(CatalogStorePhase.Filter);
				}
				else
				{
					RefreshContent(WardrobeMenu.WardrobeMenuPhase.FilterPhase);
				}
				break;
			}
			case RedirectionType.MenuNavGoBackward:
			{
				int num = 0;
				OnBackClicked();
				break;
			}
			default:
			{
				int num = default(int);
				if (num == 262146)
				{
					OnBuyClickHandler();
				}
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2B")]
		[Cpp2IlInjected.Address(RVA = "0x8732A0", Offset = "0x871CA0", VA = "0x1808732A0")]
		private void RefreshItemsFilterNb()
		{
			//Discarded unreachable code: IL_0079, IL_0086
			//IL_0078: Expected I4, but got I8
			List<FilterItemSelector> filterSelectors = _availableContent._filterSelectors;
			Func<FilterItemSelector, int> func = default(Func<FilterItemSelector, int>);
			if (_003C_003Ec._003C_003E9__138_0 == null)
			{
				func = (Func<FilterItemSelector, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FilterItemSelector x) => ((List<>)(object)x.selectedFilters)._size));
			}
			int num = Enumerable.Sum<FilterItemSelector>((IEnumerable<>)filterSelectors, (Func<, >)(object)func);
			List<Filter> list = (_currentFilters = (List<Filter>)(object)new List<T>());
			string text = default(string);
			_tfFilterCounter.Text = text;
			bool active = default(bool);
			_mcFilterCounter.SetActive(active);
			bool active2 = default(bool);
			_filterIco.SetActive(active2);
			HorizontalLayoutGroup btnFiltersLayout = _btnFiltersLayout;
			ulong num2 = default(ulong);
			btnFiltersLayout.childForceExpandWidth = (byte)num2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2C")]
		[Cpp2IlInjected.Address(RVA = "0x874970", Offset = "0x873370", VA = "0x180874970")]
		private void ResetFilters()
		{
			//Discarded unreachable code: IL_0011, IL_0017
			List<FilterItemSelector> filterSelectors = _availableContent._filterSelectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2D")]
		[Cpp2IlInjected.Address(RVA = "0x86F0C0", Offset = "0x86DAC0", VA = "0x18086F0C0")]
		private void OnBuyTap(InventoryItem item)
		{
			ShowFurniturePurchasePopup(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2E")]
		[Cpp2IlInjected.Address(RVA = "0x875180", Offset = "0x873B80", VA = "0x180875180")]
		public void ShowFurniturePurchasePopup(InventoryItem item)
		{
			//Discarded unreachable code: IL_0134
			//IL_00f0: Expected I4, but got I8
			LimitedAction deliverItem_ = SystemRoot.Instance.MetaClient.profile.player_.limitedActions_.deliverItem_;
			int cartItemCount = GetCartItemCount();
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			if (deliverItem_.IsExpired(serverTime))
			{
			}
			int count_ = deliverItem_.count_;
			LimitedAction deliverItem_2 = SystemRoot.Instance.MetaClient.profile.player_.limitedActions_.deliverItem_;
			DateTime serverTime2 = SystemRoot.Instance.MetaClient.ServerTime;
			if (deliverItem_2.IsExpired(serverTime2))
			{
			}
			int count_2 = deliverItem_2.count_;
			int maxCount_ = deliverItem_2.maxCount_;
			bool flag = maxCount_ == count_2;
			int? maxPurchasableAmount = item._maxPurchasableAmount;
			if ((object)maxPurchasableAmount != null)
			{
			}
			int maxCount_2 = deliverItem_.maxCount_;
			maxCount_2 -= count_;
			maxCount_2 -= cartItemCount;
			FurniturePurchaseWindow furniturePurchaseWindow = _furniturePurchaseWindow;
			IItemData itemData = item.ItemData;
			furniturePurchaseWindow.SetData(itemData, flag, (Nullable<>)maxPurchasableAmount);
			ulong num = default(ulong);
			_furniturePurchaseWindow.gameObject.SetActive((byte)num != 0);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (maxCount_ == count_2)
				{
					item.AddHighlight();
				}
				FurniturePurchaseWindow furniturePurchaseWindow2 = _furniturePurchaseWindow;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				furniturePurchaseWindow2.SetFocus(focusNavigation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2F")]
		[Cpp2IlInjected.Address(RVA = "0x870070", Offset = "0x86EA70", VA = "0x180870070")]
		private void OnItemTap(InventoryItem item)
		{
			//Discarded unreachable code: IL_005c, IL_0144
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = item == (UnityEngine.Object)num;
			if (flag || item.IsLocked != flag)
			{
				return;
			}
			if (ItemTypeFilter != ItemType.Clothing)
			{
				if (item.IsOwned != flag && item.IsBuyable == flag)
				{
					return;
				}
				int num2 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					IItemData itemData = item.ItemData;
					int num3 = 0;
					if (!flag2)
					{
					}
				}
				bool isSelected = default(bool);
				item.IsSelected = isSelected;
				_itemPreview.ResetTarget();
				return;
			}
			IItemData itemData2 = item.ItemData;
			float cooldown = _cooldown;
			int num4 = 0;
			if (!(Time.realtimeSinceStartup <= cooldown))
			{
				int num5 = 0;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
			}
			ClothingItemType clothingItemType = default(ClothingItemType);
			int num6 = (int)clothingItemType;
			bool flag3 = default(bool);
			Task task = default(Task);
			if (flag3)
			{
				int num7 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				_isItemSelected = false;
				IItemData itemData3 = item.ItemData;
				bool flag4 = default(bool);
				CurrencyCost currencyCost = default(CurrencyCost);
				if (flag4 && currencyCost != null)
				{
					int amount_ = currencyCost.amount_;
					Item item2 = currencyCost.Item;
					IItemData itemData4 = item.ItemData;
					Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
					task.FireAndForgetTask();
				}
				_itemSelected = item;
				_isItemSelected = true;
			}
			StoreContent availableContent = _availableContent;
			availableContent._questList.RefreshAll();
			availableContent._storeList.RefreshAll();
			RefreshPrice();
			RefreshPurchaseLimit();
			IItemData itemData5 = _itemSelected.ItemData;
			IItemData itemData6 = item.ItemData;
			while (task == null)
			{
			}
			bool flag5 = (item.IsSelected = _isItemSelected);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E30")]
		[Cpp2IlInjected.Address(RVA = "0x874800", Offset = "0x873200", VA = "0x180874800")]
		public void RemoveClothes(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0043
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			Mdl.Avatar.AvatarCustomization avatarCustomization = _003CInstance_003Ek__BackingField.StartSystem<Mdl.Avatar.AvatarCustomization>((ISystemData)num);
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			StoreContent availableContent = _availableContent;
			availableContent._questList.RefreshAll();
			availableContent._storeList.RefreshAll();
			RefreshPrice();
			RefreshPurchaseLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E31")]
		[Cpp2IlInjected.Address(RVA = "0x86F430", Offset = "0x86DE30", VA = "0x18086F430")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0059
			//IL_0047: Expected O, but got I4
			if (_currentFurniturePhase == CatalogStorePhase.Selection && displayItemOnHighlight && (long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
			{
				ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				InventoryItem inventoryItem = default(InventoryItem);
				if (inventoryItem != (UnityEngine.Object)num3)
				{
					_selectedInventoryItem = inventoryItem;
					SetItemPreview(inventoryItem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E32")]
		[Cpp2IlInjected.Address(RVA = "0x871430", Offset = "0x86FE30", VA = "0x180871430")]
		private void OnTimerRefreshCompleted(object sender, object param)
		{
			RefreshPurchaseLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E33")]
		[Cpp2IlInjected.Address(RVA = "0x86E8A0", Offset = "0x86D2A0", VA = "0x18086E8A0")]
		private void OnAnimShowComplete()
		{
			_isAnimationShow = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E34")]
		[Cpp2IlInjected.Address(RVA = "0x8717C0", Offset = "0x8701C0", VA = "0x1808717C0")]
		private void RefreshAll()
		{
			//Discarded unreachable code: IL_001e
			StoreContent availableContent = _availableContent;
			availableContent._questList.RefreshAll();
			availableContent._storeList.RefreshAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E35")]
		[Cpp2IlInjected.Address(RVA = "0x8715E0", Offset = "0x86FFE0", VA = "0x1808715E0")]
		private void OnUndoClickHandler()
		{
			//Discarded unreachable code: IL_0010
			NotificationButton btnUndo = _btnUndo;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E36")]
		[Cpp2IlInjected.Address(RVA = "0x875D10", Offset = "0x874710", VA = "0x180875D10")]
		[AsyncStateMachine(typeof(_003CUndoTask_003Ed__149))]
		private Task UndoTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E37")]
		[Cpp2IlInjected.Address(RVA = "0x871440", Offset = "0x86FE40", VA = "0x180871440")]
		private void OnUndoAllClickHandler()
		{
			//Discarded unreachable code: IL_001d
			NotificationButton btnUndoAll = _btnUndoAll;
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E38")]
		[Cpp2IlInjected.Address(RVA = "0x875AE0", Offset = "0x8744E0", VA = "0x180875AE0")]
		[AsyncStateMachine(typeof(_003CUndoAllTask_003Ed__151))]
		private Task UndoAllTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E39")]
		[Cpp2IlInjected.Address(RVA = "0x86D100", Offset = "0x86BB00", VA = "0x18086D100")]
		private void BumpButton(BaseButton btn)
		{
			//Discarded unreachable code: IL_002e
			Transform transform = btn.transform;
			int num = 0;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> tweenerCore = ((TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(btn.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E3A")]
		[Cpp2IlInjected.Address(RVA = "0x875610", Offset = "0x874010", VA = "0x180875610")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E3B")]
		[Cpp2IlInjected.Address(RVA = "0x8756C0", Offset = "0x8740C0", VA = "0x1808756C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E3C")]
		[Cpp2IlInjected.Address(RVA = "0x86FEF0", Offset = "0x86E8F0", VA = "0x18086FEF0")]
		private void OnHistoryChangeClose()
		{
			//Discarded unreachable code: IL_005a
			GameObject mcBlocker = _mcBlocker;
			if ((object)mcBlocker != null)
			{
				GameObject gameObject = mcBlocker.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			RefreshPrice();
			RefreshPurchaseLimit();
			int _003C_003E1__state = default(int);
			_003CDelaySetFocus_003Ed__136 _003CDelaySetFocus_003Ed__ = new _003CDelaySetFocus_003Ed__136(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelaySetFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDelaySetFocus_003Ed__);
			_avatarCustomization.ZoomOut();
			RefreshContent(WardrobeMenu.WardrobeMenuPhase.CategoryPhase);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E3D")]
		[Cpp2IlInjected.Address(RVA = "0x86FE50", Offset = "0x86E850", VA = "0x18086FE50")]
		private void OnFurnitureClose()
		{
			//Discarded unreachable code: IL_0024
			_itemPreview.Show();
			int _003C_003E1__state = default(int);
			_003CDelaySetFocus_003Ed__136 _003CDelaySetFocus_003Ed__ = new _003CDelaySetFocus_003Ed__136(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelaySetFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDelaySetFocus_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E3E")]
		[Cpp2IlInjected.Address(RVA = "0x86FFF0", Offset = "0x86E9F0", VA = "0x18086FFF0")]
		private void OnItemPurchased()
		{
			//Discarded unreachable code: IL_0034
			OnBackClicked();
			StoreContent availableContent = _availableContent;
			availableContent._questList._loopScrollRect.RefreshCells();
			availableContent._storeList._loopScrollRect.RefreshCells();
			RefreshPurchaseLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E3F")]
		[Cpp2IlInjected.Address(RVA = "0x86D830", Offset = "0x86C230", VA = "0x18086D830")]
		private void FocusLastSelectedItem()
		{
			//Discarded unreachable code: IL_004f
			//IL_0010: Expected O, but got I4
			InventoryItem selectedInventoryItem = _selectedInventoryItem;
			int num = 0;
			if (selectedInventoryItem != (UnityEngine.Object)num)
			{
				InventoryItem selectedInventoryItem2 = _selectedInventoryItem;
				int num2 = ((selectedInventoryItem2.IsSelected = false) ? 1 : 0);
				MenuNavigation menuNavigation = base.MenuNavigation;
				InventoryItem selectedInventoryItem3 = _selectedInventoryItem;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				FocusNavigationElement component = selectedInventoryItem3.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E40")]
		[Cpp2IlInjected.Address(RVA = "0x8711F0", Offset = "0x86FBF0", VA = "0x1808711F0")]
		private void OnQuestFilterSelected(ProfileWorld.FilterInfo filter)
		{
			ResetFilters();
			_currentQuest = filter;
			if (ItemTypeFilter != ItemType.Clothing)
			{
				RefreshContent(CatalogStorePhase.Quest);
			}
			else
			{
				RefreshContent(WardrobeMenu.WardrobeMenuPhase.Quest);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E41")]
		[Cpp2IlInjected.Address(RVA = "0x871250", Offset = "0x86FC50", VA = "0x180871250")]
		private void OnResetPressHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E42")]
		[Cpp2IlInjected.Address(RVA = "0x871250", Offset = "0x86FC50", VA = "0x180871250")]
		private void OnResetPressHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E43")]
		[Cpp2IlInjected.Address(RVA = "0x8712C0", Offset = "0x86FCC0", VA = "0x1808712C0")]
		private void OnResetReleaseHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E44")]
		[Cpp2IlInjected.Address(RVA = "0x8712C0", Offset = "0x86FCC0", VA = "0x1808712C0")]
		private void OnResetReleaseHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E45")]
		[Cpp2IlInjected.Address(RVA = "0x86E8B0", Offset = "0x86D2B0", VA = "0x18086E8B0")]
		public void OnApplyClickHandler()
		{
			ProfileWorld.FilterInfo currentQuest = _currentQuest;
			if (ItemTypeFilter != ItemType.Clothing)
			{
				RefreshContent(CatalogStorePhase.Quest);
			}
			else
			{
				RefreshContent(WardrobeMenu.WardrobeMenuPhase.Quest);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E46")]
		[Cpp2IlInjected.Address(RVA = "0x874A90", Offset = "0x873490", VA = "0x180874A90")]
		private void SetFocus()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E47")]
		[Cpp2IlInjected.Address(RVA = "0x8750C0", Offset = "0x873AC0", VA = "0x1808750C0")]
		private void SetItemPreview(InventoryItem invItem)
		{
			//Discarded unreachable code: IL_002a
			//IL_0029: Expected I4, but got I8
			ItemPreview itemPreview = _itemPreview;
			IItemData itemData = invItem.ItemData;
			_itemPreview.Show();
			ShowFurniturePurchasePopup(invItem);
			_currentFurniturePhase = CatalogStorePhase.PurchasePopup;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E48")]
		[Cpp2IlInjected.Address(RVA = "0x86F320", Offset = "0x86DD20", VA = "0x18086F320", Slot = "35")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E49")]
		[Cpp2IlInjected.Address(RVA = "0x876910", Offset = "0x875310", VA = "0x180876910")]
		private void Update()
		{
			//IL_00b8: Expected O, but got I4
			//IL_0193: Expected F4, but got I4
			float deltaTime;
			InputAction[] array;
			InputAction inputAction5;
			while (true)
			{
				int num = 0;
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
			if (_currentClothePhase == WardrobeMenu.WardrobeMenuPhase.None)
			{
				return;
			}
			Mdl.Avatar.AvatarCustomization avatarCustomization = _avatarCustomization;
			int num2 = 0;
			if (!(avatarCustomization != (UnityEngine.Object)num2))
			{
			}
			bool flag = _avatarCustomization.CanUndo();
			Selectable selectable = _btnUndo.Selectable;
			_btnUndoAll.Selectable.interactable = flag;
			selectable.interactable = flag;
			NotificationButton btnUndoAll = _btnUndoAll;
			NotificationButton btnUndo = _btnUndo;
			btnUndoAll.IsActive = flag;
			btnUndo.IsActive = flag;
			CanvasGroup btnUndoCanvasGroup = _btnUndoCanvasGroup;
			CanvasGroup btnUndoAllCanvasGroup = _btnUndoAllCanvasGroup;
			if (flag)
			{
			}
			btnUndoAllCanvasGroup.alpha = 0.5f;
			btnUndoCanvasGroup.alpha = 0.5f;
			if (!flag)
			{
				return;
			}
			if (!inputActionUndoRelease.IsTriggered && !inputActionUndoAll.IsTriggered)
			{
				if (inputActionUndoPress.IsTriggered)
				{
					_highlightImageUndoAll.gameObject.SetActive(value: true);
					Image highlightImageUndoAll = _highlightImageUndoAll;
					int num3 = 0;
					highlightImageUndoAll.fillAmount = num3;
					float undoAllPressDelay = _avatarCustomization._undoAllPressDelay;
					TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
				}
				return;
			}
			InputAction inputAction6 = inputActionUndoAll;
			int num4 = 0;
			bool flag2 = default(bool);
			if ((inputAction6.IsTriggered ? 1 : 0) != num4)
			{
				flag2 = (_justFiredPress ? 1 : 0) == num4;
			}
			GameObject gameObject = _highlightImageUndoAll.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_highlightImageUndoAll.fillAmount = 1f;
			Image highlightImageUndoAll2 = _highlightImageUndoAll;
			int complete = 0;
			int num5 = DOTween.Kill(highlightImageUndoAll2, (byte)complete != 0);
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
					int num6 = 0;
				}
				if ((object)typeof(AsyncTaskMethodBuilder).TypeHandle == null)
				{
					goto IL_0292;
				}
			}
			if (!_justFiredPress)
			{
				NotificationButton btnUndoAll3 = _btnUndoAll;
				CancellationToken cancellationToken = base.CancellationToken;
				int num7 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			goto IL_0292;
			IL_0292:
			bool flag3 = (_justFiredPress = inputActionUndoAll.IsTriggered);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E4A")]
		[Cpp2IlInjected.Address(RVA = "0x86DF10", Offset = "0x86C910", VA = "0x18086DF10")]
		private int GetPlayerCurrencyAmount(Item totalCurrencyItem)
		{
			//Discarded unreachable code: IL_0025
			Profile profile = (_profile = SystemRoot.Instance.Client.Profile);
			ProfilePlayer player_ = _profile.player_;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E4B")]
		[Cpp2IlInjected.Address(RVA = "0x871810", Offset = "0x870210", VA = "0x180871810")]
		private void RefreshBuyButton(int amount, Item totalCurrencyItem)
		{
			//Discarded unreachable code: IL_0105
			//IL_0045: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			Profile profile = (_profile = SystemRoot.Instance.Client.Profile);
			TextBase price = _price;
			int num = default(int);
			bool flag = amount > num;
			price.ColorKey = UIGameColors.GameColorName.Insufficient;
			CanvasGroup component = _readyButton.GetComponent<CanvasGroup>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				if (flag)
				{
				}
				component.alpha = 1f;
			}
			Image readyButtonLeftBg = _readyButtonLeftBg;
			int num3 = 0;
			if (readyButtonLeftBg != (UnityEngine.Object)num3)
			{
				Image readyButtonRightBg = _readyButtonRightBg;
				int num4 = 0;
				if (readyButtonRightBg != (UnityEngine.Object)num4)
				{
					Image readyButtonLeftBg2 = _readyButtonLeftBg;
					int num5 = 0;
					UiRoot instance = UiRoot.Instance;
					if (flag)
					{
						UIGameColors gameColors = instance._gameColors;
					}
					UIGameColors gameColors2 = instance._gameColors;
					Image readyButtonRightBg2 = _readyButtonRightBg;
					int num6 = 0;
					UiRoot instance2 = UiRoot.Instance;
					if (flag)
					{
						UIGameColors gameColors3 = instance2._gameColors;
					}
					UIGameColors gameColors4 = instance2._gameColors;
				}
			}
			_readyButton.IsActive = flag;
			_readyButton.Selectable.interactable = flag;
			_readyButton.GetComponent<FocusNavigationElement>().IgnoreThis = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E4C")]
		[Cpp2IlInjected.Address(RVA = "0x8771A0", Offset = "0x875BA0", VA = "0x1808771A0")]
		public StoreMenu()
		{
		}//IL_0020: Expected I4, but got I8

	}
}
