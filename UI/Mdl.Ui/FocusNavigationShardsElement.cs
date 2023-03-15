using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000340")]
	public class FocusNavigationShardsElement : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000F40")]
		public MemoryShardsPopUp MemoryShardsPopUp;

		[Cpp2IlInjected.Token(Token = "0x600147B")]
		[Cpp2IlInjected.Address(RVA = "0x1668FB0", Offset = "0x16679B0", VA = "0x181668FB0", Slot = "24")]
		public override void BringItemToFocus()
		{
			//Discarded unreachable code: IL_005a
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			MemoryShardsPopUp memoryShardsPopUp = MemoryShardsPopUp;
			int num = 0;
			if (memoryShardsPopUp == (Object)num)
			{
				MemoryShardsPopUp memoryShardsPopUp2 = (MemoryShardsPopUp = GetComponentInParent<MemoryShardsPopUp>());
			}
			MemoryShardsPopUp memoryShardsPopUp3 = MemoryShardsPopUp;
			int num2 = 0;
			if (memoryShardsPopUp3 != (Object)num2)
			{
				MemoryShardsPopUp memoryShardsPopUp4 = MemoryShardsPopUp;
				int siblingIndex = base.transform.GetSiblingIndex();
				memoryShardsPopUp4.ScrollTo(siblingIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600147C")]
		[Cpp2IlInjected.Address(RVA = "0x16690D0", Offset = "0x1667AD0", VA = "0x1816690D0")]
		public FocusNavigationShardsElement()
		{
		}
	}
}
