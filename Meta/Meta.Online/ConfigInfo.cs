using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F05")]
	public class ConfigInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700157F")]
		public string Checksum
		{
			[Cpp2IlInjected.Token(Token = "0x6007BE1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CChecksum_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007BE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CChecksum_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001580")]
		public BaseConfig ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x6007BE3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CConfigData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007BE4")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CConfigData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007BE5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ConfigInfo()
		{
		}
	}
}
