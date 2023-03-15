using Cpp2IlInjected;

namespace Gameloft.Localization.Formatter
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IResolver
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object Resolve(string key);
	}
}
