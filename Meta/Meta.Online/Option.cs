using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EFB")]
	public class Option
	{
		[Cpp2IlInjected.Token(Token = "0x2000EFC")]
		public enum OptionStyle
		{
			[Cpp2IlInjected.Token(Token = "0x4003D30")]
			Ok,
			[Cpp2IlInjected.Token(Token = "0x4003D31")]
			Cancel,
			[Cpp2IlInjected.Token(Token = "0x4003D32")]
			Retry
		}

		[Cpp2IlInjected.Token(Token = "0x1700156A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003D29")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x6007BB4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700156B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003D2A")]
		public OptionStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x6007BB5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700156C")]
		[field: Cpp2IlInjected.Token(Token = "0x4003D2B")]
		public static Option Ok
		{
			[Cpp2IlInjected.Token(Token = "0x6007BB7")]
			[Cpp2IlInjected.Address(RVA = "0x13ABE90", Offset = "0x13AA890", VA = "0x1813ABE90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700156D")]
		[field: Cpp2IlInjected.Token(Token = "0x4003D2C")]
		public static Option Cancel
		{
			[Cpp2IlInjected.Token(Token = "0x6007BB8")]
			[Cpp2IlInjected.Address(RVA = "0x13ABE30", Offset = "0x13AA830", VA = "0x1813ABE30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700156E")]
		[field: Cpp2IlInjected.Token(Token = "0x4003D2D")]
		public static Option Retry
		{
			[Cpp2IlInjected.Token(Token = "0x6007BB9")]
			[Cpp2IlInjected.Address(RVA = "0x13ABF50", Offset = "0x13AA950", VA = "0x1813ABF50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700156F")]
		[field: Cpp2IlInjected.Token(Token = "0x4003D2E")]
		public static Option ResetProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007BBA")]
			[Cpp2IlInjected.Address(RVA = "0x13ABEF0", Offset = "0x13AA8F0", VA = "0x1813ABEF0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BB6")]
		[Cpp2IlInjected.Address(RVA = "0xAFD030", Offset = "0xAFBA30", VA = "0x180AFD030")]
		public Option(string label, OptionStyle style = OptionStyle.Ok)
		{
			Label = label;
			Style = style;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BBB")]
		[Cpp2IlInjected.Address(RVA = "0x13ABC80", Offset = "0x13AA680", VA = "0x1813ABC80")]
		static Option()
		{
			Option option = default(Option);
			option.Label = "Ok";
			int num = (int)(option.Style = OptionStyle.Ok);
			Ok = option;
			Option option2 = default(Option);
			option2.Label = "Cancel";
			option2.Style = (OptionStyle)num;
			Ok = option2;
			Option option3 = default(Option);
			option3.Label = "Retry";
			option3.Style = (OptionStyle)num;
			Ok = option3;
			Option option4 = default(Option);
			option4.Label = "Reset Profile";
			option4.Style = (OptionStyle)num;
			Ok = option4;
			/*Error: Unexpected end of block*/;
		}
	}
}
