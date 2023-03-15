using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DCA")]
	public class BaseItemsProperties
	{
		[Cpp2IlInjected.Token(Token = "0x170013C8")]
		public string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x60072D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayfabId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60072D5")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPlayfabId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C9")]
		public List<int> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60072D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60072D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60072D8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BaseItemsProperties()
		{
		}
	}
}
