using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20006B4")]
	public class SitDownParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400278C")]
		public string sitDownTrigger = "Sit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400278D")]
		public string standUpTrigger = "Exit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400278E")]
		public string sitImmediateTrigger = "SitImmediate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400278F")]
		public string sitStartState = "sit_start";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002790")]
		public string sitEndState = "sit_end";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002791")]
		public float animMaxDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002792")]
		[Tooltip("Sit idle break trigger")]
		public string sitBreakTrigger = "SitBreak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002793")]
		[Tooltip("Chance of playing the sit break animation in percentage")]
		public float sitBreakProbability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002794")]
		[Tooltip("Time interval in seconds to check for sit break")]
		public float sitBreakCheckInterval = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002795")]
		[Tooltip("Time in seconds to wait before checking for sit break again")]
		public float sitBreakCooldown = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002796")]
		public List<string> triggersToReset = (List<string>)(object)new List<T>
		{
			(T)"Celebrate",
			(T)"Hello",
			(T)"Interact",
			(T)"Collect",
			(T)"Give",
			(T)"Discussion",
			(T)"Happy",
			(T)"Laughing",
			(T)"Confused",
			(T)"Sad",
			(T)"Angry"
		};

		[Cpp2IlInjected.Token(Token = "0x6001DC4")]
		[Cpp2IlInjected.Address(RVA = "0xF511B0", Offset = "0xF4FBB0", VA = "0x180F511B0")]
		public SitDownParameters()
		{
		}//Discarded unreachable code: IL_00f0

	}
}
