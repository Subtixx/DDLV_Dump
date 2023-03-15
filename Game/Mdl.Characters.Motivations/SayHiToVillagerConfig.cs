using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008ED")]
	[CreateAssetMenu]
	public class SayHiToVillagerConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40031A6")]
		[Tooltip("Chance of the character running to its destination in percentage")]
		public float runProbability = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40031A7")]
		[Tooltip("Min distance between this NPC and target character to pick target character")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031A8")]
		[Tooltip("Max distance between this NPC and target character to pick target character")]
		public float maxDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40031A9")]
		[Tooltip("Destination to meet target character will update at this interval in seconds")]
		public float updateDestinationTime = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031AA")]
		[Tooltip("Min distance from target to set destination")]
		public float minTargetDistance = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40031AB")]
		[Tooltip("Max distance from target to set destination")]
		public float maxTargetDistance = 8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031AC")]
		[Tooltip("Trigger name to play hello animation")]
		public string animTrigger = "Hello";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031AD")]
		[Tooltip("Will look at the target character continuously")]
		public bool forceLookAtTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40031AE")]
		[Tooltip("Animation duration in seconds")]
		public float animDuration = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40031AF")]
		[Tooltip("Name of the animation override layer")]
		public string animOverrideLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031B0")]
		[Tooltip("Probability of using the animation override layer in percentage")]
		public float animOverrideProbability;

		[Cpp2IlInjected.Token(Token = "0x6002915")]
		[Cpp2IlInjected.Address(RVA = "0xCC8190", Offset = "0xCC6B90", VA = "0x180CC8190", Slot = "4")]
		public override IMotivation Instantiate()
		{
			new SayHiToVillager(this).speed = 2f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002916")]
		[Cpp2IlInjected.Address(RVA = "0xCC8210", Offset = "0xCC6C10", VA = "0x180CC8210")]
		public SayHiToVillagerConfig()
		{
		}
	}
}
