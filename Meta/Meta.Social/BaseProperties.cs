using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DC9")]
	public class BaseProperties
	{
		[Cpp2IlInjected.Token(Token = "0x170013C7")]
		public string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x60072D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayfabId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60072D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPlayfabId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60072D3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BaseProperties()
		{
		}
	}
}
