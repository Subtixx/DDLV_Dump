using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	public class KnownConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000683")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CLanguage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CLanguage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		[JsonConverter(typeof(NetworkSafeDateTimeConverter))]
		public DateTime? LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xC4B5B0", Offset = "0xC49FB0", VA = "0x180C4B5B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x11510D0", Offset = "0x114FAD0", VA = "0x1811510D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public KnownConfig()
		{
		}
	}
}
