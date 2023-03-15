using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AE")]
	public abstract class MotivationCondition<C> : IMotivationCondition where C : MotivationConditionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40030D0")]
		protected C config;

		[Cpp2IlInjected.Token(Token = "0x6002827")]
		[Cpp2IlInjected.Address(RVA = "0x188BEB0", Offset = "0x188A8B0", VA = "0x18188BEB0")]
		public MotivationCondition(C config)
		{
			((MotivationCondition<>)(object)this).config = config;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002828")]
		[Cpp2IlInjected.Address(RVA = "0x28B27A0", Offset = "0x28B11A0", VA = "0x1828B27A0", Slot = "4")]
		public bool IsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//Discarded unreachable code: IL_0010, IL_001c
			C val = ((MotivationCondition<>)(object)this).config;
			return DoIsTrue(agent, currentMotivation);
		}

		[Cpp2IlInjected.Token(Token = "0x6002829")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract bool DoIsTrue(GameObject agent, IMotivation currentMotivation);
	}
}
