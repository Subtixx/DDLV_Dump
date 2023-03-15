using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200065F")]
	public interface INeedWatering
	{
		[Cpp2IlInjected.Token(Token = "0x17001332")]
		bool NeedWatering
		{
			[Cpp2IlInjected.Token(Token = "0x6004A60")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
