using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000660")]
	public interface ILimitedLife
	{
		[Cpp2IlInjected.Token(Token = "0x17001333")]
		bool CanDie
		{
			[Cpp2IlInjected.Token(Token = "0x6004A61")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
