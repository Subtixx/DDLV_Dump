using System;
using Cpp2IlInjected;

namespace Mdl.Activities
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B3A")]
	public class FishingMinigameRoundConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E6C")]
		public float TimeOutsideTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003E6D")]
		public float TimeInsideTrigger;

		[Cpp2IlInjected.Token(Token = "0x60033C6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FishingMinigameRoundConfig()
		{
		}
	}
}
