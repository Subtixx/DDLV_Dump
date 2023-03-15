using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B2E")]
	[CreateAssetMenu]
	internal class FishDifficulty : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E2D")]
		public FishingMinigameRoundConfig[] RoundConfigs;

		[Cpp2IlInjected.Token(Token = "0x600338F")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public FishDifficulty()
		{
		}
	}
}
