using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000924")]
	[CreateAssetMenu]
	internal class CritterFleeConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032E5")]
		public float fleeDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40032E6")]
		public int numberOfFleeBeforeDisappear = 1;

		[Cpp2IlInjected.Token(Token = "0x60029F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FFB70", Offset = "0x10FE570", VA = "0x1810FFB70", Slot = "4")]
		public override IMotivation Instantiate()
		{
			CritterFlee critterFlee = new CritterFlee(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FFBF0", Offset = "0x10FE5F0", VA = "0x1810FFBF0")]
		public CritterFleeConfig()
		{
		}//IL_0014: Expected I4, but got I8

	}
}
