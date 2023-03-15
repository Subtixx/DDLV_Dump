using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000934")]
	[CreateAssetMenu]
	internal class IsCritterMinigameCompletedConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.Token(Token = "0x6002A54")]
		[Cpp2IlInjected.Address(RVA = "0x11BDF20", Offset = "0x11BC920", VA = "0x1811BDF20", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			IsCritterMinigameCompletedCondition isCritterMinigameCompletedCondition = new IsCritterMinigameCompletedCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A55")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public IsCritterMinigameCompletedConditionConfig()
		{
		}
	}
}
