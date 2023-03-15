using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B3B")]
	public interface IWritableDisplayer
	{
		[Cpp2IlInjected.Token(Token = "0x6005E96")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void StartProgress();

		[Cpp2IlInjected.Token(Token = "0x6005E97")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EndProgress();
	}
}
