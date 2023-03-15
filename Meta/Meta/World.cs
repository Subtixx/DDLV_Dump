using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A56")]
	public readonly struct World
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40028FA")]
		private readonly Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40028FB")]
		private readonly IWorldEventDispatcher dispatcher;

		[Cpp2IlInjected.Token(Token = "0x17000EB2")]
		public ProfileWorld Section
		{
			[Cpp2IlInjected.Token(Token = "0x6005905")]
			[Cpp2IlInjected.Address(RVA = "0x15EA460", Offset = "0x15E8E60", VA = "0x1815EA460")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB3")]
		internal IWorldEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6005906")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			get
			{
				return dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB4")]
		public Profile FullProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005907")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB5")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6005908")]
			[Cpp2IlInjected.Address(RVA = "0x7BC800", Offset = "0x7BB200", VA = "0x1807BC800")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005904")]
		[Cpp2IlInjected.Address(RVA = "0x7BC780", Offset = "0x7BB180", VA = "0x1807BC780")]
		public static World Create(Profile profile, ProfileEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005909")]
		[Cpp2IlInjected.Address(RVA = "0x15EA470", Offset = "0x15E8E70", VA = "0x1815EA470")]
		public static implicit operator WorldProfile(World world)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600590A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
		private World(Profile profile, IWorldEventDispatcher dispatcher)
		{
			this.profile = profile;
			this.dispatcher = dispatcher;
			/*Error: Unexpected end of block*/;
		}
	}
}
