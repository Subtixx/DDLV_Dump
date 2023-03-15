using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000905")]
	[CreateAssetMenu]
	public class InFrustrumConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.Token(Token = "0x6002976")]
		[Cpp2IlInjected.Address(RVA = "0x11B2800", Offset = "0x11B1200", VA = "0x1811B2800", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			InFrustrumCondition inFrustrumCondition = new InFrustrumCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002977")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public InFrustrumConditionConfig()
		{
		}
	}
}
