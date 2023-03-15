using Cpp2IlInjected;

namespace Mdl.Platform.Xbox
{
	[Cpp2IlInjected.Token(Token = "0x2000311")]
	public class XboxSystemUsernameProvider : ISystemUsernameProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400164A")]
		public string SystemUsername
		{
			[Cpp2IlInjected.Token(Token = "0x6000D5F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public XboxSystemUsernameProvider()
		{
		}
	}
}
