using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD0")]
	public class AuthCodeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004110")]
		public string AuthCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004111")]
		public int IssuerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004112")]
		public string UserId;

		[Cpp2IlInjected.Token(Token = "0x6007F97")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AuthCodeData()
		{
		}
	}
}
