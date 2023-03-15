using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000906")]
	internal class MakeupItemView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000907")]
		public delegate void Selected(MakeupItemData data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003565")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003566")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003567")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003568")]
		[SerializeField]
		private GameObject _owned;

		[Cpp2IlInjected.Token(Token = "0x170007E3")]
		public MakeupItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60038B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60038B4")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006B")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60038B5")]
			[Cpp2IlInjected.Address(RVA = "0xFA93A0", Offset = "0xFA7DA0", VA = "0x180FA93A0")]
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
			[Cpp2IlInjected.Token(Token = "0x60038B6")]
			[Cpp2IlInjected.Address(RVA = "0xFA9440", Offset = "0xFA7E40", VA = "0x180FA9440")]
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

		[Cpp2IlInjected.Token(Token = "0x60038B7")]
		[Cpp2IlInjected.Address(RVA = "0xFA91B0", Offset = "0xFA7BB0", VA = "0x180FA91B0")]
		public void Init(MakeupItemData data, bool isOwned, bool isMale)
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
				AsyncAtlassedIcon icon = default(AsyncAtlassedIcon);
				if (isMale && !string.IsNullOrEmpty(data.maleIconAddress_))
				{
					icon = _icon;
					if ((object)icon != null)
					{
						string maleIconAddress_ = data.maleIconAddress_;
						bool flag = icon.SetIcon(maleIconAddress_);
					}
					return;
				}
				while ((object)icon == null)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038B8")]
		[Cpp2IlInjected.Address(RVA = "0xFA9360", Offset = "0xFA7D60", VA = "0x180FA9360")]
		public void ReleaseIcon()
		{
			_icon?.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x60038B9")]
		[Cpp2IlInjected.Address(RVA = "0xFA9380", Offset = "0xFA7D80", VA = "0x180FA9380")]
		private void SelectCurrent()
		{
			Selected onSelected = this.OnSelected;
			if (onSelected != null)
			{
				MakeupItemData data = Data;
				onSelected(data);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038BA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MakeupItemView()
		{
		}
	}
}
