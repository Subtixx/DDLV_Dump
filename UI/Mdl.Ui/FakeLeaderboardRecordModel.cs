using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200083A")]
	public class FakeLeaderboardRecordModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700075C")]
		public FakeVirtualPlayerModel Player
		{
			[Cpp2IlInjected.Token(Token = "0x600344A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600344B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPlayer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003095")]
		public int Score
		{
			[Cpp2IlInjected.Token(Token = "0x600344C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600344D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600344E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FakeLeaderboardRecordModel()
		{
		}
	}
}
