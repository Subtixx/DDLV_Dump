using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class TableOptions
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string RefPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CRefPrefix_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CRefPrefix_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool BypassTimestampCheck
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool IgnoreEmptyRev
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4090D60", Offset = "0x408F760", VA = "0x184090D60")]
		public TableOptions(string refPrefix = "", bool bypassTimestampCheck = false, bool ignoreEmptyRev = false)
		{
			RefPrefix = refPrefix;
			BypassTimestampCheck = bypassTimestampCheck;
			IgnoreEmptyRev = ignoreEmptyRev;
		}
	}
}
