using System;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public class TimedScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private readonly double threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private readonly double warningThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private readonly long start;

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		private static long NowMillis
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0x3549590", Offset = "0x3547F90", VA = "0x183549590")]
			get
			{
				int num = 0;
				DateTime now = DateTime.Now;
				ulong num2 = num2 + num2;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public double Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0x3549560", Offset = "0x3547F60", VA = "0x183549560")]
			get
			{
				int num = 0;
				long nowMillis = NowMillis;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x3549300", Offset = "0x3547D00", VA = "0x183549300")]
		public static TimedScope Create(string name, double threshold = 500.0, double warningThreshold = 5000.0)
		{
			TimedScope timedScope = default(TimedScope);
			timedScope.name = name;
			int num = 0;
			long num2 = (timedScope.start = NowMillis);
			return timedScope;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x3549500", Offset = "0x3547F00", VA = "0x183549500")]
		public TimedScope(string name, double threshold = 500.0, double warningThreshold = 5000.0)
		{
			this.name = name;
			int num = 0;
			long num2 = (start = NowMillis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x3549390", Offset = "0x3547D90", VA = "0x183549390", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0034
			//IL_001b: Expected O, but got I8
			//IL_0031: Expected O, but got I4
			int num = 0;
			long nowMillis = NowMillis;
			string text = name;
			string arg = $"[TS] {text} took {nowMillis}ms";
			int stringLength = text.m_stringLength;
			string text2 = $"[TS] {stringLength} took {arg}ms";
		}
	}
}
