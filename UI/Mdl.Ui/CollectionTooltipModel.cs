using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200030A")]
	public abstract class CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateDisplay(CollectionTooltip view);

		[Cpp2IlInjected.Token(Token = "0x60013BF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected CollectionTooltipModel()
		{
		}
	}
}
