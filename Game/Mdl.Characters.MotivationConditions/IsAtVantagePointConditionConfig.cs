using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Environments.PointsOfInterest;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000908")]
	[CreateAssetMenu]
	public class IsAtVantagePointConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003246")]
		public List<VantagePointType> validTypes = (List<VantagePointType>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600297C")]
		[Cpp2IlInjected.Address(RVA = "0x11BD900", Offset = "0x11BC300", VA = "0x1811BD900", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			IsAtVantagePointCondition isAtVantagePointCondition = new IsAtVantagePointCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600297D")]
		[Cpp2IlInjected.Address(RVA = "0x11BD980", Offset = "0x11BC380", VA = "0x1811BD980")]
		public IsAtVantagePointConditionConfig()
		{
		}
	}
}
