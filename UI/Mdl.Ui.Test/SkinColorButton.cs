using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200090D")]
	public class SkinColorButton : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200090E")]
		public delegate void SkinColorSelected(int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003579")]
		public Image skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400357A")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400357B")]
		public int skinColorIndex;

		[Cpp2IlInjected.Token(Token = "0x1400006E")]
		public event SkinColorSelected OnSkinColorSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60038D8")]
			[Cpp2IlInjected.Address(RVA = "0x15F2CE0", Offset = "0x15F16E0", VA = "0x1815F2CE0")]
			[CompilerGenerated]
			add
			{
				SkinColorSelected onSkinColorSelected = this.OnSkinColorSelected;
				Delegate @delegate = Delegate.Combine(onSkinColorSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSkinColorSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60038D9")]
			[Cpp2IlInjected.Address(RVA = "0x15F2D80", Offset = "0x15F1780", VA = "0x1815F2D80")]
			[CompilerGenerated]
			remove
			{
				SkinColorSelected onSkinColorSelected = this.OnSkinColorSelected;
				Delegate @delegate = Delegate.Remove(onSkinColorSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSkinColorSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038DA")]
		[Cpp2IlInjected.Address(RVA = "0x15F2C40", Offset = "0x15F1640", VA = "0x1815F2C40")]
		private void Start()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60038DB")]
		[Cpp2IlInjected.Address(RVA = "0x15F2C00", Offset = "0x15F1600", VA = "0x1815F2C00")]
		public void Init(int skinColorIndex, AvatarSkinConfig.SkinOption skin)
		{
			//Discarded unreachable code: IL_001d
			this.skinColorIndex = skinColorIndex;
			Image image = skinColor;
			Color color = (image.color = skin.iconColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60038DC")]
		[Cpp2IlInjected.Address(RVA = "0xAE2BA0", Offset = "0xAE15A0", VA = "0x180AE2BA0")]
		private void OnClick()
		{
			SkinColorSelected onSkinColorSelected = this.OnSkinColorSelected;
			if (onSkinColorSelected != null)
			{
				int index = skinColorIndex;
				onSkinColorSelected(index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038DD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SkinColorButton()
		{
		}
	}
}
