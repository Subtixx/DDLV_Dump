using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000922")]
	[CreateAssetMenu]
	internal class ConditionalCritterApproachConfig : CritterApproachConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032E1")]
		public MotivationConditionConfig Condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032E2")]
		public CritterApproachConfig MetApproach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032E3")]
		public CritterApproachConfig UnmetApproach;

		[Cpp2IlInjected.Token(Token = "0x60029ED")]
		[Cpp2IlInjected.Address(RVA = "0xA8E580", Offset = "0xA8CF80", VA = "0x180A8E580", Slot = "4")]
		public override IMotivation Instantiate()
		{
			ConditionalCritterApproach conditionalCritterApproach = new ConditionalCritterApproach(this);
			IMotivationCondition motivationCondition = (conditionalCritterApproach.condition = Condition.Instantiate());
			IMotivation motivation = (conditionalCritterApproach.metMotivation = (ICritterApproachMotivation)MetApproach.Instantiate());
			IMotivation motivation2 = (conditionalCritterApproach.unmetMotivation = (ICritterApproachMotivation)UnmetApproach.Instantiate());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029EE")]
		[Cpp2IlInjected.Address(RVA = "0xA8E6B0", Offset = "0xA8D0B0", VA = "0x180A8E6B0")]
		public ConditionalCritterApproachConfig()
		{
		}
	}
}
