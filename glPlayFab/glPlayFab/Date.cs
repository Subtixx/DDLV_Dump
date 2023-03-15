using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct Date
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int Year
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
			[CompilerGenerated]
			set
			{
				_003CYear_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4"), Cpp2IlInjected.Token(Token = "0x4000157")]
		public int Month
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x70CB90", Offset = "0x70B590", VA = "0x18070CB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x6E08C0", Offset = "0x6DF2C0", VA = "0x1806E08C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x8"), Cpp2IlInjected.Token(Token = "0x4000158")]
		public int Day
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x6E07B0", Offset = "0x6DF1B0", VA = "0x1806E07B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x6E07C0", Offset = "0x6DF1C0", VA = "0x1806E07C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[JsonIgnore]
		public DateTime DateTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x102C200", Offset = "0x102AC00", VA = "0x18102C200")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[JsonIgnore]
		public DateTime EndOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x102C250", Offset = "0x102AC50", VA = "0x18102C250")]
			get
			{
				int num = 0;
				DateTime result = default(DateTime);
				return result;
			}
		}
	}
}
