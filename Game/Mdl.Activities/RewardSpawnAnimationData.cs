using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B91")]
	[CreateAssetMenu]
	public class RewardSpawnAnimationData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004068")]
		public float minDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004069")]
		public float animationStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400406A")]
		public AnimationCurve animationHeightCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400406B")]
		public float animationHorizontalSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400406C")]
		public AnimationCurve animationScaleCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400406D")]
		public float animationEndDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400406E")]
		public bool automaticPickup = true;

		[Cpp2IlInjected.Token(Token = "0x6003581")]
		[Cpp2IlInjected.Address(RVA = "0xCC2F10", Offset = "0xCC1910", VA = "0x180CC2F10")]
		public RewardSpawnAnimationData()
		{
		}
	}
}
