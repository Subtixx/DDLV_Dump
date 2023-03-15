using System;
using Cpp2IlInjected;

namespace Mdl.Activities
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B39")]
	public class FishingMinigameConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E67")]
		public float BetweenRoundTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003E68")]
		public float FailTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E69")]
		public float InitialRoundMinimumTime = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003E6A")]
		public float InitialRoundMaximumTime = 12f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E6B")]
		public float InitialRoundTriggerTime = 1f;

		[Cpp2IlInjected.Token(Token = "0x60033C5")]
		[Cpp2IlInjected.Address(RVA = "0x1374D50", Offset = "0x1373750", VA = "0x181374D50")]
		public FishingMinigameConfig()
		{
		}
	}
}
