using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	public class CheatSlider : CheatVisualComponent
	{
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		public delegate void ValueChanged(float value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		[SerializeField]
		private Slider _slider;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ValueChanged OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0x1000AB0", Offset = "0xFFF4B0", VA = "0x181000AB0")]
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
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0x1000B50", Offset = "0xFFF550", VA = "0x181000B50")]
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

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x1000900", Offset = "0xFFF300", VA = "0x181000900")]
		public void Init(string name, float value, float minValue, float maxValue, bool wholeNumbers)
		{
			//Discarded unreachable code: IL_0066
			base.gameObject.name = name;
			Name = name;
			_name.text = name;
			_slider.minValue = minValue;
			Slider slider = _slider;
			Slider slider2 = _slider;
			_slider.value = value;
			Slider.SliderEvent onValueChanged = _slider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)(UnityAction<T0>)delegate(float val)
			{
				//Discarded unreachable code: IL_000d
				this.OnValueChanged(val);
			};
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CheatSlider()
		{
		}
	}
}
