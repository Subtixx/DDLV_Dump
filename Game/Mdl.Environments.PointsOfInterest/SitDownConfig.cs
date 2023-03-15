using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006BB")]
	[CreateAssetMenu]
	public class SitDownConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027C0")]
		[Tooltip("If running, the character will start walking at this distance from their destination")]
		public float slowDownDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40027C1")]
		public SitDownParameters sitDownParameters;

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE0")]
			[Cpp2IlInjected.Address(RVA = "0xF51140", Offset = "0xF4FB40", VA = "0x180F51140", Slot = "4")]
			get
			{
				return typeof(Bench);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE1")]
		[Cpp2IlInjected.Address(RVA = "0xF51130", Offset = "0xF4FB30", VA = "0x180F51130")]
		public SitDownConfig()
		{
		}
	}
}
