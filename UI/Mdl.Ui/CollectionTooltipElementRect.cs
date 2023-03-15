using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200032A")]
	public class CollectionTooltipElementRect : CollectionTooltipElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F18")]
		public GameObject BackgroundFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000F19")]
		public GameObject EmptyBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000F1A")]
		public GameObject LockedLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000F1B")]
		public GameObject NameLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000F1C")]
		public GameObject IconObject;

		[Cpp2IlInjected.Token(Token = "0x6001439")]
		[Cpp2IlInjected.Address(RVA = "0x114A520", Offset = "0x1148F20", VA = "0x18114A520")]
		public void SetEmptyMode(bool empty = true)
		{
			//Discarded unreachable code: IL_0055
			BackgroundFull.SetActive(empty);
			IconObject.SetActive(empty);
			LockedLabel.SetActive(empty);
			NameLabel.SetActive(empty);
			EmptyBg.SetActive(empty);
			Image component = EmptyBg.GetComponent<Image>();
			if (empty)
			{
				int num = 0;
			}
			Color white = Color.white;
		}

		[Cpp2IlInjected.Token(Token = "0x600143A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltipElementRect()
		{
		}
	}
}
