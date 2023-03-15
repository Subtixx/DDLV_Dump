using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FA0")]
	public static class OnlineClientExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007EE6")]
		[Cpp2IlInjected.Address(RVA = "0x13A24F0", Offset = "0x13A0EF0", VA = "0x1813A24F0")]
		public static bool HasAnyOnlineStatus(this OnlineClient.OnlineStatus currentValue, OnlineClient.OnlineStatus flags)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE7")]
		[Cpp2IlInjected.Address(RVA = "0x13A24E0", Offset = "0x13A0EE0", VA = "0x1813A24E0")]
		public static bool HasAllOnlineStatus(this OnlineClient.OnlineStatus currentValue, OnlineClient.OnlineStatus flags)
		{
			return currentValue == flags;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE8")]
		[Cpp2IlInjected.Address(RVA = "0x13A2500", Offset = "0x13A0F00", VA = "0x1813A2500")]
		public static bool IsFullOnline(this OnlineClient.OnlineStatus currentValue)
		{
			return currentValue == OnlineClient.OnlineStatus.FullOnline;
		}
	}
}
