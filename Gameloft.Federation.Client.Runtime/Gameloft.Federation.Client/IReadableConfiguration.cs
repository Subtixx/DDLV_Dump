using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface IReadableConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		string BasePath
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		IRequestSender RequestSender
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
