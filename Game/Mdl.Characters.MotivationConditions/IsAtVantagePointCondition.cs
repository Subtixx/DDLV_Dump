using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Environments.PointsOfInterest;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000906")]
	public class IsAtVantagePointCondition : MotivationCondition<IsAtVantagePointConditionConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6002978")]
		[Cpp2IlInjected.Address(RVA = "0x11BDCB0", Offset = "0x11BC6B0", VA = "0x1811BDCB0")]
		public IsAtVantagePointCondition(IsAtVantagePointConditionConfig config)
		{
			((MotivationCondition<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002979")]
		[Cpp2IlInjected.Address(RVA = "0x11BDA00", Offset = "0x11BC400", VA = "0x1811BDA00", Slot = "5")]
		protected override bool DoIsTrue(GameObject agent, IMotivation currentMotivation)
		{
			//IL_0062: Expected O, but got I4
			if (currentMotivation != null)
			{
				int num = 0;
				int num2 = 0;
				if (currentMotivation != null)
				{
					Type typeFromHandle = typeof(VantagePoint);
					Type type = default(Type);
					if (((object)type).Equals((object)typeFromHandle) && (object)typeFromHandle != null)
					{
						int num3 = 0;
						bool flag = default(bool);
						if (flag)
						{
							Predicate<VantagePointSlot> predicate = (Predicate<VantagePointSlot>)(object)(Predicate<T>)delegate(VantagePointSlot o)
							{
								//Discarded unreachable code: IL_0016
								GameObject _003COccupant_003Ek__BackingField = o.Occupant;
								GameObject gameObject = agent;
								return _003COccupant_003Ek__BackingField == gameObject;
							};
							List<VantagePointSlot> list = default(List<VantagePointSlot>);
							VantagePointSlot vantagePointSlot = (VantagePointSlot)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
							int num4 = 0;
							if (vantagePointSlot != (UnityEngine.Object)num4)
							{
								goto IL_0068;
							}
						}
					}
				}
			}
			int num5 = 0;
			goto IL_0068;
			IL_0068:
			throw new NullReferenceException();
		}
	}
}
