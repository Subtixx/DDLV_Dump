using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000921")]
	[CreateAssetMenu]
	internal class CautiousCritterApproachConfig : CritterApproachConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032DC")]
		public float maxDistanceToApproach = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40032DD")]
		public float highAlertDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032DE")]
		public float highAlertForgivenessPeriod = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40032DF")]
		public float idleDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032E0")]
		public GameObject highAlertVFX;

		[Cpp2IlInjected.Token(Token = "0x60029EB")]
		[Cpp2IlInjected.Address(RVA = "0x12D9DE0", Offset = "0x12D87E0", VA = "0x1812D9DE0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			CautiousCritterApproach cautiousCritterApproach = new CautiousCritterApproach(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029EC")]
		[Cpp2IlInjected.Address(RVA = "0x12D9E60", Offset = "0x12D8860", VA = "0x1812D9E60")]
		public CautiousCritterApproachConfig()
		{
		}
	}
}
