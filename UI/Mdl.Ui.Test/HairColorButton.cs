using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000904")]
	public class HairColorButton : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000905")]
		public delegate void HairColorSelected(int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003562")]
		public Image hairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003563")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003564")]
		public int hairColorIndex;

		[Cpp2IlInjected.Token(Token = "0x1400006A")]
		public event HairColorSelected OnHairColorSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60038A8")]
			[Cpp2IlInjected.Address(RVA = "0xAE2C60", Offset = "0xAE1660", VA = "0x180AE2C60")]
			[CompilerGenerated]
			add
			{
				HairColorSelected onHairColorSelected = this.OnHairColorSelected;
				Delegate @delegate = Delegate.Combine(onHairColorSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairColorSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60038A9")]
			[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1700", VA = "0x180AE2D00")]
			[CompilerGenerated]
			remove
			{
				HairColorSelected onHairColorSelected = this.OnHairColorSelected;
				Delegate @delegate = Delegate.Remove(onHairColorSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairColorSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038AA")]
		[Cpp2IlInjected.Address(RVA = "0xAE2BC0", Offset = "0xAE15C0", VA = "0x180AE2BC0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60038AB")]
		[Cpp2IlInjected.Address(RVA = "0xAE2B60", Offset = "0xAE1560", VA = "0x180AE2B60")]
		public void Init(int hairColorIndex, AvatarHairColorConfig.HairColorOption hair)
		{
			//Discarded unreachable code: IL_000f
			this.hairColorIndex = hairColorIndex;
			Image image = hairColor;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AC")]
		[Cpp2IlInjected.Address(RVA = "0xAE2B10", Offset = "0xAE1510", VA = "0x180AE2B10")]
		public void Init(int hairColorIndex, AvatarHairColorConfig.HighlightColorOption hair)
		{
			//Discarded unreachable code: IL_0016
			int displayOrder = hair.displayOrder;
			this.hairColorIndex = hairColorIndex;
			Image image = hairColor;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AD")]
		[Cpp2IlInjected.Address(RVA = "0xAE2BA0", Offset = "0xAE15A0", VA = "0x180AE2BA0")]
		private void OnClick()
		{
			HairColorSelected onHairColorSelected = this.OnHairColorSelected;
			if (onHairColorSelected != null)
			{
				int index = hairColorIndex;
				onHairColorSelected(index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038AE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HairColorButton()
		{
		}
	}
}
