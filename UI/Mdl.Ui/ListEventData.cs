using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	public class ListEventData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public readonly GameObject DisplayObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public readonly int ItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public readonly ListEventReason Reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public readonly int NextItemIndex;

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x132E2E0", Offset = "0x132CCE0", VA = "0x18132E2E0")]
		public ListEventData(GameObject displayItem, int index, ListEventReason reason = ListEventReason.Usual, int nextIndex = -1)
		{
			DisplayObject = displayItem;
			Reason = reason;
			NextItemIndex = 0;
			ItemIndex = index;
		}
	}
}
