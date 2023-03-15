using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000933")]
	internal class IsCritterMinigameCompletedCondition : MotivationCondition<IsCritterMinigameCompletedConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6002A52")]
		[Cpp2IlInjected.Address(RVA = "0x11BE040", Offset = "0x11BCA40", VA = "0x1811BE040")]
		public IsCritterMinigameCompletedCondition(IsCritterMinigameCompletedConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A53")]
		[Cpp2IlInjected.Address(RVA = "0x11BDFA0", Offset = "0x11BC9A0", VA = "0x1811BDFA0", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//Discarded unreachable code: IL_001e
			//IL_0010: Expected O, but got I4
			Critter component = agent.GetComponent<Critter>();
			int num = 0;
			bool flag = component != (Object)num;
			if (!flag)
			{
				return flag;
			}
			return component.CompletedMinigame;
		}
	}
}
