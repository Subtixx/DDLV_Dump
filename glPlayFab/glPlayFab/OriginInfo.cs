using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class OriginInfo
	{
		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public DateTime? Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9969C0", VA = "0x180997FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public OriginInfo()
		{
		}
	}
}
