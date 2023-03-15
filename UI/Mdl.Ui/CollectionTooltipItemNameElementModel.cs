using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200031A")]
	public class CollectionTooltipItemNameElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000370")]
		public CharacterItemData CharacterItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013FA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013FB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCharacterItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013FC")]
		[Cpp2IlInjected.Address(RVA = "0x114C6E0", Offset = "0x114B0E0", VA = "0x18114C6E0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0016
			//IL_0015: Expected O, but got I4
			IItemData itemData = base.ItemData;
			string value = default(string);
			((Dictionary<TKey, TValue>)(object)base.Texts)[(TKey)8] = (TValue)value;
		}

		[Cpp2IlInjected.Token(Token = "0x60013FD")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipItemNameElementModel()
		{
		}
	}
}
