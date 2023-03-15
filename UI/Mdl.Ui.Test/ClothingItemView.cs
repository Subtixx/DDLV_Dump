using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008FA")]
	internal class ClothingItemView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008FB")]
		public delegate void Selected(ClothingItemData data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003549")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400354A")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400354B")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400354C")]
		[SerializeField]
		private GameObject _owned;

		[Cpp2IlInjected.Token(Token = "0x170007E1")]
		public ClothingItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6003870")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003871")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000065")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003872")]
			[Cpp2IlInjected.Address(RVA = "0x1002070", Offset = "0x1000A70", VA = "0x181002070")]
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
			[Cpp2IlInjected.Token(Token = "0x6003873")]
			[Cpp2IlInjected.Address(RVA = "0x1002110", Offset = "0x1000B10", VA = "0x181002110")]
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

		[Cpp2IlInjected.Token(Token = "0x6003874")]
		[Cpp2IlInjected.Address(RVA = "0x1001EB0", Offset = "0x10008B0", VA = "0x181001EB0")]
		public void Init(ClothingItemData data, bool isOwned, bool isMale)
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
				if (string.IsNullOrEmpty(data.iconAddress_))
				{
					return;
				}
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

		[Cpp2IlInjected.Token(Token = "0x6003875")]
		[Cpp2IlInjected.Address(RVA = "0xFA9360", Offset = "0xFA7D60", VA = "0x180FA9360")]
		public void ReleaseIcon()
		{
			_icon?.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6003876")]
		[Cpp2IlInjected.Address(RVA = "0xFA9380", Offset = "0xFA7D80", VA = "0x180FA9380")]
		private void SelectCurrent()
		{
			Selected onSelected = this.OnSelected;
			if (onSelected != null)
			{
				ClothingItemData data = Data;
				onSelected(data);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003877")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ClothingItemView()
		{
		}
	}
}
