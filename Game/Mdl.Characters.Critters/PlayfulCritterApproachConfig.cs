using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000935")]
	[CreateAssetMenu]
	internal class PlayfulCritterApproachConfig : CritterApproachConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003329")]
		public int numberOfTimesCritterRunAway = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400332A")]
		public float distanceToRunAway = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400332B")]
		public float timeForAvatarToGetClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400332C")]
		public float minDistanceToRunAway;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400332D")]
		public float maxDistanceToRunAway;

		[Cpp2IlInjected.Token(Token = "0x6002A56")]
		[Cpp2IlInjected.Address(RVA = "0xCAEAB0", Offset = "0xCAD4B0", VA = "0x180CAEAB0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			PlayfulCritterApproach playfulCritterApproach = new PlayfulCritterApproach(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A57")]
		[Cpp2IlInjected.Address(RVA = "0xCAEB30", Offset = "0xCAD530", VA = "0x180CAEB30")]
		public PlayfulCritterApproachConfig()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
