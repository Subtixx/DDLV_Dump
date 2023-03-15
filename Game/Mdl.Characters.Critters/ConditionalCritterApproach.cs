using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000929")]
	internal class ConditionalCritterApproach : Motivation<ConditionalCritterApproachConfig>, ICritterApproachMotivation, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032F1")]
		private ICritterApproachMotivation unmetMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032F2")]
		private ICritterApproachMotivation metMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032F3")]
		private IMotivationCondition condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40032F4")]
		private ICritterApproachMotivation currentMotivation;

		[Cpp2IlInjected.Token(Token = "0x6002A04")]
		[Cpp2IlInjected.Address(RVA = "0xA8EAB0", Offset = "0xA8D4B0", VA = "0x180A8EAB0")]
		private ICritterApproachMotivation GetCurrentMotivation()
		{
			ICritterApproachMotivation critterApproachMotivation = currentMotivation;
			if (critterApproachMotivation == null)
			{
			}
			return critterApproachMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A05")]
		[Cpp2IlInjected.Address(RVA = "0xA8ECD0", Offset = "0xA8D6D0", VA = "0x180A8ECD0")]
		public ConditionalCritterApproach(ConditionalCritterApproachConfig conditionalCritterApproach)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)conditionalCritterApproach);
			IMotivationCondition motivationCondition = (condition = conditionalCritterApproach.Condition.Instantiate());
			IMotivation motivation = (metMotivation = (ICritterApproachMotivation)conditionalCritterApproach.MetApproach.Instantiate());
			IMotivation motivation2 = (unmetMotivation = (ICritterApproachMotivation)conditionalCritterApproach.UnmetApproach.Instantiate());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A06")]
		[Cpp2IlInjected.Address(RVA = "0xA8EAC0", Offset = "0xA8D4C0", VA = "0x180A8EAC0")]
		private bool IsConditionMet(GameObject agent)
		{
			//Discarded unreachable code: IL_0025
			IMotivationCondition motivationCondition = condition;
			ICritterApproachMotivation critterApproachMotivation = currentMotivation;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return motivationCondition.IsTrue(agent, critterApproachMotivation);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A07")]
		[Cpp2IlInjected.Address(RVA = "0xA8E860", Offset = "0xA8D260", VA = "0x180A8E860", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			if (IsConditionMet(agent))
			{
			}
			ICritterApproachMotivation critterApproachMotivation = (currentMotivation = unmetMotivation);
			ICritterApproachMotivation critterApproachMotivation2 = currentMotivation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A08")]
		[Cpp2IlInjected.Address(RVA = "0xA8E8F0", Offset = "0xA8D2F0", VA = "0x180A8E8F0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//Discarded unreachable code: IL_003a
			bool flag = IsConditionMet(agent);
			if (flag)
			{
			}
			ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			ICritterApproachMotivation critterApproachMotivation2 = currentMotivation;
			if (critterApproachMotivation2 != critterApproachMotivation)
			{
				if (critterApproachMotivation2 != null)
				{
				}
				currentMotivation = critterApproachMotivation;
				ICritterApproachMotivation critterApproachMotivation3 = currentMotivation;
				ICritterApproachMotivation critterApproachMotivation4 = currentMotivation;
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A09")]
		[Cpp2IlInjected.Address(RVA = "0xA8EA50", Offset = "0xA8D450", VA = "0x180A8EA50", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			if (currentMotivation == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0A")]
		[Cpp2IlInjected.Address(RVA = "0xA8E9E0", Offset = "0xA8D3E0", VA = "0x180A8E9E0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0012: Expected O, but got I8
			if (currentMotivation != null)
			{
			}
			currentMotivation = (ICritterApproachMotivation)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0B")]
		[Cpp2IlInjected.Address(RVA = "0xA8E720", Offset = "0xA8D120", VA = "0x180A8E720", Slot = "14")]
		public override bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			//Discarded unreachable code: IL_0016
			//IL_0016: Expected I4, but got O
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			return (byte)(int)typeof(IMotivation).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0C")]
		[Cpp2IlInjected.Address(RVA = "0xA8E6C0", Offset = "0xA8D0C0", VA = "0x180A8E6C0", Slot = "24")]
		public bool CanBeFed()
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0D")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8D1F0", VA = "0x180A8E7F0", Slot = "22")]
		public void CancelFeeding(GameObject agent)
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7A0", Offset = "0xA8D1A0", VA = "0x180A8E7A0", Slot = "23")]
		public bool CanInteractWithAvatar()
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0F")]
		[Cpp2IlInjected.Address(RVA = "0xA8EB90", Offset = "0xA8D590", VA = "0x180A8EB90", Slot = "21")]
		public bool ShouldEnterLocomotionAnimationState(GameObject agent)
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A10")]
		[Cpp2IlInjected.Address(RVA = "0xA8EC00", Offset = "0xA8D600", VA = "0x180A8EC00", Slot = "20")]
		public bool ShouldFlee(GameObject agent)
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A11")]
		[Cpp2IlInjected.Address(RVA = "0xA8EC70", Offset = "0xA8D670", VA = "0x180A8EC70", Slot = "19")]
		public bool ShouldTrigger(GameObject agent)
		{
			if (currentMotivation == null)
			{
				ICritterApproachMotivation critterApproachMotivation = unmetMotivation;
			}
			throw new NullReferenceException();
		}
	}
}
