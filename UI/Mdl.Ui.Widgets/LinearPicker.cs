using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009BC")]
	public class LinearPicker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20009BD")]
		public delegate void ValueChangedDelegate(float value, bool onRelease);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003955")]
		[SerializeField]
		private Slider _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003956")]
		private float _lastValue;

		[Cpp2IlInjected.Token(Token = "0x1700085D")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6003CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA63A20", Offset = "0xA62420", VA = "0x180A63A20")]
			get
			{
				string contentType = ((IOpenIdAPI)_slider).ContentType;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003CED")]
			[Cpp2IlInjected.Address(RVA = "0x132C990", Offset = "0x132B390", VA = "0x18132C990")]
			set
			{
				//Discarded unreachable code: IL_0022
				_slider.value = value;
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
				if (onValueChanged != null)
				{
					int onRelease = 0;
					onValueChanged(value, (byte)onRelease != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000082")]
		public event ValueChangedDelegate OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003CEE")]
			[Cpp2IlInjected.Address(RVA = "0x132C850", Offset = "0x132B250", VA = "0x18132C850")]
			[CompilerGenerated]
			add
			{
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
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
			[Cpp2IlInjected.Token(Token = "0x6003CEF")]
			[Cpp2IlInjected.Address(RVA = "0x132C8F0", Offset = "0x132B2F0", VA = "0x18132C8F0")]
			[CompilerGenerated]
			remove
			{
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
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

		[Cpp2IlInjected.Token(Token = "0x6003CF0")]
		[Cpp2IlInjected.Address(RVA = "0x132C640", Offset = "0x132B040", VA = "0x18132C640")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			Slider.SliderEvent onValueChanged = _slider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(RaiseValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF1")]
		[Cpp2IlInjected.Address(RVA = "0x132C720", Offset = "0x132B120", VA = "0x18132C720")]
		private void Update()
		{
			//Discarded unreachable code: IL_005a
			if (!Input.GetMouseButtonDown(0))
			{
				if (!Input.GetMouseButtonUp(0))
				{
					return;
				}
				Slider slider = _slider;
				float value = slider.value;
				if ((object)slider != null)
				{
					ValueChangedDelegate onValueChanged = this.OnValueChanged;
					if (onValueChanged != null)
					{
						float value2 = _slider.value;
						onValueChanged(value2, onRelease: true);
					}
				}
			}
			else
			{
				float num = (_lastValue = _slider.value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF2")]
		[Cpp2IlInjected.Address(RVA = "0x132C700", Offset = "0x132B100", VA = "0x18132C700")]
		private void RaiseValueChanged(float value)
		{
			ValueChangedDelegate onValueChanged = this.OnValueChanged;
			if (onValueChanged != null)
			{
				int onRelease = 0;
				onValueChanged(value, (byte)onRelease != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LinearPicker()
		{
		}
	}
}
