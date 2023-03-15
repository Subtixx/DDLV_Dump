using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000235")]
	public interface IGeneratorContext
	{
		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		IProfile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x600155E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600155B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next();

		[Cpp2IlInjected.Token(Token = "0x600155C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int Next(int max);

		[Cpp2IlInjected.Token(Token = "0x600155D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int Next(int min, int max);
	}
}
