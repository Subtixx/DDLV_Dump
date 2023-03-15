using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000904")]
	public class InFrustrumCondition : MotivationCondition<InFrustrumConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6002974")]
		[Cpp2IlInjected.Address(RVA = "0x11B29F0", Offset = "0x11B13F0", VA = "0x1811B29F0")]
		public InFrustrumCondition(InFrustrumConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002975")]
		[Cpp2IlInjected.Address(RVA = "0x11B2880", Offset = "0x11B1280", VA = "0x1811B2880", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			Collider component = agent.GetComponent<Collider>();
			int num = 0;
			bool flag = component != (Object)num;
			if (!flag)
			{
				return flag;
			}
			Plane[] array = GeometryUtility.CalculateFrustumPlanes(SystemRoot.Instance._playerCamera);
			bool result = default(bool);
			return result;
		}
	}
}
