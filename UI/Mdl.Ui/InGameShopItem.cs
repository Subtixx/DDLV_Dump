using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Localization.Formatter;
using Google.Protobuf.WellKnownTypes;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005AA")]
	public class InGameShopItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20005AB")]
		public delegate void Selected(InGameShopItem item);

		[Cpp2IlInjected.Token(Token = "0x20005AC")]
		public delegate void GamepadClicked(InGameShopItem item);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F3F")]
		[SerializeField]
		private BaseButton _btn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F40")]
		[SerializeField]
		private RectTransform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F41")]
		[SerializeField]
		private RectTransform _mcOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F42")]
		[SerializeField]
		private RectTransform _mcSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F43")]
		[SerializeField]
		private RectTransform _bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F44")]
		[SerializeField]
		private RectTransform _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001F45")]
		[SerializeField]
		private RectTransform _deco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001F46")]
		[SerializeField]
		private RectTransform _itemBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001F47")]
		[SerializeField]
		private RectTransform _bundleBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001F48")]
		[SerializeField]
		private AsyncAtlassedIcon _itemIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001F49")]
		[SerializeField]
		private AsyncAtlassedIcon[] _itemBundleIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001F4A")]
		[SerializeField]
		private RectTransform _itemBundleIconContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001F4B")]
		[SerializeField]
		private AsyncAtlassedIcon _priceIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001F4C")]
		[SerializeField]
		private RectTransform _mcPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001F4D")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001F4E")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001F4F")]
		[SerializeField]
		private EventRewardItemFocusElement _focusNavElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001F50")]
		[SerializeField]
		private AssetReferenceTexture[] _hardCurrencyIcons;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4001F54")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBD")]
		[Cpp2IlInjected.Token(Token = "0x4001F55")]
		private bool _isHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001F56")]
		private float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4001F57")]
		public bool IsLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x4001F58")]
		private bool _isOwned;

		[Cpp2IlInjected.Token(Token = "0x170005B4")]
		public EventRewardItemFocusElement FocusNavElement
		{
			[Cpp2IlInjected.Token(Token = "0x60024F3")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _focusNavElement;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB8"), Cpp2IlInjected.Token(Token = "0x4001F53")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60024F8")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCF0", Offset = "0xD2E6F0", VA = "0x180D2FCF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60024F9")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD30", Offset = "0xD2E730", VA = "0x180D2FD30")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005B6")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60024FA")]
			[Cpp2IlInjected.Address(RVA = "0x131D380", Offset = "0x131BD80", VA = "0x18131D380")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x60024FB")]
			[Cpp2IlInjected.Address(RVA = "0x131D580", Offset = "0x131BF80", VA = "0x18131D580")]
			set
			{
				_isSelected = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B7")]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x60024FC")]
			[Cpp2IlInjected.Address(RVA = "0x131D360", Offset = "0x131BD60", VA = "0x18131D360")]
			get
			{
				return _isOwned;
			}
			[Cpp2IlInjected.Token(Token = "0x60024FD")]
			[Cpp2IlInjected.Address(RVA = "0x131D560", Offset = "0x131BF60", VA = "0x18131D560")]
			set
			{
				_isOwned = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC6"), Cpp2IlInjected.Token(Token = "0x4001F59")]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x60024FE")]
			[Cpp2IlInjected.Address(RVA = "0x131D350", Offset = "0x131BD50", VA = "0x18131D350")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60024FF")]
			[Cpp2IlInjected.Address(RVA = "0x131D550", Offset = "0x131BF50", VA = "0x18131D550")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005B9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC7"), Cpp2IlInjected.Token(Token = "0x4001F5A")]
		public bool IsRecurrent
		{
			[Cpp2IlInjected.Token(Token = "0x6002500")]
			[Cpp2IlInjected.Address(RVA = "0x131D370", Offset = "0x131BD70", VA = "0x18131D370")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002501")]
			[Cpp2IlInjected.Address(RVA = "0x131D570", Offset = "0x131BF70", VA = "0x18131D570")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005BA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC8"), Cpp2IlInjected.Token(Token = "0x4001F5B")]
		public bool IsDailyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002502")]
			[Cpp2IlInjected.Address(RVA = "0xD3CD40", Offset = "0xD3B740", VA = "0x180D3CD40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002503")]
			[Cpp2IlInjected.Address(RVA = "0xD3CEF0", Offset = "0xD3B8F0", VA = "0x180D3CEF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005BB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC9"), Cpp2IlInjected.Token(Token = "0x4001F5C")]
		public bool IsWeeklyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002504")]
			[Cpp2IlInjected.Address(RVA = "0x131D390", Offset = "0x131BD90", VA = "0x18131D390")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002505")]
			[Cpp2IlInjected.Address(RVA = "0x131D590", Offset = "0x131BF90", VA = "0x18131D590")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xCA"), Cpp2IlInjected.Token(Token = "0x4001F5D")]
		public bool IsHouseSkinItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002506")]
			[Cpp2IlInjected.Address(RVA = "0x131D340", Offset = "0x131BD40", VA = "0x18131D340")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002507")]
			[Cpp2IlInjected.Address(RVA = "0x131D540", Offset = "0x131BF40", VA = "0x18131D540")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005BD")]
		public DateTime? EndOfSale
		{
			[Cpp2IlInjected.Token(Token = "0x6002508")]
			[Cpp2IlInjected.Address(RVA = "0x131D330", Offset = "0x131BD30", VA = "0x18131D330")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002509")]
			[Cpp2IlInjected.Address(RVA = "0x131D520", Offset = "0x131BF20", VA = "0x18131D520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BE")]
		public OnlineStoreData Store
		{
			[Cpp2IlInjected.Token(Token = "0x600250A")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			[CompilerGenerated]
			get
			{
				return _003CStore_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600250B")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			[CompilerGenerated]
			private set
			{
				_003CStore_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BF")]
		public Definitions.StoreContent StoreContent
		{
			[Cpp2IlInjected.Token(Token = "0x600250C")]
			[Cpp2IlInjected.Address(RVA = "0x131D3B0", Offset = "0x131BDB0", VA = "0x18131D3B0")]
			get
			{
				InGameShopContent.UIStoreContent uIStoreContent = UIStoreContent;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C0")]
		public InGameShopContent.UIStoreContent UIStoreContent
		{
			[Cpp2IlInjected.Token(Token = "0x600250D")]
			[Cpp2IlInjected.Address(RVA = "0x131D3C0", Offset = "0x131BDC0", VA = "0x18131D3C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600250E")]
			[Cpp2IlInjected.Address(RVA = "0x131D5C0", Offset = "0x131BFC0", VA = "0x18131D5C0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x100"), Cpp2IlInjected.Token(Token = "0x4001F61")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600250F")]
			[Cpp2IlInjected.Address(RVA = "0x976100", Offset = "0x974B00", VA = "0x180976100")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002510")]
			[Cpp2IlInjected.Address(RVA = "0x976690", Offset = "0x975090", VA = "0x180976690")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x104"), Cpp2IlInjected.Token(Token = "0x4001F62")]
		public int OriginalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6002511")]
			[Cpp2IlInjected.Address(RVA = "0x131D3A0", Offset = "0x131BDA0", VA = "0x18131D3A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002512")]
			[Cpp2IlInjected.Address(RVA = "0x131D5B0", Offset = "0x131BFB0", VA = "0x18131D5B0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x108"), Cpp2IlInjected.Token(Token = "0x4001F63")]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6002513")]
			[Cpp2IlInjected.Address(RVA = "0xE58430", Offset = "0xE56E30", VA = "0x180E58430")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002514")]
			[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE56E80", VA = "0x180E58480")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C4")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002515")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002516")]
			[Cpp2IlInjected.Address(RVA = "0x83E110", Offset = "0x83CB10", VA = "0x18083E110")]
			[CompilerGenerated]
			private set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C5")]
		public string ListName
		{
			[Cpp2IlInjected.Token(Token = "0x6002517")]
			[Cpp2IlInjected.Address(RVA = "0xA5C390", Offset = "0xA5AD90", VA = "0x180A5C390")]
			[CompilerGenerated]
			get
			{
				return _003CListName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002518")]
			[Cpp2IlInjected.Address(RVA = "0x131D5A0", Offset = "0x131BFA0", VA = "0x18131D5A0")]
			[CompilerGenerated]
			private set
			{
				_003CListName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C6")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002519")]
			[Cpp2IlInjected.Address(RVA = "0x9760E0", Offset = "0x974AE0", VA = "0x1809760E0")]
			[CompilerGenerated]
			get
			{
				return _003CIconAddress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600251A")]
			[Cpp2IlInjected.Address(RVA = "0x131D530", Offset = "0x131BF30", VA = "0x18131D530")]
			[CompilerGenerated]
			private set
			{
				_003CIconAddress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x128"), Cpp2IlInjected.Token(Token = "0x4001F67")]
		public Item CurrencyToBuy
		{
			[Cpp2IlInjected.Token(Token = "0x600251B")]
			[Cpp2IlInjected.Address(RVA = "0x9762D0", Offset = "0x974CD0", VA = "0x1809762D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600251C")]
			[Cpp2IlInjected.Address(RVA = "0x9766A0", Offset = "0x9750A0", VA = "0x1809766A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C8")]
		public string CurrencyName
		{
			[Cpp2IlInjected.Token(Token = "0x600251D")]
			[Cpp2IlInjected.Address(RVA = "0x131D1D0", Offset = "0x131BBD0", VA = "0x18131D1D0")]
			get
			{
				//Discarded unreachable code: IL_0027
				Item item = CurrencyToBuy;
				bool flag = default(bool);
				if (flag)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item2 = CurrencyToBuy;
					IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData(item2);
				}
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000043")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60024F4")]
			[Cpp2IlInjected.Address(RVA = "0x131D130", Offset = "0x131BB30", VA = "0x18131D130")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024F5")]
			[Cpp2IlInjected.Address(RVA = "0x131D480", Offset = "0x131BE80", VA = "0x18131D480")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000044")]
		public event GamepadClicked OnGamepadClicked
		{
			[Cpp2IlInjected.Token(Token = "0x60024F6")]
			[Cpp2IlInjected.Address(RVA = "0x131D090", Offset = "0x131BA90", VA = "0x18131D090")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024F7")]
			[Cpp2IlInjected.Address(RVA = "0x131D3E0", Offset = "0x131BDE0", VA = "0x18131D3E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600251E")]
		[Cpp2IlInjected.Address(RVA = "0x131CF20", Offset = "0x131B920", VA = "0x18131CF20")]
		private void Start()
		{
			//Discarded unreachable code: IL_005d
			//IL_0010: Expected O, but got I4
			RectTransform animatedContent = _animatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				Vector3 vector = default(Vector3);
				float num2 = (_oY = vector.y);
			}
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button.ButtonClickedEvent onClick = btn.ButtonComponent.m_OnClick;
				UnityAction call = OnClicked;
				onClick.AddListener(call);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600251F")]
		[Cpp2IlInjected.Address(RVA = "0x131C4D0", Offset = "0x131AED0", VA = "0x18131C4D0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_002c
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button.ButtonClickedEvent onClick = btn.ButtonComponent.m_OnClick;
				UnityAction call = OnClicked;
				onClick.RemoveListener(call);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002520")]
		[Cpp2IlInjected.Address(RVA = "0x131C410", Offset = "0x131AE10", VA = "0x18131C410")]
		private void OnClicked()
		{
			//Discarded unreachable code: IL_007a
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				if (UiRoot.Instance.IsLastInputFromJoystick)
				{
					this.OnGamepadClicked?.Invoke(this);
					return;
				}
			}
			while (_isSelected)
			{
			}
			_btn?.PostWwiseEvent();
			_isSelected = true;
			RefreshDisplay();
			Selected onSelected = this.OnSelected;
			while (onSelected == null)
			{
			}
			onSelected(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002521")]
		[Cpp2IlInjected.Address(RVA = "0x131B1B0", Offset = "0x1319BB0", VA = "0x18131B1B0")]
		internal void Click()
		{
			if (!_isSelected)
			{
				_btn?.PostWwiseEvent();
				_isSelected = true;
				RefreshDisplay();
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002522")]
		[Cpp2IlInjected.Address(RVA = "0x131C580", Offset = "0x131AF80", VA = "0x18131C580")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_00b1
			//IL_0017: Expected O, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = true;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_animatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			RefreshDisplay();
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !_isSelected)
			{
				_btn?.PostWwiseEvent();
				_isSelected = true;
				RefreshDisplay();
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002523")]
		[Cpp2IlInjected.Address(RVA = "0x131B210", Offset = "0x1319C10", VA = "0x18131B210")]
		public unsafe void Init(OnlineStoreData store, InGameShopContent.UIStoreContent uiContent, InGameShopMenu.InGameShopTabType currentTab, bool isWeeklyItem, bool isDailyItem)
		{
			//IL_00db: Expected O, but got I4
			//IL_0134: Expected O, but got I4
			//IL_0149: Expected O, but got I4
			//IL_019f: Expected O, but got I4
			//IL_0209: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_03aa: Expected O, but got I4
			//IL_04a3: Expected I4, but got I8
			Definitions.StoreContent.Info info = default(Definitions.StoreContent.Info);
			ContentPrice contentPrice = default(ContentPrice);
			Definitions.StoreContent.Types.StoreSale storeSale = default(Definitions.StoreContent.Types.StoreSale);
			StoreContentBundle storeContentBundle = default(StoreContentBundle);
			ConditionDate endDate_2;
			int num;
			while (true)
			{
				num = 0;
				Store = store;
				Release();
				IsWeeklyItem = (IsDailyItem = (IsRecurrent = currentTab == InGameShopMenu.InGameShopTabType.HardCurrency));
				if (info != null)
				{
					List<ContentPrice> prices = info.Prices;
					if (prices != null && Enumerable.FirstOrDefault<ContentPrice>((IEnumerable<>)prices) != null)
					{
						goto IL_0055;
					}
				}
				contentPrice = new ContentPrice();
				contentPrice.currencyId_ = num;
				goto IL_0055;
				IL_0055:
				if (info != null)
				{
				}
				bool flag = (IsOnSale = num != 0);
				if (num != 0)
				{
					DateTime dateTime = storeSale.endDate_.date_.ToDateTime();
				}
				ConditionDate endDate_ = store.endDate_;
				if (endDate_ != null)
				{
					Timestamp date_ = endDate_.date_;
				}
				if (storeContentBundle == null)
				{
					continue;
				}
				OnlineBundleData data = storeContentBundle.Data;
				if (data != null)
				{
					endDate_2 = data.endDate_;
					if (endDate_2 != null)
					{
						break;
					}
				}
			}
			int num2 = default(int);
			if ((object)endDate_2.date_.ToDateTime() == null)
			{
				num2 = 0;
			}
			EndOfSale = (DateTime?)(object)num2;
			IStoreContentType storeContentType = default(IStoreContentType);
			if (storeContentType != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (_003C_003Ec._003C_003E9__112_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<Definitions.StoreContent.ItemReward> enumerable = default(IEnumerable<Definitions.StoreContent.ItemReward>);
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)enumerable);
			}
			if ((IsRecurrent ? 1 : 0) == num && num != 0)
			{
				Client client = default(Client);
				uint num4 = default(uint);
				if (client.profile.player_.HasAnyItem((List<>)num, (int)num4))
				{
				}
				Client client2 = default(Client);
				bool flag2 = client2.profile.world_.IsAnyItemOnGrid((List<>)num);
			}
			int num5 = ((_isOwned = false) ? 1 : 0);
			Definitions.StoreContent.Types.StoreSale _003CActiveSale_003Ek__BackingField = info.ActiveSale;
			int amount_ = contentPrice.amount_;
			int num6 = _003CActiveSale_003Ek__BackingField.ApplyTo(amount_);
			int num7 = (Price = contentPrice.amount_);
			int num8 = (OriginalPrice = contentPrice.amount_);
			if (info != null)
			{
			}
			Name = (string)num;
			if (info != null)
			{
				List<Definitions.StoreContent.ItemReward> items = info.Items;
				ItemType itemType = default(ItemType);
				if (itemType != ItemType.Building)
				{
				}
			}
			IsHouseSkinItem = (byte)num != 0;
			if (num == 0 && _003C_003Ec._003C_003E9__112_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0017
					ItemType itemType2 = default(ItemType);
					if (itemType2 == ItemType.Decal)
					{
					}
					ItemType itemType3 = default(ItemType);
					if (itemType3 == ItemType.Makeup)
					{
					}
					string text4 = default(string);
					return $"{text4} x{text4}";
				};
			}
			ListName = "menu.shop_house_skin";
			if ((IsRecurrent ? 1 : 0) == num || info != null)
			{
			}
			uint num9 = default(uint);
			Amount = (int)num9;
			int currencyId_ = contentPrice.currencyId_;
			CurrencyToBuy = (Item)num9;
			if (info != null)
			{
			}
			IconAddress = (string)num;
			AssetReferenceTexture[] hardCurrencyIcons = _hardCurrencyIcons;
			if (Enumerable.Count<AssetReferenceTexture>((IEnumerable<>)(object)hardCurrencyIcons) > 0)
			{
				List<Definitions.StoreContent> list2 = (List<Definitions.StoreContent>)(object)Enumerable.ToList<Definitions.StoreContent>((IEnumerable<>)(object)hardCurrencyIcons);
				if (_003C_003Ec._003C_003E9__112_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				int b = default(int);
				int b2 = Mathf.Max(0, b);
				AssetReferenceTexture[] hardCurrencyIcons2 = _hardCurrencyIcons;
				int a = Enumerable.Count<AssetReferenceTexture>((IEnumerable<>)(object)hardCurrencyIcons2) - 1;
				a = Mathf.Min(a, b2);
				string text = (IconAddress = hardCurrencyIcons2[a].AssetGUID);
			}
			AsyncAtlassedIcon itemIcon = _itemIcon;
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			bool active = default(bool);
			_priceIcon.gameObject.SetActive(active);
			bool flag4 = default(bool);
			if (flag4)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = CurrencyToBuy;
				IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData(item);
				AsyncAtlassedIcon priceIcon = _priceIcon;
			}
			Transform parent = _priceIcon.transform.parent;
			parent.RebuildLayout();
			bool flag5 = default(bool);
			if ((long)parent != 9)
			{
				flag5 = (long)parent == 16;
			}
			_itemIcon.gameObject.SetActive(flag5);
			_itemBg.gameObject.SetActive(flag5);
			_itemBundleIconContainer.gameObject.SetActive(flag5);
			_bundleBg.gameObject.SetActive(flag5);
			int num10 = Enumerable.Count<AsyncAtlassedIcon>((IEnumerable<>)(object)_itemBundleIcon);
			string text3 = default(string);
			Transform parent2 = default(Transform);
			if (!flag5)
			{
				if (num10 > 0)
				{
					_itemBundleIcon[num].Release();
					num++;
					int num11 = Enumerable.Count<AsyncAtlassedIcon>((IEnumerable<>)(object)_itemBundleIcon);
				}
				AsyncAtlassedIcon itemIcon2 = _itemIcon;
				string stringID = default(string);
				_tfPrice.StringID = stringID;
				string stringID2 = Name;
				int num12 = 0;
				string text2 = LocalizationManager.FromStringID(stringID2, (IResolver)num12);
				if ((IsRecurrent ? 1 : 0) != num)
				{
					text3 = *(int*)Amount + " " + text2;
				}
				_tfName.StringID = text3;
				GameObject gameObject = _mcSale.gameObject;
				bool active2 = (_isOwned ? 1 : 0) == num;
				gameObject.SetActive(active2);
				GameObject gameObject2 = _mcOwned.gameObject;
				bool isOwned = _isOwned;
				gameObject2.SetActive(isOwned);
				GameObject gameObject3 = _mcPrice.gameObject;
				bool active3 = !_isOwned;
				int num13 = 0;
				gameObject3.SetActive(active3);
				_tfPrice.transform.RebuildLayout();
				parent2 = _tfPrice.transform.parent;
				parent2.RebuildLayout();
				return;
			}
			while ((long)(IntPtr)parent2 <= 0L)
			{
			}
			AsyncAtlassedIcon asyncAtlassedIcon = _itemBundleIcon[(object)text3];
			int num14 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			if (!string.IsNullOrWhiteSpace(text3))
			{
				GameObject gameObject4 = asyncAtlassedIcon.gameObject;
				int num15 = 0;
				ulong num16 = default(ulong);
				gameObject4.SetActive((byte)num16 != 0);
				int num17 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			asyncAtlassedIcon.Release();
			GameObject gameObject5 = asyncAtlassedIcon.gameObject;
			int active4 = 0;
			gameObject5.SetActive((byte)active4 != 0);
			AsyncAtlassedIcon[] itemBundleIcon = _itemBundleIcon;
			uint num18 = num18 + 16;
			int num19 = Enumerable.Count<AsyncAtlassedIcon>((IEnumerable<>)(object)itemBundleIcon);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002524")]
		[Cpp2IlInjected.Address(RVA = "0x131C3A0", Offset = "0x131ADA0", VA = "0x18131C3A0")]
		public bool IsCollectable(out bool isInsufficient)
		{
			if (!IsRecurrent)
			{
				if (!_isOwned)
				{
					int currencyBalance = CurrencyContent.GetCurrencyBalance(CurrencyToBuy);
					bool flag = (isInsufficient.m_value = currencyBalance < Price);
					return currencyBalance >= Price;
				}
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002525")]
		[Cpp2IlInjected.Address(RVA = "0x131CDC0", Offset = "0x131B7C0", VA = "0x18131CDC0")]
		public void ResetOnSelectedListener()
		{
			if ((object)typeof(Selected).TypeHandle != null)
			{
				int num = 0;
				int num2 = 0;
				if ((long)num < (long)(IntPtr)typeof(Selected).TypeHandle)
				{
					if ((object)typeof(Selected).TypeHandle != null)
					{
					}
					Delegate @delegate = default(Delegate);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while (@delegate != this)
						{
						}
						num2++;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002526")]
		[Cpp2IlInjected.Address(RVA = "0x131CC60", Offset = "0x131B660", VA = "0x18131CC60")]
		public void ResetOnGamepadClickedListener()
		{
			if ((object)typeof(GamepadClicked).TypeHandle != null)
			{
				int num = 0;
				int num2 = 0;
				if ((long)num < (long)(IntPtr)typeof(GamepadClicked).TypeHandle)
				{
					if ((object)typeof(GamepadClicked).TypeHandle != null)
					{
					}
					Delegate @delegate = default(Delegate);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while (@delegate != this)
						{
						}
						num2++;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002527")]
		[Cpp2IlInjected.Address(RVA = "0x131C8B0", Offset = "0x131B2B0", VA = "0x18131C8B0")]
		public void Release()
		{
			//IL_0020: Expected O, but got I4
			//IL_0058: Expected F4, but got I4
			//IL_00f5: Expected O, but got I8
			if (_isHighlighted)
			{
				RectTransform animatedContent = _animatedContent;
				_isHighlighted = false;
				int num = 0;
				if (animatedContent != (UnityEngine.Object)num)
				{
					RectTransform animatedContent2 = _animatedContent;
					int complete = 0;
					int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
					float oY = _oY;
					int num3 = 0;
					RectTransform animatedContent3 = _animatedContent;
					int num4 = 0;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, (float)num4, (byte)num3 != 0)).Play();
				}
				RefreshDisplay();
			}
			_itemIcon.Release();
			_priceIcon.Release();
			_isSelected = false;
			RefreshDisplay();
			Selected onSelected = this.OnSelected;
			Delegate delegate2 = default(Delegate);
			if (onSelected != null)
			{
				Delegate[] invocationList = onSelected.GetInvocationList();
				int num5 = 0;
				int num6 = 0;
				int length = invocationList.Length;
				if (num5 < length)
				{
					Delegate @delegate = invocationList[num6];
					if ((object)@delegate != null)
					{
					}
					Selected onSelected2 = this.OnSelected;
					delegate2 = Delegate.Remove(onSelected2, @delegate);
					if ((object)delegate2 != null && (object)delegate2 == null)
					{
						throw new InvalidCastException();
					}
					while ((object)delegate2 != onSelected2)
					{
					}
					num6++;
				}
			}
			this.OnSelected = (Selected)0;
			if ((object)typeof(GamepadClicked).TypeHandle != null)
			{
				int num7 = 0;
				int num8 = 0;
				if ((long)num7 < (long)(IntPtr)typeof(GamepadClicked).TypeHandle)
				{
					if ((object)typeof(GamepadClicked).TypeHandle != null)
					{
					}
					Delegate delegate3 = default(Delegate);
					if ((object)delegate3 != null && (object)delegate3 == null)
					{
						throw new InvalidCastException();
					}
					while ((object)delegate3 != delegate2)
					{
					}
					num8++;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002528")]
		[Cpp2IlInjected.Address(RVA = "0x131C6E0", Offset = "0x131B0E0", VA = "0x18131C6E0")]
		public void OnHighlightRemoved()
		{
			//IL_0017: Expected O, but got I4
			//IL_004f: Expected F4, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = false;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				RectTransform animatedContent3 = _animatedContent;
				int num4 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, (float)num4, (byte)num3 != 0)).Play();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6002529")]
		[Cpp2IlInjected.Address(RVA = "0x131C7D0", Offset = "0x131B1D0", VA = "0x18131C7D0")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0074
			int num = 0;
			if ((_isOwned ? 1 : 0) != num)
			{
			}
			GameObject gameObject = _bg.gameObject;
			bool active = !_isSelected;
			gameObject.SetActive(active);
			GameObject gameObject2 = _selectedBg.gameObject;
			bool isSelected = _isSelected;
			gameObject2.SetActive(isSelected);
			GameObject gameObject3 = _deco.gameObject;
			bool isHighlighted = _isHighlighted;
			gameObject3.SetActive(isHighlighted);
			_mcOwned.gameObject.SetActive((byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600252A")]
		[Cpp2IlInjected.Address(RVA = "0x131D030", Offset = "0x131BA30", VA = "0x18131D030")]
		public InGameShopItem()
		{
			int num = 0;
			CurrencyToBuy = CurrencyItem.HardCurrencyItem;
			base._002Ector();
		}
	}
}
