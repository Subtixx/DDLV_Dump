using Cpp2IlInjected;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000887")]
	public interface IGrowable
	{
		[Cpp2IlInjected.Token(Token = "0x170017F8")]
		Timestamp EndOfGrowth
		{
			[Cpp2IlInjected.Token(Token = "0x6005F55")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005F56")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
