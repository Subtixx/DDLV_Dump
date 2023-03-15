using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000936")]
	[CreateAssetMenu]
	internal class TimidCritterApproachConfig : CritterApproachConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400332E")]
		public float distanceToHide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400332F")]
		public float hideTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003330")]
		public float maxAvatarMoveDistanceToResetTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003331")]
		public GameObject hidingVFX;

		[Cpp2IlInjected.Token(Token = "0x6002A58")]
		[Cpp2IlInjected.Address(RVA = "0x13D3890", Offset = "0x13D2290", VA = "0x1813D3890", Slot = "4")]
		public override IMotivation Instantiate()
		{
			new TimidCritterApproach(this).hideTimer = -1f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A59")]
		[Cpp2IlInjected.Address(RVA = "0xA8E6B0", Offset = "0xA8D0B0", VA = "0x180A8E6B0")]
		public TimidCritterApproachConfig()
		{
		}
	}
}
