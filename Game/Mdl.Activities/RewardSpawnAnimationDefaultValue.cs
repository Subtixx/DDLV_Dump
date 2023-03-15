using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B92")]
	internal class RewardSpawnAnimationDefaultValue : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400406F")]
		public GameObject animationStartVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004070")]
		public GameObject animationProjectileVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004071")]
		public string animationProjectileVFXEndTrigger = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004072")]
		public GameObject animationEndVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004073")]
		public AK.Wwise.Event rewardGroundSpawnLandSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004074")]
		public RewardSpawnAnimationData animationData;

		[Cpp2IlInjected.Token(Token = "0x6003582")]
		[Cpp2IlInjected.Address(RVA = "0xCC2F20", Offset = "0xCC1920", VA = "0x180CC2F20")]
		public RewardSpawnAnimationDefaultValue()
		{
		}
	}
}
