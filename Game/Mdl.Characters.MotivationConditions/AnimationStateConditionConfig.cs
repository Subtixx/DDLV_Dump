using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000901")]
	[CreateAssetMenu]
	public class AnimationStateConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003242")]
		[Tooltip("The exact name of the animation state")]
		public string stateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003243")]
		[Tooltip("The animation layer to consider")]
		public int layerIndex;

		[Cpp2IlInjected.Token(Token = "0x600296D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E270", Offset = "0xA3CC70", VA = "0x180A3E270", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			AnimationStateCondition animationStateCondition = new AnimationStateCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600296E")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public AnimationStateConditionConfig()
		{
		}
	}
}
