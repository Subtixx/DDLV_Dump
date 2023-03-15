using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000331")]
	public class CollectionTooltipFishing : CollectionTooltip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F22")]
		public RectTransform Elements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F23")]
		public CollectionTooltipElement Energy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F24")]
		public CollectionTooltipElement SellPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000F25")]
		public LocationComponent Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000F26")]
		public GameObject Separator;

		[Cpp2IlInjected.Token(Token = "0x600144A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltipFishing()
		{
		}
	}
}
