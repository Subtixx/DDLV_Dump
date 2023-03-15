using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000974")]
	public class HSLCircularPicker : ColorPicker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400380C")]
		[SerializeField]
		private CircularPicker _hueSaturationPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400380D")]
		[SerializeField]
		private LinearPicker _lightnessPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400380E")]
		[SerializeField]
		private Image _colorPreview;

		[Cpp2IlInjected.Token(Token = "0x17000814")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003B6C")]
			[Cpp2IlInjected.Address(RVA = "0xAE20D0", Offset = "0xAE0AD0", VA = "0x180AE20D0", Slot = "4")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B6D")]
			[Cpp2IlInjected.Address(RVA = "0xAE2220", Offset = "0xAE0C20", VA = "0x180AE2220", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_003e
				//IL_0015: Expected F4, but got I4
				//IL_0025: Expected F4, but got I4
				//IL_003d: Expected F4, but got I4
				int num = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				_hueSaturationPicker.Angle = num;
				int num2 = 0;
				_hueSaturationPicker.Distance = num2;
				int num3 = 0;
				int num4 = Mathf.RoundToInt(z);
				_lightnessPicker.Value = num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000815")]
		public int Hue
		{
			[Cpp2IlInjected.Token(Token = "0x6003B6E")]
			[Cpp2IlInjected.Address(RVA = "0xAE2190", Offset = "0xAE0B90", VA = "0x180AE2190")]
			get
			{
				//Discarded unreachable code: IL_0011
				return Mathf.RoundToInt(_hueSaturationPicker._angle);
			}
			[Cpp2IlInjected.Token(Token = "0x6003B6F")]
			[Cpp2IlInjected.Address(RVA = "0xAE22E0", Offset = "0xAE0CE0", VA = "0x180AE22E0")]
			set
			{
				//Discarded unreachable code: IL_000d
				//IL_000c: Expected F4, but got I4
				_hueSaturationPicker.Angle = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000816")]
		public int Saturation
		{
			[Cpp2IlInjected.Token(Token = "0x6003B70")]
			[Cpp2IlInjected.Address(RVA = "0xAE21F0", Offset = "0xAE0BF0", VA = "0x180AE21F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return Mathf.RoundToInt(_hueSaturationPicker._distance);
			}
			[Cpp2IlInjected.Token(Token = "0x6003B71")]
			[Cpp2IlInjected.Address(RVA = "0xAE2340", Offset = "0xAE0D40", VA = "0x180AE2340")]
			set
			{
				//Discarded unreachable code: IL_000d
				//IL_000c: Expected F4, but got I4
				_hueSaturationPicker.Distance = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000817")]
		public int Lightness
		{
			[Cpp2IlInjected.Token(Token = "0x6003B72")]
			[Cpp2IlInjected.Address(RVA = "0xAE21C0", Offset = "0xAE0BC0", VA = "0x180AE21C0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return Mathf.RoundToInt(_lightnessPicker.Value);
			}
			[Cpp2IlInjected.Token(Token = "0x6003B73")]
			[Cpp2IlInjected.Address(RVA = "0xAE2310", Offset = "0xAE0D10", VA = "0x180AE2310")]
			set
			{
				//Discarded unreachable code: IL_000d
				//IL_000c: Expected F4, but got I4
				_lightnessPicker.Value = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B74")]
		[Cpp2IlInjected.Address(RVA = "0xAE1E80", Offset = "0xAE0880", VA = "0x180AE1E80")]
		private void Start()
		{
			//Discarded unreachable code: IL_003d
			CircularPicker hueSaturationPicker = _hueSaturationPicker;
			CircularPicker.ValueChangedDelegate value = UpdateHueSaturation;
			hueSaturationPicker.OnValueChanged += value;
			LinearPicker lightnessPicker = _lightnessPicker;
			LinearPicker.ValueChangedDelegate value2 = UpdateLightness;
			lightnessPicker.OnValueChanged += value2;
			UpdatePreview();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B75")]
		[Cpp2IlInjected.Address(RVA = "0xAE1F70", Offset = "0xAE0970", VA = "0x180AE1F70")]
		private void UpdateHueSaturation(float angle, float distance, bool onRelease)
		{
			if (onRelease)
			{
			}
			UpdatePreview();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B76")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FC0", Offset = "0xAE09C0", VA = "0x180AE1FC0")]
		private void UpdateLightness(float value, bool onRelease)
		{
			if (onRelease)
			{
			}
			UpdatePreview();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B77")]
		[Cpp2IlInjected.Address(RVA = "0xAE2010", Offset = "0xAE0A10", VA = "0x180AE2010")]
		private void UpdatePreview()
		{
			//Discarded unreachable code: IL_001b
			//IL_0010: Expected O, but got I4
			Image colorPreview = _colorPreview;
			int num = 0;
			if (colorPreview != (UnityEngine.Object)num)
			{
				Image colorPreview2 = _colorPreview;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B78")]
		[Cpp2IlInjected.Address(RVA = "0xAE20C0", Offset = "0xAE0AC0", VA = "0x180AE20C0")]
		public HSLCircularPicker()
		{
		}
	}
}
