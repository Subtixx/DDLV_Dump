using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008F4")]
	[CreateAssetMenu]
	public class SwimAroundConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40031D9")]
		[Tooltip("Min distance from NPC to set destination")]
		public float minDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40031DA")]
		[Tooltip("Max distance from NPC to set destination")]
		public float maxDistance = 75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031DB")]
		[Tooltip("Idle time min duration in seconds")]
		public float idleMinDuration = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40031DC")]
		[Tooltip("Idle time max duration in seconds")]
		public float idleMaxDuration = 40f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031DD")]
		[Tooltip("Idle time duration in seconds in the event that we failed to find a path")]
		public float idleFailedDuration = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40031DE")]
		[Tooltip("Distance from destination to complete path (default = 0.1)")]
		public float keepDistance = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031DF")]
		[Tooltip("Trigger to enter a custom walk animation")]
		public string animInTriggerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031E0")]
		[Tooltip("The name of the in animation state")]
		public string animInStateName = "WOL_start";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40031E1")]
		[Tooltip("Trigger to exit the custom walk animation")]
		public string animOutTriggerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031E2")]
		[Tooltip("The name of the out animation state")]
		public string animOutStateName = "WOL_end";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40031E3")]
		[Tooltip("The maximum amount of time to wait for the in/out animation completion")]
		public float maxAnimOverrideDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40031E4")]
		[Tooltip("Name of the animation override layer")]
		public string animOverrideLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40031E5")]
		[Tooltip("Probability of using the animation override layer in percentage")]
		public float animOverrideProbability;

		[Cpp2IlInjected.Token(Token = "0x6002933")]
		[Cpp2IlInjected.Address(RVA = "0x10662F0", Offset = "0x1064CF0", VA = "0x1810662F0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			SwimAround swimAround = new SwimAround(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002934")]
		[Cpp2IlInjected.Address(RVA = "0x1066370", Offset = "0x1064D70", VA = "0x181066370")]
		public SwimAroundConfig()
		{
		}
	}
}
