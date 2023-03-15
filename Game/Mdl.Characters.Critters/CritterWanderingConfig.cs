using Cpp2IlInjected;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092F")]
	internal class CritterWanderingConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400331C")]
		public bool canRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400331D")]
		public float minIdleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400331E")]
		public float maxIdleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400331F")]
		public int minDestinations = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003320")]
		public int maxDestinations = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003321")]
		public float minDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003322")]
		public float maxDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003323")]
		public float minDistancePercentageToRun = 0.3f;

		[Cpp2IlInjected.Token(Token = "0x6002A4A")]
		[Cpp2IlInjected.Address(RVA = "0x1102760", Offset = "0x1101160", VA = "0x181102760", Slot = "4")]
		public override IMotivation Instantiate()
		{
			CritterWandering critterWandering = new CritterWandering(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A4B")]
		[Cpp2IlInjected.Address(RVA = "0x11027E0", Offset = "0x11011E0", VA = "0x1811027E0")]
		public CritterWanderingConfig()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0012: Expected I4, but got I8

	}
}
