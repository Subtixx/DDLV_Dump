using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public static class InboxExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x27B4BB0", Offset = "0x27B35B0", VA = "0x1827B4BB0")]
		public static bool IsNotStarted(this InboxMessageAccessRestriction accessRestriction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x27B4BA0", Offset = "0x27B35A0", VA = "0x1827B4BA0")]
		public static bool IsHidden(this InboxMessageAccessRestriction accessRestriction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
