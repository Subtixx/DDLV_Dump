using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200064C")]
	public interface IScalableValue
	{
		[Cpp2IlInjected.Token(Token = "0x1700130D")]
		int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6004A2F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700130E")]
		int ScalingScript
		{
			[Cpp2IlInjected.Token(Token = "0x6004A30")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
