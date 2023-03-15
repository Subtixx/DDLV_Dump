using System;
using Cpp2IlInjected;

namespace Mdl.Activities
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B3B")]
	public class FishingMinigameGameplayConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E6E")]
		public float MaxTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003E6F")]
		public float TriggerStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E70")]
		public float TriggerEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003E71")]
		public float BetweenRoundTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E72")]
		public float FailTime;

		[Cpp2IlInjected.Token(Token = "0x60033C7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FishingMinigameGameplayConfig()
		{
		}
	}
}
