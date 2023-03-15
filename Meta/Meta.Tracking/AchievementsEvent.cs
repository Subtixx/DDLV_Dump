using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7E")]
	public class AchievementsEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F80")]
		public string AchievementName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC8")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D240", Offset = "0x1E2BC40", VA = "0x181E2D240")]
			set
			{
				AddParameter(value, "AchievementName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F81")]
		public string AchievementType
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC9")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D360", Offset = "0x1E2BD60", VA = "0x181E2D360")]
			set
			{
				AddParameter(value, "AchievementType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F82")]
		public int EarnedDreamlight
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACA")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D3C0", Offset = "0x1E2BDC0", VA = "0x181E2D3C0")]
			set
			{
				AddParameter(value, "EarnedDreamlight");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F83")]
		public int AchievementStep
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACB")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D300", Offset = "0x1E2BD00", VA = "0x181E2D300")]
			set
			{
				AddParameter(value, "AchievementStep");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F84")]
		public string AchievementState
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACC")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D2A0", Offset = "0x1E2BCA0", VA = "0x181E2D2A0")]
			set
			{
				AddParameter(value, "AchievementState");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F85")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACD")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D210", Offset = "0x1E2BC10", VA = "0x181E2D210", Slot = "4")]
			get
			{
				return "achivements";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F86")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACE")]
			[Cpp2IlInjected.Address(RVA = "0x1E2D1B0", Offset = "0x1E2BBB0", VA = "0x181E2D1B0", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC7")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA90", Offset = "0x5BB490", VA = "0x1805BCA90")]
		public AchievementsEvent(ClientData clientData)
		{
			AddCommonParameters(clientData, currencyBalance: true);
		}
	}
}
