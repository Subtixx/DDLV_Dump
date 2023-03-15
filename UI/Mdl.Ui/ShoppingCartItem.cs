using System.Runtime.CompilerServices;
using Assets.UI.Utilities;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000369")]
	[RequiredAllNotNull]
	public class ShoppingCartItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001080")]
		protected bool _showCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4001081")]
		[HideInInspector]
		public bool GiveItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4001082")]
		[HideInInspector]
		public int Amount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001088")]
		[SerializeField]
		protected AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001089")]
		[SerializeField]
		protected TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400108A")]
		[SerializeField]
		protected TextBase _tfItemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400108B")]
		[SerializeField]
		protected AsyncAtlassedIcon _mcCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400108C")]
		[SerializeField]
		protected RectTransform _mcCurrencyHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400108D")]
		[SerializeField]
		private AssetReferenceTexture _moonstoneIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400108E")]
		[SerializeField]
		[Nulllable]
		protected RectTransform _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400108F")]
		[SerializeField]
		[Nulllable]
		protected TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001090")]
		[HideInInspector]
		public int CartIndex = -1;

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public bool ShowCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x60015CB")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get
			{
				return _showCurrency;
			}
			[Cpp2IlInjected.Token(Token = "0x60015CC")]
			[Cpp2IlInjected.Address(RVA = "0x15EAED0", Offset = "0x15E98D0", VA = "0x1815EAED0")]
			set
			{
				_showCurrency = value;
				RefreshCurrency();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x4001083")]
		internal int SelectedAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60015CD")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015CE")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x74"), Cpp2IlInjected.Token(Token = "0x4001084")]
		internal int InventoryAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60015CF")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015D0")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x4001085")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60015D1")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015D2")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60015D3")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60015D4")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			internal set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public ItemState ItemState
		{
			[Cpp2IlInjected.Token(Token = "0x60015D5")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			[CompilerGenerated]
			get
			{
				return _003CItemState_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60015D6")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			[CompilerGenerated]
			internal set
			{
				_003CItemState_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		private bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x60015D7")]
			[Cpp2IlInjected.Address(RVA = "0x15EAE00", Offset = "0x15E9800", VA = "0x1815EAE00")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.MetaClient.profile.player_.avatarIsMale_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015D8")]
		[Cpp2IlInjected.Address(RVA = "0x15EA900", Offset = "0x15E9300", VA = "0x1815EA900", Slot = "9")]
		internal virtual void Refresh()
		{
			//Discarded unreachable code: IL_0130
			//IL_0015: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			RawImage rawImage = mc_icon.RawImage;
			int num = 0;
			rawImage.texture = (Texture)num;
			IItemData itemData = ItemData;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				IItemData itemData2 = ItemData;
				int num2 = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				bool flag = default(bool);
				if (flag)
				{
					string assetGUID = _moonstoneIcon.AssetGUID;
				}
			}
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			IItemData itemData3 = ItemData;
			bool avatarIsMale_ = SystemRoot.Instance.MetaClient.profile.player_.avatarIsMale_;
			string iconAddressForGender = itemData3.GetIconAddressForGender(avatarIsMale_);
			bool flag2 = asyncAtlassedIcon.SetIcon(iconAddressForGender);
			RectTransform mcAmount = _mcAmount;
			int num3 = 0;
			if (mcAmount != (Object)num3)
			{
				TextBase tfAmount = _tfAmount;
				int num4 = 0;
				if (tfAmount != (Object)num4)
				{
					IItemData itemData4 = ItemData;
					ItemType itemType2 = default(ItemType);
					if (itemType2 == ItemType.Currency)
					{
						_mcAmount.gameObject.SetActive(value: true);
						TextBase tfAmount2 = _tfAmount;
						string text = default(string);
						string text3 = (tfAmount2.Text = "x" + text);
					}
				}
			}
			TextBase tfItemName = _tfItemName;
			if (!GiveItem)
			{
				GameObject gameObject = tfItemName.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			else
			{
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive(value: true);
				IItemData itemData5 = ItemData;
				TextBase tfItemName2 = _tfItemName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015D9")]
		[Cpp2IlInjected.Address(RVA = "0x15EAD00", Offset = "0x15E9700", VA = "0x1815EAD00")]
		public void SetItemAmount(bool active, int amount = 0)
		{
			//Discarded unreachable code: IL_0015
			bool flag = default(bool);
			if (flag)
			{
				base.gameObject.SetActive(active);
				if (!active)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015DA")]
		[Cpp2IlInjected.Address(RVA = "0x15EA6E0", Offset = "0x15E90E0", VA = "0x1815EA6E0")]
		private void RefreshCurrency()
		{
			//Discarded unreachable code: IL_0063
			if (_showCurrency)
			{
				IItemData itemData = ItemData;
				bool flag = default(bool);
				if (flag)
				{
					CurrencyCost currencyCost = default(CurrencyCost);
					int num = (Price = currencyCost.amount_);
					AsyncAtlassedIcon mcCurrency = _mcCurrency;
					string text = default(string);
					_tfPrice.Text = text;
				}
			}
			GameObject gameObject = _mcCurrencyHolder.gameObject;
			bool showCurrency = _showCurrency;
			gameObject.SetActive(showCurrency);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcCurrencyHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x60015DB")]
		[Cpp2IlInjected.Address(RVA = "0x15EA5E0", Offset = "0x15E8FE0", VA = "0x1815EA5E0")]
		public void DisableSelection()
		{
			//Discarded unreachable code: IL_0039
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			FocusNavigationElement component = GetComponent<FocusNavigationElement>();
			int num = 0;
			if (component != (Object)num)
			{
				component.IgnoreThis = true;
			}
			BaseButton component2 = GetComponent<BaseButton>();
			int num2 = 0;
			if (component2 != (Object)num2)
			{
				int num3 = ((component2.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015DC")]
		[Cpp2IlInjected.Address(RVA = "0x15EADE0", Offset = "0x15E97E0", VA = "0x1815EADE0")]
		public ShoppingCartItem()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0019: Expected I4, but got I8

	}
}
