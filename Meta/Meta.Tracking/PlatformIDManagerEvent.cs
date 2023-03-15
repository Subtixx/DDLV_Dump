using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7F")]
	public sealed class PlatformIDManagerEvent : TrackingEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x17000F87")]
		public static string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005ACF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA050", Offset = "0x7B8A50", VA = "0x1807BA050")]
			get
			{
				return "platformIDManager";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F88")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD0")]
			[Cpp2IlInjected.Address(RVA = "0x7BA050", Offset = "0x7B8A50", VA = "0x1807BA050", Slot = "4")]
			get
			{
				return "platformIDManager";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F89")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD1")]
			[Cpp2IlInjected.Address(RVA = "0x7BA040", Offset = "0x7B8A40", VA = "0x1807BA040", Slot = "5")]
			get
			{
				return 425723;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8A")]
		protected override DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD2")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
			get
			{
				return DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8B")]
		public string Platform_sn_userid
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD3")]
			[Cpp2IlInjected.Address(RVA = "0x7BA0E0", Offset = "0x7B8AE0", VA = "0x1807BA0E0")]
			set
			{
				AddParameter(value, "Platform_sn_userid");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8C")]
		public int Platform_sn_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD4")]
			[Cpp2IlInjected.Address(RVA = "0x7BA080", Offset = "0x7B8A80", VA = "0x1807BA080")]
			set
			{
				AddParameter(value, "Platform_sn_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AD5")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FD0", Offset = "0x7B89D0", VA = "0x1807B9FD0")]
		public PlatformIDManagerEvent()
		{
		}
	}
}
