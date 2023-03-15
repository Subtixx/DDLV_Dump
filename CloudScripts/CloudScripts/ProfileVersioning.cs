using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	public class ProfileVersioning
	{
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public const int CurrentVersion = 175;

		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public const int NotFixedInAnyClientVersion = int.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public const int InvalidOnlineVersion = -1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ProfileVersioning()
		{
		}
	}
}
