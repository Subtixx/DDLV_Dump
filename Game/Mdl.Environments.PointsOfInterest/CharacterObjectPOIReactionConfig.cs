using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E5")]
	[CreateAssetMenu]
	public class CharacterObjectPOIReactionConfig : BaseObjectPOIReactionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400288F")]
		[SerializeField]
		public List<CharacterAnimation> validTypes = (List<CharacterAnimation>)(object)new List<T>((int)Enumerable.Cast<CharacterAnimation>((IEnumerable)Enum.GetValues(typeof(CharacterAnimation))));

		[Cpp2IlInjected.Token(Token = "0x17000462")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001EAD")]
			[Cpp2IlInjected.Address(RVA = "0x12E8990", Offset = "0x12E7390", VA = "0x1812E8990", Slot = "4")]
			get
			{
				return typeof(CharacterObjectPOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAE")]
		[Cpp2IlInjected.Address(RVA = "0x12E87C0", Offset = "0x12E71C0", VA = "0x1812E87C0", Slot = "5")]
		public override bool IsValidTrigger(Enum trigger)
		{
			if (trigger != null && trigger != null)
			{
				List<CharacterAnimation> list = validTypes;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAF")]
		[Cpp2IlInjected.Address(RVA = "0x12E8870", Offset = "0x12E7270", VA = "0x1812E8870")]
		public CharacterObjectPOIReactionConfig()
		{
		}//IL_0019: Expected I4, but got O

	}
}
