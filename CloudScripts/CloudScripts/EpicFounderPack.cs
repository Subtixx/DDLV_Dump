using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public static class EpicFounderPack
	{
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static string DeluxeId = "76463fd4fb4b4d4f8adf777d95e1b3d0";

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static string UltimateId;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x116DDC0", Offset = "0x116C7C0", VA = "0x18116DDC0")]
		static EpicFounderPack()
		{
			DeluxeId = "6b3cf0fa07c74fd8b28bade73bc0f1b2";
			/*Error: Unexpected end of block*/;
		}
	}
}
