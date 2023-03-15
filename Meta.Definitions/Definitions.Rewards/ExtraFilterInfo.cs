using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000237")]
	public class ExtraFilterInfo
	{
		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		public List<IItemFilter> FilterList
		{
			[Cpp2IlInjected.Token(Token = "0x6001564")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CFilterList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001565")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CFilterList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public List<IItemFilter> FilterOutList
		{
			[Cpp2IlInjected.Token(Token = "0x6001566")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CFilterOutList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001567")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CFilterOutList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001568")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ExtraFilterInfo()
		{
		}
	}
}
