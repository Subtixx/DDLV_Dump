using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct Time
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int Hour
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
			[CompilerGenerated]
			set
			{
				_003CHour_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4"), Cpp2IlInjected.Token(Token = "0x400015C")]
		public int Minute
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x70CB90", Offset = "0x70B590", VA = "0x18070CB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x6E08C0", Offset = "0x6DF2C0", VA = "0x1806E08C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x14F8120", Offset = "0x14F6B20", VA = "0x1814F8120")]
		public DateTime GetDateTime(int year, int month, int day)
		{
			int num = 0;
			int num2 = Minute;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x14F8040", Offset = "0x14F6A40", VA = "0x1814F8040")]
		public DateTime GetDateTime(DateTime today)
		{
			int num = 0;
			int num2 = Minute;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x14F80D0", Offset = "0x14F6AD0", VA = "0x1814F80D0")]
		public DateTime GetDateTime(Date today)
		{
			int num = 0;
			int num2 = Minute;
			/*Error: Unexpected end of block*/;
		}
	}
}
