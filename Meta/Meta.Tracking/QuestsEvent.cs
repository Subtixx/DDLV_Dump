using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7A")]
	public class QuestsEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F58")]
		public string QuestIssuerName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9C")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF80", Offset = "0x5BB980", VA = "0x1805BCF80")]
			set
			{
				AddParameter(value, "QuestIssuerName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F59")]
		public string QuestID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9D")]
			[Cpp2IlInjected.Address(RVA = "0x5BCEC0", Offset = "0x5BB8C0", VA = "0x1805BCEC0")]
			set
			{
				AddParameter(value, "QuestID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5A")]
		public string QuestStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9E")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFE0", Offset = "0x5BB9E0", VA = "0x1805BCFE0")]
			set
			{
				AddParameter(value, "QuestStatus");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5B")]
		public string QuestType
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9F")]
			[Cpp2IlInjected.Address(RVA = "0x5BD040", Offset = "0x5BBA40", VA = "0x1805BD040")]
			set
			{
				AddParameter(value, "QuestType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5C")]
		public int QuestIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA0")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF20", Offset = "0x5BB920", VA = "0x1805BCF20")]
			set
			{
				AddParameter(value, "QuestIndex");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5D")]
		public bool IsTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA1")]
			[Cpp2IlInjected.Address(RVA = "0x5BCB60", Offset = "0x5BB560", VA = "0x1805BCB60")]
			set
			{
				AddParameter(value, "IsTutorial");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5E")]
		public string MacroEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA2")]
			[Cpp2IlInjected.Address(RVA = "0x5BCBC0", Offset = "0x5BB5C0", VA = "0x1805BCBC0")]
			set
			{
				AddParameter(value, "MacroEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5F")]
		public string MiniEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA3")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC20", Offset = "0x5BB620", VA = "0x1805BCC20")]
			set
			{
				AddParameter(value, "MiniEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F60")]
		public string MissionName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA4")]
			[Cpp2IlInjected.Address(RVA = "0x5BCDA0", Offset = "0x5BB7A0", VA = "0x1805BCDA0")]
			set
			{
				AddParameter(value, "MissionName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F61")]
		public string MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA5")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC80", Offset = "0x5BB680", VA = "0x1805BCC80")]
			set
			{
				AddParameter(value, "MissionID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F62")]
		public string MissionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA6")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE00", Offset = "0x5BB800", VA = "0x1805BCE00")]
			set
			{
				AddParameter(value, "MissionStatus");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F63")]
		public string MissionType
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA7")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE60", Offset = "0x5BB860", VA = "0x1805BCE60")]
			set
			{
				AddParameter(value, "MissionType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F64")]
		public int MissionIndexQuest
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA8")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCE0", Offset = "0x5BB6E0", VA = "0x1805BCCE0")]
			set
			{
				AddParameter(value, "MissionIndexQuest");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F65")]
		public int MissionIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA9")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD40", Offset = "0x5BB740", VA = "0x1805BCD40")]
			set
			{
				AddParameter(value, "MissionIndex");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F66")]
		public int StepId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAA")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0A0", Offset = "0x5BBAA0", VA = "0x1805BD0A0")]
			set
			{
				AddParameter(value, "StepId");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F67")]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAB")]
			[Cpp2IlInjected.Address(RVA = "0x5BD100", Offset = "0x5BBB00", VA = "0x1805BD100")]
			set
			{
				AddParameter(value, "StepName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F68")]
		public string StepType
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAC")]
			[Cpp2IlInjected.Address(RVA = "0x5BD1C0", Offset = "0x5BBBC0", VA = "0x1805BD1C0")]
			set
			{
				AddParameter(value, "StepType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F69")]
		public string StepStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAD")]
			[Cpp2IlInjected.Address(RVA = "0x5BD160", Offset = "0x5BBB60", VA = "0x1805BD160")]
			set
			{
				AddParameter(value, "StepStatus");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6A")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAE")]
			[Cpp2IlInjected.Address(RVA = "0x5BCB30", Offset = "0x5BB530", VA = "0x1805BCB30", Slot = "4")]
			get
			{
				return "quests";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6B")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AAF")]
			[Cpp2IlInjected.Address(RVA = "0x5BCAD0", Offset = "0x5BB4D0", VA = "0x1805BCAD0", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A9B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA90", Offset = "0x5BB490", VA = "0x1805BCA90")]
		public QuestsEvent(ClientData clientData)
		{
			AddCommonParameters(clientData, currencyBalance: true);
		}
	}
}
