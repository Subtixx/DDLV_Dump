using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	public class CheatToggle : CheatVisualComponent
	{
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		public delegate void ValueChanged(bool isOn);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[SerializeField]
		private Toggle _toggle;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ValueChanged OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x1000DD0", Offset = "0xFFF7D0", VA = "0x181000DD0")]
			[CompilerGenerated]
			add
			{
				ValueChanged onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Combine(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x1000E70", Offset = "0xFFF870", VA = "0x181000E70")]
			[CompilerGenerated]
			remove
			{
				ValueChanged onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Remove(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x1000C80", Offset = "0xFFF680", VA = "0x181000C80")]
		public void Init(string name, bool value)
		{
			//Discarded unreachable code: IL_004c
			base.gameObject.name = name;
			Name = name;
			_name.text = name;
			_toggle.isOn = value;
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)(UnityAction<T0>)delegate(bool isOn)
			{
				//Discarded unreachable code: IL_000d
				this.OnValueChanged(isOn);
			};
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CheatToggle()
		{
		}
	}
}
