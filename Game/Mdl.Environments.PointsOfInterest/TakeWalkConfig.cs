using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006C6")]
	[CreateAssetMenu]
	public class TakeWalkConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001E10")]
			[Cpp2IlInjected.Address(RVA = "0x106D910", Offset = "0x106C310", VA = "0x18106D910", Slot = "4")]
			get
			{
				return typeof(Circuit);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E11")]
		[Cpp2IlInjected.Address(RVA = "0x106D900", Offset = "0x106C300", VA = "0x18106D900")]
		public TakeWalkConfig()
		{
		}
	}
}
