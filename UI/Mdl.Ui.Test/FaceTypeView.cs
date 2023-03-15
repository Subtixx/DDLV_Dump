using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000902")]
	internal class FaceTypeView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000903")]
		public delegate void Selected(int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400355D")]
		[SerializeField]
		private Image _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400355E")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.Token(Token = "0x170007E2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003560")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600389F")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038A0")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000069")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600389D")]
			[Cpp2IlInjected.Address(RVA = "0x1525D40", Offset = "0x1524740", VA = "0x181525D40")]
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
			[Cpp2IlInjected.Token(Token = "0x600389E")]
			[Cpp2IlInjected.Address(RVA = "0x1525DE0", Offset = "0x15247E0", VA = "0x181525DE0")]
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

		[Cpp2IlInjected.Token(Token = "0x60038A1")]
		[Cpp2IlInjected.Address(RVA = "0x1525C60", Offset = "0x1524660", VA = "0x181525C60")]
		public void Init(int index, AvatarFaceConfig.FacePartOption data)
		{
			//Discarded unreachable code: IL_003a
			Button button = _button;
			Index = index;
			button.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick = _button.m_OnClick;
			UnityAction call = SelectCurrent;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60038A2")]
		[Cpp2IlInjected.Address(RVA = "0x1525D20", Offset = "0x1524720", VA = "0x181525D20")]
		private void SelectCurrent()
		{
			Selected onSelected = this.OnSelected;
			if (onSelected != null)
			{
				int index = Index;
				onSelected(index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038A3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FaceTypeView()
		{
		}
	}
}
