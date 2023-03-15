using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters.Critters;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E6")]
	public class CritterObjectPOI : BaseObjectPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002890")]
		[SerializeField]
		private CritterAnimation defaultEntryAnimationTrigger;

		[Cpp2IlInjected.Token(Token = "0x17000463")]
		public override Enum DefaultEntryAnimationTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB0")]
			[Cpp2IlInjected.Address(RVA = "0x1102710", Offset = "0x1101110", VA = "0x181102710", Slot = "15")]
			get
			{
				CritterAnimation critterAnimation = defaultEntryAnimationTrigger;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB1")]
		[Cpp2IlInjected.Address(RVA = "0x1102640", Offset = "0x1101040", VA = "0x181102640", Slot = "16")]
		public override bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_0010: Expected O, but got I4
			Critter component = agent.GetComponent<Critter>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				return base.CanVisit(agent, actionConfig);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public CritterObjectPOI()
		{
		}
	}
}
