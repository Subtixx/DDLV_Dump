using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Environments.PointsOfInterest
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20006D9")]
	public class MeetingParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002838")]
		public float minReactionDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002839")]
		public float maxReactionDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400283A")]
		public List<string> reactionTriggers = (List<string>)(object)new List<T>
		{
			(T)"Happy",
			(T)"Laughing",
			(T)"Confused",
			(T)"Angry"
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400283B")]
		public string endReactionTrigger = "Exit";

		[Cpp2IlInjected.Token(Token = "0x6001E69")]
		[Cpp2IlInjected.Address(RVA = "0xBC2930", Offset = "0xBC1330", VA = "0x180BC2930")]
		public MeetingParameters()
		{
		}//Discarded unreachable code: IL_0061

	}
}
