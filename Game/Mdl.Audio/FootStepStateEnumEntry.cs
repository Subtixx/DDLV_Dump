using System;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000AD6")]
	public class FootStepStateEnumEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C1D")]
		public string state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C1E")]
		public Switch eventState;

		[Cpp2IlInjected.Token(Token = "0x60031F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FootStepStateEnumEntry()
		{
		}
	}
}
