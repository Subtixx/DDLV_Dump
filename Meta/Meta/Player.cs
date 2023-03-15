using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A57")]
	public readonly struct Player
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40028FC")]
		private readonly Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40028FD")]
		private readonly IPlayerEventDispatcher dispatcher;

		[Cpp2IlInjected.Token(Token = "0x17000EB6")]
		internal ProfilePlayer Section
		{
			[Cpp2IlInjected.Token(Token = "0x600590C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC820", Offset = "0x7BB220", VA = "0x1807BC820")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB7")]
		internal IPlayerEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x600590D")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			get
			{
				return dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB8")]
		public Profile FullProfile
		{
			[Cpp2IlInjected.Token(Token = "0x600590E")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB9")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600590F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC800", Offset = "0x7BB200", VA = "0x1807BC800")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600590B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC780", Offset = "0x7BB180", VA = "0x1807BC780")]
		public static Player Create(Profile profile, ProfileEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005910")]
		[Cpp2IlInjected.Address(RVA = "0x7BC830", Offset = "0x7BB230", VA = "0x1807BC830")]
		public static implicit operator PlayerProfile(Player player)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005911")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
		private Player(Profile profile, IPlayerEventDispatcher dispatcher)
		{
			this.profile = profile;
			this.dispatcher = dispatcher;
			/*Error: Unexpected end of block*/;
		}
	}
}
