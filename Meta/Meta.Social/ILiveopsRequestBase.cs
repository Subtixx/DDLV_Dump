using Cpp2IlInjected;
using Definitions;
using Google.Protobuf.Collections;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DA3")]
	public interface ILiveopsRequestBase
	{
		[Cpp2IlInjected.Token(Token = "0x170013B9")]
		RepeatedField<KnownLiveopsItem> KnownItems
		{
			[Cpp2IlInjected.Token(Token = "0x6007235")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170013BA")]
		bool IncludeScheduled
		{
			[Cpp2IlInjected.Token(Token = "0x6007236")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
