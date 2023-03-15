using System.Linq.Expressions.Interpreter;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A2")]
	public class ModifiedTimeComparator : LongComparator
	{
		[Cpp2IlInjected.Token(Token = "0x6005464")]
		[Cpp2IlInjected.Address(RVA = "0x7896C0", Offset = "0x7880C0", VA = "0x1807896C0")]
		public ModifiedTimeComparator(MiniProfile miniProfile)
		{
			((System.Linq.Expressions.Interpreter.LessThanInstruction.LessThanInt32)(object)this)._002Ector((object)miniProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x6005465")]
		[Cpp2IlInjected.Address(RVA = "0x1393E00", Offset = "0x1392800", VA = "0x181393E00", Slot = "4")]
		public override bool IsOlder(MiniProfile other)
		{
			//Discarded unreachable code: IL_0030
			long seconds = ((MiniProfileComparator)this).MiniProfile.gameInfo_.modified_.Seconds;
			long seconds2 = other.gameInfo_.modified_.Seconds;
			return IsOlder(seconds, seconds2);
		}

		[Cpp2IlInjected.Token(Token = "0x6005466")]
		[Cpp2IlInjected.Address(RVA = "0x1393D80", Offset = "0x1392780", VA = "0x181393D80", Slot = "5")]
		public override bool IsNewer(MiniProfile other)
		{
			//Discarded unreachable code: IL_0030
			long seconds = ((MiniProfileComparator)this).MiniProfile.gameInfo_.modified_.Seconds;
			long seconds2 = other.gameInfo_.modified_.Seconds;
			return IsNewer(seconds, seconds2);
		}

		[Cpp2IlInjected.Token(Token = "0x6005467")]
		[Cpp2IlInjected.Address(RVA = "0x1393E80", Offset = "0x1392880", VA = "0x181393E80", Slot = "6")]
		public override string ToDebugStr()
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I8
			long seconds = ((MiniProfileComparator)this).MiniProfile.gameInfo_.modified_.Seconds;
			return $"ModifiedTimeInSec={seconds}";
		}
	}
}
