using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000931")]
	internal class IsCritterFedCondition : MotivationCondition<IsCritterFedConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6002A4E")]
		[Cpp2IlInjected.Address(RVA = "0x11BDED0", Offset = "0x11BC8D0", VA = "0x1811BDED0")]
		public IsCritterFedCondition(IsCritterFedConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A4F")]
		[Cpp2IlInjected.Address(RVA = "0x11BDE30", Offset = "0x11BC830", VA = "0x1811BDE30", Slot = "5")]
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
			return component.Fed;
		}
	}
}
