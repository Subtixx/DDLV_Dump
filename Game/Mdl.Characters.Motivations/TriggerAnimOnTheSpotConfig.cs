using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008FA")]
	[CreateAssetMenu]
	public class TriggerAnimOnTheSpotConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003206")]
		[Tooltip("The name of the animation trigger at start")]
		public string enterTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003207")]
		[Tooltip("The name of the enter animation state")]
		public string enterAnimState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003208")]
		[Tooltip("The name of the animation trigger at end")]
		public string exitTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003209")]
		[Tooltip("The name of the end animation state")]
		public string exitAnimState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400320A")]
		[Tooltip("The maximum amount of time to wait for the in/out animation completion")]
		public float maxAnimWaitDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400320B")]
		[Tooltip("The minimum duration of the action in seconds")]
		public float minDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400320C")]
		[Tooltip("The maximum duration of the action in seconds")]
		public float maxDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400320D")]
		[Tooltip("Should we prevent characters from approaching during the animation")]
		public bool clearSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400320E")]
		[Tooltip("What should be the size of the exclusion zone during the animation")]
		public Vector3 clearedSpaceSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400320F")]
		[Tooltip("What should be the offset of the exclusion zone during the animation")]
		public Vector3 clearedSpaceOffset;

		[Cpp2IlInjected.Token(Token = "0x600294B")]
		[Cpp2IlInjected.Address(RVA = "0x13DECA0", Offset = "0x13DD6A0", VA = "0x1813DECA0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			TriggerAnimOnTheSpot triggerAnimOnTheSpot = new TriggerAnimOnTheSpot(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600294C")]
		[Cpp2IlInjected.Address(RVA = "0x13DED20", Offset = "0x13DD720", VA = "0x1813DED20")]
		public TriggerAnimOnTheSpotConfig()
		{
		}
	}
}
