using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200092A")]
	internal class FurnitureItemView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200092B")]
		public delegate void Selected(FurnitureItemData data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003618")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003619")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400361A")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400361B")]
		[SerializeField]
		private GameObject _owned;

		[Cpp2IlInjected.Token(Token = "0x170007F4")]
		public FurnitureItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60039BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60039BC")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000076")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60039BD")]
			[Cpp2IlInjected.Address(RVA = "0x16709B0", Offset = "0x166F3B0", VA = "0x1816709B0")]
			[CompilerGenerated]
			add
			{
				Selected onSelected = this.OnSelected;
				Delegate @delegate = Delegate.Combine(onSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039BE")]
			[Cpp2IlInjected.Address(RVA = "0x1670A50", Offset = "0x166F450", VA = "0x181670A50")]
			[CompilerGenerated]
			remove
			{
				Selected onSelected = this.OnSelected;
				Delegate @delegate = Delegate.Remove(onSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039BF")]
		[Cpp2IlInjected.Address(RVA = "0x1670820", Offset = "0x166F220", VA = "0x181670820")]
		public void Init(FurnitureItemData data, bool isOwned)
		{
			Data = data;
			_button.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick = _button.m_OnClick;
			UnityAction call = SelectCurrent;
			onClick.AddListener(call);
			_icon?.Release();
			_owned.SetActive(isOwned);
			Text text = _name;
			if (data != null)
			{
				string text2 = (text.text = data.name_);
				if (!string.IsNullOrEmpty(data.iconAddress_))
				{
					AsyncAtlassedIcon icon = _icon;
					if ((object)icon != null)
					{
						string iconAddress_ = data.iconAddress_;
						bool flag = icon.SetIcon(iconAddress_);
					}
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039C0")]
		[Cpp2IlInjected.Address(RVA = "0xFA9360", Offset = "0xFA7D60", VA = "0x180FA9360")]
		public void ReleaseIcon()
		{
			_icon?.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x60039C1")]
		[Cpp2IlInjected.Address(RVA = "0xFA9380", Offset = "0xFA7D80", VA = "0x180FA9380")]
		private void SelectCurrent()
		{
			Selected onSelected = this.OnSelected;
			if (onSelected != null)
			{
				FurnitureItemData data = Data;
				onSelected(data);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039C2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FurnitureItemView()
		{
		}
	}
}
