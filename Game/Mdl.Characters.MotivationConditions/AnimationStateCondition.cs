using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000900")]
	public class AnimationStateCondition : MotivationCondition<AnimationStateConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x600296B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3F0", Offset = "0xA3CDF0", VA = "0x180A3E3F0")]
		public AnimationStateCondition(AnimationStateConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x600296C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2F0", Offset = "0xA3CCF0", VA = "0x180A3E2F0", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num = 0;
			bool flag = componentInChildren != (Object)num;
			if (!flag)
			{
				return flag;
			}
			AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
			float length = animatorStateInfo.m_Length;
			int loop = animatorStateInfo.m_Loop;
			bool result = default(bool);
			return result;
		}
	}
}
