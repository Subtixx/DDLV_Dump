using System;
using Cpp2IlInjected;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B3C")]
	public class FishingMiniGameEventArgs : EventArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E73")]
		public float NormalizedProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E74")]
		public FishingMinigameGameplayConfig Config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E75")]
		public int CurrentRoundIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003E76")]
		public FishingMiniGame.FishingResult? Result;

		[Cpp2IlInjected.Token(Token = "0x60033C8")]
		[Cpp2IlInjected.Address(RVA = "0x1370DC0", Offset = "0x136F7C0", VA = "0x181370DC0")]
		public FishingMiniGameEventArgs()
		{
		}
	}
}
