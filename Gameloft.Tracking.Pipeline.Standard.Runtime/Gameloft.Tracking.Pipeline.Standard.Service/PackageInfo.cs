using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct PackageInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public uint GGID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
			[CompilerGenerated]
			set
			{
				_003CGGID_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4"), Cpp2IlInjected.Token(Token = "0x4000071")]
		public PlatformID Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x70CB90", Offset = "0x70B590", VA = "0x18070CB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6E08C0", Offset = "0x6DF2C0", VA = "0x1806E08C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCD0", Offset = "0x6DC6D0", VA = "0x1806DDCD0")]
			[CompilerGenerated]
			set
			{
				_003CVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string SHA1
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CSHA1_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CSHA1_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string UserAgent
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CUserAgent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CUserAgent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string Host
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CHost_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CHost_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000076")]
		public uint GLOTv3Revision
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set;
		}
	}
}
