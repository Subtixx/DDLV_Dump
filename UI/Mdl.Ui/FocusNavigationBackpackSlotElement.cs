using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000578")]
	public class FocusNavigationBackpackSlotElement : FocusNavigationGroupedElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001DDA")]
		[SerializeField]
		[NotNull]
		private BackpackSlotInventoryItem _inventoryItem;

		[Cpp2IlInjected.Token(Token = "0x60023C4")]
		[Cpp2IlInjected.Address(RVA = "0x16612F0", Offset = "0x165FCF0", VA = "0x1816612F0", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_001f
			BackpackSlotInventoryItem inventoryItem = _inventoryItem;
			if (!inventoryItem.IsDisabled)
			{
				inventoryItem.OnSelectItem(selected: true);
				base.SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C5")]
		[Cpp2IlInjected.Address(RVA = "0x16612B0", Offset = "0x165FCB0", VA = "0x1816612B0", Slot = "19")]
		public override void RemoveFocus()
		{
			//Discarded unreachable code: IL_0017
			BackpackSlotInventoryItem inventoryItem = _inventoryItem;
			int selected = 0;
			inventoryItem.OnSelectItem((byte)selected != 0);
			base.RemoveFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60023C6")]
		[Cpp2IlInjected.Address(RVA = "0x1661340", Offset = "0x165FD40", VA = "0x181661340")]
		public FocusNavigationBackpackSlotElement()
		{
			GroupLinks = new LayoutGroup[4];
			((FocusNavigationElement)this)._002Ector();
		}
	}
}
