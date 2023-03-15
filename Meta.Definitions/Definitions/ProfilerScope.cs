using System;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public struct ProfilerScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private readonly long start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly double threshold;

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		private static long NowMillis
		{
			[Cpp2IlInjected.Token(Token = "0x6000C81")]
			[Cpp2IlInjected.Address(RVA = "0x2889AE0", Offset = "0x28884E0", VA = "0x182889AE0")]
			get
			{
				int num = 0;
				DateTime now = DateTime.Now;
				ulong num2 = num2 + num2;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x28897D0", Offset = "0x28881D0", VA = "0x1828897D0")]
		public static ProfilerScope Create(string name, double thresholdDuration = 500.0)
		{
			int num = 0;
			int num2 = (name.m_stringLength = 0);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x28899E0", Offset = "0x28883E0", VA = "0x1828899E0")]
		public ProfilerScope(string name, double thresholdDuration)
		{
			//Discarded unreachable code: IL_0017
			this.name = name;
			int num = 0;
			long num2 = (start = NowMillis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x2889800", Offset = "0x2888200", VA = "0x182889800", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0009
			int num = 0;
			long nowMillis = NowMillis;
		}
	}
}
