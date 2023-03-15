using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200084A")]
	public interface IHasSpriteURI
	{
		[Cpp2IlInjected.Token(Token = "0x600349A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetURI(SpriteType spriteType);
	}
}
