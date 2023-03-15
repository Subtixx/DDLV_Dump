using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008D9")]
	[CreateAssetMenu]
	internal class HangoutConfig : FollowConfig
	{
		[Cpp2IlInjected.Token(Token = "0x60028CD")]
		[Cpp2IlInjected.Address(RVA = "0x154AFF0", Offset = "0x15499F0", VA = "0x18154AFF0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			Hangout hangout = new Hangout(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028CE")]
		[Cpp2IlInjected.Address(RVA = "0x154B050", Offset = "0x1549A50", VA = "0x18154B050")]
		public HangoutConfig()
		{
		}
	}
}
