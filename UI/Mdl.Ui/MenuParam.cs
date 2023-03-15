using System;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200022B")]
	public class MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009B3")]
		public Action OnFocusInAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009B4")]
		public Action OnPopAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009B5")]
		public Action<int> AnswerAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40009B6")]
		public object[] Params;

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MenuParam()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB9")]
		[Cpp2IlInjected.Address(RVA = "0x128EB20", Offset = "0x128D520", VA = "0x18128EB20")]
		public MenuParam(MenuParam other)
		{
			Action action = (OnFocusInAction = other.OnFocusInAction);
			Action action2 = (OnPopAction = other.OnPopAction);
			Action<int> action3 = (AnswerAction = other.AnswerAction);
			object[] array = (Params = other.Params);
			throw new NullReferenceException();
		}
	}
}
