using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E3")]
	public abstract class BaseObjectPOIReactionConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002887")]
		[Tooltip("If running, the character will start walking at this distance from their destination")]
		public float slowDownDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002888")]
		public string enterTriggerOverride = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002889")]
		public string endAnimationStateOverride = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400288A")]
		public string exitTrigger = "Exit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400288B")]
		public bool lookAt = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400288C")]
		public float enterDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400288D")]
		public float exitDuration = 2f;

		[Cpp2IlInjected.Token(Token = "0x6001EA8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IsValidTrigger(Enum trigger);

		[Cpp2IlInjected.Token(Token = "0x6001EA9")]
		[Cpp2IlInjected.Address(RVA = "0x163BB20", Offset = "0x163A520", VA = "0x18163BB20")]
		protected BaseObjectPOIReactionConfig()
		{
		}
	}
}
