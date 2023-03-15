using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004C4")]
	internal interface IStartFTUEPanel
	{
		[Cpp2IlInjected.Token(Token = "0x17000506")]
		bool IsInAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001F22")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001F23")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F24")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Transform GetContent();

		[Cpp2IlInjected.Token(Token = "0x6001F25")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BaseButton GetBackButton();

		[Cpp2IlInjected.Token(Token = "0x6001F26")]
		[Cpp2IlInjected.Address(Slot = "4")]
		BaseButton GetNextButton();

		[Cpp2IlInjected.Token(Token = "0x6001F27")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetFocus(FocusNavigation focusNavigation);

		[Cpp2IlInjected.Token(Token = "0x6001F28")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Show();

		[Cpp2IlInjected.Token(Token = "0x6001F29")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Hide();
	}
}
