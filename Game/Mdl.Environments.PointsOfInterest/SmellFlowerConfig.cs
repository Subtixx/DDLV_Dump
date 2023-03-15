using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CB")]
	[CreateAssetMenu]
	public class SmellFlowerConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002807")]
		[Tooltip("If running, the character will start walking at this distance from their destination")]
		public float slowDownDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002808")]
		public string enterTrigger = "Smell";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002809")]
		public string exitTrigger = "Exit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400280A")]
		public float enterDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400280B")]
		public float exitDuration = 2f;

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2B")]
			[Cpp2IlInjected.Address(RVA = "0xF55A40", Offset = "0xF54440", VA = "0x180F55A40", Slot = "4")]
			get
			{
				return typeof(Flower);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E2C")]
		[Cpp2IlInjected.Address(RVA = "0xF559C0", Offset = "0xF543C0", VA = "0x180F559C0")]
		public SmellFlowerConfig()
		{
		}
	}
}
