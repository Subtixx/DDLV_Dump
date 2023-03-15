using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public interface IUserInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000302")]
		string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C55")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		string UserIdOtherPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000C56")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
