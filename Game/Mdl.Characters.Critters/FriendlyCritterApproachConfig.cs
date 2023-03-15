using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000930")]
	[CreateAssetMenu]
	internal class FriendlyCritterApproachConfig : CritterApproachConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003324")]
		public float maxDistanceToApproach = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003325")]
		public float idleTime = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003326")]
		public float minMovementDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003327")]
		public float maxMovementDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003328")]
		public float sittingTime = 10f;

		[Cpp2IlInjected.Token(Token = "0x6002A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1470380", Offset = "0x146ED80", VA = "0x181470380", Slot = "4")]
		public override IMotivation Instantiate()
		{
			FriendlyCritterApproach friendlyCritterApproach = new FriendlyCritterApproach(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1470400", Offset = "0x146EE00", VA = "0x181470400")]
		public FriendlyCritterApproachConfig()
		{
		}
	}
}
