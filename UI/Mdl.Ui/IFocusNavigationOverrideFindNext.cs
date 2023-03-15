using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200024E")]
	public interface IFocusNavigationOverrideFindNext
	{
		[Cpp2IlInjected.Token(Token = "0x6000EA1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindNextFocusElement(FocusDirection direction, int input, FocusNavigationElement currentElement, out ISupportsFocusNavigation nextElement);
	}
}
