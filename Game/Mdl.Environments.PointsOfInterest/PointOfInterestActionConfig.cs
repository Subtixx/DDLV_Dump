using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E9")]
	public abstract class PointOfInterestActionConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002895")]
		[Tooltip("Weight to pick this point of interest when no one is already present")]
		public float soloWeight = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002896")]
		[Tooltip("Weight to pick this point of interest when there is at least one character present")]
		public float socialWeight = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002897")]
		[Tooltip("Weight to be added as bonus when the player is near this point of interest")]
		public float nearAvatarBonusWeight = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002898")]
		[Tooltip("Distance from player to add the near avatar bonus")]
		public float nearAvatarDistance = 20f;

		[Cpp2IlInjected.Token(Token = "0x17000465")]
		public abstract Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EB8")]
		[Cpp2IlInjected.Address(RVA = "0xCB3330", Offset = "0xCB1D30", VA = "0x180CB3330")]
		protected PointOfInterestActionConfig()
		{
		}
	}
}
