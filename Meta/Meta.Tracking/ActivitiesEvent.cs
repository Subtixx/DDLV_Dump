using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A70")]
	public class ActivitiesEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000EF6")]
		public string ActivityName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A31")]
			[Cpp2IlInjected.Address(RVA = "0x18E1B80", Offset = "0x18E0580", VA = "0x1818E1B80")]
			set
			{
				AddParameter(value, "ActivityName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF7")]
		public string ActivityType
		{
			[Cpp2IlInjected.Token(Token = "0x6005A32")]
			[Cpp2IlInjected.Address(RVA = "0x18E1C40", Offset = "0x18E0640", VA = "0x1818E1C40")]
			set
			{
				AddParameter(value, "ActivityType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF8")]
		public string ActivityResult
		{
			[Cpp2IlInjected.Token(Token = "0x6005A33")]
			[Cpp2IlInjected.Address(RVA = "0x18E1BE0", Offset = "0x18E05E0", VA = "0x1818E1BE0")]
			set
			{
				AddParameter(value, "ActivityResult");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF9")]
		public string ActivityLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005A34")]
			[Cpp2IlInjected.Address(RVA = "0x18E1B20", Offset = "0x18E0520", VA = "0x1818E1B20")]
			set
			{
				AddParameter(value, "ActivityLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFA")]
		public string CharacterName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A35")]
			[Cpp2IlInjected.Address(RVA = "0x18E1CA0", Offset = "0x18E06A0", VA = "0x1818E1CA0")]
			set
			{
				AddParameter(value, "CharacterName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFB")]
		public string CharacterProfession
		{
			[Cpp2IlInjected.Token(Token = "0x6005A36")]
			[Cpp2IlInjected.Address(RVA = "0x18E1D00", Offset = "0x18E0700", VA = "0x1818E1D00")]
			set
			{
				AddParameter(value, "CharacterProfession");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFC")]
		public string TimeLimitedEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A37")]
			[Cpp2IlInjected.Address(RVA = "0x18E1DC0", Offset = "0x18E07C0", VA = "0x1818E1DC0")]
			set
			{
				AddParameter(value, "TimeLimitedEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFD")]
		public string MiniEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A38")]
			[Cpp2IlInjected.Address(RVA = "0x18E1D60", Offset = "0x18E0760", VA = "0x1818E1D60")]
			set
			{
				AddParameter(value, "MiniEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFE")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A39")]
			[Cpp2IlInjected.Address(RVA = "0x18E1AF0", Offset = "0x18E04F0", VA = "0x1818E1AF0", Slot = "4")]
			get
			{
				return "activities";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFF")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A3A")]
			[Cpp2IlInjected.Address(RVA = "0x18E1A90", Offset = "0x18E0490", VA = "0x1818E1A90", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A30")]
		[Cpp2IlInjected.Address(RVA = "0x18E1960", Offset = "0x18E0360", VA = "0x1818E1960")]
		public ActivitiesEvent(ClientData clientData)
		{
			//Discarded unreachable code: IL_0025
			//IL_0011: Expected I4, but got I8
			//IL_0011: Expected I4, but got I8
			int num = 0;
			ulong num2 = default(ulong);
			AddCommonParameters(clientData, (byte)num2 != 0, (byte)num2 != 0);
			ILocation location = clientData.location;
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				num++;
			}
		}
	}
}
