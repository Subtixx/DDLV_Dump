using Cpp2IlInjected;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002AB")]
	public interface ISystemUsernameProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000162")]
		string SystemUsername
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
