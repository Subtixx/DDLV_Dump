using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E4")]
	public class CharacterObjectPOI : BaseObjectPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400288E")]
		[SerializeField]
		private CharacterAnimation defaultEntryAnimationTrigger;

		[Cpp2IlInjected.Token(Token = "0x17000461")]
		public override Enum DefaultEntryAnimationTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6001EAA")]
			[Cpp2IlInjected.Address(RVA = "0x12E8AD0", Offset = "0x12E74D0", VA = "0x1812E8AD0", Slot = "15")]
			get
			{
				CharacterAnimation characterAnimation = defaultEntryAnimationTrigger;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAB")]
		[Cpp2IlInjected.Address(RVA = "0x12E8A00", Offset = "0x12E7400", VA = "0x1812E8A00", Slot = "16")]
		public override bool CanVisit(GameObject agent, PointOfInterestActionConfig actionConfig)
		{
			//IL_0010: Expected O, but got I4
			Character component = agent.GetComponent<Character>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				return base.CanVisit(agent, actionConfig);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public CharacterObjectPOI()
		{
		}
	}
}
