using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public readonly struct PlayerProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private readonly IProfile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private readonly IProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		public IProfilePlayer Section
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8D")]
			[Cpp2IlInjected.Address(RVA = "0x2878CE0", Offset = "0x28776E0", VA = "0x182878CE0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		public IProfile Full
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		public IProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			get
			{
				return dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC780", Offset = "0x7BB180", VA = "0x1807BC780")]
		public static PlayerProfile Create(IProfile profile, [Optional] IProfileEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D90")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
		private PlayerProfile(IProfile profile, IProfileEventDispatcher dispatcher)
		{
			this.profile = profile;
			this.dispatcher = dispatcher;
			/*Error: Unexpected end of block*/;
		}
	}
}
