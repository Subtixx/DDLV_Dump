using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008FF")]
	[CreateAssetMenu]
	public class WalkAroundConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003232")]
		[Tooltip("Min distance from NPC to set destination")]
		public float minDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003233")]
		[Tooltip("Max distance from NPC to set destination")]
		public float maxDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003234")]
		[Tooltip("Min duration of this motivation in seconds")]
		public float minDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003235")]
		[Tooltip("Max duration of this motivation in seconds")]
		public float maxDuration = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003236")]
		[Tooltip("Idle time min duration in seconds")]
		public float idleMinDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003237")]
		[Tooltip("Idle time max duration in seconds")]
		public float idleMaxDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003238")]
		[Tooltip("Distance from destination to complete path (default = 0.1)")]
		public float keepDistance = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003239")]
		[Tooltip("Should the default character walk be overridden")]
		public bool overrideWalkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400323A")]
		[Tooltip("Override of the character walk speed. Only applies if \"overrideWalkSpeed\" is set to true")]
		public float walkSpeedOverride = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400323B")]
		[Tooltip("Trigger to enter a custom walk animation")]
		public string animInTriggerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400323C")]
		[Tooltip("The name of the in animation state")]
		public string animInStateName = "WOL_start";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400323D")]
		[Tooltip("Trigger to exit the custom walk animation")]
		public string animOutTriggerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400323E")]
		[Tooltip("The name of the out animation state")]
		public string animOutStateName = "WOL_end";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400323F")]
		[Tooltip("The maximum amount of time to wait for the in/out animation completion")]
		public float maxAnimOverrideDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003240")]
		[Tooltip("Name of the animation override layer")]
		public string animOverrideLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003241")]
		[Tooltip("Probability of using the animation override layer in percentage")]
		public float animOverrideProbability;

		[Cpp2IlInjected.Token(Token = "0x6002969")]
		[Cpp2IlInjected.Address(RVA = "0xD4C960", Offset = "0xD4B360", VA = "0x180D4C960", Slot = "4")]
		public override IMotivation Instantiate()
		{
			WalkAround walkAround = new WalkAround(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600296A")]
		[Cpp2IlInjected.Address(RVA = "0xD4C9E0", Offset = "0xD4B3E0", VA = "0x180D4C9E0")]
		public WalkAroundConfig()
		{
		}
	}
}
