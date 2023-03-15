using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000366")]
	[RequiredAllNotNull]
	internal class SelectableBackpackItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000367")]
		public delegate void OnDeselectDelegate(int index);

		[Cpp2IlInjected.Token(Token = "0x2000368")]
		public delegate void OnAmountChangedDelegate(int index, int amount);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400106F")]
		public OnDeselectDelegate OnDeselect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001070")]
		public OnAmountChangedDelegate OnAmountChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001071")]
		[SerializeField]
		private AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001072")]
		[SerializeField]
		private TextBase tf_itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001073")]
		[SerializeField]
		private TextBase tf_inventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001074")]
		[SerializeField]
		private RectTransform _mcInventoryCounterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001075")]
		[SerializeField]
		private TextBase tf_selectedAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001077")]
		[SerializeField]
		private Button _btnDeselect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001078")]
		[SerializeField]
		private Button _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001079")]
		[SerializeField]
		private Button _btnSubtract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400107F")]
		[SerializeField]
		private GameObject _mcSelected;

		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4001076")]
		public int SelectedAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60015AC")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015AD")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60015AE")]
			[Cpp2IlInjected.Address(RVA = "0x125C0D0", Offset = "0x125AAD0", VA = "0x18125C0D0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _mcSelected.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x60015AF")]
			[Cpp2IlInjected.Address(RVA = "0x125C100", Offset = "0x125AB00", VA = "0x18125C100")]
			set
			{
				//Discarded unreachable code: IL_0078
				_mcSelected.SetActive(value);
				int num = Math.Max(SelectedAmount, 1);
				Button btnAdd = _btnAdd;
				SelectedAmount = num;
				bool flag2 = (btnAdd.interactable = InventoryCount != num);
				int num2 = SelectedAmount;
				string text = default(string);
				tf_selectedAmount.Text = text;
				OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
				if (onAmountChanged != null)
				{
					int amount = SelectedAmount;
					int index = ItemIndex;
					onAmountChanged(index, amount);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		internal string IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60015B0")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CIconTexture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B1")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CIconTexture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		internal AsyncAtlassedIcon IconAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60015B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return mc_icon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x400107B")]
		internal int InventoryCount
		{
			[Cpp2IlInjected.Token(Token = "0x60015B3")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015B4")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		internal string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60015B5")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CItemName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60015B6")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x88"), Cpp2IlInjected.Token(Token = "0x400107D")]
		internal int ItemIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60015B7")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015B8")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x8C"), Cpp2IlInjected.Token(Token = "0x400107E")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60015B9")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015BA")]
			[Cpp2IlInjected.Address(RVA = "0x125C200", Offset = "0x125AC00", VA = "0x18125C200")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x60015BB")]
		[Cpp2IlInjected.Address(RVA = "0x125BE40", Offset = "0x125A840", VA = "0x18125BE40")]
		internal void Refresh()
		{
			//Discarded unreachable code: IL_00df
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			int num = 0;
			RawImage rawImage = asyncAtlassedIcon.RawImage;
			int num2 = 0;
			rawImage.texture = (Texture)num2;
			TextBase textBase = tf_itemName;
			int num3 = 0;
			if (textBase != (UnityEngine.Object)num3)
			{
				TextBase textBase2 = tf_itemName;
				string text2 = (textBase2.StringID = ItemName);
			}
			TextBase textBase3 = tf_inventoryCount;
			int num4 = 0;
			if (textBase3 != (UnityEngine.Object)num4)
			{
				int num5 = InventoryCount;
				string text3 = default(string);
				tf_inventoryCount.Text = text3;
				if ((object)tf_inventoryCount.transform != null)
				{
				}
				TextBase textBase4 = tf_inventoryCount;
				RectTransform mcInventoryCounterContent = _mcInventoryCounterContent;
				Transform transform = textBase4.transform;
				int num6 = (SelectedAmount = InventoryCount);
			}
			AsyncAtlassedIcon asyncAtlassedIcon2 = mc_icon;
			int num7 = 0;
			if (asyncAtlassedIcon2 != (UnityEngine.Object)num7)
			{
				AsyncAtlassedIcon asyncAtlassedIcon3 = mc_icon;
				string icon = IconTexture;
				bool flag = asyncAtlassedIcon3.SetIcon(icon);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015BC")]
		[Cpp2IlInjected.Address(RVA = "0x125BA60", Offset = "0x125A460", VA = "0x18125BA60")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0065
			Button.ButtonClickedEvent onClick = _btnDeselect.m_OnClick;
			UnityAction call = OnDeselectHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnAdd.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSubtract.m_OnClick;
			UnityAction call3 = OnSubtractHandler;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60015BD")]
		[Cpp2IlInjected.Address(RVA = "0x125BC10", Offset = "0x125A610", VA = "0x18125BC10")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			Button.ButtonClickedEvent onClick = _btnDeselect.m_OnClick;
			UnityAction call = OnDeselectHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnAdd.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSubtract.m_OnClick;
			UnityAction call3 = OnSubtractHandler;
			onClick3.RemoveListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60015BE")]
		[Cpp2IlInjected.Address(RVA = "0x125BD60", Offset = "0x125A760", VA = "0x18125BD60")]
		private void OnSubtractHandler()
		{
			//Discarded unreachable code: IL_0028, IL_0033, IL_0044
			OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
			if (onAmountChanged != null)
			{
				int amount = SelectedAmount;
				int index = ItemIndex;
				onAmountChanged(index, amount);
			}
			RefreshSelectedAmount();
		}

		[Cpp2IlInjected.Token(Token = "0x60015BF")]
		[Cpp2IlInjected.Address(RVA = "0x125BBB0", Offset = "0x125A5B0", VA = "0x18125BBB0")]
		private void OnAddClickHandler()
		{
			int num = SelectedAmount;
			num = (SelectedAmount = num + 1);
			OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
			if (onAmountChanged != null)
			{
				int index = ItemIndex;
				onAmountChanged(index, num);
			}
			RefreshSelectedAmount();
		}

		[Cpp2IlInjected.Token(Token = "0x60015C0")]
		[Cpp2IlInjected.Address(RVA = "0x125BBF0", Offset = "0x125A5F0", VA = "0x18125BBF0")]
		private void OnDeselectHandler()
		{
			OnDeselectDelegate onDeselect = OnDeselect;
			if (onDeselect != null)
			{
				int index = ItemIndex;
				onDeselect(index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015C1")]
		[Cpp2IlInjected.Address(RVA = "0x125BDC0", Offset = "0x125A7C0", VA = "0x18125BDC0")]
		private void RefreshSelectedAmount()
		{
			//Discarded unreachable code: IL_005f
			Button btnAdd = _btnAdd;
			int num = SelectedAmount;
			bool flag2 = (btnAdd.interactable = InventoryCount != num);
			int num2 = SelectedAmount;
			string text = default(string);
			tf_selectedAmount.Text = text;
			OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
			if (onAmountChanged != null)
			{
				int amount = SelectedAmount;
				int index = ItemIndex;
				onAmountChanged(index, amount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015C2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelectableBackpackItem()
		{
		}
	}
}
