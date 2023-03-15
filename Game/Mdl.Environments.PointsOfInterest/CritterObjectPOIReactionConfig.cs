using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E7")]
	[CreateAssetMenu]
	public class CritterObjectPOIReactionConfig : BaseObjectPOIReactionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002891")]
		[SerializeField]
		public List<CritterAnimation> validTypes = (List<CritterAnimation>)(object)new List<T>((int)Enumerable.Cast<CritterAnimation>((IEnumerable)Enum.GetValues(typeof(CritterAnimation))));

		[Cpp2IlInjected.Token(Token = "0x17000464")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB3")]
			[Cpp2IlInjected.Address(RVA = "0x11025D0", Offset = "0x1100FD0", VA = "0x1811025D0", Slot = "4")]
			get
			{
				return typeof(CritterObjectPOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB4")]
		[Cpp2IlInjected.Address(RVA = "0x11023F0", Offset = "0x1100DF0", VA = "0x1811023F0", Slot = "5")]
		public override bool IsValidTrigger(Enum trigger)
		{
			if (trigger != null && trigger != null)
			{
				List<CritterAnimation> list = validTypes;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB5")]
		[Cpp2IlInjected.Address(RVA = "0x11024B0", Offset = "0x1100EB0", VA = "0x1811024B0")]
		public CritterObjectPOIReactionConfig()
		{
		}//IL_0019: Expected I4, but got O

	}
}
