using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	public class CheatButton : CheatVisualComponent
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		public delegate void ButtonClicked();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ButtonClicked OnButtonClicked
		{
			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xFFF6E0", Offset = "0xFFE0E0", VA = "0x180FFF6E0")]
			[CompilerGenerated]
			add
			{
				ButtonClicked onButtonClicked = this.OnButtonClicked;
				Delegate @delegate = Delegate.Combine(onButtonClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onButtonClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0xFFF780", Offset = "0xFFE180", VA = "0x180FFF780")]
			[CompilerGenerated]
			remove
			{
				ButtonClicked onButtonClicked = this.OnButtonClicked;
				Delegate @delegate = Delegate.Remove(onButtonClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onButtonClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xFFF5F0", Offset = "0xFFDFF0", VA = "0x180FFF5F0")]
		public void Init(string name)
		{
			//Discarded unreachable code: IL_0040
			base.gameObject.name = name;
			Name = name;
			_name.text = name;
			Button.ButtonClickedEvent onClick = _button.m_OnClick;
			UnityAction call = delegate
			{
				//Discarded unreachable code: IL_000c
				this.OnButtonClicked();
			};
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CheatButton()
		{
		}
	}
}
