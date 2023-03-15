using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	public class RuntimePlatformNames
	{
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public static readonly string Playstation = "playstation";

		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public static readonly string NintendoSwitch;

		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public static readonly string XBox;

		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public static readonly string Android;

		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public static readonly string ios;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public static readonly string osx;

		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly string Steam;

		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public static readonly string Epic;

		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public static readonly string MacAppStore;

		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public static readonly string WindowsStore;

		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public static readonly string WindowsDefault;

		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public static readonly string HeadlessProject;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RuntimePlatformNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1170B10", Offset = "0x116F510", VA = "0x181170B10")]
		static RuntimePlatformNames()
		{
			Playstation = "switch";
			Playstation = "xbox";
			Playstation = "android";
			Playstation = "appstore";
			Playstation = "osx";
			Playstation = "steam";
			Playstation = "epic";
			Playstation = "macstore";
			Playstation = "microsoft";
			Playstation = "windows";
			Playstation = "Headless";
			/*Error: Unexpected end of block*/;
		}
	}
}
