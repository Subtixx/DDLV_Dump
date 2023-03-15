using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008DD")]
	[CreateAssetMenu]
	public class HoldStallConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003176")]
		[Tooltip("Min distance from stall to teleport character")]
		public float minTeleportDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003177")]
		[Tooltip("Distance from stall where character will slow down")]
		public float slowDownDistance = 5f;

		[Cpp2IlInjected.Token(Token = "0x60028DB")]
		[Cpp2IlInjected.Address(RVA = "0x11AC310", Offset = "0x11AAD10", VA = "0x1811AC310", Slot = "4")]
		public override IMotivation Instantiate()
		{
			HoldStall holdStall = new HoldStall(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028DC")]
		[Cpp2IlInjected.Address(RVA = "0x11AC390", Offset = "0x11AAD90", VA = "0x1811AC390")]
		public HoldStallConfig()
		{
		}
	}
}
