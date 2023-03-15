using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200099C")]
	public abstract class MiniProfileComparator
	{
		[Cpp2IlInjected.Token(Token = "0x17000E9D")]
		public MiniProfile MiniProfile
		{
			[Cpp2IlInjected.Token(Token = "0x600544D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600544E")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CMiniProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600544C")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		protected MiniProfileComparator(MiniProfile miniProfile)
		{
			MiniProfile = miniProfile;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600544F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsOlder(MiniProfile other);

		[Cpp2IlInjected.Token(Token = "0x6005450")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IsNewer(MiniProfile other);

		[Cpp2IlInjected.Token(Token = "0x6005451")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract string ToDebugStr();
	}
}
