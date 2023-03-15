using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000975")]
	public class ColorFilterItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400380F")]
		public Color SelectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003810")]
		public Color HighlightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003811")]
		private Color _filterColor;

		[Cpp2IlInjected.Token(Token = "0x6003B79")]
		[Cpp2IlInjected.Address(RVA = "0x11507F0", Offset = "0x114F1F0", VA = "0x1811507F0", Slot = "4")]
		public override void Init(Filter filter, bool showText)
		{
			//Discarded unreachable code: IL_001b
			base.Init(filter, showText);
			if ((object)filter == null)
			{
			}
			int num = 0;
			Image image = bg.Image;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B7A")]
		[Cpp2IlInjected.Address(RVA = "0xE26030", Offset = "0xE24A30", VA = "0x180E26030")]
		public ColorFilterItem()
		{
		}
	}
}
