using Cpp2IlInjected;
using Mdl.Environments.PointsOfInterest;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008FC")]
	[CreateAssetMenu]
	public class VisitPointOfInterestConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003218")]
		[Tooltip("Specific config for point of interest type")]
		public PointOfInterestActionConfig action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003219")]
		[Tooltip("Could visit more than one point of this type in a row")]
		public int pointOfInterestCount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400321A")]
		[Tooltip("Susbsequent points min distance")]
		public float nextPointMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400321B")]
		[Tooltip("Subsequent points max distance")]
		public float nextPointMaxDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400321C")]
		[Tooltip("Chance of the character running to its destination in percentage")]
		public float runProbability = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400321D")]
		[Tooltip("Min distance between NPC and point of interest to pick point of interest")]
		public float minDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400321E")]
		[Tooltip("Max distance between NPC and point of interest to pick point of interest")]
		public float maxDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400321F")]
		[Tooltip("Min duration of action when destination is reached")]
		[Range(0f, 2.1474836E+09f)]
		public float minDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003220")]
		[Range(0f, 2.1474836E+09f)]
		[Tooltip("Max duration of action when destination is reached")]
		public float maxDuration = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003221")]
		[Tooltip("Name of the animation override layer")]
		public string animOverrideLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003222")]
		[Tooltip("Probability of using the animation override layer in percentage")]
		public float animOverrideProbability;

		[Cpp2IlInjected.Token(Token = "0x600295D")]
		[Cpp2IlInjected.Address(RVA = "0xD48C10", Offset = "0xD47610", VA = "0x180D48C10", Slot = "4")]
		public override IMotivation Instantiate()
		{
			new VisitPointOfInterest(this).speed = 2f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600295E")]
		[Cpp2IlInjected.Address(RVA = "0xD48C90", Offset = "0xD47690", VA = "0x180D48C90")]
		public VisitPointOfInterestConfig()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
