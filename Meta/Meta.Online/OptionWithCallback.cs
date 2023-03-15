using System;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EFD")]
	public class OptionWithCallback
	{
		[Cpp2IlInjected.Token(Token = "0x17001570")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003D33")]
		public Option Option
		{
			[Cpp2IlInjected.Token(Token = "0x6007BBC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001571")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003D34")]
		private Action Callback
		{
			[Cpp2IlInjected.Token(Token = "0x6007BBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BBE")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public OptionWithCallback(Option option, Action callback)
		{
			Option = option;
			Callback = callback;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BBF")]
		[Cpp2IlInjected.Address(RVA = "0x13ABC60", Offset = "0x13AA660", VA = "0x1813ABC60")]
		public void Select()
		{
			//Discarded unreachable code: IL_000c
			Callback();
		}
	}
}
