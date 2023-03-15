using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Assets.UI.Utilities;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Mdl.Characters;
using Mdl.Platform;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200035A")]
	public class ItemSlot : TemplateButton, IHasText, IHasSpriteURI
	{
		[Cpp2IlInjected.Token(Token = "0x200035B")]
		public enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x4001040")]
			CollectionItemLock,
			[Cpp2IlInjected.Token(Token = "0x4001041")]
			CraftLocked,
			[Cpp2IlInjected.Token(Token = "0x4001042")]
			Reset,
			[Cpp2IlInjected.Token(Token = "0x4001043")]
			CollectionItemNoClick
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400101C")]
		[Space]
		public RawImage Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400101D")]
		public RedDot RedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400101E")]
		public RectTransform Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400101F")]
		public CanvasGroup[] CanvasGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001021")]
		public UnityEvent[] ExtraPhases;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001022")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001023")]
		public GameObject FriendshipLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001024")]
		[SerializeField]
		protected CanvasGroup NormalBgCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001025")]
		[SerializeField]
		protected GameObject SelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001026")]
		[SerializeField]
		protected CanvasGroup SelectedBgCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001027")]
		[SerializeField]
		protected GameObject HighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001028")]
		[SerializeField]
		protected CanvasGroup HighlightBgCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001029")]
		[SerializeField]
		protected GameObject SelectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400102A")]
		[SerializeField]
		protected CanvasGroup SelectedHighlightBgCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400102B")]
		[SerializeField]
		protected GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400102C")]
		[SerializeField]
		protected CanvasGroup LabelCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400102D")]
		[SerializeField]
		protected GameObject[] WhiteBgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400102E")]
		[SerializeField]
		private AK.Wwise.Event _clickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400102F")]
		[SerializeField]
		private GameObject _skinBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001030")]
		[SerializeField]
		private GameObject _lockImg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001031")]
		[SerializeField]
		private RectTransform _IconRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001032")]
		[SerializeField]
		private float _iconDimensionForSkinPopup = 200f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4001033")]
		[SerializeField]
		private float _yValueForSkinIcon = 157f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001034")]
		public float BgOpacityWhenLock = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4001035")]
		public float IconOpacityWhenLock = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001036")]
		public float LabelOpacityWhenLock = 0.8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001037")]
		private CharacterSkinItemData[] _skins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001038")]
		private CollectionMenu.SkinShortcutEvent SkinEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001039")]
		private CharacterItemData _characterItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400103A")]
		private string _overrideText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400103B")]
		private Vector2 _defaultRedDotPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400103C")]
		private RectTransform _originalIconRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400103D")]
		private bool _useClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B9")]
		[Cpp2IlInjected.Token(Token = "0x400103E")]
		private bool _isLock;

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public ItemSlotModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x600155A")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600155B")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public bool UseClickSfx
		{
			[Cpp2IlInjected.Token(Token = "0x600155C")]
			[Cpp2IlInjected.Address(RVA = "0x1326D40", Offset = "0x1325740", VA = "0x181326D40")]
			get
			{
				return _useClickSfx;
			}
			[Cpp2IlInjected.Token(Token = "0x600155D")]
			[Cpp2IlInjected.Address(RVA = "0x1326D60", Offset = "0x1325760", VA = "0x181326D60")]
			set
			{
				_useClickSfx = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public bool IsLock
		{
			[Cpp2IlInjected.Token(Token = "0x600155E")]
			[Cpp2IlInjected.Address(RVA = "0x1326C60", Offset = "0x1325660", VA = "0x181326C60")]
			get
			{
				return _isLock;
			}
			[Cpp2IlInjected.Token(Token = "0x600155F")]
			[Cpp2IlInjected.Address(RVA = "0x1326D50", Offset = "0x1325750", VA = "0x181326D50")]
			set
			{
				_isLock = value;
				SetOpacity(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		private bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6001560")]
			[Cpp2IlInjected.Address(RVA = "0x1326C70", Offset = "0x1325670", VA = "0x181326C70")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.MetaClient.profile.player_.avatarIsMale_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001561")]
		[Cpp2IlInjected.Address(RVA = "0x13249D0", Offset = "0x13233D0", VA = "0x1813249D0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_001c
			UnityEvent onClicked = OnClicked;
			UnityAction call = OnClickItem;
			onClicked.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001562")]
		[Cpp2IlInjected.Address(RVA = "0x1325170", Offset = "0x1323B70", VA = "0x181325170", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0022
			base.OnEnable();
			UnityEvent onPressed = OnPressed;
			UnityAction call = OnPressedHandler;
			onPressed.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001563")]
		[Cpp2IlInjected.Address(RVA = "0x13250D0", Offset = "0x1323AD0", VA = "0x1813250D0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_0022
			base.OnDisable();
			UnityEvent onPressed = OnPressed;
			UnityAction call = OnPressedHandler;
			onPressed.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001564")]
		[Cpp2IlInjected.Address(RVA = "0x1325040", Offset = "0x1323A40", VA = "0x181325040")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			UnityEvent onClicked = OnClicked;
			UnityAction call = OnClickItem;
			onClicked.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001565")]
		[Cpp2IlInjected.Address(RVA = "0x1324FE0", Offset = "0x13239E0", VA = "0x181324FE0")]
		private void OnClickItem()
		{
			if (!_isLock && _useClickSfx)
			{
				AK.Wwise.Event clickSfx = _clickSfx;
				if (clickSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = clickSfx.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001566")]
		[Cpp2IlInjected.Address(RVA = "0x1325210", Offset = "0x1323C10", VA = "0x181325210")]
		private void OnPressedHandler()
		{
			//Discarded unreachable code: IL_0021
			int num = 0;
			if (!PlatformUtils.HasMouse())
			{
				FocusNavigation focusNavigation = base.FocusNavigation;
				FocusNavigationElement focus = base.FocusNavigationElement;
				focusNavigation.SetFocus(focus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001567")]
		[Cpp2IlInjected.Address(RVA = "0x1324D70", Offset = "0x1323770", VA = "0x181324D70")]
		public void Highlight()
		{
			//Discarded unreachable code: IL_00ea
			//IL_0010: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			GameObject highlightBg = HighlightBg;
			int num = 0;
			if (highlightBg != (UnityEngine.Object)num)
			{
				HighlightBg.SetActive(value: true);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num2 = 0;
			if (selectedHighlightBg != (UnityEngine.Object)num2)
			{
				GameObject selectedBg = SelectedBg;
				int active = 0;
				selectedBg.SetActive((byte)active != 0);
				SelectedHighlightBg.SetActive(value: true);
			}
			GameObject decoration = Decoration;
			int num3 = 0;
			if (decoration != (UnityEngine.Object)num3)
			{
				Decoration.SetActive(value: true);
			}
			if (RedDot.gameObject.activeSelf)
			{
				GameObject gameObject = RedDot.gameObject;
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				ItemSlotModel itemSlotModel = Model;
				RedDotHelper redDotHelper = instance.RedDotHelper;
				IItemData _003CItemData_003Ek__BackingField = itemSlotModel.ItemData;
				bool active2 = default(bool);
				gameObject.SetActive(active2);
			}
			CollectionMenu.SkinShortcutEvent skinEvent = SkinEvent;
			if (skinEvent != null)
			{
				CharacterSkinItemData[] skins = _skins;
				int num5 = 0;
				if (skins != null)
				{
				}
				((UnityEvent<T0, T1>)(object)skinEvent).Invoke((T0)num5, (T1)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001568")]
		[Cpp2IlInjected.Address(RVA = "0x1325C10", Offset = "0x1324610", VA = "0x181325C10")]
		public void RemoveHighlight()
		{
			//Discarded unreachable code: IL_00c8
			//IL_0010: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			GameObject highlightBg = HighlightBg;
			int num = 0;
			if (highlightBg != (UnityEngine.Object)num)
			{
				GameObject highlightBg2 = HighlightBg;
				int active = 0;
				highlightBg2.SetActive((byte)active != 0);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num2 = 0;
			if (selectedHighlightBg != (UnityEngine.Object)num2)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				int active2 = 0;
				selectedHighlightBg2.SetActive((byte)active2 != 0);
			}
			GameObject selectedBg = SelectedBg;
			int num3 = 0;
			if (selectedBg != (UnityEngine.Object)num3)
			{
				GameObject selectedBg2 = SelectedBg;
				bool isSelected = base._isSelected;
				selectedBg2.SetActive(isSelected);
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (UnityEngine.Object)num4)
			{
				GameObject decoration2 = Decoration;
				int active3 = 0;
				decoration2.SetActive((byte)active3 != 0);
			}
			CollectionMenu.SkinShortcutEvent skinEvent = SkinEvent;
			if (skinEvent != null)
			{
				int num5 = 0;
				int num6 = 0;
				((UnityEvent<T0, T1>)(object)skinEvent).Invoke((T0)num6, (T1)num5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001569")]
		[Cpp2IlInjected.Address(RVA = "0x1326590", Offset = "0x1324F90", VA = "0x181326590")]
		public void SetSelected(bool selected)
		{
			//IL_0014: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			if (!selected)
			{
				GameObject selectedHighlightBg = SelectedHighlightBg;
				int num = 0;
				if (selectedHighlightBg != (UnityEngine.Object)num)
				{
					GameObject selectedHighlightBg2 = SelectedHighlightBg;
					int active = 0;
					selectedHighlightBg2.SetActive((byte)active != 0);
				}
				GameObject selectedBg = SelectedBg;
				int active2 = 0;
				selectedBg.SetActive((byte)active2 != 0);
			}
			else
			{
				GameObject selectedHighlightBg3 = SelectedHighlightBg;
				int num2 = 0;
				if (!(selectedHighlightBg3 != (UnityEngine.Object)num2))
				{
					throw new NullReferenceException();
				}
				SelectedHighlightBg.SetActive(selected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600156A")]
		[Cpp2IlInjected.Address(RVA = "0x1324B70", Offset = "0x1323570", VA = "0x181324B70", Slot = "17")]
		public string GetText(TextType textType)
		{
			//Discarded unreachable code: IL_0066
			//IL_004a: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			if ((long)Model != 0)
			{
				string overrideText = _overrideText;
				if ("" != null)
				{
					ItemSlotModel itemSlotModel = Model;
					ItemSlotModel.AlternateDataClass alternateData = itemSlotModel.AlternateData;
					if (alternateData == null)
					{
						IItemData _003CItemData_003Ek__BackingField = itemSlotModel.ItemData;
						string result = default(string);
						return result;
					}
					string displayName = alternateData.DisplayName;
					int num = 0;
					return LocalizationManager.FromStringID(displayName, (IResolver)num);
				}
				string overrideText2 = _overrideText;
				int num2 = 0;
				return LocalizationManager.FromStringID(overrideText2, (IResolver)num2);
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x600156B")]
		[Cpp2IlInjected.Address(RVA = "0x1324C40", Offset = "0x1323640", VA = "0x181324C40", Slot = "18")]
		public string GetURI(SpriteType spriteType)
		{
			//Discarded unreachable code: IL_004c
			ItemSlotModel itemSlotModel = Model;
			if (itemSlotModel != null)
			{
				ItemSlotModel.AlternateDataClass alternateData = itemSlotModel.AlternateData;
				if (alternateData == null)
				{
					IItemData _003CItemData_003Ek__BackingField = itemSlotModel.ItemData;
					bool avatarIsMale_ = SystemRoot.Instance.MetaClient.profile.player_.avatarIsMale_;
					return _003CItemData_003Ek__BackingField.GetIconAddressForGender(avatarIsMale_);
				}
				return alternateData.IconAddress;
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x600156C")]
		[Cpp2IlInjected.Address(RVA = "0x1325250", Offset = "0x1323C50", VA = "0x181325250", Slot = "19")]
		public virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_025a
			//IL_0012: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			//IL_0205: Expected O, but got I4
			//IL_0245: Expected O, but got I4
			int num = 0;
			GameObject skinBtn = _skinBtn;
			int num2 = 0;
			if (skinBtn != (UnityEngine.Object)num2)
			{
				GameObject skinBtn2 = _skinBtn;
				int active = 0;
				skinBtn2.SetActive((byte)active != 0);
			}
			GameObject lockImg = _lockImg;
			int num3 = 0;
			if (lockImg == (UnityEngine.Object)num3)
			{
				RectTransform content = Content;
				int num4 = 0;
				if (content != (UnityEngine.Object)num4)
				{
					int childCount = Content.childCount;
					GameObject gameObject = (_lockImg = Content.transform.GetChild(4).gameObject);
				}
			}
			GameObject lockImg2 = _lockImg;
			int num5 = 0;
			if (lockImg2 != (UnityEngine.Object)num5)
			{
				GameObject lockImg3 = _lockImg;
				int active2 = 0;
				lockImg3.SetActive((byte)active2 != 0);
			}
			if ((IntPtr)SkinEvent == (IntPtr)num)
			{
				int num6 = 0;
				CollectionMenu menu = UiRoot.Instance._menuStack.GetMenu<CollectionMenu>();
				CollectionMenu.SkinShortcutEvent skinEvent = default(CollectionMenu.SkinShortcutEvent);
				if ((object)menu != null)
				{
					skinEvent = menu.SkinEvent;
				}
				SkinEvent = skinEvent;
			}
			ItemSlotModel itemSlotModel = Model;
			if (itemSlotModel != null)
			{
				itemSlotModel.UpdateDisplay(this);
				ItemSlotModel itemSlotModel2 = Model;
				if ((long)itemSlotModel2.AlternateData == 0 && (long)itemSlotModel2.ItemData != 0)
				{
					GameObject gameObject2 = RedDot.gameObject;
					int num7 = 0;
					UiRoot instance = UiRoot.Instance;
					ItemSlotModel itemSlotModel3 = Model;
					RedDotHelper redDotHelper = instance.RedDotHelper;
					IItemData _003CItemData_003Ek__BackingField = itemSlotModel3.ItemData;
					bool active3 = default(bool);
					gameObject2.SetActive(active3);
				}
				GameObject skinBtn3 = _skinBtn;
				int num8 = 0;
				ItemType itemType = default(ItemType);
				if (skinBtn3 != (UnityEngine.Object)num8 && Model.ItemData != null && itemType == ItemType.Character)
				{
					ItemSlotModel itemSlotModel4 = Model;
					if (!itemSlotModel4.IsForSkinPopup)
					{
						IItemData _003CItemData_003Ek__BackingField2 = itemSlotModel4.ItemData;
						CharacterItemData characterItemData = default(CharacterItemData);
						_characterItemData = characterItemData;
						CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
						int iD = _characterItemData.ID;
						CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
						if (characterInstance == null || characterInstance.selectableCharacterSkinItemDatas == null)
						{
						}
						CharacterSkinItemData[] skins = default(CharacterSkinItemData[]);
						_skins = skins;
						bool isUnlocked = CharacterManager.IsCharacterUnlocked(characterInstance);
						SetupSkinText(isUnlocked);
					}
				}
				if (Model.IsForSkinPopup)
				{
					RectTransform originalIconRect = _originalIconRect;
					int num9 = 0;
					if (originalIconRect == (UnityEngine.Object)num9)
					{
						RectTransform rectTransform = (_originalIconRect = _IconRect);
						float iconDimensionForSkinPopup = _iconDimensionForSkinPopup;
						RectTransform iconRect = _IconRect;
						RectTransform iconRect2 = _IconRect;
						int num10 = 0;
						Vector2 anchoredPosition = iconRect2.anchoredPosition;
						iconRect2.anchoredPosition = (Vector2)num10;
					}
				}
			}
			OnRefreshDisplay?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600156D")]
		[Cpp2IlInjected.Address(RVA = "0x1326760", Offset = "0x1325160", VA = "0x181326760")]
		private unsafe void SetupSkinText(bool isUnlocked)
		{
			//Discarded unreachable code: IL_0103
			//IL_00d6: Expected F4, but got I4
			//IL_00d1: Expected native int or pointer, but got O
			if (_skins.Length != 0)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				CharacterSkinItemData[] skins = _skins;
				Func<CharacterSkinItemData, bool> func = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)delegate(CharacterSkinItemData x)
				{
					//Discarded unreachable code: IL_0015
					ListInventory skins2 = profile.Skins;
					Item item = x.Item;
					bool result = default(bool);
					return result;
				};
				int num = Enumerable.Count<CharacterSkinItemData>((IEnumerable<>)(object)skins, (Func<, >)(object)func);
				if (isUnlocked)
				{
					num++;
				}
				SkinBtnHandler component = _skinBtn.GetComponent<SkinBtnHandler>();
				int length = _skins.Length;
				length++;
				component.SetText(num, length);
				_skinBtn.SetActive(value: true);
				int num2 = 0;
				float y = _defaultRedDotPos.y;
				Vector2 zero = Vector2.zero;
				Vector2 anchoredPosition = RedDot.gameObject.GetComponent<RectTransform>().anchoredPosition;
				RedDot redDot = RedDot;
				_defaultRedDotPos = anchoredPosition;
				((Vector2*)(IntPtr)_defaultRedDotPos)->y = 0f;
				RectTransform component2 = redDot.gameObject.GetComponent<RectTransform>();
				Vector2 defaultRedDotPos = _defaultRedDotPos;
				float y2 = _defaultRedDotPos.y;
				component2.anchoredPosition = defaultRedDotPos;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600156E")]
		[Cpp2IlInjected.Address(RVA = "0x1326AF0", Offset = "0x13254F0", VA = "0x181326AF0")]
		public void UpdateRedDot()
		{
			//Discarded unreachable code: IL_0047
			if (RedDot.gameObject.activeSelf)
			{
				GameObject gameObject = RedDot.gameObject;
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				ItemSlotModel itemSlotModel = Model;
				RedDotHelper redDotHelper = instance.RedDotHelper;
				IItemData _003CItemData_003Ek__BackingField = itemSlotModel.ItemData;
				bool active = default(bool);
				gameObject.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600156F")]
		[Cpp2IlInjected.Address(RVA = "0x13258D0", Offset = "0x13242D0", VA = "0x1813258D0", Slot = "16")]
		internal unsafe override void Release()
		{
			//Discarded unreachable code: IL_0163
			//IL_0025: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_0128: Expected native int or pointer, but got O
			//IL_0141: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			GameObject gameObject = RedDot.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject friendshipLevel = FriendshipLevel;
			int num = 0;
			if (friendshipLevel != (UnityEngine.Object)num)
			{
				GameObject friendshipLevel2 = FriendshipLevel;
				int active2 = 0;
				friendshipLevel2.SetActive((byte)active2 != 0);
			}
			GameObject skinBtn = _skinBtn;
			int num2 = 0;
			if (skinBtn != (UnityEngine.Object)num2)
			{
				GameObject skinBtn2 = _skinBtn;
				int active3 = 0;
				skinBtn2.SetActive((byte)active3 != 0);
			}
			RectTransform content = Content;
			int num3 = 0;
			if (content != (UnityEngine.Object)num3)
			{
				RectTransform content2 = Content;
				int num4 = 0;
				Vector2 vector = (content2.anchoredPosition = Vector2.zero);
			}
			int num5 = 0;
			base.FocusNavigationElement = (FocusNavigationElement)num5;
			base.FocusNavigation = (FocusNavigation)num5;
			Model = (ItemSlotModel)num5;
			_overrideText = "";
			_characterItemData = (CharacterItemData)num5;
			int num6 = 0;
			float y = _defaultRedDotPos.y;
			Vector2 zero2 = Vector2.zero;
			RectTransform component = RedDot.gameObject.GetComponent<RectTransform>();
			Vector2 defaultRedDotPos = _defaultRedDotPos;
			float y2 = _defaultRedDotPos.y;
			component.anchoredPosition = defaultRedDotPos;
			int num7 = 0;
			Vector2 vector2 = (_defaultRedDotPos = Vector2.zero);
			((Vector2*)(IntPtr)_defaultRedDotPos)->y = y2;
			RectTransform originalIconRect = _originalIconRect;
			int num8 = 0;
			if (originalIconRect != (UnityEngine.Object)num8)
			{
				RectTransform rectTransform = (_IconRect = _originalIconRect);
				_originalIconRect = (RectTransform)num5;
			}
			base.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6001570")]
		[Cpp2IlInjected.Address(RVA = "0x13260A0", Offset = "0x1324AA0", VA = "0x1813260A0")]
		public void SetOpacityValueForLockBg(float bgOpacity)
		{
			BgOpacityWhenLock = bgOpacity;
		}

		[Cpp2IlInjected.Token(Token = "0x6001571")]
		[Cpp2IlInjected.Address(RVA = "0x13260B0", Offset = "0x1324AB0", VA = "0x1813260B0")]
		public void SetOpacityValueForLockIcon(float iconOpacity)
		{
			IconOpacityWhenLock = iconOpacity;
		}

		[Cpp2IlInjected.Token(Token = "0x6001572")]
		[Cpp2IlInjected.Address(RVA = "0x13260C0", Offset = "0x1324AC0", VA = "0x1813260C0")]
		public void SetOpacityValueForLockLabel(float labelOpacity)
		{
			LabelOpacityWhenLock = labelOpacity;
		}

		[Cpp2IlInjected.Token(Token = "0x6001573")]
		[Cpp2IlInjected.Address(RVA = "0x13260D0", Offset = "0x1324AD0", VA = "0x1813260D0")]
		public void SetOpacity(bool isLock)
		{
			//Discarded unreachable code: IL_012b
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_010a: Expected O, but got I4
			RawImage icon = Icon;
			int num = 0;
			if (!(icon == (UnityEngine.Object)num))
			{
				CanvasGroup component = Icon.GetComponent<CanvasGroup>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					if (isLock)
					{
					}
					component.alpha = 1f;
				}
				CanvasGroup labelCG = LabelCG;
				int num3 = 0;
				if (labelCG != (UnityEngine.Object)num3)
				{
					CanvasGroup labelCG2 = LabelCG;
					if (isLock)
					{
					}
					labelCG2.alpha = 1f;
				}
			}
			CanvasGroup normalBgCG = NormalBgCG;
			int num4 = 0;
			if (!(normalBgCG == (UnityEngine.Object)num4))
			{
				CanvasGroup normalBgCG2 = NormalBgCG;
				if (isLock)
				{
				}
				normalBgCG2.alpha = 1f;
			}
			CanvasGroup highlightBgCG = HighlightBgCG;
			int num5 = 0;
			if (!(highlightBgCG == (UnityEngine.Object)num5))
			{
				CanvasGroup highlightBgCG2 = HighlightBgCG;
				if (isLock)
				{
				}
				highlightBgCG2.alpha = 1f;
			}
			CanvasGroup selectedBgCG = SelectedBgCG;
			int num6 = 0;
			if (!(selectedBgCG == (UnityEngine.Object)num6))
			{
				CanvasGroup selectedBgCG2 = SelectedBgCG;
				if (isLock)
				{
				}
				selectedBgCG2.alpha = 1f;
			}
			CanvasGroup selectedHighlightBgCG = SelectedHighlightBgCG;
			int num7 = 0;
			if (!(selectedHighlightBgCG == (UnityEngine.Object)num7))
			{
				CanvasGroup selectedHighlightBgCG2 = SelectedHighlightBgCG;
				float bgOpacityWhenLock = default(float);
				if (isLock)
				{
					bgOpacityWhenLock = BgOpacityWhenLock;
				}
				selectedHighlightBgCG2.alpha = bgOpacityWhenLock;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001574")]
		[Cpp2IlInjected.Address(RVA = "0x1325E70", Offset = "0x1324870", VA = "0x181325E70")]
		private void SetIconAndLabelOpacity(bool isLock)
		{
			//Discarded unreachable code: IL_006f
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			RawImage icon = Icon;
			int num = 0;
			if (icon == (UnityEngine.Object)num)
			{
				return;
			}
			CanvasGroup component = Icon.GetComponent<CanvasGroup>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				if (isLock)
				{
				}
				component.alpha = 1f;
			}
			CanvasGroup labelCG = LabelCG;
			int num3 = 0;
			if (labelCG != (UnityEngine.Object)num3)
			{
				CanvasGroup labelCG2 = LabelCG;
				float labelOpacityWhenLock = default(float);
				if (isLock)
				{
					labelOpacityWhenLock = LabelOpacityWhenLock;
				}
				labelCG2.alpha = labelOpacityWhenLock;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001575")]
		[Cpp2IlInjected.Address(RVA = "0x1325FF0", Offset = "0x13249F0", VA = "0x181325FF0")]
		private void SetNormalBgCanvasGroup(bool isLock)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			CanvasGroup normalBgCG = NormalBgCG;
			int num = 0;
			if (!(normalBgCG == (UnityEngine.Object)num))
			{
				CanvasGroup normalBgCG2 = NormalBgCG;
				if (isLock)
				{
				}
				normalBgCG2.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001576")]
		[Cpp2IlInjected.Address(RVA = "0x1325DC0", Offset = "0x13247C0", VA = "0x181325DC0")]
		private void SetHighlightBgCanvasGroup(bool isLock)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			CanvasGroup highlightBgCG = HighlightBgCG;
			int num = 0;
			if (!(highlightBgCG == (UnityEngine.Object)num))
			{
				CanvasGroup highlightBgCG2 = HighlightBgCG;
				if (isLock)
				{
				}
				highlightBgCG2.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001577")]
		[Cpp2IlInjected.Address(RVA = "0x13264E0", Offset = "0x1324EE0", VA = "0x1813264E0")]
		private void SetSelectedBgCanvasGroup(bool isLock)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			CanvasGroup selectedBgCG = SelectedBgCG;
			int num = 0;
			if (!(selectedBgCG == (UnityEngine.Object)num))
			{
				CanvasGroup selectedBgCG2 = SelectedBgCG;
				if (isLock)
				{
				}
				selectedBgCG2.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001578")]
		[Cpp2IlInjected.Address(RVA = "0x1326430", Offset = "0x1324E30", VA = "0x181326430")]
		private void SetSelectHighlightBgCanvasGroup(bool isLock)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			CanvasGroup selectedHighlightBgCG = SelectedHighlightBgCG;
			int num = 0;
			if (!(selectedHighlightBgCG == (UnityEngine.Object)num))
			{
				CanvasGroup selectedHighlightBgCG2 = SelectedHighlightBgCG;
				if (isLock)
				{
				}
				selectedHighlightBgCG2.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001579")]
		[Cpp2IlInjected.Address(RVA = "0x13266C0", Offset = "0x13250C0", VA = "0x1813266C0")]
		public void SetWhiteBgs(bool isLock)
		{
			//Discarded unreachable code: IL_002f
			GameObject[] whiteBgs = WhiteBgs;
			if (whiteBgs != null)
			{
				int num = 0;
				if (num < whiteBgs.Length)
				{
					whiteBgs[num].SetActive(isLock);
					GameObject[] whiteBgs2 = WhiteBgs;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600157A")]
		[Cpp2IlInjected.Address(RVA = "0x976350", Offset = "0x974D50", VA = "0x180976350")]
		public CharacterSkinItemData[] GetSkins()
		{
			return _skins;
		}

		[Cpp2IlInjected.Token(Token = "0x600157B")]
		[Cpp2IlInjected.Address(RVA = "0x1324A60", Offset = "0x1323460", VA = "0x181324A60")]
		public CharacterManager.CharacterInstance GetCharacterInstance()
		{
			//Discarded unreachable code: IL_0019
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int iD = _characterItemData.ID;
			CharacterManager.CharacterInstance result = default(CharacterManager.CharacterInstance);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600157C")]
		[Cpp2IlInjected.Address(RVA = "0x1324B60", Offset = "0x1323560", VA = "0x181324B60")]
		public CharacterItemData GetItemData()
		{
			return _characterItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600157D")]
		[Cpp2IlInjected.Address(RVA = "0x1326AC0", Offset = "0x13254C0", VA = "0x181326AC0")]
		public void ToggleLock(bool value)
		{
			//Discarded unreachable code: IL_000d
			_lockImg.SetActive(value);
		}

		[Cpp2IlInjected.Token(Token = "0x600157E")]
		[Cpp2IlInjected.Address(RVA = "0x1325FE0", Offset = "0x13249E0", VA = "0x181325FE0")]
		public void SetLabel(string text)
		{
			_overrideText = text;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600157F")]
		[Cpp2IlInjected.Address(RVA = "0x1326BE0", Offset = "0x13255E0", VA = "0x181326BE0")]
		public unsafe ItemSlot()
		{
			//IL_0052: Expected F4, but got I4
			//IL_004d: Expected native int or pointer, but got O
			int num = 0;
			_defaultRedDotPos = Vector2.zero;
			((Vector2*)(IntPtr)_defaultRedDotPos)->y = 0f;
			_useClickSfx = true;
			base._002Ector();
		}
	}
}
