using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200033B")]
	public class CollectionTooltipRecipe : CollectionTooltip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F39")]
		public RectTransform Elements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F3A")]
		public CollectionTooltipElement Energy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F3B")]
		public CollectionTooltipElement SellPrice;

		[Cpp2IlInjected.Token(Token = "0x600146E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltipRecipe()
		{
		}
	}
}
