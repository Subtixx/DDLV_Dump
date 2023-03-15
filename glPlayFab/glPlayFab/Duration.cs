using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct Duration
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int Days
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
			[CompilerGenerated]
			set
			{
				_003CDays_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4"), Cpp2IlInjected.Token(Token = "0x400015E")]
		public int Hours
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x70CB90", Offset = "0x70B590", VA = "0x18070CB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x6E08C0", Offset = "0x6DF2C0", VA = "0x1806E08C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x8"), Cpp2IlInjected.Token(Token = "0x400015F")]
		public int Minutes
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6E07B0", Offset = "0x6DF1B0", VA = "0x1806E07B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6E07C0", Offset = "0x6DF1C0", VA = "0x1806E07C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[JsonIgnore]
		public TimeSpan TimeSpan
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x102E110", Offset = "0x102CB10", VA = "0x18102E110")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x102E0D0", Offset = "0x102CAD0", VA = "0x18102E0D0")]
		public Duration(TimeSpan ts)
		{
			int num = default(int);
			Days = num;
			int num2 = default(int);
			Hours = num2;
			int num3 = default(int);
			Minutes = num3;
		}
	}
}
