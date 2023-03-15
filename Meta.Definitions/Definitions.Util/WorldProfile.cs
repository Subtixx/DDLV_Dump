using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	public readonly struct WorldProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private readonly IProfile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private readonly IProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		public IProfileWorld Section
		{
			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0x17D06A0", Offset = "0x17CF0A0", VA = "0x1817D06A0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		public IProfile Full
		{
			[Cpp2IlInjected.Token(Token = "0x6000D93")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		public IProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6000D94")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			get
			{
				return dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D91")]
		[Cpp2IlInjected.Address(RVA = "0x7BC780", Offset = "0x7BB180", VA = "0x1807BC780")]
		public static WorldProfile Create(IProfile profile, [Optional] IProfileEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
		private WorldProfile(IProfile profile, IProfileEventDispatcher dispatcher)
		{
			this.profile = profile;
			this.dispatcher = dispatcher;
			/*Error: Unexpected end of block*/;
		}
	}
}
