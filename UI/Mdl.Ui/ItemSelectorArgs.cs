using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B8")]
	public struct ItemSelectorArgs : IInfoGizmoArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002D48")]
		public IItemSelectorItem[] Items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4002D49")]
		public int InitialSelectionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D4A")]
		public Action<int> OnItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D4B")]
		public Dictionary<int, Sprite> Icons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D4C")]
		public InteractPreviewData InteractPreviewData;
	}
}
