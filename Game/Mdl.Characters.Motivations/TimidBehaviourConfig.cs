using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008F6")]
	[CreateAssetMenu]
	internal class TimidBehaviourConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40031ED")]
		[Tooltip("Distance threshold that, when crossed by the avatar, will trigger the hiding behavior")]
		public float distanceToHide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40031EE")]
		[Tooltip("Time in seconds")]
		public float hideTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031EF")]
		[Tooltip("Distance threshold that, when crossed by the avatar, will reset the hiding behavior")]
		public float maxAvatarMoveDistanceToResetTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40031F0")]
		public bool hideAgainOnMovement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031F1")]
		[Tooltip("Animation played when the character hide from the player")]
		public string hideTrigger = "Sad";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031F2")]
		public AnimationClip idleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031F3")]
		[HideInInspector]
		public AnimationClip _defaultIdle;

		[Cpp2IlInjected.Token(Token = "0x600293D")]
		[Cpp2IlInjected.Address(RVA = "0x13D2AB0", Offset = "0x13D14B0", VA = "0x1813D2AB0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			new TimidBehaviour(this).hideTimer = -1f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600293E")]
		[Cpp2IlInjected.Address(RVA = "0x13D2B30", Offset = "0x13D1530", VA = "0x1813D2B30")]
		public TimidBehaviourConfig()
		{
		}
	}
}
