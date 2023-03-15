using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079E")]
	public interface IRelaxer
	{
		[Cpp2IlInjected.Token(Token = "0x60021DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRelaxStart();

		[Cpp2IlInjected.Token(Token = "0x60021DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnRelaxEnd();
	}
}
