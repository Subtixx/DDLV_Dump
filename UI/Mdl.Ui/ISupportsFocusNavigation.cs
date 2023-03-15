using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200024D")]
	public interface ISupportsFocusNavigation
	{
		[Cpp2IlInjected.Token(Token = "0x6000E9C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetFocus();

		[Cpp2IlInjected.Token(Token = "0x6000E9D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveFocus();

		[Cpp2IlInjected.Token(Token = "0x6000E9E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Click(ShortcutDefinition shortcut);

		[Cpp2IlInjected.Token(Token = "0x6000E9F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AssignNext(FocusDirection direction, ISupportsFocusNavigation next);

		[Cpp2IlInjected.Token(Token = "0x6000EA0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ISupportsFocusNavigation FindNext(FocusDirection direction, int input);
	}
}
