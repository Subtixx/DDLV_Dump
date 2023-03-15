using Cpp2IlInjected;

namespace Gameloft.Tracking.Device.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class ValueSetExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4030520", Offset = "0x402EF20", VA = "0x184030520")]
		public static ValueSetTransaction AutoSave(this ValueSet pthis)
		{
			ValueSetTransaction valueSetTransaction = default(ValueSetTransaction);
			valueSetTransaction.innerSet = pthis;
			return valueSetTransaction;
		}
	}
}
