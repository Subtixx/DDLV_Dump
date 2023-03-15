using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000902")]
	internal class ConditionItemCondition : MotivationCondition<ConditionItemConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x600296F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4B0", Offset = "0xA8CEB0", VA = "0x180A8E4B0")]
		public ConditionItemCondition(ConditionItemConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002970")]
		[Cpp2IlInjected.Address(RVA = "0xA8E2E0", Offset = "0xA8CCE0", VA = "0x180A8E2E0", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//Discarded unreachable code: IL_0018
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool result = default(bool);
			return result;
		}
	}
}
