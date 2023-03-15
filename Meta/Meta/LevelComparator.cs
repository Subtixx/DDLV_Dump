using System.Linq.Expressions.Interpreter;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A0")]
	public class LevelComparator : IntComparator
	{
		[Cpp2IlInjected.Token(Token = "0x600545C")]
		[Cpp2IlInjected.Address(RVA = "0x7896C0", Offset = "0x7880C0", VA = "0x1807896C0")]
		public LevelComparator(MiniProfile miniProfile)
		{
			((System.Linq.Expressions.Interpreter.LessThanInstruction.LessThanInt32)(object)this)._002Ector((object)miniProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x600545D")]
		[Cpp2IlInjected.Address(RVA = "0x18A1DA0", Offset = "0x18A07A0", VA = "0x1818A1DA0", Slot = "4")]
		public override bool IsOlder(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int playerLevel_ = other.playerLevel_;
			int playerLevel_2 = miniProfile.playerLevel_;
			return IsOlder(playerLevel_2, playerLevel_);
		}

		[Cpp2IlInjected.Token(Token = "0x600545E")]
		[Cpp2IlInjected.Address(RVA = "0x18A1D70", Offset = "0x18A0770", VA = "0x1818A1D70", Slot = "5")]
		public override bool IsNewer(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int playerLevel_ = other.playerLevel_;
			int playerLevel_2 = miniProfile.playerLevel_;
			return IsNewer(playerLevel_2, playerLevel_);
		}

		[Cpp2IlInjected.Token(Token = "0x600545F")]
		[Cpp2IlInjected.Address(RVA = "0x18A1DD0", Offset = "0x18A07D0", VA = "0x1818A1DD0", Slot = "6")]
		public override string ToDebugStr()
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			int playerLevel_ = ((MiniProfileComparator)this).MiniProfile.playerLevel_;
			return $"Level={playerLevel_}";
		}
	}
}
