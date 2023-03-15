using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	public interface IHasText
	{
		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetText(TextType textType);
	}
}
