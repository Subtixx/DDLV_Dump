using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000328")]
	public class CollectionTooltipProfessionElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public ProfessionItemData ProfessionItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600142C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CProfessionItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600142D")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CProfessionItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600142E")]
		[Cpp2IlInjected.Address(RVA = "0x114D9E0", Offset = "0x114C3E0", VA = "0x18114D9E0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0016, IL_002a, IL_004d
			if (base.ItemData != null)
			{
				Dictionary<TextType, string> dictionary = base.Texts;
				throw new NullReferenceException();
			}
			view.OnPhaseChanged[1]?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600142F")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipProfessionElementModel()
		{
		}
	}
}
