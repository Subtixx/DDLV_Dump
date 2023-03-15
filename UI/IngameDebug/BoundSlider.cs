using System;
using Cpp2IlInjected;
using glPlayFab;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class BoundSlider : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public delegate void OnValueChangedDelegate(BoundSlider source, float value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		[SerializeField]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		[SerializeField]
		private Image sliderBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		[SerializeField]
		private Image thumb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private bool sliderFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public OnValueChangedDelegate OnValueChanged;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public Slider BackingField
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slider;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool IsFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return sliderFocused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xA63A20", Offset = "0xA62420", VA = "0x180A63A20")]
			get
			{
				string contentType = ((IOpenIdAPI)slider).ContentType;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xA63B70", Offset = "0xA62570", VA = "0x180A63B70")]
			set
			{
				//Discarded unreachable code: IL_000d
				string contentType = ((IOpenIdAPI)slider).ContentType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA63A50", Offset = "0xA62450", VA = "0x180A63A50")]
			set
			{
				//Discarded unreachable code: IL_007a
				if (!(m_skin != value))
				{
					int version = m_skin.m_version;
					if (m_skinVersion == version)
					{
						return;
					}
				}
				m_skin = value;
				UISkin skin = m_skin;
				Image image = sliderBackground;
				int num = (m_skinVersion = skin.m_version);
				Color color = (image.color = skin.m_sliderBackgroundColor);
				UISkin skin2 = m_skin;
				Image image2 = thumb;
				Color color2 = (image2.color = skin2.m_sliderThumbColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA637E0", Offset = "0xA621E0", VA = "0x180A637E0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_005c
			PointerEventListener pointerEventListener = slider.gameObject.AddComponent<PointerEventListener>();
			PointerEventListener.PointerEvent value = delegate
			{
				sliderFocused = true;
			};
			pointerEventListener.PointerDown += value;
			PointerEventListener.PointerEvent value2 = delegate
			{
				sliderFocused = false;
			};
			pointerEventListener.PointerDown -= value2;
			Slider.SliderEvent onValueChanged = slider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(SliderValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA63970", Offset = "0xA62370", VA = "0x180A63970")]
		public void SetRange(float min, float max)
		{
			//Discarded unreachable code: IL_001d
			if (!(min <= max))
			{
			}
			slider.minValue = min;
			slider.maxValue = min;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA639D0", Offset = "0xA623D0", VA = "0x180A639D0")]
		private void SliderValueChanged(float value)
		{
			if (sliderFocused)
			{
				OnValueChanged?.Invoke(this, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BoundSlider()
		{
		}
	}
}
