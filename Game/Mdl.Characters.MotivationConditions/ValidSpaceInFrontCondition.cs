using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000909")]
	internal class ValidSpaceInFrontCondition : MotivationCondition<ValidSpaceInFrontConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x600297E")]
		[Cpp2IlInjected.Address(RVA = "0xD42F60", Offset = "0xD41960", VA = "0x180D42F60")]
		public ValidSpaceInFrontCondition(ValidSpaceInFrontConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x600297F")]
		[Cpp2IlInjected.Address(RVA = "0xD42D60", Offset = "0xD41760", VA = "0x180D42D60", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			NavMeshAgent component = agent.GetComponent<NavMeshAgent>();
			Transform transform = agent.transform;
			Transform transform2 = agent.transform;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				int agentTypeID = component.agentTypeID;
				int walkableMask = component.walkableMask;
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}
	}
}
