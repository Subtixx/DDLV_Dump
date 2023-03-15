using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FCF")]
	public class ServiceLabelData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400410D")]
		public bool IsPS5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400410E")]
		public string PS4ServiceLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400410F")]
		public string PS5ServiceLabel;

		[Cpp2IlInjected.Token(Token = "0x6007F96")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ServiceLabelData()
		{
		}
	}
}
