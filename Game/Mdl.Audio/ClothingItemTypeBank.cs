using System;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000ADC")]
	public class ClothingItemTypeBank
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C29")]
		public Switch switch_obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C2A")]
		public Bank bank_obj;

		[Cpp2IlInjected.Token(Token = "0x6003200")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ClothingItemTypeBank()
		{
		}
	}
}
