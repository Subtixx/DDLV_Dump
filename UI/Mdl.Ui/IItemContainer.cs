using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public interface IItemContainer
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event ItemDataDelegate OnItemData;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event ItemActivatedDelegate OnItemActivated;

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void InitItems(int itemCount, int initialSelectionIndex);

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetFocus(FocusNavigation focusNavigation);
	}
}
