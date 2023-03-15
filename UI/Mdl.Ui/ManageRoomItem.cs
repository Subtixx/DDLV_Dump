using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000544")]
	[RequiredAllNotNull]
	public class ManageRoomItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C6C")]
		[SerializeField]
		private GameObject _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C6D")]
		[SerializeField]
		private GameObject _mcSelectedBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C6E")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C6F")]
		[SerializeField]
		private AnimatedButton _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C70")]
		[SerializeField]
		private RefreshBuyButton _refreshBuyButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001C71")]
		[SerializeField]
		private CurrencyItemView _mcCurrencyView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001C72")]
		public HouseExpansion.Types.InteriorExpansion.Types.ExpansionData RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001C73")]
		public bool IsBought;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4001C74")]
		private bool _isSelected;

		[Cpp2IlInjected.Token(Token = "0x17000549")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600222D")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x600222E")]
			[Cpp2IlInjected.Address(RVA = "0xFAD860", Offset = "0xFAC260", VA = "0x180FAD860")]
			set
			{
				//Discarded unreachable code: IL_002c
				_isSelected = value;
				_mcSelectedBackground.SetActive(value);
				GameObject mcBackground = _mcBackground;
				bool active = !_isSelected;
				mcBackground.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600222F")]
		[Cpp2IlInjected.Address(RVA = "0xFAD800", Offset = "0xFAC200", VA = "0x180FAD800")]
		private void RefreshSelected()
		{
			//Discarded unreachable code: IL_002e
			GameObject mcSelectedBackground = _mcSelectedBackground;
			bool isSelected = _isSelected;
			mcSelectedBackground.SetActive(isSelected);
			GameObject mcBackground = _mcBackground;
			bool active = !_isSelected;
			mcBackground.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002230")]
		[Cpp2IlInjected.Address(RVA = "0xFAD6C0", Offset = "0xFAC0C0", VA = "0x180FAD6C0")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00a0
			HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData = RoomData;
			TextBase tfLabel = _tfLabel;
			string text = (tfLabel.StringID = roomData.name_);
			GameObject gameObject = _mcCurrencyView.gameObject;
			bool active = !IsBought;
			gameObject.SetActive(active);
			if (!IsBought)
			{
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData2 = RoomData;
				CurrencyItemView mcCurrencyView = _mcCurrencyView;
				RepeatedField<CurrencyCost> price_ = roomData2.price_;
				int index = 0;
				Item item = ((CurrencyCost)((RepeatedField<T>)(object)price_)[index]).Item;
				RepeatedField<CurrencyCost> price_2 = RoomData.price_;
				int index2 = 0;
				CurrencyCost currencyCost = (CurrencyCost)((RepeatedField<T>)(object)price_2)[index2];
			}
			_refreshBuyButton?.RefreshBuy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002231")]
		[Cpp2IlInjected.Address(RVA = "0xFAD6A0", Offset = "0xFAC0A0", VA = "0x180FAD6A0")]
		public void OnRoomSelected()
		{
			_button?.PostWwiseEvent();
		}

		[Cpp2IlInjected.Token(Token = "0x6002232")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ManageRoomItem()
		{
		}
	}
}
