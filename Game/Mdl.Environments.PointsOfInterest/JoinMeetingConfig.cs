using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CE")]
	[CreateAssetMenu]
	public class JoinMeetingConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400280C")]
		[Tooltip("If running, the character will start walking at this distance from their destination")]
		public float slowDownDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400280D")]
		[Tooltip("If the agent has a house and that house has a meeting point, the npc will choose this meeting point")]
		public bool favorNpcHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400280E")]
		public MeetingParameters meetingParameters;

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001E39")]
			[Cpp2IlInjected.Address(RVA = "0x11C3F50", Offset = "0x11C2950", VA = "0x1811C3F50", Slot = "4")]
			get
			{
				return typeof(MeetingPoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3A")]
		[Cpp2IlInjected.Address(RVA = "0xF51130", Offset = "0xF4FB30", VA = "0x180F51130")]
		public JoinMeetingConfig()
		{
		}
	}
}
