using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FA3")]
	public class ProfileConflictResolutionResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000FA4")]
		public enum ConflictResolutionType
		{
			[Cpp2IlInjected.Token(Token = "0x4004062")]
			NoConflictDetected,
			[Cpp2IlInjected.Token(Token = "0x4004063")]
			UsingLocal,
			[Cpp2IlInjected.Token(Token = "0x4004064")]
			UsingRemote,
			[Cpp2IlInjected.Token(Token = "0x4004065")]
			NewUser,
			[Cpp2IlInjected.Token(Token = "0x4004066")]
			ProfileReset,
			[Cpp2IlInjected.Token(Token = "0x4004067")]
			ProfileResetFailed
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400405D")]
		public bool pickedByDebugCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400405E")]
		public bool pickedByUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400405F")]
		public ConflictResolutionType resolutionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004060")]
		public MiniProfile usedMiniProfile;

		[Cpp2IlInjected.Token(Token = "0x6007EEC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ProfileConflictResolutionResult()
		{
		}
	}
}
