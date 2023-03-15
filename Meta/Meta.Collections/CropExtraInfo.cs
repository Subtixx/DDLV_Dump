using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001106")]
	public class CropExtraInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700184F")]
		public CurrencyCost Price
		{
			[Cpp2IlInjected.Token(Token = "0x6008ACF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AD0")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001850")]
		public Duration Time
		{
			[Cpp2IlInjected.Token(Token = "0x6008AD1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CTime_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AD2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CTime_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AD3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CropExtraInfo()
		{
		}
	}
}
