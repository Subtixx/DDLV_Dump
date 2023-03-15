using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[OriginalName("Energy")]
		Energy,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[OriginalName("ArenaInvitation")]
		ArenaInvitation,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[OriginalName("Mana")]
		Mana,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[OriginalName("Crystal")]
		Crystal,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[OriginalName("SocialPoint")]
		SocialPoint
	}
}
