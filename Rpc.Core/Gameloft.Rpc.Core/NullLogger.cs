using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class NullLogger : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static NullLogger Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x38DF7F0", Offset = "0x38DE1F0", VA = "0x1838DF7F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		void ILogger.Log(LogLevel level, string message, Exception e)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NullLogger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x38DF790", Offset = "0x38DE190", VA = "0x1838DF790")]
		static NullLogger()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
