using System.Linq.Expressions.Interpreter;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A1")]
	public class XpComparator : IntComparator
	{
		[Cpp2IlInjected.Token(Token = "0x6005460")]
		[Cpp2IlInjected.Address(RVA = "0x7896C0", Offset = "0x7880C0", VA = "0x1807896C0")]
		public XpComparator(MiniProfile miniProfile)
		{
			((System.Linq.Expressions.Interpreter.LessThanInstruction.LessThanInt32)(object)this)._002Ector((object)miniProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x6005461")]
		[Cpp2IlInjected.Address(RVA = "0x15EA540", Offset = "0x15E8F40", VA = "0x1815EA540", Slot = "4")]
		public override bool IsOlder(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int playerXp_ = other.playerXp_;
			int playerXp_2 = miniProfile.playerXp_;
			return IsOlder(playerXp_2, playerXp_);
		}

		[Cpp2IlInjected.Token(Token = "0x6005462")]
		[Cpp2IlInjected.Address(RVA = "0x15EA510", Offset = "0x15E8F10", VA = "0x1815EA510", Slot = "5")]
		public override bool IsNewer(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int playerXp_ = other.playerXp_;
			int playerXp_2 = miniProfile.playerXp_;
			return IsNewer(playerXp_2, playerXp_);
		}

		[Cpp2IlInjected.Token(Token = "0x6005463")]
		[Cpp2IlInjected.Address(RVA = "0x15EA570", Offset = "0x15E8F70", VA = "0x1815EA570", Slot = "6")]
		public override string ToDebugStr()
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			int playerXp_ = ((MiniProfileComparator)this).MiniProfile.playerXp_;
			return $"Xp={playerXp_}";
		}
	}
}
