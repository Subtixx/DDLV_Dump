using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000972")]
	public class ColorSwatchPicker : ColorPicker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003804")]
		public ColorPalette palette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003805")]
		public RectTransform anchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003806")]
		public ColorSwatch swatchPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003807")]
		private ColorSwatch _currentSwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003808")]
		private Color _fallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003809")]
		private Dictionary<string, ColorSwatch> _colorMap;

		[Cpp2IlInjected.Token(Token = "0x17000813")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003B65")]
			[Cpp2IlInjected.Address(RVA = "0x14A13A0", Offset = "0x149FDA0", VA = "0x1814A13A0", Slot = "4")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
				}
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B66")]
			[Cpp2IlInjected.Address(RVA = "0x14A1450", Offset = "0x149FE50", VA = "0x1814A1450", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_000d, IL_0011, IL_0026, IL_0036, IL_0037, IL_004e
				//IL_0023: Expected O, but got I4
				Dictionary<string, ColorSwatch> colorMap = _colorMap;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B67")]
		[Cpp2IlInjected.Address(RVA = "0x14A1030", Offset = "0x149FA30", VA = "0x1814A1030")]
		private void Start()
		{
			//Discarded unreachable code: IL_0072, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6
			List<Color> colors = palette.colors;
			bool flag = default(bool);
			if (flag)
			{
				ColorSwatch original = swatchPrefab;
				RectTransform parent = anchor;
				ColorSwatch swatch = UnityEngine.Object.Instantiate(original, parent);
				GameObject selected = swatch.selected;
				int active = 0;
				selected.SetActive((byte)active != 0);
				ColorSwatch colorSwatch = swatch;
				Dictionary<string, ColorSwatch> colorMap = _colorMap;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B68")]
		[Cpp2IlInjected.Address(RVA = "0x14A0EF0", Offset = "0x149F8F0", VA = "0x1814A0EF0")]
		private void SelectColor(ColorSwatch swatch)
		{
			//Discarded unreachable code: IL_004f
			//IL_0010: Expected O, but got I4
			ColorSwatch currentSwatch = _currentSwatch;
			int num = 0;
			if (currentSwatch != (UnityEngine.Object)num)
			{
				GameObject selected = _currentSwatch.selected;
				int active = 0;
				selected.SetActive((byte)active != 0);
			}
			ColorSwatch currentSwatch2 = _currentSwatch;
			bool active2 = swatch != currentSwatch2;
			swatch.selected.SetActive(active2);
			_currentSwatch = swatch;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B69")]
		[Cpp2IlInjected.Address(RVA = "0x14A1310", Offset = "0x149FD10", VA = "0x1814A1310")]
		public ColorSwatchPicker()
		{
			Color white = Color.white;
			_colorMap = (Dictionary<string, ColorSwatch>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
		}
	}
}
