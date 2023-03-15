using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000990")]
	public interface IOnlineResponse
	{
		[Cpp2IlInjected.Token(Token = "0x17000E8A")]
		int PlayFabResult
		{
			[Cpp2IlInjected.Token(Token = "0x60053F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60053F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
