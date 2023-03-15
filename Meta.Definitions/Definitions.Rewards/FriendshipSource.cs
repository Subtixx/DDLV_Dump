using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000225")]
	public enum FriendshipSource
	{
		[Cpp2IlInjected.Token(Token = "0x40008BC")]
		[OriginalName("Unknown")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40008BD")]
		[OriginalName("Cheat")]
		Cheat,
		[Cpp2IlInjected.Token(Token = "0x40008BE")]
		[OriginalName("Discuss")]
		Discuss,
		[Cpp2IlInjected.Token(Token = "0x40008BF")]
		[OriginalName("FirstDailyPreferredGift")]
		FirstDailyPreferredGift,
		[Cpp2IlInjected.Token(Token = "0x40008C0")]
		[OriginalName("Gift")]
		Gift,
		[Cpp2IlInjected.Token(Token = "0x40008C1")]
		[OriginalName("Mission")]
		Mission,
		[Cpp2IlInjected.Token(Token = "0x40008C2")]
		[OriginalName("RestaurantOrder")]
		RestaurantOrder,
		[Cpp2IlInjected.Token(Token = "0x40008C3")]
		[OriginalName("HangoutActivity")]
		HangoutActivity,
		[Cpp2IlInjected.Token(Token = "0x40008C4")]
		[OriginalName("HangoutActivityPreferred")]
		HangoutActivityPreferred
	}
}
