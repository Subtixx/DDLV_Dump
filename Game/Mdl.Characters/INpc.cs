using Cpp2IlInjected;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A6")]
	public interface INpc
	{
		[Cpp2IlInjected.Token(Token = "0x170005D8")]
		NpcBodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6002800")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005D9")]
		MotivationConfig FreeTimeMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x6002801")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005DA")]
		float WalkSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6002802")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005DB")]
		float RunSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6002803")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005DC")]
		bool TraversingLink
		{
			[Cpp2IlInjected.Token(Token = "0x6002804")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002805")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
}
